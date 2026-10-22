using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UESkillExchange
{
    public partial class MarketplaceForm : Form
    {
        private class CategoryItem
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

            public CategoryItem(int id, string name)
            {
                CategoryId = id;
                CategoryName = name;
            }

            public override string ToString()
            {
                return CategoryName;
            }
        }

        public MarketplaceForm()
        {
            InitializeComponent();
        }

        private void MarketplaceForm_Load(object sender, EventArgs e)
        {
            UpdateWelcomeMessage();
            PopulateCategories();
            LoadListings();
        }

        public void UpdateWelcomeMessage()
        {
            string name = string.IsNullOrWhiteSpace(DbHelper.CurrentUserName) ? "Zach Plata" : DbHelper.CurrentUserName;
            lblWelcome.Text = $"Welcome, {name}";
            lblSessionUser.Text = $"Student: {name}";
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add(new CategoryItem(0, "All Categories"));

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database= db_skillexchange; uid=root");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;

                conn.Open();
                cmd.CommandText = "SELECT category_id, category_name FROM tbl_categories ORDER BY category_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int catId = Convert.ToInt32(reader["category_id"]);
                    string catName = reader["category_name"].ToString() ?? string.Empty;
                    cmbCategory.Items.Add(new CategoryItem(catId, catName));
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load skill categories: " + ex.Message,
                    "Database Notice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void LoadListings()
        {
            flpListings.SuspendLayout();
            flpListings.Controls.Clear();

            int selectedCatId = 0;
            string selectedCatName = string.Empty;
            if (cmbCategory.SelectedItem is CategoryItem catItem)
            {
                selectedCatId = catItem.CategoryId;
                selectedCatName = catItem.CategoryName;
            }

            string keyword = txtSearch.Text.Trim();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database= db_skillexchange; uid=root");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;

                conn.Open();

                string query = "SELECT sl.listing_id, sl.owner_id, " +
                               "COALESCE(u.full_name, sl.owner_name, 'Anonymous') AS display_owner_name, " +
                               "COALESCE(u.college, '') AS college, " +
                               "sl.category, " +
                               "COALESCE(c.category_name, sl.category, 'General') AS display_category, " +
                               "sl.skill_offered, sl.skill_wanted, sl.description, sl.status " +
                               "FROM tbl_skilllistings sl " +
                               "LEFT JOIN tbl_users u ON sl.owner_id = u.user_id " +
                               "LEFT JOIN tbl_categories c ON (sl.category = c.category_name OR sl.category = CAST(c.category_id AS CHAR)) " +
                               "WHERE (sl.status = 'Open' OR sl.status = 'open' OR sl.status IS NULL) " +
                               "AND (u.is_blacklisted = 'No' OR u.is_blacklisted = '0' OR u.is_blacklisted IS NULL)";

                if (selectedCatId > 0 && !string.IsNullOrEmpty(selectedCatName))
                {
                    string safeCatName = selectedCatName.Replace("'", "''");
                    query += " AND (sl.category = '" + safeCatName + "' OR sl.category = '" + selectedCatId + "')";
                }

                if (!string.IsNullOrEmpty(keyword))
                {
                    string safeKeyword = keyword.Replace("'", "''");
                    query += " AND (sl.skill_offered LIKE '%" + safeKeyword + "%' OR " +
                             "sl.skill_wanted LIKE '%" + safeKeyword + "%' OR " +
                             "sl.description LIKE '%" + safeKeyword + "%' OR " +
                             "sl.category LIKE '%" + safeKeyword + "%' OR " +
                             "sl.owner_name LIKE '%" + safeKeyword + "%')";
                }

                query += " ORDER BY sl.listing_id DESC";

                cmd.CommandText = query;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    int listingId = Convert.ToInt32(reader["listing_id"]);
                    int ownerId = reader["owner_id"] != DBNull.Value ? Convert.ToInt32(reader["owner_id"]) : 0;
                    string categoryName = reader["display_category"].ToString() ?? "General";
                    string skillOffered = reader["skill_offered"].ToString() ?? string.Empty;
                    string skillWanted = reader["skill_wanted"].ToString() ?? string.Empty;
                    string description = reader["description"].ToString() ?? string.Empty;
                    DateTime createdAt = DateTime.MinValue;
                    string ownerName = reader["display_owner_name"].ToString() ?? "Anonymous";
                    string college = reader["college"].ToString() ?? string.Empty;

                    Panel card = CreateSkillCard(
                        listingId,
                        ownerId,
                        ownerName,
                        college,
                        categoryName,
                        skillOffered,
                        skillWanted,
                        description,
                        createdAt,
                        (s, e) => OpenTradeDialog(listingId, skillOffered, skillWanted, ownerName, college),
                        (s, e) => OpenReportDialog(ownerId, listingId, ownerName)
                    );

                    flpListings.Controls.Add(card);
                    count++;
                }

                reader.Close();
                conn.Close();

                if (count == 0)
                {
                    flpListings.Controls.Add(CreateEmptyStateCard("No active skill listings found matching your search criteria."));
                }
            }
            catch (Exception ex)
            {
                flpListings.Controls.Add(CreateEmptyStateCard("Database connection error: " + ex.Message));
            }
            finally
            {
                flpListings.ResumeLayout();
            }
        }

        private void OpenTradeDialog(int listingId, string skillOffered, string skillWanted, string ownerName = "", string college = "")
        {
            using (TradeRequestDialog dlg = new TradeRequestDialog(listingId, skillOffered, skillWanted, ownerName, college))
            {
                dlg.ShowDialog(this);
            }
        }

        private void OpenReportDialog(int reportedUserId, int listingId, string ownerName)
        {
            using (ReportDialog dlg = new ReportDialog(reportedUserId, listingId, ownerName))
            {
                dlg.ShowDialog(this);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadListings();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
            LoadListings();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadListings();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListings();
        }

        private void btnNavMarketplace_Click(object sender, EventArgs e)
        {
            LoadListings();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListings();
        }


        private void btnMyDashboard_Click(object sender, EventArgs e)
        {
            using (StudentDashboardForm dashForm = new StudentDashboardForm())
            {
                dashForm.ShowDialog(this);
                LoadListings();
            }
        }

        private void lblSessionUser_Click(object sender, EventArgs e)
        {
        }

        private void lblBrandSub_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                DbHelper.CurrentUserId = 0;
                DbHelper.CurrentUserName = string.Empty;

                this.Hide();
                using (AuthForm authForm = new AuthForm())
                {
                    authForm.ShowDialog();
                }
                this.Close();
            }
        }

        private void btnTestTradeRequest_Click(object sender, EventArgs e)
        {
            // Open the Trade Request dialog with sample skill listing details
            OpenTradeDialog(
                listingId: 1,
                skillOffered: "C# WinForms & MySQL Tutoring",
                skillWanted: "Figma UI Design or Video Editing",
                ownerName: "Samantha Cruz",
                college: "College of Computer Studies and Systems (CCSS)"
            );
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }
    }
}
