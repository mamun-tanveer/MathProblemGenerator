namespace WindowsApp
{
    partial class Form1
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
            this.ProblemBox = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.TimeHeaderLabel = new System.Windows.Forms.Label();
            this.TimeValueLabel = new System.Windows.Forms.Label();
            this.OpListBox = new System.Windows.Forms.CheckedListBox();
            this.AnswerCountBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProblemBox
            // 
            this.ProblemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemBox.Location = new System.Drawing.Point(12, 44);
            this.ProblemBox.Multiline = true;
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.ReadOnly = true;
            this.ProblemBox.Size = new System.Drawing.Size(282, 120);
            this.ProblemBox.TabIndex = 0;
            this.ProblemBox.TabStop = false;
            this.ProblemBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Location = new System.Drawing.Point(13, 170);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(282, 39);
            this.AnswerBox.TabIndex = 1;
            this.AnswerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(13, 215);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(433, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // TimeHeaderLabel
            // 
            this.TimeHeaderLabel.AutoSize = true;
            this.TimeHeaderLabel.Location = new System.Drawing.Point(301, 170);
            this.TimeHeaderLabel.Name = "TimeHeaderLabel";
            this.TimeHeaderLabel.Size = new System.Drawing.Size(42, 13);
            this.TimeHeaderLabel.TabIndex = 4;
            this.TimeHeaderLabel.Text = "Time = ";
            // 
            // TimeValueLabel
            // 
            this.TimeValueLabel.AutoSize = true;
            this.TimeValueLabel.Location = new System.Drawing.Point(349, 170);
            this.TimeValueLabel.Name = "TimeValueLabel";
            this.TimeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeValueLabel.TabIndex = 5;
            // 
            // OpListBox
            // 
            this.OpListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpListBox.FormattingEnabled = true;
            this.OpListBox.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "TIMES",
            "DIVIDE"});
            this.OpListBox.Location = new System.Drawing.Point(300, 44);
            this.OpListBox.Name = "OpListBox";
            this.OpListBox.Size = new System.Drawing.Size(146, 72);
            this.OpListBox.TabIndex = 6;
            // 
            // AnswerCountBox
            // 
            this.AnswerCountBox.AutoSize = true;
            this.AnswerCountBox.Location = new System.Drawing.Point(304, 187);
            this.AnswerCountBox.Name = "AnswerCountBox";
            this.AnswerCountBox.Size = new System.Drawing.Size(0, 13);
            this.AnswerCountBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.AnswerCountBox);
            this.Controls.Add(this.OpListBox);
            this.Controls.Add(this.TimeValueLabel);
            this.Controls.Add(this.TimeHeaderLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.ProblemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProblemBox;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TimeHeaderLabel;
        private System.Windows.Forms.Label TimeValueLabel;
        private System.Windows.Forms.CheckedListBox OpListBox;
        private System.Windows.Forms.Label AnswerCountBox;
    }
}

