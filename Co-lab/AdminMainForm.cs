namespace Co_LAB
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            btn_SkillCategories.PerformClick();
        }

        // ==========================================
        // SIDEBAR BUTTON CLICK EVENTS (TRANSITIONS)
        // ==========================================

        private void btn_SkillCategories_Click(object sender, EventArgs e)
        {
            uc_SkillCategories frm = new uc_SkillCategories();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_SkillCategories);
            lblHeaderTitle.Text = "Skill Categories Creation";
        }

        private void btn_ModerateListings_Click(object sender, EventArgs e)
        {
            uc_ModerateListings frm = new uc_ModerateListings();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_ModerateListings);
            lblHeaderTitle.Text = "Moderate Skill Listings";
        }

        private void btn_ReportedStudents_Click(object sender, EventArgs e)
        {
            uc_ReportedStudents frm = new uc_ReportedStudents();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_ReportedStudents);
            lblHeaderTitle.Text = "Reports & Blacklist";
        }

        private void btn_UpdateTOS_Click(object sender, EventArgs e)
        {
            uc_UpdateTOS frm = new uc_UpdateTOS();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_UpdateTOS);
            lblHeaderTitle.Text = "Update Terms of Service";
        }

        private void SetActiveButton(Button activeButton)
        {
            Button[] navButtons = { btn_SkillCategories, btn_ModerateListings, btn_ReportedStudents, btn_UpdateTOS };
            foreach (var btn in navButtons)
            {
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(28, 28, 33);
                    btn.ForeColor = Color.FromArgb(16, 185, 129); // Emerald Green
                    pnlNavIndicator.Location = new Point(0, btn.Top);
                    pnlNavIndicator.Height = btn.Height;
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(161, 161, 170); // Muted gray
                }
            }
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out of the Admin panel?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
