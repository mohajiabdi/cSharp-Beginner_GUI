namespace Hotel_Management_V1._2
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            timer1 = new System.Windows.Forms.Timer(components);
            pbar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pbar
            // 
            pbar.Animated = true;
            pbar.FillColor = Color.FromArgb(200, 213, 218, 223);
            pbar.Font = new Font("Verdana", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pbar.ForeColor = Color.White;
            pbar.Location = new Point(149, 128);
            pbar.Minimum = 0;
            pbar.Name = "pbar";
            pbar.ProgressColor = Color.FromArgb(5, 44, 79);
            pbar.ProgressColor2 = Color.FromArgb(10, 84, 151);
            pbar.ProgressThickness = 30;
            pbar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbar.ShowText = true;
            pbar.Size = new Size(254, 254);
            pbar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 51);
            label1.Name = "label1";
            label1.Size = new Size(467, 36);
            label1.TabIndex = 0;
            label1.Text = "Hotel Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 37, 63);
            ClientSize = new Size(572, 394);
            Controls.Add(label1);
            Controls.Add(pbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbar;
        private Label label1;
    }
}
