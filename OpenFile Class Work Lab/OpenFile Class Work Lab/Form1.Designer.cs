namespace OpenFile_Class_Work_Lab
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
            btnOpen = new Button();
            txtDis = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 13.8F);
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(130, 48);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Read";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtDis
            // 
            txtDis.Font = new Font("Segoe UI", 13.8F);
            txtDis.Location = new Point(12, 80);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(776, 358);
            txtDis.TabIndex = 1;
            txtDis.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDis);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private RichTextBox txtDis;
        private OpenFileDialog openFileDialog1;
    }
}
