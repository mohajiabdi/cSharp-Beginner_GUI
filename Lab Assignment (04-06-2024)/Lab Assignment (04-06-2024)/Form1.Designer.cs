namespace Lab_Assignment__04_06_2024_
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
            txtInput = new TextBox();
            btnAge = new Button();
            btnAdd = new Button();
            btnSeconds = new Button();
            txtDis = new RichTextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Verdana", 18F);
            txtInput.Location = new Point(12, 41);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(337, 44);
            txtInput.TabIndex = 0;
            // 
            // btnAge
            // 
            btnAge.Font = new Font("Verdana", 18F);
            btnAge.Location = new Point(12, 111);
            btnAge.Name = "btnAge";
            btnAge.Size = new Size(337, 98);
            btnAge.TabIndex = 1;
            btnAge.Text = "Calculate Age In Days";
            btnAge.UseVisualStyleBackColor = true;
            btnAge.Click += btnAge_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Verdana", 18F);
            btnAdd.Location = new Point(12, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(337, 98);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add One";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSeconds
            // 
            btnSeconds.Font = new Font("Verdana", 18F);
            btnSeconds.Location = new Point(12, 389);
            btnSeconds.Name = "btnSeconds";
            btnSeconds.Size = new Size(337, 98);
            btnSeconds.TabIndex = 3;
            btnSeconds.Text = "Minutes To Seconds";
            btnSeconds.UseVisualStyleBackColor = true;
            btnSeconds.Click += btnSeconds_Click;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(371, 12);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(412, 475);
            txtDis.TabIndex = 4;
            txtDis.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 499);
            Controls.Add(txtDis);
            Controls.Add(btnSeconds);
            Controls.Add(btnAdd);
            Controls.Add(btnAge);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnAge;
        private Button btnAdd;
        private Button btnSeconds;
        private RichTextBox txtDis;
    }
}
