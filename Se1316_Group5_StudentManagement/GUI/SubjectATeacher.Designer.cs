namespace Se1316_Group5_StudentManagement.GUI {
    partial class SubjectATeacher {
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
            this.dataSubjectATeacher = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnModefile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjectATeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSubjectATeacher
            // 
            this.dataSubjectATeacher.AllowUserToAddRows = false;
            this.dataSubjectATeacher.AllowUserToDeleteRows = false;
            this.dataSubjectATeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubjectATeacher.Location = new System.Drawing.Point(13, 13);
            this.dataSubjectATeacher.Name = "dataSubjectATeacher";
            this.dataSubjectATeacher.ReadOnly = true;
            this.dataSubjectATeacher.Size = new System.Drawing.Size(513, 425);
            this.dataSubjectATeacher.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(543, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 272);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnModefile
            // 
            this.btnModefile.Location = new System.Drawing.Point(543, 308);
            this.btnModefile.Name = "btnModefile";
            this.btnModefile.Size = new System.Drawing.Size(75, 23);
            this.btnModefile.TabIndex = 2;
            this.btnModefile.Text = "Modefile";
            this.btnModefile.UseVisualStyleBackColor = true;
            this.btnModefile.Click += new System.EventHandler(this.btnModefile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SubjectATeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModefile);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataSubjectATeacher);
            this.Name = "SubjectATeacher";
            this.Text = "SubjectATeacher";
            this.Load += new System.EventHandler(this.SubjectATeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjectATeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSubjectATeacher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnModefile;
        private System.Windows.Forms.Button btnCancel;
    }
}