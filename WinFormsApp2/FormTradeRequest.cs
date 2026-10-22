using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UESkillExchange;

namespace FormTradeRequest
{
    /// <summary>
    /// FormTradeRequest (TradeRequestDialog) - Member 3 (Trowa)
    /// Allows a student to propose a skill exchange (Face-to-Face or Online)
    /// for a chosen skill listing.
    /// Fully editable directly in the Visual Studio Windows Forms Designer.
    /// </summary>
    public partial class FormTradeRequest : Form
    {
        private int _listingId;

        /// <summary>
        /// Compatibility aliases to access the return skill ComboBox
        /// via cmbReturnSkill, comboBox1, or txtReturnSkill.
        /// </summary>
        public ComboBox cmbReturnSkill => comboBox1;
        public ComboBox txtReturnSkill => comboBox1;

        /// <summary>
        /// Parameterized constructor matching the project blueprint specifications.
        /// </summary>
        /// <param name="listingId">ID of the skill listing being requested</param>
        /// <param name="skillOffered">The skill offered by the target student</param>
        /// <param name="skillWanted">The skill requested by the target student</param>
        public FormTradeRequest(int listingId, string skillOffered, string skillWanted)
        {
            InitializeComponent();
            _listingId = listingId;
            lblTargetSkill.Text = $"They Offer: {skillOffered}\r\nThey Need: {skillWanted}";
        }

        /// <summary>
        /// Optional constructor allowing custom target user details.
        /// </summary>
        public FormTradeRequest(int listingId, string skillOffered, string skillWanted, string userName, string deptYear, double rating = 5.0)
            : this(listingId, skillOffered, skillWanted)
        {
            if (!string.IsNullOrWhiteSpace(userName))
                lblUserName.Text = userName;

            if (!string.IsNullOrWhiteSpace(deptYear))
                lblUserDept.Text = deptYear;

            lblUserRating.Text = rating.ToString("0.0");
        }

        /// <summary>
        /// Default parameterless constructor for Visual Studio Designer and testing.
        /// </summary>
        public FormTradeRequest() 
            : this(1, "C# WinForms & MySQL Tutoring", "Figma UI Design or Video Editing")
        {
        }

        private void FormTradeRequest_Load(object sender, EventArgs e)
        {
            // Set friendly placeholder hints in input text boxes and ComboBox
            CueBannerHelper.SetPlaceholder(comboBox1, "Select or type skill to offer in return...");

            UpdateVenuePromptAndPlaceholder();
            CueBannerHelper.SetPlaceholder(txtScheduleNotes, "Enter proposed dates/times and contact info (e.g., Available Tue/Thu 2-4 PM, FB: fb.com/username, Contact: 0917-xxx-xxxx)...");

            // Attempt to load target user profile if database is online
            LoadTargetUserDetails();
        }

        /// <summary>
        /// Radio Button Logic: Updates venue prompt label dynamically based on selected mode.
        /// </summary>
        private void rbMode_CheckedChanged(object sender, EventArgs e)
        {
            UpdateVenuePromptAndPlaceholder();
        }

        private void UpdateVenuePromptAndPlaceholder()
        {
            if (rbF2F.Checked)
            {
                lblVenuePrompt.Text = "Required Campus Meetup Location (e.g., UE Library 2nd Floor):";
                CueBannerHelper.SetPlaceholder(txtVenueOrLink, "e.g., UE Manila Library 3rd Floor Study Hub, Tan Yan Kee Bldg");
            }
            else
            {
                lblVenuePrompt.Text = "Required Meeting Link (Google Meet / Zoom / Discord URL):";
                CueBannerHelper.SetPlaceholder(txtVenueOrLink, "e.g., https://meet.google.com/xyz-abcd-efg or Zoom URL");
            }
        }

        /// <summary>
        /// Validates inputs and inserts trade request record into trade_requests table.
        /// </summary>
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            // Validation: Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtVenueOrLink.Text) ||
                string.IsNullOrWhiteSpace(txtScheduleNotes.Text))
            {
                MessageBox.Show(
                    "All fields—including the return skill and venue or meeting link—are required.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validation: Online trades require valid URL starting with http:// or https://
            if (rbOnline.Checked && !txtVenueOrLink.Text.Trim().StartsWith("http", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Online trades require a valid meeting URL starting with http:// or https:// (e.g., Google Meet or Zoom).",
                    "Invalid Meeting URL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtVenueOrLink.Focus();
                return;
            }

            string mode = rbF2F.Checked ? "F2F" : "Online";

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO trade_requests 
                                   (listing_id, requester_id, skill_offered_in_return, trade_mode, venue_or_link, schedule_notes) 
                                   VALUES (@lid, @reqId, @returnSkill, @mode, @venue, @notes)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@lid", _listingId);
                        cmd.Parameters.AddWithValue("@reqId", DbHelper.CurrentUserId);
                        cmd.Parameters.AddWithValue("@returnSkill", comboBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@mode", mode);
                        cmd.Parameters.AddWithValue("@venue", txtVenueOrLink.Text.Trim());
                        cmd.Parameters.AddWithValue("@notes", txtScheduleNotes.Text.Trim());
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException sqlEx) when (sqlEx.Number == 1146)
                        {
                            // Table trade_requests doesn't exist; try tbl_traderequests
                            cmd.CommandText = @"INSERT INTO tbl_traderequests 
                                               (listing_id, requester_id, skill_offered_in_return, trade_mode, venue_or_link, schedule_notes) 
                                               VALUES (@lid, @reqId, @returnSkill, @mode, @venue, @notes)";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show(
                    "Trade request sent successfully! You can track this in your Dashboard.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to save trade request to database:\n{ex.Message}\n\nPlease ensure MySQL is running and the database is configured in DbHelper.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cancel button: closes the dialog without submitting.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Helper to fetch target user's display information from database if available.
        /// Gracefully handled with try/catch if database is not yet created.
        /// </summary>
        private void LoadTargetUserDetails()
        {
            if (_listingId <= 0) return;

            // If username has already been populated from caller (e.g. MarketplaceForm)
            if (!string.IsNullOrWhiteSpace(lblUserName.Text) && lblUserName.Text != "Alex Santos")
                return;

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // 1. Try tbl_skilllistings & tbl_users (MarketplaceForm schema)
                    try
                    {
                        string sql = @"
                            SELECT COALESCE(u.full_name, sl.owner_name, 'Anonymous') AS full_name, 
                                   COALESCE(u.college, '') AS dept_year 
                            FROM tbl_skilllistings sl
                            LEFT JOIN tbl_users u ON sl.owner_id = u.user_id
                            WHERE sl.listing_id = @lid LIMIT 1";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@lid", _listingId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("full_name")))
                                        lblUserName.Text = reader.GetString("full_name");
                                    if (!reader.IsDBNull(reader.GetOrdinal("dept_year")))
                                        lblUserDept.Text = reader.GetString("dept_year");
                                    return;
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Fallback to alternative table schema below
                    }

                    // 2. Try skill_listings & users schema
                    string fallbackSql = @"
                        SELECT u.full_name, u.dept_year 
                        FROM skill_listings s
                        INNER JOIN users u ON s.user_id = u.user_id
                        WHERE s.listing_id = @lid LIMIT 1";

                    using (var cmd = new MySqlCommand(fallbackSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@lid", _listingId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("full_name")))
                                    lblUserName.Text = reader.GetString("full_name");
                                if (!reader.IsDBNull(reader.GetOrdinal("dept_year")))
                                    lblUserDept.Text = reader.GetString("dept_year");
                            }
                        }
                    }
                }
            }
            catch
            {
                // Graceful fallback: If DB is not yet created or reachable, preserve default display text
            }
        }
    }
}
