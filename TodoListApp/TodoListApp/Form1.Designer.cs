namespace TodoListApp
{
    partial class Todo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todo));
            txtTitle = new TextBox();
            txtDesc = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            todoListTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)todoListTable).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(31, 106);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(365, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(31, 187);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(365, 120);
            txtDesc.TabIndex = 1;
            txtDesc.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 54);
            label1.TabIndex = 2;
            label1.Text = "Todo List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(31, 349);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add List";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(158, 349);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit List";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(294, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 43);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // todoListTable
            // 
            todoListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoListTable.Location = new Point(435, 106);
            todoListTable.Name = "todoListTable";
            todoListTable.RowHeadersWidth = 51;
            todoListTable.Size = new Size(383, 286);
            todoListTable.TabIndex = 5;
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 450);
            Controls.Add(todoListTable);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesc);
            Controls.Add(txtTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Todo";
            Text = "Todo List App";
            Load += Todo_Load;
            ((System.ComponentModel.ISupportInitialize)todoListTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private RichTextBox txtDesc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView todoListTable;
    }
}
