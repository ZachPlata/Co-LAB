using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UESkillExchange
{
    public partial class ReportDialog : Form
    {
        private readonly int _reportedUserId;
        private readonly int _listingId;
        private readonly string _targetName;

        public ReportDialog(int reportedUserId, int listingId, string targetName)
        {
            InitializeComponent();

            _reportedUserId = reportedUserId;
            _listingId = listingId;
            _targetName = string.IsNullOrWhiteSpace(targetName) ? "Unknown Student" : targetName;

            lblTargetStudent.Text = "Reporting Student: " + _targetName;
            this.Load += ReportDialog_Load;
        }

        private void ReportDialog_Load(object? sender, EventArgs e)
        {
            // Dynamically load community rules from tbl_regulations if available
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database= db_skillexchange; uid=root");
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader reader;

                conn.Open();
                cmd.CommandText = "SELECT rules_text FROM tbl_regulations ORDER BY reg_id ASC LIMIT 1";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string rules = reader["rules_text"].ToString() ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(rules))
                    {
                        lblWarning.Text = rules;
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch
            {
                // Fallback to static community guidelines notice
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show(
                "Do you want to submit this violation report?",
                "Submit Report",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.No)
            {
                return;
            }

            string reason = txtReason.Text.Trim();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter a reason for the report.", "Input Required");
                txtReason.Focus();
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database= db_skillexchange; uid=root");
                MySqlCommand cmd = new MySqlCommand();

                string reporterName = string.IsNullOrWhiteSpace(DbHelper.CurrentUserName) ? "Student" : DbHelper.CurrentUserName;

                conn.Open();
                cmd.CommandText = "INSERT INTO tbl_reports (reported_user_id, reported_user_name, reporter_name, reason, status) VALUES (" +
                    _reportedUserId + ", " +
                    "'" + _targetName.Replace("'", "''") + "', " +
                    "'" + reporterName.Replace("'", "''") + "', " +
                    "'" + reason.Replace("'", "''") + "', " +
                    "'Pending')";

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("RECORD SAVE", "Report Submitted");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting report: " + ex.Message, "Database Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pnlWarning_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(80, 70, 30)))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pnlWarning.Width - 1, pnlWarning.Height - 1);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(40, 62, 45)))
            {
                e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
            }
        }

        private void pnlActions_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(40, 62, 45)))
            {
                e.Graphics.DrawLine(pen, 0, 0, pnlActions.Width, 0);
            }
        }
    }
}
