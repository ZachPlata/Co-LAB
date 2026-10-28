namespace Co_LAB
{
    partial class AdminMainForm
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
            pnlNavContainer = new Panel();
            pnlNavIndicator = new Panel();
            btn_UpdateTOS = new Button();
            btn_ReportedStudents = new Button();
            btn_ModerateListings = new Button();
            btn_SkillCategories = new Button();
            pnlSidebarBottom = new Panel();
            btn_SignOut = new Button();
            lblAdminInfo = new Label();
            pnlDividerBottom = new Panel();
            pnlBrand = new Panel();
            pnlDividerTop = new Panel();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            pnlHeader = new Panel();
            pnlDividerHeader = new Panel();
            lblWelcome = new Label();
            lblHeaderTitle = new Label();
            panelContent = new Panel();
            content_adminpan = new FlowLayoutPanel();
            pnlSidebar.SuspendLayout();
            pnlNavContainer.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            pnlBrand.SuspendLayout();
            pnlHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 15, 17);
            pnlSidebar.Controls.Add(pnlNavContainer);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(pnlBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlNavContainer
            // 
            pnlNavContainer.Controls.Add(pnlNavIndicator);
            pnlNavContainer.Controls.Add(btn_UpdateTOS);
            pnlNavContainer.Controls.Add(btn_ReportedStudents);
            pnlNavContainer.Controls.Add(btn_ModerateListings);
            pnlNavContainer.Controls.Add(btn_SkillCategories);
            pnlNavContainer.Dock = DockStyle.Fill;
            pnlNavContainer.Location = new Point(0, 85);
            pnlNavContainer.Name = "pnlNavContainer";
            pnlNavContainer.Padding = new Padding(0, 10, 0, 0);
            pnlNavContainer.Size = new Size(250, 535);
            pnlNavContainer.TabIndex = 1;
            // 
            // pnlNavIndicator
            // 
            pnlNavIndicator.BackColor = Color.FromArgb(16, 185, 129);
            pnlNavIndicator.Location = new Point(0, 10);
            pnlNavIndicator.Name = "pnlNavIndicator";
            pnlNavIndicator.Size = new Size(4, 50);
            pnlNavIndicator.TabIndex = 4;
            // 
            // btn_UpdateTOS
            // 
            btn_UpdateTOS.Cursor = Cursors.Hand;
            btn_UpdateTOS.Dock = DockStyle.Top;
            btn_UpdateTOS.FlatAppearance.BorderSize = 0;
            btn_UpdateTOS.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 42);
            btn_UpdateTOS.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 33);
            btn_UpdateTOS.FlatStyle = FlatStyle.Flat;
            btn_UpdateTOS.Font = new Font("Segoe UI", 10F);
            btn_UpdateTOS.ForeColor = Color.FromArgb(161, 161, 170);
            btn_UpdateTOS.Location = new Point(0, 160);
            btn_UpdateTOS.Name = "btn_UpdateTOS";
            btn_UpdateTOS.Padding = new Padding(22, 0, 10, 0);
            btn_UpdateTOS.Size = new Size(250, 50);
            btn_UpdateTOS.TabIndex = 3;
            btn_UpdateTOS.Text = "Update TOS";
            btn_UpdateTOS.TextAlign = ContentAlignment.MiddleLeft;
            btn_UpdateTOS.UseVisualStyleBackColor = true;
            btn_UpdateTOS.Click += btn_UpdateTOS_Click;
            // 
            // btn_ReportedStudents
            // 
            btn_ReportedStudents.Cursor = Cursors.Hand;
            btn_ReportedStudents.Dock = DockStyle.Top;
            btn_ReportedStudents.FlatAppearance.BorderSize = 0;
            btn_ReportedStudents.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 42);
            btn_ReportedStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 33);
            btn_ReportedStudents.FlatStyle = FlatStyle.Flat;
            btn_ReportedStudents.Font = new Font("Segoe UI", 10F);
            btn_ReportedStudents.ForeColor = Color.FromArgb(161, 161, 170);
            btn_ReportedStudents.Location = new Point(0, 110);
            btn_ReportedStudents.Name = "btn_ReportedStudents";
            btn_ReportedStudents.Padding = new Padding(22, 0, 10, 0);
            btn_ReportedStudents.Size = new Size(250, 50);
            btn_ReportedStudents.TabIndex = 2;
            btn_ReportedStudents.Text = "Reports & Blacklist";
            btn_ReportedStudents.TextAlign = ContentAlignment.MiddleLeft;
            btn_ReportedStudents.UseVisualStyleBackColor = true;
            btn_ReportedStudents.Click += btn_ReportedStudents_Click;
            // 
            // btn_ModerateListings
            // 
            btn_ModerateListings.Cursor = Cursors.Hand;
            btn_ModerateListings.Dock = DockStyle.Top;
            btn_ModerateListings.FlatAppearance.BorderSize = 0;
            btn_ModerateListings.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 42);
            btn_ModerateListings.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 33);
            btn_ModerateListings.FlatStyle = FlatStyle.Flat;
            btn_ModerateListings.Font = new Font("Segoe UI", 10F);
            btn_ModerateListings.ForeColor = Color.FromArgb(161, 161, 170);
            btn_ModerateListings.Location = new Point(0, 60);
            btn_ModerateListings.Name = "btn_ModerateListings";
            btn_ModerateListings.Padding = new Padding(22, 0, 10, 0);
            btn_ModerateListings.Size = new Size(250, 50);
            btn_ModerateListings.TabIndex = 1;
            btn_ModerateListings.Text = "Moderate Listings";
            btn_ModerateListings.TextAlign = ContentAlignment.MiddleLeft;
            btn_ModerateListings.UseVisualStyleBackColor = true;
            btn_ModerateListings.Click += btn_ModerateListings_Click;
            // 
            // btn_SkillCategories
            // 
            btn_SkillCategories.Cursor = Cursors.Hand;
            btn_SkillCategories.Dock = DockStyle.Top;
            btn_SkillCategories.FlatAppearance.BorderSize = 0;
            btn_SkillCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 42);
            btn_SkillCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 33);
            btn_SkillCategories.FlatStyle = FlatStyle.Flat;
            btn_SkillCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_SkillCategories.ForeColor = Color.FromArgb(16, 185, 129);
            btn_SkillCategories.Location = new Point(0, 10);
            btn_SkillCategories.Name = "btn_SkillCategories";
            btn_SkillCategories.Padding = new Padding(22, 0, 10, 0);
            btn_SkillCategories.Size = new Size(250, 50);
            btn_SkillCategories.TabIndex = 0;
            btn_SkillCategories.Text = "Skill Categories";
            btn_SkillCategories.TextAlign = ContentAlignment.MiddleLeft;
            btn_SkillCategories.UseVisualStyleBackColor = true;
            btn_SkillCategories.Click += btn_SkillCategories_Click;
            // 
            // pnlSidebarBottom
            // 
            pnlSidebarBottom.Controls.Add(btn_SignOut);
            pnlSidebarBottom.Controls.Add(lblAdminInfo);
            pnlSidebarBottom.Controls.Add(pnlDividerBottom);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 620);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(250, 100);
            pnlSidebarBottom.TabIndex = 2;
            // 
            // btn_SignOut
            // 
            btn_SignOut.Cursor = Cursors.Hand;
            btn_SignOut.Dock = DockStyle.Bottom;
            btn_SignOut.FlatAppearance.BorderSize = 0;
            btn_SignOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 25, 25);
            btn_SignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 20, 20);
            btn_SignOut.FlatStyle = FlatStyle.Flat;
            btn_SignOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_SignOut.ForeColor = Color.FromArgb(239, 68, 68);
            btn_SignOut.Location = new Point(0, 50);
            btn_SignOut.Name = "btn_SignOut";
            btn_SignOut.Padding = new Padding(22, 0, 0, 0);
            btn_SignOut.Size = new Size(250, 50);
            btn_SignOut.TabIndex = 2;
            btn_SignOut.Text = "Sign Out";
            btn_SignOut.TextAlign = ContentAlignment.MiddleLeft;
            btn_SignOut.UseVisualStyleBackColor = true;
            btn_SignOut.Click += btn_SignOut_Click;
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.AutoSize = true;
            lblAdminInfo.Font = new Font("Segoe UI", 9F);
            lblAdminInfo.ForeColor = Color.FromArgb(161, 161, 170);
            lblAdminInfo.Location = new Point(22, 20);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(104, 15);
            lblAdminInfo.TabIndex = 1;
            lblAdminInfo.Text = "Admin: Zach Plata";
            // 
            // pnlDividerBottom
            // 
            pnlDividerBottom.BackColor = Color.FromArgb(39, 39, 42);
            pnlDividerBottom.Dock = DockStyle.Top;
            pnlDividerBottom.Location = new Point(0, 0);
            pnlDividerBottom.Name = "pnlDividerBottom";
            pnlDividerBottom.Size = new Size(250, 1);
            pnlDividerBottom.TabIndex = 0;
            // 
            // pnlBrand
            // 
            pnlBrand.Controls.Add(pnlDividerTop);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(250, 85);
            pnlBrand.TabIndex = 0;
            // 
            // pnlDividerTop
            // 
            pnlDividerTop.BackColor = Color.FromArgb(39, 39, 42);
            pnlDividerTop.Dock = DockStyle.Bottom;
            pnlDividerTop.Location = new Point(0, 84);
            pnlDividerTop.Name = "pnlDividerTop";
            pnlDividerTop.Size = new Size(250, 1);
            pnlDividerTop.TabIndex = 2;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 8.25F);
            lblBrandSubtitle.ForeColor = Color.FromArgb(161, 161, 170);
            lblBrandSubtitle.Location = new Point(22, 48);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(144, 13);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Admin Management Portal";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.FromArgb(16, 185, 129);
            lblBrandTitle.Location = new Point(20, 18);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(93, 30);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "CO-LAB";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 18, 20);
            pnlHeader.Controls.Add(pnlDividerHeader);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(950, 85);
            pnlHeader.TabIndex = 1;
            // 
            // pnlDividerHeader
            // 
            pnlDividerHeader.BackColor = Color.FromArgb(39, 39, 42);
            pnlDividerHeader.Dock = DockStyle.Bottom;
            pnlDividerHeader.Location = new Point(0, 84);
            pnlDividerHeader.Name = "pnlDividerHeader";
            pnlDividerHeader.Size = new Size(950, 1);
            pnlDividerHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(16, 185, 129);
            lblWelcome.Location = new Point(780, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(137, 17);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Zach Plata";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(30, 24);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(266, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Skill Categories Creation";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(24, 24, 27);
            panelContent.Controls.Add(content_adminpan);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 85);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(950, 635);
            panelContent.TabIndex = 2;
            // 
            // content_adminpan
            // 
            content_adminpan.Location = new Point(0, 0);
            content_adminpan.Name = "content_adminpan";
            content_adminpan.Size = new Size(950, 632);
            content_adminpan.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 17);
            ClientSize = new Size(1200, 720);
            Controls.Add(panelContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 600);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CO-LAB - Admin Portal";
            Load += AdminMainForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlNavContainer.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            pnlSidebarBottom.PerformLayout();
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlBrand;
        private Label lblBrandTitle;
        private Label lblBrandSubtitle;
        private Panel pnlDividerTop;
        private Panel pnlNavContainer;
        private Button btn_SkillCategories;
        private Button btn_ModerateListings;
        private Button btn_ReportedStudents;
        private Button btn_UpdateTOS;
        private Panel pnlNavIndicator;
        private Panel pnlSidebarBottom;
        private Panel pnlDividerBottom;
        private Label lblAdminInfo;
        private Button btn_SignOut;
        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblWelcome;
        private Panel pnlDividerHeader;
        private Panel panelContent;
        private FlowLayoutPanel content_adminpan;
    }
}
