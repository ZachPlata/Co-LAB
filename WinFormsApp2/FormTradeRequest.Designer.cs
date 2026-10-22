using System.Drawing;
using System.Windows.Forms;

namespace FormTradeRequest
{
    partial class FormTradeRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTargetSkillHeader = new Label();
            lblTargetSkill = new Label();
            pnlUserCard = new RoundedPanel();
            avatarTargetUser = new AvatarCircle();
            lblUserName = new Label();
            lblUserDept = new Label();
            lblStarIcon = new Label();
            lblUserRating = new Label();
            lblReturnSkillPrompt = new Label();
            lblModePrompt = new Label();
            pnlMode = new RoundedPanel();
            rbF2F = new RadioButton();
            rbOnline = new RadioButton();
            lblVenuePrompt = new Label();
            pnlVenueOrLink = new RoundedPanel();
            txtVenueOrLink = new TextBox();
            lblSchedulePrompt = new Label();
            pnlScheduleNotes = new RoundedPanel();
            txtScheduleNotes = new TextBox();
            btnSendRequest = new RoundedButton();
            btnCancel = new RoundedButton();
            comboBox1 = new ComboBox();
            pnlUserCard.SuspendLayout();
            pnlMode.SuspendLayout();
            pnlVenueOrLink.SuspendLayout();
            pnlScheduleNotes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(28, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(342, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Propose Skill Exchange";
            // 
            // lblTargetSkillHeader
            // 
            lblTargetSkillHeader.AutoSize = true;
            lblTargetSkillHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTargetSkillHeader.ForeColor = Color.White;
            lblTargetSkillHeader.Location = new Point(28, 62);
            lblTargetSkillHeader.Name = "lblTargetSkillHeader";
            lblTargetSkillHeader.Size = new Size(115, 25);
            lblTargetSkillHeader.TabIndex = 1;
            lblTargetSkillHeader.Text = "Target Skill:";
            // 
            // lblTargetSkill
            // 
            lblTargetSkill.Font = new Font("Segoe UI", 9.5F);
            lblTargetSkill.ForeColor = Color.FromArgb(200, 225, 205);
            lblTargetSkill.Location = new Point(149, 59);
            lblTargetSkill.Name = "lblTargetSkill";
            lblTargetSkill.Size = new Size(363, 62);
            lblTargetSkill.TabIndex = 2;
            lblTargetSkill.Text = "They Offer: C# WinForms & MySQL Tutoring\r\nThey Need: Figma UI Design or Video Editing";
            // 
            // pnlUserCard
            // 
            pnlUserCard.BackColor = Color.FromArgb(17, 30, 21);
            pnlUserCard.BorderColor = Color.FromArgb(46, 72, 52);
            pnlUserCard.BorderWidth = 1.2F;
            pnlUserCard.Controls.Add(avatarTargetUser);
            pnlUserCard.Controls.Add(lblUserName);
            pnlUserCard.Controls.Add(lblUserDept);
            pnlUserCard.Controls.Add(lblStarIcon);
            pnlUserCard.Controls.Add(lblUserRating);
            pnlUserCard.CornerRadius = 14;
            pnlUserCard.Location = new Point(28, 130);
            pnlUserCard.Name = "pnlUserCard";
            pnlUserCard.Size = new Size(484, 68);
            pnlUserCard.TabIndex = 3;
            // 
            // avatarTargetUser
            // 
            avatarTargetUser.Location = new Point(12, 10);
            avatarTargetUser.Name = "avatarTargetUser";
            avatarTargetUser.Size = new Size(48, 48);
            avatarTargetUser.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(68, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(54, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User";
            // 
            // lblUserDept
            // 
            lblUserDept.AutoSize = true;
            lblUserDept.Font = new Font("Segoe UI", 9F);
            lblUserDept.ForeColor = Color.FromArgb(160, 185, 168);
            lblUserDept.Location = new Point(68, 38);
            lblUserDept.Name = "lblUserDept";
            lblUserDept.Size = new Size(87, 20);
            lblUserDept.TabIndex = 2;
            lblUserDept.Text = "course: Year";
            // 
            // lblStarIcon
            // 
            lblStarIcon.AutoSize = true;
            lblStarIcon.Font = new Font("Segoe UI", 13F);
            lblStarIcon.ForeColor = Color.FromArgb(240, 185, 52);
            lblStarIcon.Location = new Point(392, 18);
            lblStarIcon.Name = "lblStarIcon";
            lblStarIcon.Size = new Size(31, 30);
            lblStarIcon.TabIndex = 3;
            lblStarIcon.Text = "★";
            // 
            // lblUserRating
            // 
            lblUserRating.AutoSize = true;
            lblUserRating.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblUserRating.ForeColor = Color.FromArgb(240, 185, 52);
            lblUserRating.Location = new Point(426, 21);
            lblUserRating.Name = "lblUserRating";
            lblUserRating.Size = new Size(41, 28);
            lblUserRating.TabIndex = 4;
            lblUserRating.Text = "5.0";
            // 
            // lblReturnSkillPrompt
            // 
            lblReturnSkillPrompt.AutoSize = true;
            lblReturnSkillPrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReturnSkillPrompt.ForeColor = Color.FromArgb(215, 230, 218);
            lblReturnSkillPrompt.Location = new Point(28, 222);
            lblReturnSkillPrompt.Name = "lblReturnSkillPrompt";
            lblReturnSkillPrompt.Size = new Size(372, 20);
            lblReturnSkillPrompt.TabIndex = 4;
            lblReturnSkillPrompt.Text = "What skill will you give in return? (Strictly No Cash):";
            // 
            // lblModePrompt
            // 
            lblModePrompt.AutoSize = true;
            lblModePrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModePrompt.ForeColor = Color.FromArgb(215, 230, 218);
            lblModePrompt.Location = new Point(28, 276);
            lblModePrompt.Name = "lblModePrompt";
            lblModePrompt.Size = new Size(232, 20);
            lblModePrompt.TabIndex = 6;
            lblModePrompt.Text = "Exchange Format / Trade Mode:";
            // 
            // pnlMode
            // 
            pnlMode.BackColor = Color.White;
            pnlMode.BorderColor = Color.Transparent;
            pnlMode.BorderWidth = 0F;
            pnlMode.Controls.Add(rbF2F);
            pnlMode.Controls.Add(rbOnline);
            pnlMode.CornerRadius = 14;
            pnlMode.Location = new Point(28, 298);
            pnlMode.Name = "pnlMode";
            pnlMode.Size = new Size(484, 38);
            pnlMode.TabIndex = 7;
            // 
            // rbF2F
            // 
            rbF2F.AutoSize = true;
            rbF2F.Checked = true;
            rbF2F.Cursor = Cursors.Hand;
            rbF2F.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbF2F.ForeColor = Color.FromArgb(20, 36, 24);
            rbF2F.Location = new Point(20, 7);
            rbF2F.Name = "rbF2F";
            rbF2F.Size = new Size(211, 27);
            rbF2F.TabIndex = 0;
            rbF2F.TabStop = true;
            rbF2F.Text = "Face-to-Face (Campus)";
            rbF2F.UseVisualStyleBackColor = true;
            rbF2F.CheckedChanged += rbMode_CheckedChanged;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Cursor = Cursors.Hand;
            rbOnline.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            rbOnline.ForeColor = Color.FromArgb(20, 36, 24);
            rbOnline.Location = new Point(255, 7);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(146, 27);
            rbOnline.TabIndex = 1;
            rbOnline.Text = "Online Session";
            rbOnline.UseVisualStyleBackColor = true;
            rbOnline.CheckedChanged += rbMode_CheckedChanged;
            // 
            // lblVenuePrompt
            // 
            lblVenuePrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVenuePrompt.ForeColor = Color.FromArgb(215, 230, 218);
            lblVenuePrompt.Location = new Point(28, 344);
            lblVenuePrompt.Name = "lblVenuePrompt";
            lblVenuePrompt.Size = new Size(484, 20);
            lblVenuePrompt.TabIndex = 8;
            lblVenuePrompt.Text = "Required Campus Meetup Location (e.g., UE Library 2nd Floor):";
            // 
            // pnlVenueOrLink
            // 
            pnlVenueOrLink.BackColor = Color.White;
            pnlVenueOrLink.BorderColor = Color.Transparent;
            pnlVenueOrLink.BorderWidth = 0F;
            pnlVenueOrLink.Controls.Add(txtVenueOrLink);
            pnlVenueOrLink.CornerRadius = 14;
            pnlVenueOrLink.Location = new Point(28, 366);
            pnlVenueOrLink.Name = "pnlVenueOrLink";
            pnlVenueOrLink.Size = new Size(484, 38);
            pnlVenueOrLink.TabIndex = 9;
            // 
            // txtVenueOrLink
            // 
            txtVenueOrLink.BorderStyle = BorderStyle.None;
            txtVenueOrLink.Font = new Font("Segoe UI", 10.5F);
            txtVenueOrLink.ForeColor = Color.FromArgb(25, 25, 25);
            txtVenueOrLink.Location = new Point(14, 8);
            txtVenueOrLink.Name = "txtVenueOrLink";
            txtVenueOrLink.Size = new Size(456, 24);
            txtVenueOrLink.TabIndex = 0;
            // 
            // lblSchedulePrompt
            // 
            lblSchedulePrompt.AutoSize = true;
            lblSchedulePrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSchedulePrompt.ForeColor = Color.FromArgb(215, 230, 218);
            lblSchedulePrompt.Location = new Point(28, 412);
            lblSchedulePrompt.Name = "lblSchedulePrompt";
            lblSchedulePrompt.Size = new Size(55, 20);
            lblSchedulePrompt.TabIndex = 10;
            lblSchedulePrompt.Text = "Notes:";
            // 
            // pnlScheduleNotes
            // 
            pnlScheduleNotes.BackColor = Color.White;
            pnlScheduleNotes.BorderColor = Color.Transparent;
            pnlScheduleNotes.BorderWidth = 0F;
            pnlScheduleNotes.Controls.Add(txtScheduleNotes);
            pnlScheduleNotes.CornerRadius = 14;
            pnlScheduleNotes.Location = new Point(28, 434);
            pnlScheduleNotes.Name = "pnlScheduleNotes";
            pnlScheduleNotes.Size = new Size(484, 155);
            pnlScheduleNotes.TabIndex = 11;
            // 
            // txtScheduleNotes
            // 
            txtScheduleNotes.BorderStyle = BorderStyle.None;
            txtScheduleNotes.Font = new Font("Segoe UI", 10.5F);
            txtScheduleNotes.ForeColor = Color.FromArgb(25, 25, 25);
            txtScheduleNotes.Location = new Point(14, 10);
            txtScheduleNotes.Multiline = true;
            txtScheduleNotes.Name = "txtScheduleNotes";
            txtScheduleNotes.ScrollBars = ScrollBars.Vertical;
            txtScheduleNotes.Size = new Size(456, 134);
            txtScheduleNotes.TabIndex = 0;
            // 
            // btnSendRequest
            // 
            btnSendRequest.CornerRadius = 10;
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendRequest.ForeColor = Color.White;
            btnSendRequest.HoverColor = Color.FromArgb(112, 160, 124);
            btnSendRequest.Location = new Point(268, 614);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.NormalColor = Color.FromArgb(96, 142, 108);
            btnSendRequest.PressedColor = Color.FromArgb(82, 125, 93);
            btnSendRequest.Size = new Size(132, 40);
            btnSendRequest.TabIndex = 12;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // btnCancel
            // 
            btnCancel.CornerRadius = 10;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.HoverColor = Color.FromArgb(205, 60, 60);
            btnCancel.Location = new Point(412, 614);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalColor = Color.FromArgb(184, 48, 48);
            btnCancel.PressedColor = Color.FromArgb(160, 38, 38);
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(484, 28);
            comboBox1.TabIndex = 14;
            // 
            // FormTradeRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 36, 24);
            ClientSize = new Size(540, 680);
            Controls.Add(comboBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSendRequest);
            Controls.Add(pnlScheduleNotes);
            Controls.Add(lblSchedulePrompt);
            Controls.Add(pnlVenueOrLink);
            Controls.Add(lblVenuePrompt);
            Controls.Add(pnlMode);
            Controls.Add(lblModePrompt);
            Controls.Add(lblReturnSkillPrompt);
            Controls.Add(pnlUserCard);
            Controls.Add(lblTargetSkill);
            Controls.Add(lblTargetSkillHeader);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTradeRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Propose Skill Exchange";
            Load += FormTradeRequest_Load;
            pnlUserCard.ResumeLayout(false);
            pnlUserCard.PerformLayout();
            pnlMode.ResumeLayout(false);
            pnlMode.PerformLayout();
            pnlVenueOrLink.ResumeLayout(false);
            pnlVenueOrLink.PerformLayout();
            pnlScheduleNotes.ResumeLayout(false);
            pnlScheduleNotes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitle;
        public Label lblTargetSkillHeader;
        public Label lblTargetSkill;
        public RoundedPanel pnlUserCard;
        public AvatarCircle avatarTargetUser;
        public Label lblUserName;
        public Label lblUserDept;
        public Label lblStarIcon;
        public Label lblUserRating;
        public Label lblReturnSkillPrompt;
        public Label lblModePrompt;
        public RoundedPanel pnlMode;
        public RadioButton rbF2F;
        public RadioButton rbOnline;
        public Label lblVenuePrompt;
        public RoundedPanel pnlVenueOrLink;
        public TextBox txtVenueOrLink;
        public Label lblSchedulePrompt;
        public RoundedPanel pnlScheduleNotes;
        public TextBox txtScheduleNotes;
        public RoundedButton btnSendRequest;
        public RoundedButton btnCancel;
        public ComboBox comboBox1;
    }
}
