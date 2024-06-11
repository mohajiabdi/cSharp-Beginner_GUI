namespace Lists_and_ImageLists
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
            txtDis = new RichTextBox();
            btnCount = new Button();
            SuspendLayout();
            // 
            // txtDis
            // 
            txtDis.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDis.Location = new Point(12, 12);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(776, 353);
            txtDis.TabIndex = 0;
            txtDis.Text = "";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(12, 400);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(167, 38);
            btnCount.TabIndex = 1;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCount);
            Controls.Add(txtDis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtDis;
        private Button btnCount;
    }
}
