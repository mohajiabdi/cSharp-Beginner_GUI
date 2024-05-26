namespace Ciise_Lessons_1
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
            lblOutput = new Label();
            btnCall = new Button();
            textBox1 = new TextBox();
            txtResult = new RichTextBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(160, 31);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(92, 41);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Ciise ";
            // 
            // btnCall
            // 
            btnCall.Location = new Point(199, 180);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(132, 65);
            btnCall.TabIndex = 1;
            btnCall.Text = "Call";
            btnCall.UseVisualStyleBackColor = true;
            btnCall.Click += btnCall_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(258, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 47);
            textBox1.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(475, 180);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(295, 232);
            txtResult.TabIndex = 3;
            txtResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(textBox1);
            Controls.Add(btnCall);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btnCall;
        private TextBox textBox1;
        private RichTextBox txtResult;
    }
}
