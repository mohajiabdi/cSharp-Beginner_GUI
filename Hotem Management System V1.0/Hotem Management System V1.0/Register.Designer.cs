namespace Hotem_Management_System_V1._0
{
    partial class Register
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btnLock = new Guna.UI2.WinForms.Guna2Button();
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnLock
            // 
            btnLock.BorderRadius = 25;
            btnLock.CustomizableEdges = customizableEdges1;
            btnLock.DisabledState.BorderColor = Color.DarkGray;
            btnLock.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLock.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLock.ForeColor = Color.White;
            btnLock.Location = new Point(658, 585);
            btnLock.Name = "btnLock";
            btnLock.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLock.Size = new Size(312, 56);
            btnLock.TabIndex = 9;
            btnLock.Text = "Lock Home Manager";
            btnLock.Click += btnLock_Click;
            // 
            // btnHome
            // 
            btnHome.BorderRadius = 25;
            btnHome.CustomizableEdges = customizableEdges3;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(340, 585);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHome.Size = new Size(312, 56);
            btnHome.TabIndex = 10;
            btnHome.Text = "Home Maganer";
            btnHome.Click += btnHome_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btnHome);
            Controls.Add(btnLock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLock;
        private Guna.UI2.WinForms.Guna2Button btnHome;
    }
}