namespace WageCalculator
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
            label2 = new Label();
            lblMessage = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            btnCalculate = new Button();
            btnClose = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F);
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 0;
            label1.Text = "Hours Worked";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F);
            label2.Location = new Point(10, 105);
            label2.Name = "label2";
            label2.Size = new Size(217, 34);
            label2.TabIndex = 1;
            label2.Text = "Earned Per Hour";
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Blue;
            lblMessage.Location = new Point(60, 184);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(269, 68);
            lblMessage.TabIndex = 2;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Click += lblMessage_Click;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(255, 53);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(169, 27);
            txtHours.TabIndex = 3;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(255, 105);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(169, 27);
            txtRate.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(10, 289);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(130, 49);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(294, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 49);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(149, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 49);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 370);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Wage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMessage;
        private TextBox txtHours;
        private TextBox txtRate;
        private Button btnCalculate;
        private Button btnClose;
        private Button btnClear;
    }
}
