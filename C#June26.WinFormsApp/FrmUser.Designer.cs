namespace C_June26.WinFormsApp
{
    partial class FrmUser
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
            dgvData = new DataGridView();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colRowNo = new DataGridViewTextBoxColumn();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colEdit, colDelete, colRowNo, colUserId, colUsername, colPassword });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 135);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.Size = new Size(383, 163);
            dgvData.TabIndex = 7;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // colRowNo
            // 
            colRowNo.DataPropertyName = "RowNo";
            colRowNo.HeaderText = "Row No";
            colRowNo.Name = "colRowNo";
            colRowNo.ReadOnly = true;
            // 
            // colUserId
            // 
            colUserId.DataPropertyName = "UserID";
            colUserId.HeaderText = "User ID";
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "username";
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "UserPassword";
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(94, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 44);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 84);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(94, 84);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 298);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Name = "FrmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colRowNo;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
    }
}
