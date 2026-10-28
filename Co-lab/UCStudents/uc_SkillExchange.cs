using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Co_LAB
{
    [System.ComponentModel.DesignerCategory("UserControl")]
    public partial class uc_SkillExchange : UserControl
    {
        public uc_SkillExchange()
        {
            InitializeComponent();
        }

        private void uc_SkillExchange_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMarketplaceCards("", "All Categories");
        }

        /// <summary>
        /// Loads skill categories from the database or falls back to common defaults.
        /// </summary>
        public void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");

            try
            {
                // Query categories table created by Miggy/Admin
                DataTable dt = DatabaseHelper.ExecuteQuery("SELECT CategoryName FROM tbl_categories ORDER BY CategoryName ASC");
                foreach (DataRow row in dt.Rows)
                {
                    string? name = row["CategoryName"]?.ToString();
                    if (!string.IsNullOrEmpty(name))
                    {
                        cmbCategory.Items.Add(name);
                    }
                }
            }
            catch
            {
                // Fallback default categories if tbl_categories is not yet created in phpMyAdmin
                cmbCategory.Items.AddRange(new object[] {
                    "Computer Science & IT",
                    "Graphic & Visual Design",
                    "Engineering & Math",
                    "Music & Arts",
                    "Language & Writing",
                    "Business & Marketing"
                });
            }

            cmbCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Queries the database and dynamically generates cards inside the FlowLayoutPanel.
        /// </summary>
        public void LoadMarketplaceCards(string keyword, string category)
        {
            flpMarketplace.SuspendLayout();
            flpMarketplace.Controls.Clear();

            try
            {
                string query = "SELECT * FROM tbl_skills WHERE (Status = 'Active' OR Status IS NULL)";
                var parameters = new System.Collections.Generic.List<MySqlParameter>();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query += " AND (SkillTitle LIKE @kw OR Description LIKE @kw OR OfferedBy LIKE @kw)";
                    parameters.Add(new MySqlParameter("@kw", "%" + keyword.Trim() + "%"));
                }

                if (!string.IsNullOrWhiteSpace(category) && category != "All Categories")
                {
                    query += " AND Category = @cat";
                    parameters.Add(new MySqlParameter("@cat", category));
                }

                query += " ORDER BY SkillId DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters.ToArray());

                if (dt.Rows.Count == 0)
                {
                    ShowEmptyState("No skill listings found matching your search.");
                    lblListingCount.Text = "0 skills available";
                }
                else
                {
                    lblListingCount.Text = $"{dt.Rows.Count} skill(s) available";
                    foreach (DataRow row in dt.Rows)
                    {
                        Panel card = CreateSkillCard(row);
                        flpMarketplace.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowEmptyState($"Could not connect to database: {ex.Message}\nMake sure MySQL is running in XAMPP.");
                lblListingCount.Text = "Database offline";
            }
            finally
            {
                flpMarketplace.ResumeLayout();
            }
        }

        /// <summary>
        /// Creates a modern dark-themed card panel for a single skill.
        /// </summary>
        private Panel CreateSkillCard(DataRow row)
        {
            string skillId = row["SkillId"]?.ToString() ?? "0";
            string title = row["SkillTitle"]?.ToString() ?? "Untitled Skill";
            string cat = row["Category"]?.ToString() ?? "General";
            string desc = row["Description"]?.ToString() ?? "No description provided.";
            string offeredBy = row["OfferedBy"]?.ToString() ?? "Anonymous Student";
            string mode = row["DeliveryMode"]?.ToString() ?? "Online";

            Panel card = new Panel
            {
                Width = 280,
                Height = 250,
                BackColor = Color.FromArgb(32, 32, 36),
                Margin = new Padding(10),
                Padding = new Padding(14)
            };

            // Category Badge
            Label lblBadge = new Label
            {
                Text = cat.ToUpper(),
                Font = new Font("Segoe UI Semibold", 7.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(16, 185, 129), // Emerald
                AutoSize = true,
                Location = new Point(14, 12)
            };

            // Mode Badge (Online or F2F)
            Label lblMode = new Label
            {
                Text = mode == "Face-to-Face" ? "📍 F2F" : "🌐 Online",
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(161, 161, 170),
                AutoSize = true,
                Location = new Point(card.Width - 65, 12)
            };

            // Skill Title
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(12, 32),
                Size = new Size(card.Width - 24, 25),
                AutoEllipsis = true
            };

            // Description
            Label lblDesc = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(161, 161, 170),
                Location = new Point(14, 60),
                Size = new Size(card.Width - 28, 75),
                AutoEllipsis = true
            };

            // Offered By
            Label lblAuthor = new Label
            {
                Text = "👤 " + offeredBy,
                Font = new Font("Segoe UI Semibold", 8.5F),
                ForeColor = Color.FromArgb(212, 212, 216),
                Location = new Point(14, 145),
                Size = new Size(card.Width - 28, 20),
                AutoEllipsis = true
            };

            // Divider Line
            Panel divider = new Panel
            {
                BackColor = Color.FromArgb(45, 45, 50),
                Location = new Point(14, 175),
                Size = new Size(card.Width - 28, 1)
            };

            // "Request Trade" Button
            Button btnTrade = new Button
            {
                Text = "🤝 Request Trade",
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                BackColor = Color.FromArgb(16, 185, 129), // Emerald green
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Size = new Size(160, 32),
                Location = new Point(14, 185)
            };
            btnTrade.FlatAppearance.BorderSize = 0;
            btnTrade.Click += (s, e) =>
            {
                OnRequestTradeClicked(skillId, title, offeredBy, mode);
            };

            // "Report" Button
            Button btnReport = new Button
            {
                Text = "🚩 Report",
                Font = new Font("Segoe UI", 8F),
                BackColor = Color.FromArgb(45, 45, 50),
                ForeColor = Color.FromArgb(239, 68, 68), // Soft red
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Size = new Size(80, 32),
                Location = new Point(184, 185)
            };
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.Click += (s, e) =>
            {
                OnReportClicked(skillId, title, offeredBy);
            };

            card.Controls.Add(lblBadge);
            card.Controls.Add(lblMode);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblAuthor);
            card.Controls.Add(divider);
            card.Controls.Add(btnTrade);
            card.Controls.Add(btnReport);

            return card;
        }

        private void ShowEmptyState(string message)
        {
            Label lblEmpty = new Label
            {
                Text = message,
                ForeColor = Color.FromArgb(161, 161, 170),
                Font = new Font("Segoe UI", 10.5F),
                AutoSize = false,
                Size = new Size(600, 80),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(120, 100, 0, 0)
            };
            flpMarketplace.Controls.Add(lblEmpty);
        }

        private void OnRequestTradeClicked(string skillId, string title, string owner, string mode)
        {
            // Connects with Trowa's Trade Request feature
            MessageBox.Show(
                $"Opening trade proposal for:\n\nSkill: {title}\nOffered by: {owner}\nMode: {mode}\n\n(Trowa's FormTradeRequest will open here!)",
                "Trade Request",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnReportClicked(string skillId, string title, string owner)
        {
            // Report dialog for Miggy's Admin Moderation / Reported Students queue
            string reason = Microsoft.VisualBasic.Interaction.InputBox(
                $"Why are you reporting this listing?\n\nListing: {title}\nPosted by: {owner}",
                "Report Listing / Student",
                "Inappropriate content or spam");

            if (!string.IsNullOrWhiteSpace(reason))
            {
                try
                {
                    string insertSql = @"INSERT INTO tbl_reports (SkillId, ReportedUser, Reason, ReportDate, Status) 
                                         VALUES (@sid, @user, @reason, NOW(), 'Pending')";
                    DatabaseHelper.ExecuteNonQuery(insertSql,
                        new MySqlParameter("@sid", skillId),
                        new MySqlParameter("@user", owner),
                        new MySqlParameter("@reason", reason.Trim())
                    );
                    MessageBox.Show("Report submitted successfully. Admin will review this listing.", "Report Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not record report: {ex.Message}", "Database Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMarketplaceCards(txtSearch.Text, cmbCategory.SelectedItem?.ToString() ?? "All Categories");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbCategory.SelectedIndex = 0;
            LoadMarketplaceCards("", "All Categories");
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMarketplaceCards(txtSearch.Text, cmbCategory.SelectedItem?.ToString() ?? "All Categories");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
