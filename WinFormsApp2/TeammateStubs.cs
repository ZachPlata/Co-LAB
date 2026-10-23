using System;
using System.Windows.Forms;

namespace UESkillExchange
{
    // Lightweight placeholder stubs for teammate forms.
    // Replace with Member 2, 3, and 4 actual implementations when integrated.

// auth form was here

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

    /// <summary>
    /// Member 3 Trade Request Form integration.
    /// Connects MarketplaceForm (and other forms) in UESkillExchange to the full FormTradeRequest implementation.
    /// </summary>
    public class TradeRequestDialog : global::FormTradeRequest.FormTradeRequest
    {
        public TradeRequestDialog(int listingId, string skillOffered, string skillWanted)
            : base(listingId, skillOffered, skillWanted)
        {
        }

        public TradeRequestDialog(int listingId, string skillOffered, string skillWanted, string userName, string deptYear, double rating = 5.0)
            : base(listingId, skillOffered, skillWanted, userName, deptYear, rating)
        {
        }

        public TradeRequestDialog()
            : base()
        {
        }
    }

    /// <summary>
    /// Alias allowing code in UESkillExchange to instantiate FormTradeRequest directly.
    /// </summary>
    public class FormTradeRequest : global::FormTradeRequest.FormTradeRequest
    {
        public FormTradeRequest(int listingId, string skillOffered, string skillWanted)
            : base(listingId, skillOffered, skillWanted)
        {
        }

        public FormTradeRequest(int listingId, string skillOffered, string skillWanted, string userName, string deptYear, double rating = 5.0)
            : base(listingId, skillOffered, skillWanted, userName, deptYear, rating)
        {
        }

        public FormTradeRequest()
            : base()
        {
        }
    }
}
