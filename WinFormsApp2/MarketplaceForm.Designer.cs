using System;
using System.Drawing;
using System.Windows.Forms;

namespace UESkillExchange
{
    partial class MarketplaceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlSidebarBottom = new Panel();
            lblSessionUser = new Label();
            btnLogout = new Button();
            btnMyDashboard = new Button();
            btnNavMarketplace = new Button();
            pnlSidebarTop = new Panel();
            lblBrand = new Label();
            lblBrandSub = new Label();
            pnlMain = new Panel();
            flpListings = new FlowLayoutPanel();
            pnlFilterBar = new Panel();
            btnRefresh = new Button();
            btnReset = new Button();
            btnFilter = new Button();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlTopBar = new Panel();
            lblWelcome = new Label();
            lblPageTitle = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pnlSidebar.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            pnlSidebarTop.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlFilterBar.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(10, 16, 11);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavMarketplace);
            pnlSidebar.Controls.Add(btnMyDashboard);
            pnlSidebar.Controls.Add(pnlSidebarTop);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 720);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // pnlSidebarBottom
            // 
            pnlSidebarBottom.Controls.Add(lblSessionUser);
            pnlSidebarBottom.Controls.Add(btnLogout);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 625);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Padding = new Padding(15, 10, 15, 15);
            pnlSidebarBottom.Size = new Size(220, 95);
            pnlSidebarBottom.TabIndex = 5;
            pnlSidebarBottom.Paint += pnlSidebarBottom_Paint;
            // 
            // lblSessionUser
            // 
            lblSessionUser.AutoEllipsis = true;
            lblSessionUser.Dock = DockStyle.Top;
            lblSessionUser.Font = new Font("Segoe UI", 8.25F);
            lblSessionUser.ForeColor = Color.FromArgb(130, 150, 135);
            lblSessionUser.Location = new Point(15, 10);
            lblSessionUser.Name = "lblSessionUser";
            lblSessionUser.Size = new Size(190, 28);
            lblSessionUser.TabIndex = 0;
            lblSessionUser.Text = "Student:";
            lblSessionUser.Click += lblSessionUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(235, 75, 75);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(15, 46);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 34);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Sign Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyDashboard
            // 
            btnMyDashboard.BackColor = Color.Transparent;
            btnMyDashboard.Cursor = Cursors.Hand;
            btnMyDashboard.Dock = DockStyle.Top;
            btnMyDashboard.FlatAppearance.BorderSize = 0;
            btnMyDashboard.FlatStyle = FlatStyle.Flat;
            btnMyDashboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnMyDashboard.ForeColor = Color.FromArgb(215, 225, 218);
            btnMyDashboard.Location = new Point(0, 92);
            btnMyDashboard.Name = "btnMyDashboard";
            btnMyDashboard.Padding = new Padding(20, 0, 0, 0);
            btnMyDashboard.Size = new Size(220, 44);
            btnMyDashboard.TabIndex = 1;
            btnMyDashboard.Text = "Student Dashboard";
            btnMyDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMyDashboard.UseVisualStyleBackColor = false;
            btnMyDashboard.Click += btnMyDashboard_Click;
            // 
            // btnNavMarketplace
            // 
            btnNavMarketplace.BackColor = Color.FromArgb(22, 35, 25);
            btnNavMarketplace.Cursor = Cursors.Hand;
            btnNavMarketplace.Dock = DockStyle.Top;
            btnNavMarketplace.FlatAppearance.BorderSize = 0;
            btnNavMarketplace.FlatStyle = FlatStyle.Flat;
            btnNavMarketplace.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnNavMarketplace.ForeColor = Color.FromArgb(245, 184, 46);
            btnNavMarketplace.Location = new Point(0, 136);
            btnNavMarketplace.Name = "btnNavMarketplace";
            btnNavMarketplace.Padding = new Padding(20, 0, 0, 0);
            btnNavMarketplace.Size = new Size(220, 44);
            btnNavMarketplace.TabIndex = 2;
            btnNavMarketplace.Text = "Marketplace Overview";
            btnNavMarketplace.TextAlign = ContentAlignment.MiddleLeft;
            btnNavMarketplace.UseVisualStyleBackColor = false;
            btnNavMarketplace.Click += btnNavMarketplace_Click;
            // 
            // pnlSidebarTop
            // 
            pnlSidebarTop.Controls.Add(lblBrand);
            pnlSidebarTop.Controls.Add(lblBrandSub);
            pnlSidebarTop.Dock = DockStyle.Top;
            pnlSidebarTop.Location = new Point(0, 0);
            pnlSidebarTop.Name = "pnlSidebarTop";
            pnlSidebarTop.Padding = new Padding(20, 20, 20, 15);
            pnlSidebarTop.Size = new Size(220, 92);
            pnlSidebarTop.TabIndex = 0;
            pnlSidebarTop.Paint += pnlSidebarTop_Paint;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Black", 13.5F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(245, 184, 46);
            lblBrand.Location = new Point(16, 20);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(80, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "CO-LAB";
            lblBrand.Click += lblBrand_Click;
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI", 8F);
            lblBrandSub.ForeColor = Color.FromArgb(145, 165, 150);
            lblBrandSub.Location = new Point(18, 48);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(141, 13);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "UE Student Skill Exchange";
            lblBrandSub.Click += lblBrandSub_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(14, 20, 15);
            pnlMain.Controls.Add(flpListings);
            pnlMain.Controls.Add(pnlFilterBar);
            pnlMain.Controls.Add(pnlTopBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(220, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(944, 720);
            pnlMain.TabIndex = 1;
            // 
            // flpListings
            // 
            flpListings.AutoScroll = true;
            flpListings.BackColor = Color.FromArgb(14, 20, 15);
            flpListings.Dock = DockStyle.Fill;
            flpListings.Location = new Point(0, 130);
            flpListings.Name = "flpListings";
            flpListings.Padding = new Padding(20, 10, 20, 20);
            flpListings.Size = new Size(944, 590);
            flpListings.TabIndex = 2;
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.BackColor = Color.FromArgb(22, 35, 25);
            pnlFilterBar.Controls.Add(btnRefresh);
            pnlFilterBar.Controls.Add(btnReset);
            pnlFilterBar.Controls.Add(btnFilter);
            pnlFilterBar.Controls.Add(cmbCategory);
            pnlFilterBar.Controls.Add(lblCategory);
            pnlFilterBar.Controls.Add(txtSearch);
            pnlFilterBar.Controls.Add(lblSearch);
            pnlFilterBar.Dock = DockStyle.Top;
            pnlFilterBar.Location = new Point(0, 68);
            pnlFilterBar.Margin = new Padding(20, 0, 20, 0);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(944, 62);
            pnlFilterBar.TabIndex = 1;
            pnlFilterBar.Paint += pnlFilterBar_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(36, 54, 40);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.FromArgb(210, 225, 215);
            btnRefresh.Location = new Point(811, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh Listings";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(36, 54, 40);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F);
            btnReset.ForeColor = Color.FromArgb(210, 225, 215);
            btnReset.Location = new Point(728, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(46, 105, 63);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(636, 16);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(85, 29);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(16, 26, 18);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 9.5F);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(431, 18);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(190, 25);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(190, 205, 195);
            lblCategory.Location = new Point(368, 23);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(16, 26, 18);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(106, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 24);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(190, 205, 195);
            lblSearch.Location = new Point(24, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Skills:";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(14, 20, 15);
            pnlTopBar.Controls.Add(lblWelcome);
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Padding = new Padding(24, 20, 24, 10);
            pnlTopBar.Size = new Size(944, 68);
            pnlTopBar.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(245, 184, 46);
            lblWelcome.Location = new Point(620, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(300, 22);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Student";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(20, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(309, 30);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Skill Exchange Marketplace";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // MarketplaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 20, 15);
            ClientSize = new Size(1164, 720);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1020, 640);
            Name = "MarketplaceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UE Student Skill Exchange - Marketplace";
            Load += MarketplaceForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            pnlSidebarTop.ResumeLayout(false);
            pnlSidebarTop.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlFilterBar.ResumeLayout(false);
            pnlFilterBar.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        #region UI Component & Styling Methods

        /// <summary>
        /// Builds a custom 310x250 card Panel with the dark forest-green design.
        /// </summary>
        public Panel CreateSkillCard(
            int listingId,
            int ownerId,
            string ownerName,
            string deptYear,
            string categoryName,
            string skillOffered,
            string skillWanted,
            string description,
            DateTime createdAt,
            EventHandler onTradeClick,
            EventHandler onReportClick)
        {
            bool isSelf = (ownerId == DbHelper.CurrentUserId);

            Panel card = new Panel
            {
                Size = new Size(310, 250),
                BackColor = Color.FromArgb(22, 35, 25),
                Margin = new Padding(12),
                Tag = listingId
            };

            card.Paint += (s, pe) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(40, 62, 45), 1))
                {
                    pe.Graphics.DrawRectangle(borderPen, 0, 0, card.Width - 1, card.Height - 1);
                }
            };

            Label lblBadge = new Label
            {
                Text = categoryName.ToUpperInvariant(),
                AutoSize = true,
                BackColor = Color.FromArgb(245, 184, 46),
                ForeColor = Color.FromArgb(10, 18, 12),
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Padding = new Padding(6, 2, 6, 2),
                Location = new Point(14, 12)
            };

            Label lblDate = new Label
            {
                Text = createdAt == DateTime.MinValue ? "Active" : createdAt.ToString("MMM dd, yyyy"),
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(135, 155, 140),
                Location = new Point(165, 13),
                Size = new Size(130, 16),
                TextAlign = ContentAlignment.MiddleRight
            };

            Label lblOwner = new Label
            {
                Text = string.IsNullOrWhiteSpace(deptYear) ? ownerName : $"{ownerName} • {deptYear}",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(175, 192, 180),
                Location = new Point(14, 38),
                Size = new Size(280, 18),
                AutoEllipsis = true
            };

            Label lblOffered = new Label
            {
                Text = $"Offers: {skillOffered}",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(14, 60),
                Size = new Size(280, 22),
                AutoEllipsis = true
            };

            Label lblWanted = new Label
            {
                Text = $"Wants: {skillWanted}",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(245, 184, 46),
                Location = new Point(14, 84),
                Size = new Size(280, 20),
                AutoEllipsis = true
            };

            string truncatedDesc = description;
            if (!string.IsNullOrEmpty(truncatedDesc) && truncatedDesc.Length > 95)
            {
                truncatedDesc = truncatedDesc.Substring(0, 95).TrimEnd() + "...";
            }

            Label lblDesc = new Label
            {
                Text = string.IsNullOrWhiteSpace(truncatedDesc) ? "No additional details provided." : truncatedDesc,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(155, 172, 160),
                Location = new Point(14, 108),
                Size = new Size(280, 80),
                AutoEllipsis = true
            };

            Button btnTrade = new Button
            {
                Text = isSelf ? "Your Listing" : "Request Trade",
                Location = new Point(14, 202),
                Size = new Size(190, 34),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold)
            };
            btnTrade.FlatAppearance.BorderSize = 0;

            if (isSelf)
            {
                btnTrade.Enabled = false;
                btnTrade.BackColor = Color.FromArgb(28, 42, 32);
                btnTrade.ForeColor = Color.FromArgb(95, 115, 100);
            }
            else
            {
                btnTrade.Enabled = true;
                btnTrade.BackColor = Color.FromArgb(46, 105, 63);
                btnTrade.ForeColor = Color.White;
                btnTrade.Cursor = Cursors.Hand;
                if (onTradeClick != null)
                {
                    btnTrade.Click += onTradeClick;
                }
            }

            Button btnReport = new Button
            {
                Text = "Report",
                Location = new Point(212, 202),
                Size = new Size(84, 34),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
            };
            btnReport.FlatAppearance.BorderSize = 0;

            if (isSelf)
            {
                btnReport.Enabled = false;
                btnReport.BackColor = Color.FromArgb(28, 42, 32);
                btnReport.ForeColor = Color.FromArgb(95, 115, 100);
            }
            else
            {
                btnReport.Enabled = true;
                btnReport.BackColor = Color.FromArgb(180, 40, 40);
                btnReport.ForeColor = Color.White;
                btnReport.Cursor = Cursors.Hand;
                if (onReportClick != null)
                {
                    btnReport.Click += onReportClick;
                }
            }

            card.Controls.Add(lblBadge);
            card.Controls.Add(lblDate);
            card.Controls.Add(lblOwner);
            card.Controls.Add(lblOffered);
            card.Controls.Add(lblWanted);
            card.Controls.Add(lblDesc);
            card.Controls.Add(btnTrade);
            card.Controls.Add(btnReport);

            return card;
        }

        /// <summary>
        /// Builds an empty-state notification card when no records are found.
        /// </summary>
        public Panel CreateEmptyStateCard(string message)
        {
            Panel pnlEmpty = new Panel
            {
                Size = new Size(Math.Max(flpListings.ClientSize.Width - 60, 400), 160),
                BackColor = Color.FromArgb(22, 35, 25),
                Margin = new Padding(15)
            };

            pnlEmpty.Paint += (s, pe) =>
            {
                using (Pen p = new Pen(Color.FromArgb(40, 62, 45), 1))
                {
                    pe.Graphics.DrawRectangle(p, 0, 0, pnlEmpty.Width - 1, pnlEmpty.Height - 1);
                }
            };

            Label lblMsg = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(170, 188, 175)
            };

            pnlEmpty.Controls.Add(lblMsg);
            return pnlEmpty;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.FromArgb(32, 48, 36), 1))
            {
                e.Graphics.DrawLine(borderPen, pnlSidebar.Width - 1, 0, pnlSidebar.Width - 1, pnlSidebar.Height);
            }
        }

        private void pnlSidebarTop_Paint(object sender, PaintEventArgs e)
        {
            using (Pen dividerPen = new Pen(Color.FromArgb(40, 62, 45), 1))
            {
                e.Graphics.DrawLine(dividerPen, 15, pnlSidebarTop.Height - 1, pnlSidebarTop.Width - 15, pnlSidebarTop.Height - 1);
            }
        }

        private void pnlSidebarBottom_Paint(object sender, PaintEventArgs e)
        {
            using (Pen dividerPen = new Pen(Color.FromArgb(40, 62, 45), 1))
            {
                e.Graphics.DrawLine(dividerPen, 15, 0, pnlSidebarBottom.Width - 15, 0);
            }
        }

        private void pnlFilterBar_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.FromArgb(40, 62, 45), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, pnlFilterBar.Width - 1, pnlFilterBar.Height - 1);
            }
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarTop;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Button btnNavMarketplace;
        private System.Windows.Forms.Button btnMyDashboard;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.Label lblSessionUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flpListings;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
