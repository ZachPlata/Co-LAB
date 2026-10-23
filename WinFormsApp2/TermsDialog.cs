using System;
using System.Drawing;
using System.Windows.Forms;

namespace UESkillExchange
{
    public class TermsDialog : Form
    {
        // ---- Edit the Terms of Service text here ----
        private const string TermsText =
@"UE SKILL EXCHANGE - TERMS OF SERVICE

1. NO CASH OR MONETARY PAYMENTS
All trades must be skill-for-skill only. Asking for or offering money, load, gifts, or any other payment in exchange for a skill is not allowed.

2. VERIFIED UE ACCOUNTS ONLY
Only students with an official @ue.edu.ph email address may register and use the platform.

3. FACE-TO-FACE TRADES
Face-to-face skill exchanges must take place inside official UE campus areas such as the Library, Study Lounges, or Open Grounds.

4. ONLINE TRADES
Online skill exchanges must use a valid Google Meet, Zoom, or Discord link provided in the trade request.

5. RESPECT AND CONDUCT
Be honest and respectful to other students. Harassment, inappropriate behavior, fake listings, and misleading skill offers are not tolerated.

6. REPORTING AND BLACKLISTING
Students may report any user who violates these rules. After review, the Admin may remove listings or blacklist accounts. Blacklisted students can no longer log in or post skills.

7. ACCEPTANCE OF TERMS
By ticking the agreement box during registration, you confirm that you have read and agree to follow these Terms of Service.";

        public TermsDialog()
        {
            // ---- Theme colors (match the Marketplace) ----
            Color bg = ColorTranslator.FromHtml("#0C1410");
            Color panel = ColorTranslator.FromHtml("#101A14");
            Color btnGreen = ColorTranslator.FromHtml("#2B6B43");

            // ---- Form ----
            Text = "Terms of Service";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(500, 450);
            BackColor = bg;

            // ---- Terms text (read-only, plain text) ----
            var txtTermsContent = new TextBox
            {
                Name = "txtTermsContent",
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new Point(15, 15),
                Size = new Size(470, 375),
                BackColor = panel,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10f),
                TabStop = false,
                Text = TermsText.Replace("\r\n", "\n").Replace("\n", Environment.NewLine)
            };

            // ---- Close button ----
            var btnClose = new Button
            {
                Name = "btnClose",
                Text = "Close",
                Location = new Point(385, 402),
                Size = new Size(100, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = btnGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();

            AcceptButton = btnClose;
            CancelButton = btnClose;   // Esc also closes

            Controls.Add(txtTermsContent);
            Controls.Add(btnClose);

            // Stop the text from opening highlighted
            Shown += (s, e) =>
            {
                txtTermsContent.SelectionStart = 0;
                txtTermsContent.SelectionLength = 0;
                ActiveControl = btnClose;
            };
        }
    }
}