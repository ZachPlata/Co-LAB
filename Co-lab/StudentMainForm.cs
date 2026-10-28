namespace Co_LAB
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            btn_StudentDashboard.PerformClick();
        }

        // ==========================================
        // SIDEBAR BUTTON CLICK EVENTS (TRANSITIONS)
        // ==========================================

        private void btn_StudentDashboard_Click(object sender, EventArgs e)
        {
            uc_StudentDashboard frm = new uc_StudentDashboard();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_StudentDashboard);
            lblHeaderTitle.Text = "Student Dashboard";
        }

        private void btn_PostSkill_Click(object sender, EventArgs e)
        {
            uc_PostSkill frm = new uc_PostSkill();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_PostSkill);
            lblHeaderTitle.Text = "Post New Skill";
        }

        private void btn_ManageSkills_Click(object sender, EventArgs e)
        {
            uc_ManageSkills frm = new uc_ManageSkills();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_ManageSkills);
            lblHeaderTitle.Text = "Offered Skills";
        }

        private void btn_TradeRequests_Click(object sender, EventArgs e)
        {
            uc_TradeRequests frm = new uc_TradeRequests();
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btn_TradeRequests);
            lblHeaderTitle.Text = "Trade Requests";
        }

        private void SetActiveButton(Button activeButton)
        {
            Button[] navButtons = { btn_StudentDashboard, btn_PostSkill, btn_ManageSkills, btn_TradeRequests };
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
            if (MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
