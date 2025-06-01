namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Doctor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Doctor));
            this.dgv_Doctors = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Specialty = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_DID = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_speciality = new System.Windows.Forms.Label();
            this.pb_FindByName = new System.Windows.Forms.PictureBox();
            this.pb_FindBySpecialty = new System.Windows.Forms.PictureBox();
            this.pb_FindById = new System.Windows.Forms.PictureBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindBySpecialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindById)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Doctors
            // 
            this.dgv_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.FullName,
            this.Specialty,
            this.Phone});
            this.dgv_Doctors.Location = new System.Drawing.Point(64, 202);
            this.dgv_Doctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Doctors.Name = "dgv_Doctors";
            this.dgv_Doctors.RowHeadersWidth = 51;
            this.dgv_Doctors.RowTemplate.Height = 24;
            this.dgv_Doctors.Size = new System.Drawing.Size(910, 275);
            this.dgv_Doctors.TabIndex = 29;
            this.dgv_Doctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Doctors_CellClick);
            // 
            // DoctorID
            // 
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Specialty
            // 
            this.Specialty.HeaderText = "Specialty";
            this.Specialty.Name = "Specialty";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // cb_Specialty
            // 
            this.cb_Specialty.FormattingEnabled = true;
            this.cb_Specialty.Items.AddRange(new object[] {
            "General Practitioner",
            "Cardiologist",
            "Neurologist",
            "Pediatrician",
            "Oncologist",
            "Orthopedist",
            "Dermatologist",
            "Gastroenterologist",
            "Ophthalmologist",
            "Psychiatrist",
            "Surgeon",
            "Anesthesiologist",
            "Endocrinologist",
            "Gynecologist",
            "Urologist"});
            this.cb_Specialty.Location = new System.Drawing.Point(260, 121);
            this.cb_Specialty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Specialty.Name = "cb_Specialty";
            this.cb_Specialty.Size = new System.Drawing.Size(170, 33);
            this.cb_Specialty.TabIndex = 28;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(630, 50);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(240, 31);
            this.txt_Name.TabIndex = 26;
            // 
            // txt_DID
            // 
            this.txt_DID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DID.Location = new System.Drawing.Point(186, 50);
            this.txt_DID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DID.Name = "txt_DID";
            this.txt_DID.Size = new System.Drawing.Size(60, 31);
            this.txt_DID.TabIndex = 25;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(4, 33);
            this.lb_doctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(89, 21);
            this.lb_doctor.TabIndex = 24;
            this.lb_doctor.Text = "Doctor ID:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(432, 50);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(88, 21);
            this.lb_fullname.TabIndex = 23;
            this.lb_fullname.Text = "Full name:";
            // 
            // lb_speciality
            // 
            this.lb_speciality.AutoSize = true;
            this.lb_speciality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speciality.Location = new System.Drawing.Point(80, 119);
            this.lb_speciality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_speciality.Name = "lb_speciality";
            this.lb_speciality.Size = new System.Drawing.Size(85, 21);
            this.lb_speciality.TabIndex = 22;
            this.lb_speciality.Text = "Specialty:";
            // 
            // pb_FindByName
            // 
            this.pb_FindByName.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByName.Image")));
            this.pb_FindByName.Location = new System.Drawing.Point(878, 50);
            this.pb_FindByName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_FindByName.Name = "pb_FindByName";
            this.pb_FindByName.Size = new System.Drawing.Size(56, 40);
            this.pb_FindByName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByName.TabIndex = 48;
            this.pb_FindByName.TabStop = false;
            this.pb_FindByName.Click += new System.EventHandler(this.pb_FindByName_Click);
            // 
            // pb_FindBySpecialty
            // 
            this.pb_FindBySpecialty.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindBySpecialty.Image")));
            this.pb_FindBySpecialty.Location = new System.Drawing.Point(458, 121);
            this.pb_FindBySpecialty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_FindBySpecialty.Name = "pb_FindBySpecialty";
            this.pb_FindBySpecialty.Size = new System.Drawing.Size(20, 23);
            this.pb_FindBySpecialty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindBySpecialty.TabIndex = 47;
            this.pb_FindBySpecialty.TabStop = false;
            this.pb_FindBySpecialty.Click += new System.EventHandler(this.pb_FindBySpecialty_Click);
            // 
            // pb_FindById
            // 
            this.pb_FindById.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindById.Image")));
            this.pb_FindById.Location = new System.Drawing.Point(260, 65);
            this.pb_FindById.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_FindById.Name = "pb_FindById";
            this.pb_FindById.Size = new System.Drawing.Size(20, 23);
            this.pb_FindById.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindById.TabIndex = 45;
            this.pb_FindById.TabStop = false;
            this.pb_FindById.Click += new System.EventHandler(this.pb_FindById_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(630, 138);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(204, 60);
            this.btn_Reload.TabIndex = 54;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(520, 481);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 40);
            this.btn_Delete.TabIndex = 53;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Lime;
            this.btn_Save.Location = new System.Drawing.Point(236, 481);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(60, 40);
            this.btn_Save.TabIndex = 52;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(364, 481);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 40);
            this.btn_Cancel.TabIndex = 51;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Edit.Location = new System.Drawing.Point(122, 481);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(60, 40);
            this.btn_Edit.TabIndex = 50;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add.Location = new System.Drawing.Point(36, 481);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 40);
            this.btn_Add.TabIndex = 49;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Phone.Location = new System.Drawing.Point(210, 165);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(220, 31);
            this.txt_Phone.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Phone:";
            // 
            // uc_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pb_FindByName);
            this.Controls.Add(this.pb_FindBySpecialty);
            this.Controls.Add(this.pb_FindById);
            this.Controls.Add(this.dgv_Doctors);
            this.Controls.Add(this.cb_Specialty);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_DID);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_speciality);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Doctor";
            this.Size = new System.Drawing.Size(1204, 721);
            this.Load += new System.EventHandler(this.uc_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindBySpecialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindById)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Doctors;
        private System.Windows.Forms.ComboBox cb_Specialty;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_DID;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_speciality;
        private System.Windows.Forms.PictureBox pb_FindById;
        private System.Windows.Forms.PictureBox pb_FindBySpecialty;
        private System.Windows.Forms.PictureBox pb_FindByName;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}
