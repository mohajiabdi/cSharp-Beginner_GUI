namespace Order_Function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblDis = new Label();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            txtNum3 = new TextBox();
            btnSort = new Button();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            SuspendLayout();
            // 
            // lblDis
            // 
            lblDis.BorderStyle = BorderStyle.Fixed3D;
            lblDis.Location = new Point(12, 161);
            lblDis.Name = "lblDis";
            lblDis.Size = new Size(440, 242);
            lblDis.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Verdana", 18F);
            txtNum2.Location = new Point(102, 12);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(84, 44);
            txtNum2.TabIndex = 1;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Verdana", 18F);
            txtNum1.Location = new Point(12, 12);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(84, 44);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += textBox2_TextChanged;
            // 
            // txtNum3
            // 
            txtNum3.Font = new Font("Verdana", 18F);
            txtNum3.Location = new Point(192, 12);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(84, 44);
            txtNum3.TabIndex = 2;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(182, 76);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(109, 52);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtNum4
            // 
            txtNum4.Font = new Font("Verdana", 18F);
            txtNum4.Location = new Point(282, 12);
            txtNum4.Name = "txtNum4";
            txtNum4.Size = new Size(84, 44);
            txtNum4.TabIndex = 3;
            // 
            // txtNum5
            // 
            txtNum5.Font = new Font("Verdana", 18F);
            txtNum5.Location = new Point(372, 12);
            txtNum5.Name = "txtNum5";
            txtNum5.Size = new Size(84, 44);
            txtNum5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(txtNum5);
            Controls.Add(txtNum4);
            Controls.Add(btnSort);
            Controls.Add(txtNum3);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(lblDis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDis;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private TextBox txtNum3;
        private Button btnSort;
        private TextBox txtNum4;
        private TextBox txtNum5;
    }
}
