namespace ListBoxes_and_More
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
            lblMessage = new Label();
            txtCountry = new TextBox();
            lstCountryNames = new ListBox();
            btnInsert = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnRemove = new Button();
            btnFind = new Button();
            btnCount = new Button();
            btnSelectedIndex = new Button();
            btnSelectedItem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 0;
            label1.Text = "Enter Country Name: ";
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.ActiveCaption;
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Font = new Font("Segoe UI", 18F);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(27, 410);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(591, 130);
            lblMessage.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 18F);
            txtCountry.Location = new Point(305, 19);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(287, 47);
            txtCountry.TabIndex = 2;
            // 
            // lstCountryNames
            // 
            lstCountryNames.Font = new Font("Segoe UI", 18F);
            lstCountryNames.FormattingEnabled = true;
            lstCountryNames.ItemHeight = 41;
            lstCountryNames.Items.AddRange(new object[] { "Somalia", "Kenya", "Ethiopia", "India", "USA", "UK", "Canada", "Mexico", "Syria", "Saudi Arabia", "South Africa", "Ghana", "Zambia", "Pakistan" });
            lstCountryNames.Location = new Point(27, 93);
            lstCountryNames.Name = "lstCountryNames";
            lstCountryNames.Size = new Size(243, 291);
            lstCountryNames.TabIndex = 3;
            lstCountryNames.SelectedIndexChanged += lstCountryNames_SelectedIndexChanged;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 13.8F);
            btnInsert.Location = new Point(476, 93);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(142, 65);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 13.8F);
            btnAdd.Location = new Point(288, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 65);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F);
            btnClear.Location = new Point(476, 164);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 65);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 13.8F);
            btnRemove.Location = new Point(288, 164);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(142, 65);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 13.8F);
            btnFind.Location = new Point(476, 235);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(142, 65);
            btnFind.TabIndex = 8;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 13.8F);
            btnCount.Location = new Point(288, 235);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(142, 65);
            btnCount.TabIndex = 9;
            btnCount.Text = "COUNT";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnSelectedIndex
            // 
            btnSelectedIndex.Font = new Font("Segoe UI", 13.8F);
            btnSelectedIndex.Location = new Point(288, 306);
            btnSelectedIndex.Name = "btnSelectedIndex";
            btnSelectedIndex.Size = new Size(142, 81);
            btnSelectedIndex.TabIndex = 10;
            btnSelectedIndex.Text = "Selected Index";
            btnSelectedIndex.UseVisualStyleBackColor = true;
            btnSelectedIndex.Click += btnSelectedIndex_Click;
            // 
            // btnSelectedItem
            // 
            btnSelectedItem.Font = new Font("Segoe UI", 13.8F);
            btnSelectedItem.Location = new Point(476, 306);
            btnSelectedItem.Name = "btnSelectedItem";
            btnSelectedItem.Size = new Size(142, 81);
            btnSelectedItem.TabIndex = 11;
            btnSelectedItem.Text = "Selected Item";
            btnSelectedItem.UseVisualStyleBackColor = true;
            btnSelectedItem.Click += btnSelectedItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 584);
            Controls.Add(btnSelectedItem);
            Controls.Add(btnSelectedIndex);
            Controls.Add(btnCount);
            Controls.Add(btnFind);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnInsert);
            Controls.Add(lstCountryNames);
            Controls.Add(txtCountry);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ListBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMessage;
        private TextBox txtCountry;
        private ListBox lstCountryNames;
        private Button btnInsert;
        private Button btnAdd;
        private Button btnClear;
        private Button btnRemove;
        private Button btnFind;
        private Button btnCount;
        private Button btnSelectedIndex;
        private Button btnSelectedItem;
    }
}
