namespace BMI
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
            txtWeight = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            txtHeight = new TextBox();
            rbtnKg = new RadioButton();
            rbtnPounds = new RadioButton();
            rbtnMeters = new RadioButton();
            rbtnCm = new RadioButton();
            grpWeight = new GroupBox();
            grpHeight = new GroupBox();
            grpWeight.SuspendLayout();
            grpHeight.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 60);
            label1.TabIndex = 0;
            label1.Text = "BMI";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(98, 160);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(344, 27);
            txtWeight.TabIndex = 1;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(201, 402);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(138, 56);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(98, 309);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(344, 73);
            lblResult.TabIndex = 0;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += lblResult_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(98, 262);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(344, 27);
            txtHeight.TabIndex = 1;
            // 
            // rbtnKg
            // 
            rbtnKg.AutoSize = true;
            rbtnKg.Location = new Point(113, 26);
            rbtnKg.Name = "rbtnKg";
            rbtnKg.Size = new Size(97, 24);
            rbtnKg.TabIndex = 4;
            rbtnKg.TabStop = true;
            rbtnKg.Text = "Kilograms";
            rbtnKg.UseVisualStyleBackColor = true;
            rbtnKg.CheckedChanged += rbtnKg_CheckedChanged;
            // 
            // rbtnPounds
            // 
            rbtnPounds.AutoSize = true;
            rbtnPounds.Location = new Point(21, 26);
            rbtnPounds.Name = "rbtnPounds";
            rbtnPounds.Size = new Size(77, 24);
            rbtnPounds.TabIndex = 4;
            rbtnPounds.TabStop = true;
            rbtnPounds.Text = "Pounds";
            rbtnPounds.UseVisualStyleBackColor = true;
            rbtnPounds.CheckedChanged += rbtnPounds_CheckedChanged;
            // 
            // rbtnMeters
            // 
            rbtnMeters.AutoSize = true;
            rbtnMeters.Location = new Point(124, 26);
            rbtnMeters.Name = "rbtnMeters";
            rbtnMeters.Size = new Size(75, 24);
            rbtnMeters.TabIndex = 4;
            rbtnMeters.TabStop = true;
            rbtnMeters.Text = "Meters";
            rbtnMeters.UseVisualStyleBackColor = true;
            rbtnMeters.CheckedChanged += rbtnMeters_CheckedChanged;
            // 
            // rbtnCm
            // 
            rbtnCm.AutoSize = true;
            rbtnCm.Location = new Point(9, 23);
            rbtnCm.Name = "rbtnCm";
            rbtnCm.Size = new Size(109, 24);
            rbtnCm.TabIndex = 4;
            rbtnCm.TabStop = true;
            rbtnCm.Text = "Centimeters";
            rbtnCm.UseVisualStyleBackColor = true;
            rbtnCm.CheckedChanged += rbtnCm_CheckedChanged;
            // 
            // grpWeight
            // 
            grpWeight.Controls.Add(rbtnPounds);
            grpWeight.Controls.Add(rbtnKg);
            grpWeight.Location = new Point(98, 96);
            grpWeight.Name = "grpWeight";
            grpWeight.Size = new Size(250, 58);
            grpWeight.TabIndex = 5;
            grpWeight.TabStop = false;
            grpWeight.Text = "Weight :";
            // 
            // grpHeight
            // 
            grpHeight.Controls.Add(rbtnMeters);
            grpHeight.Controls.Add(rbtnCm);
            grpHeight.Location = new Point(98, 202);
            grpHeight.Name = "grpHeight";
            grpHeight.Size = new Size(250, 53);
            grpHeight.TabIndex = 0;
            grpHeight.TabStop = false;
            grpHeight.Text = "Hright : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 472);
            Controls.Add(grpHeight);
            Controls.Add(grpWeight);
            Controls.Add(btnCalculate);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblResult);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpWeight.ResumeLayout(false);
            grpWeight.PerformLayout();
            grpHeight.ResumeLayout(false);
            grpHeight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWeight;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtHeight;
        private RadioButton rbtnKg;
        private RadioButton rbtnPounds;
        private RadioButton rbtnMeters;
        private RadioButton rbtnCm;
        private GroupBox grpWeight;
        private GroupBox grpHeight;
    }
}
