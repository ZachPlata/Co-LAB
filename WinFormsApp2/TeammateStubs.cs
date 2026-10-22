using System;
using System.Windows.Forms;

namespace UESkillExchange
{
    // Lightweight placeholder stubs for teammate forms.
    // Replace with Member 2, 3, and 4 actual implementations when integrated.

    public class AuthForm : Form
    {
        public AuthForm()
        {
            this.Text = "UE Skill Exchange - Authentication";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    public class PostSkillForm : Form
    {
        public PostSkillForm()
        {
            this.Text = "Post New Skill";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(450, 400);
        }
    }

    public class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            this.Text = "My Student Dashboard";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(700, 500);
        }
    }

    public class TradeRequestDialog : Form
    {
        public TradeRequestDialog(int listingId, string skillOffered, string skillWanted)
        {
            this.Text = "Request Skill Trade";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(480, 420);
        }
    }
}
