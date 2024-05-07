namespace Loop_Example2
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            lblDis = new Label();
            label5 = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtUpdate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F);
            label1.Location = new Point(95, 34);
            label1.Name = "label1";
            label1.Size = new Size(234, 34);
            label1.TabIndex = 0;
            label1.Text = "Loop Challenge";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16.2F);
            label2.Location = new Point(24, 121);
            label2.Name = "label2";
            label2.Size = new Size(85, 34);
            label2.TabIndex = 1;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16.2F);
            label3.Location = new Point(251, 121);
            label3.Name = "label3";
            label3.Size = new Size(68, 34);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 16.2F);
            button1.Location = new Point(24, 357);
            button1.Name = "button1";
            button1.Size = new Size(140, 65);
            button1.TabIndex = 5;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 16.2F);
            button2.Location = new Point(224, 357);
            button2.Name = "button2";
            button2.Size = new Size(140, 65);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblDis
            // 
            lblDis.BackColor = Color.FromArgb(224, 224, 224);
            lblDis.Font = new Font("Verdana", 16.2F);
            lblDis.Location = new Point(458, 34);
            lblDis.Name = "lblDis";
            lblDis.Size = new Size(330, 407);
            lblDis.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16.2F);
            label5.Location = new Point(14, 241);
            label5.Name = "label5";
            label5.Size = new Size(115, 34);
            label5.TabIndex = 9;
            label5.Text = "Update";
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Verdana", 16.2F);
            txtStart.Location = new Point(14, 174);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(125, 40);
            txtStart.TabIndex = 10;
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Verdana", 16.2F);
            txtEnd.Location = new Point(224, 174);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(125, 40);
            txtEnd.TabIndex = 11;
            // 
            // txtUpdate
            // 
            txtUpdate.Font = new Font("Verdana", 16.2F);
            txtUpdate.Location = new Point(14, 291);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(125, 40);
            txtUpdate.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUpdate);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(label5);
            Controls.Add(lblDis);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label lblDis;
        private Label label5;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtUpdate;
    }
}
