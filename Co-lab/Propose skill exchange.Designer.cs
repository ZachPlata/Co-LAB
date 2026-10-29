namespace Co_LAB
{
    partial class Propose_skill_exchange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            lblHeaderTitle = new Label();
            label1 = new Label();
            radioButton2 = new RadioButton();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 185, 129);
            panel1.Location = new Point(21, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 52);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(424, 23);
            comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(21, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 24);
            panel2.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(48, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(146, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Face to face (Campus)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(21, 319);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(424, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(21, 373);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(424, 23);
            maskedTextBox2.SkipLiterals = false;
            maskedTextBox2.TabIndex = 4;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(21, 16);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(251, 30);
            lblHeaderTitle.TabIndex = 5;
            lblHeaderTitle.Text = "Propose Skill Exchange";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 6;
            label1.Text = "Target Skill:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(251, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Online Sessions";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Propose_skill_exchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 27);
            Controls.Add(label1);
            Controls.Add(lblHeaderTitle);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "Propose_skill_exchange";
            Size = new Size(466, 543);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label lblHeaderTitle;
        private Label label1;
    }
}
