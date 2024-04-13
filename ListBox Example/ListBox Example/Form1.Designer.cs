namespace ListBox_Example
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
            lbCountries = new ListBox();
            txtCountries = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnCount = new Button();
            btnSorted = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lbCountries
            // 
            lbCountries.Font = new Font("Segoe UI", 18F);
            lbCountries.FormattingEnabled = true;
            lbCountries.ItemHeight = 41;
            lbCountries.Location = new Point(386, 44);
            lbCountries.Name = "lbCountries";
            lbCountries.ScrollAlwaysVisible = true;
            lbCountries.SelectionMode = SelectionMode.MultiSimple;
            lbCountries.Size = new Size(402, 373);
            lbCountries.TabIndex = 0;
            // 
            // txtCountries
            // 
            txtCountries.Font = new Font("Segoe UI", 18F);
            txtCountries.Location = new Point(25, 44);
            txtCountries.Name = "txtCountries";
            txtCountries.Size = new Size(311, 47);
            txtCountries.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F);
            btnAdd.Location = new Point(99, 112);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 56);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 18F);
            btnRemove.Location = new Point(99, 174);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(151, 56);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 18F);
            btnCount.Location = new Point(99, 236);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(151, 56);
            btnCount.TabIndex = 4;
            btnCount.Text = "COUNT";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnSorted
            // 
            btnSorted.Font = new Font("Segoe UI", 18F);
            btnSorted.Location = new Point(99, 298);
            btnSorted.Name = "btnSorted";
            btnSorted.Size = new Size(151, 56);
            btnSorted.TabIndex = 5;
            btnSorted.Text = "SORT";
            btnSorted.UseVisualStyleBackColor = true;
            btnSorted.Click += btnSorted_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(99, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 56);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnSorted);
            Controls.Add(btnCount);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtCountries);
            Controls.Add(lbCountries);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ListBox ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCountries;
        private TextBox txtCountries;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnCount;
        private Button btnSorted;
        private Button btnClear;
    }
}
