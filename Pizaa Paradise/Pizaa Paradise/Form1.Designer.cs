namespace Pizaa_Paradise
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
            label1 = new Label();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            groupBox1 = new GroupBox();
            chMushroms = new CheckBox();
            chOnions = new CheckBox();
            groupBox2 = new GroupBox();
            chCorn = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtPhone = new TextBox();
            btnOrder = new Button();
            nmQuantity = new NumericUpDown();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 31);
            label1.Name = "label1";
            label1.Size = new Size(602, 38);
            label1.TabIndex = 0;
            label1.Text = "Pizza Paradise | A Cutomizable Order System";
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(21, 39);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(78, 29);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(21, 82);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(103, 29);
            rbMedium.TabIndex = 2;
            rbMedium.TabStop = true;
            rbMedium.Text = "Medium";
            rbMedium.UseVisualStyleBackColor = true;
            rbMedium.CheckedChanged += rbMedium_CheckedChanged;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(21, 125);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(79, 29);
            rbLarge.TabIndex = 3;
            rbLarge.TabStop = true;
            rbLarge.Text = "Large";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSmall);
            groupBox1.Controls.Add(rbLarge);
            groupBox1.Controls.Add(rbMedium);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Pizza Size";
            // 
            // chMushroms
            // 
            chMushroms.AutoSize = true;
            chMushroms.Location = new Point(22, 43);
            chMushroms.Name = "chMushroms";
            chMushroms.Size = new Size(122, 29);
            chMushroms.TabIndex = 5;
            chMushroms.Text = "Mushroms";
            chMushroms.UseVisualStyleBackColor = true;
            // 
            // chOnions
            // 
            chOnions.AutoSize = true;
            chOnions.Location = new Point(22, 86);
            chOnions.Name = "chOnions";
            chOnions.Size = new Size(94, 29);
            chOnions.TabIndex = 6;
            chOnions.Text = "Onions";
            chOnions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chCorn);
            groupBox2.Controls.Add(chMushroms);
            groupBox2.Controls.Add(chOnions);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(317, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Topping Type";
            // 
            // chCorn
            // 
            chCorn.AutoSize = true;
            chCorn.Location = new Point(22, 125);
            chCorn.Name = "chCorn";
            chCorn.Size = new Size(82, 29);
            chCorn.TabIndex = 7;
            chCorn.Text = "Corns";
            chCorn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 360);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 8;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(414, 360);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 9;
            label3.Text = "Customer Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(56, 471);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 10;
            label4.Text = "Pizza Price";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(56, 407);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 34);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(56, 516);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(294, 34);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(414, 407);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(294, 34);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(56, 595);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(652, 60);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "&Order Now";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // nmQuantity
            // 
            nmQuantity.Location = new Point(15, 68);
            nmQuantity.Name = "nmQuantity";
            nmQuantity.Size = new Size(150, 31);
            nmQuantity.TabIndex = 11;
            nmQuantity.ValueChanged += nmQuantity_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nmQuantity);
            groupBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(595, 139);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 169);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(groupBox3);
            Controls.Add(btnOrder);
            Controls.Add(txtPhone);
            Controls.Add(txtPrice);
            Controls.Add(groupBox2);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pizza Paradise";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private GroupBox groupBox1;
        private CheckBox chMushroms;
        private CheckBox chOnions;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtPhone;
        private Button btnOrder;
        private CheckBox chCorn;
        private NumericUpDown nmQuantity;
        private GroupBox groupBox3;
    }
}
