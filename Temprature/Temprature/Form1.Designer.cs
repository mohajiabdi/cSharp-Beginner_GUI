namespace Temprature
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
            lblCelcius = new Label();
            lblMessage = new Label();
            btnCalculate = new Button();
            txtCelcius = new TextBox();
            SuspendLayout();
            // 
            // lblCelcius
            // 
            lblCelcius.AutoSize = true;
            lblCelcius.Font = new Font("Segoe UI", 13.8F);
            lblCelcius.Location = new Point(96, 56);
            lblCelcius.Name = "lblCelcius";
            lblCelcius.Size = new Size(115, 31);
            lblCelcius.TabIndex = 0;
            lblCelcius.Text = "Celcius :   ";
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(43, 136);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(372, 57);
            lblMessage.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(152, 209);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(138, 62);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtCelcius
            // 
            txtCelcius.Location = new Point(198, 60);
            txtCelcius.Name = "txtCelcius";
            txtCelcius.Size = new Size(217, 27);
            txtCelcius.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 329);
            Controls.Add(txtCelcius);
            Controls.Add(btnCalculate);
            Controls.Add(lblMessage);
            Controls.Add(lblCelcius);
            Name = "Form1";
            Text = "Temprature";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCelcius;
        private Label lblMessage;
        private Button btnCalculate;
        private TextBox txtCelcius;
    }
}
