using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UESkillExchange
{
    public partial class AuthForm : Form
    {
        // Theme colors (edit here to restyle)
        private static Color C(string hex) => ColorTranslator.FromHtml(hex);
        private readonly Color clrBg = C("#0C1410");
        private readonly Color clrCard = C("#101A14");
        private readonly Color clrInput = C("#142019");
        private readonly Color clrMuted = C("#8FB89A");
        private readonly Color clrLink = C("#4FBF7A");
        private readonly Color clrGold = C("#F5B335");
        private readonly Color clrBtn = C("#2B6B43");
        private readonly Color clrBtnOff = C("#1E2B24");

        public AuthForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        // ================= THEME =================
        private void ApplyTheme()
        {
            BackColor = clrBg;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 9.5f);

            // Textboxes, labels, checkbox, link, tab pages
            StyleControls(this);

            // Buttons: colors/flat style only (size and position unchanged)
            StyleButton(btnLogin);
            StyleButton(btnRegister);

            // Tab headers
            StyleTabs();

            // CO-LAB heading
            AddBrandHeader();

            // Give the "Department and Year" label room (change 20 to 30 if still clipped)
            txtRegDeptYear.Left += 20;
            txtRegDeptYear.Width -= 20;
        }

        private void StyleControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                switch (c)
                {
                    case Button:
                        break; // handled by StyleButton

                    case TabPage p:
                        p.UseVisualStyleBackColor = false;
                        p.BackColor = clrCard;
                        break;

                    case TextBox t:
                        t.BackColor = clrInput;
                        t.ForeColor = Color.White;
                        t.BorderStyle = BorderStyle.FixedSingle;
                        break;

                    case LinkLabel l:
                        l.LinkColor = clrLink;
                        l.ActiveLinkColor = Color.White;
                        l.VisitedLinkColor = clrLink;
                        l.BackColor = Color.Transparent;
                        break;

                    case CheckBox cb:
                        cb.ForeColor = Color.White;
                        cb.BackColor = Color.Transparent;
                        break;

                    case Label lb:
                        lb.ForeColor = clrMuted;
                        lb.BackColor = Color.Transparent;
                        break;
                }
                StyleControls(c);
            }
        }

        private void StyleButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.UseVisualStyleBackColor = false;
            b.ForeColor = Color.White;
            b.Cursor = Cursors.Hand;
            b.BackColor = b.Enabled ? clrBtn : clrBtnOff;
            b.EnabledChanged += (s, e) =>
            {
                var btn = (Button)s!;
                btn.BackColor = btn.Enabled ? clrBtn : clrBtnOff;
            };
        }

        private void StyleTabs()
        {
            tabAuth.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabAuth.SizeMode = TabSizeMode.Fixed;
            tabAuth.ItemSize = new Size(110, 30);
            tabAuth.DrawItem += (s, e) =>
            {
                bool selected = e.Index == tabAuth.SelectedIndex;
                using (var back = new SolidBrush(selected ? clrBtn : clrCard))
                    e.Graphics.FillRectangle(back, e.Bounds);

                using (var f = new Font("Segoe UI", 9.5f, FontStyle.Bold))
                    TextRenderer.DrawText(e.Graphics, tabAuth.TabPages[e.Index].Text, f,
                        e.Bounds, selected ? Color.White : clrMuted,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        private void AddBrandHeader()
        {
            const int headerHeight = 50;

            var lblBrand = new Label
            {
                Name = "lblBrand",
                Text = "CO-LAB",
                Font = new Font("Segoe UI", 18f, FontStyle.Bold),
                ForeColor = clrGold,
                BackColor = clrBg,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = headerHeight
            };

            // Make room: grow the form, and push the tab control down if it isn't docked
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + headerHeight);
            if (tabAuth.Dock == DockStyle.None)
                tabAuth.Top += headerHeight;

            Controls.Add(lblBrand);
        }

        // ================= EVENTS =================
        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = chkAgree.Checked;
        }

        private void lnkTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermsDialog tos = new TermsDialog();
            tos.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtRegEmail.Text.Trim().ToLower();

            // 1. Enforce @ue.edu.ph requirement
            if (!email.EndsWith("@ue.edu.ph"))
            {
                MessageBox.Show("Registration requires an official @ue.edu.ph email address.",
                    "UE Account Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRegName.Text) ||
                string.IsNullOrWhiteSpace(txtRegPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRegDeptYear.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO users (full_name, ue_email, password, dept_year, role) VALUES (@name, @email, @pass, @dept, 'student')";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtRegName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", txtRegPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", txtRegDeptYear.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registration successful! You may now log in.");

                txtRegName.Clear(); txtRegEmail.Clear(); txtRegPassword.Clear(); txtRegDeptYear.Clear();
                chkAgree.Checked = false;
                tabAuth.SelectedTab = tabLogin;
            }
            catch (MySqlException ex)
            {
                // 1062 = duplicate entry (email already registered)
                if (ex.Number == 1062)
                    MessageBox.Show("That @ue.edu.ph email is already registered.");
                else
                    MessageBox.Show("Cannot connect to the database. Make sure MySQL is running in XAMPP.",
                        "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT user_id, full_name, role, is_blacklisted FROM users WHERE ue_email = @email AND password = @pass LIMIT 1";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", txtLoginEmail.Text.Trim().ToLower());
                        cmd.Parameters.AddWithValue("@pass", txtLoginPassword.Text.Trim());

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Check if student was blacklisted by Admin
                                if (Convert.ToInt32(reader["is_blacklisted"]) == 1)
                                {
                                    MessageBox.Show("Your account has been blacklisted by the Admin for violating exchange policies.",
                                        "Account Suspended", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }

                                DbHelper.CurrentUserId = Convert.ToInt32(reader["user_id"]);
                                DbHelper.CurrentUserName = reader["full_name"].ToString() ?? "";
                                DbHelper.CurrentUserRole = reader["role"].ToString() ?? "";

                                this.Hide();

                                if (DbHelper.CurrentUserRole == "admin")
                                {
                                    // AdminForm admin = new AdminForm();
                                    // admin.Show();
                                    MessageBox.Show("Admin login OK (AdminForm not merged yet).");
                                }
                                else
                                {
                                    MarketplaceForm market = new MarketplaceForm();
                                    market.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid UE Email or Password.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Cannot connect to the database. Make sure MySQL is running in XAMPP.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}