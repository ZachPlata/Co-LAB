namespace UESkillExchange
{
    partial class ReportDialog
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblTargetStudent = new System.Windows.Forms.Label();
            this.pnlWarning = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblReasonPrompt = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlWarning.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(25)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblTargetStudent);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 14, 20, 12);
            this.pnlHeader.Size = new System.Drawing.Size(464, 76);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(184)))), ((int)(((byte)(46)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(18, 12);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(225, 21);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Student Report Moderation";
            // 
            // lblTargetStudent
            // 
            this.lblTargetStudent.AutoSize = true;
            this.lblTargetStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTargetStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.lblTargetStudent.Location = new System.Drawing.Point(20, 39);
            this.lblTargetStudent.Name = "lblTargetStudent";
            this.lblTargetStudent.Size = new System.Drawing.Size(124, 17);
            this.lblTargetStudent.TabIndex = 1;
            this.lblTargetStudent.Text = "Reporting Student: ";
            // 
            // pnlWarning
            // 
            this.pnlWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.pnlWarning.Controls.Add(this.lblWarning);
            this.pnlWarning.Location = new System.Drawing.Point(20, 90);
            this.pnlWarning.Name = "pnlWarning";
            this.pnlWarning.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlWarning.Size = new System.Drawing.Size(424, 58);
            this.pnlWarning.TabIndex = 1;
            this.pnlWarning.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWarning_Paint);
            // 
            // lblWarning
            // 
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(195)))), ((int)(((byte)(90)))));
            this.lblWarning.Location = new System.Drawing.Point(12, 10);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(400, 38);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Notice: Submitting false or malicious reports violates the UE Community Guidelines and may lead to account suspension or disciplinary action.";
            // 
            // lblReasonPrompt
            // 
            this.lblReasonPrompt.AutoSize = true;
            this.lblReasonPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReasonPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.lblReasonPrompt.Location = new System.Drawing.Point(20, 160);
            this.lblReasonPrompt.Name = "lblReasonPrompt";
            this.lblReasonPrompt.Size = new System.Drawing.Size(193, 15);
            this.lblReasonPrompt.TabIndex = 2;
            this.lblReasonPrompt.Text = "Reason for Report / Specific Violation:";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(18)))));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReason.ForeColor = System.Drawing.Color.White;
            this.txtReason.Location = new System.Drawing.Point(20, 182);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(424, 110);
            this.txtReason.TabIndex = 3;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(11)))));
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnSubmitReport);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 307);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(464, 54);
            this.pnlActions.TabIndex = 4;
            this.pnlActions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActions_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
            this.btnCancel.Location = new System.Drawing.Point(234, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSubmitReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReport.FlatAppearance.BorderSize = 0;
            this.btnSubmitReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitReport.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReport.Location = new System.Drawing.Point(338, 11);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(106, 32);
            this.btnSubmitReport.TabIndex = 0;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // ReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReasonPrompt);
            this.Controls.Add(this.pnlWarning);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Student / Listing";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlWarning.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblTargetStudent;
        private System.Windows.Forms.Panel pnlWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblReasonPrompt;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitReport;
    }
}
