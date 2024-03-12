namespace TodoList
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
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGVOne = new DataGridView();
            richTxtDescribe = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGVOne).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "TODO LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F);
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 1;
            label2.Text = "Title: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F);
            label3.Location = new Point(24, 171);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(24, 120);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(378, 27);
            txtTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(151, 375);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 44);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Todo";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(283, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 44);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Todo";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGVOne
            // 
            dataGVOne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVOne.Location = new Point(455, 120);
            dataGVOne.Name = "dataGVOne";
            dataGVOne.RowHeadersWidth = 51;
            dataGVOne.Size = new Size(491, 299);
            dataGVOne.TabIndex = 5;
            // 
            // richTxtDescribe
            // 
            richTxtDescribe.Location = new Point(24, 205);
            richTxtDescribe.Name = "richTxtDescribe";
            richTxtDescribe.Size = new Size(378, 145);
            richTxtDescribe.TabIndex = 1;
            richTxtDescribe.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 476);
            Controls.Add(richTxtDescribe);
            Controls.Add(dataGVOne);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVOne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGVOne;
        private RichTextBox richTxtDescribe;
    }
}
