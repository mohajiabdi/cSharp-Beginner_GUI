namespace Random_Numbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGenerate = new Button();
            btnCheck = new Button();
            lblNumbers = new Label();
            lblResult = new Label();
            txtUserAnswer = new TextBox();
            txtRandom = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 0;
            label1.Text = "Generator";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(192, 0, 192);
            btnGenerate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnGenerate.Location = new Point(12, 68);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(317, 53);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(192, 0, 192);
            btnCheck.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnCheck.Location = new Point(12, 333);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(317, 58);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblNumbers
            // 
            lblNumbers.BackColor = Color.FromArgb(255, 128, 0);
            lblNumbers.Font = new Font("Segoe UI", 18F);
            lblNumbers.Location = new Point(12, 191);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(317, 47);
            lblNumbers.TabIndex = 3;
            lblNumbers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 128, 0);
            lblResult.Font = new Font("Segoe UI", 18F);
            lblResult.Location = new Point(12, 405);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(317, 47);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            txtUserAnswer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserAnswer.Location = new Point(12, 255);
            txtUserAnswer.Name = "txtUserAnswer";
            txtUserAnswer.Size = new Size(317, 38);
            txtUserAnswer.TabIndex = 5;
            // 
            // txtRandom
            // 
            txtRandom.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRandom.Location = new Point(151, 138);
            txtRandom.Name = "txtRandom";
            txtRandom.Size = new Size(178, 38);
            txtRandom.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 7;
            label2.Text = "Set Limit: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 479);
            Controls.Add(label2);
            Controls.Add(txtRandom);
            Controls.Add(txtUserAnswer);
            Controls.Add(lblResult);
            Controls.Add(lblNumbers);
            Controls.Add(btnCheck);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerate;
        private Button btnCheck;
        private Label lblNumbers;
        private Label lblResult;
        private TextBox txtUserAnswer;
        private TextBox txtRandom;
        private Label label2;
    }
}
