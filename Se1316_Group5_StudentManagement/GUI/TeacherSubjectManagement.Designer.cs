namespace Se1316_Group5_StudentManagement.GUI {
    partial class TeacherSubjectManagement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataTeacherSubject = new System.Windows.Forms.DataGridView();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbTeacherId = new System.Windows.Forms.ComboBox();
            this.cbbSubjectId = new System.Windows.Forms.ComboBox();
            this.lbTeacherId = new System.Windows.Forms.Label();
            this.lbSubjectId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacherSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTeacherSubject
            // 
            this.dataTeacherSubject.AllowUserToAddRows = false;
            this.dataTeacherSubject.AllowUserToDeleteRows = false;
            this.dataTeacherSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeacherSubject.Location = new System.Drawing.Point(16, 99);
            this.dataTeacherSubject.Name = "dataTeacherSubject";
            this.dataTeacherSubject.ReadOnly = true;
            this.dataTeacherSubject.Size = new System.Drawing.Size(520, 305);
            this.dataTeacherSubject.TabIndex = 0;
            this.dataTeacherSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTeacherSubject_CellClick);
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(124, 35);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(199, 21);
            this.cbxSubject.TabIndex = 1;
            this.cbxSubject.SelectedValueChanged += new System.EventHandler(this.cbxSubject_SelectedValueChanged);
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(16, 38);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(43, 13);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Code";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(124, 65);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.ReadOnly = true;
            this.txtSubjectCode.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectCode.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cbbTeacherId);
            this.groupBox1.Controls.Add(this.cbbSubjectId);
            this.groupBox1.Controls.Add(this.lbTeacherId);
            this.groupBox1.Controls.Add(this.lbSubjectId);
            this.groupBox1.Location = new System.Drawing.Point(542, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(274, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(10, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(168, 59);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(168, 33);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 4;
            // 
            // cbbTeacherId
            // 
            this.cbbTeacherId.Enabled = false;
            this.cbbTeacherId.FormattingEnabled = true;
            this.cbbTeacherId.Location = new System.Drawing.Point(68, 58);
            this.cbbTeacherId.Name = "cbbTeacherId";
            this.cbbTeacherId.Size = new System.Drawing.Size(94, 21);
            this.cbbTeacherId.TabIndex = 3;
            this.cbbTeacherId.SelectedValueChanged += new System.EventHandler(this.cbbTeacherId_SelectedValueChanged);
            // 
            // cbbSubjectId
            // 
            this.cbbSubjectId.Enabled = false;
            this.cbbSubjectId.FormattingEnabled = true;
            this.cbbSubjectId.Location = new System.Drawing.Point(68, 32);
            this.cbbSubjectId.Name = "cbbSubjectId";
            this.cbbSubjectId.Size = new System.Drawing.Size(94, 21);
            this.cbbSubjectId.TabIndex = 2;
            this.cbbSubjectId.SelectedValueChanged += new System.EventHandler(this.cbbSubjectId_SelectedValueChanged);
            // 
            // lbTeacherId
            // 
            this.lbTeacherId.AutoSize = true;
            this.lbTeacherId.Location = new System.Drawing.Point(7, 66);
            this.lbTeacherId.Name = "lbTeacherId";
            this.lbTeacherId.Size = new System.Drawing.Size(59, 13);
            this.lbTeacherId.TabIndex = 1;
            this.lbTeacherId.Text = "Teacher Id";
            // 
            // lbSubjectId
            // 
            this.lbSubjectId.AutoSize = true;
            this.lbSubjectId.Location = new System.Drawing.Point(7, 35);
            this.lbSubjectId.Name = "lbSubjectId";
            this.lbSubjectId.Size = new System.Drawing.Size(55, 13);
            this.lbSubjectId.TabIndex = 0;
            this.lbSubjectId.Text = "Subject Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(461, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TeacherSubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 462);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.dataTeacherSubject);
            this.Name = "TeacherSubjectManagement";
            this.Text = "TeacherSubjectManagement";
            this.Load += new System.EventHandler(this.TeacherSubjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacherSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTeacherSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTeacherId;
        private System.Windows.Forms.Label lbSubjectId;
        private System.Windows.Forms.ComboBox cbbTeacherId;
        private System.Windows.Forms.ComboBox cbbSubjectId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}