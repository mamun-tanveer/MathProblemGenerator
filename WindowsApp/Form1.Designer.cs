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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeHeaderLabel = new System.Windows.Forms.Label();
            this.TimeValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProblemBox
            // 
            this.ProblemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemBox.Location = new System.Drawing.Point(13, 13);
            this.ProblemBox.Multiline = true;
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.ReadOnly = true;
            this.ProblemBox.Size = new System.Drawing.Size(282, 141);
            this.ProblemBox.TabIndex = 0;
            this.ProblemBox.TabStop = false;
            this.ProblemBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Location = new System.Drawing.Point(13, 160);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(302, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 79);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TimeHeaderLabel
            // 
            this.TimeHeaderLabel.AutoSize = true;
            this.TimeHeaderLabel.Location = new System.Drawing.Point(302, 99);
            this.TimeHeaderLabel.Name = "TimeHeaderLabel";
            this.TimeHeaderLabel.Size = new System.Drawing.Size(42, 13);
            this.TimeHeaderLabel.TabIndex = 4;
            this.TimeHeaderLabel.Text = "Time = ";
            // 
            // TimeValueLabel
            // 
            this.TimeValueLabel.AutoSize = true;
            this.TimeValueLabel.Location = new System.Drawing.Point(351, 99);
            this.TimeValueLabel.Name = "TimeValueLabel";
            this.TimeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeValueLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.TimeValueLabel);
            this.Controls.Add(this.TimeHeaderLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.ProblemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProblemBox;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeHeaderLabel;
        private System.Windows.Forms.Label TimeValueLabel;
    }
}

