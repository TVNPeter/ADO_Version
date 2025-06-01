namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Patient));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Patients = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.dTP_BD = new System.Windows.Forms.DateTimePicker();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_patient = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pb_FindByPID = new System.Windows.Forms.PictureBox();
            this.pb_FindByName = new System.Windows.Forms.PictureBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(519, 374);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 40);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Lime;
            this.btn_Save.Location = new System.Drawing.Point(265, 374);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(60, 40);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(356, 374);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 40);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Edit.Location = new System.Drawing.Point(135, 374);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(60, 40);
            this.btn_Edit.TabIndex = 28;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add.Location = new System.Drawing.Point(50, 374);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 40);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Patients
            // 
            this.dgv_Patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FullName,
            this.Gender,
            this.BirthDate,
            this.Address,
            this.Phone});
            this.dgv_Patients.Location = new System.Drawing.Point(32, 162);
            this.dgv_Patients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Patients.Name = "dgv_Patients";
            this.dgv_Patients.RowHeadersWidth = 51;
            this.dgv_Patients.RowTemplate.Height = 24;
            this.dgv_Patients.Size = new System.Drawing.Size(603, 195);
            this.dgv_Patients.TabIndex = 26;
            this.dgv_Patients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patients_CellClick);
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "PhoneNumber";
            this.Phone.Name = "Phone";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Address.Location = new System.Drawing.Point(127, 90);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(333, 20);
            this.txt_Address.TabIndex = 25;
            // 
            // dTP_BD
            // 
            this.dTP_BD.Location = new System.Drawing.Point(380, 15);
            this.dTP_BD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_BD.Name = "dTP_BD";
            this.dTP_BD.Size = new System.Drawing.Size(199, 20);
            this.dTP_BD.TabIndex = 24;
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(499, 54);
            this.cb_Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(80, 21);
            this.cb_Gender.TabIndex = 23;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(127, 52);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(220, 20);
            this.txt_Name.TabIndex = 22;
            // 
            // txt_PID
            // 
            this.txt_PID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_PID.Location = new System.Drawing.Point(127, 19);
            this.txt_PID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.Size = new System.Drawing.Size(68, 20);
            this.txt_PID.TabIndex = 21;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(28, 87);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(76, 21);
            this.lb_address.TabIndex = 20;
            this.lb_address.Text = "Address:";
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birthday.Location = new System.Drawing.Point(288, 14);
            this.lb_birthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(88, 21);
            this.lb_birthday.TabIndex = 19;
            this.lb_birthday.Text = "BirthDate:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(421, 54);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(74, 21);
            this.lb_gender.TabIndex = 18;
            this.lb_gender.Text = "Gender:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(28, 51);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(90, 21);
            this.lb_fullname.TabIndex = 17;
            this.lb_fullname.Text = "Full Name:";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(28, 17);
            this.lb_patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(92, 21);
            this.lb_patient.TabIndex = 16;
            this.lb_patient.Text = "Patient ID:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(402, 124);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(192, 24);
            this.btn_Reload.TabIndex = 44;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // pb_FindByPID
            // 
            this.pb_FindByPID.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByPID.Image")));
            this.pb_FindByPID.Location = new System.Drawing.Point(197, 15);
            this.pb_FindByPID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_FindByPID.Name = "pb_FindByPID";
            this.pb_FindByPID.Size = new System.Drawing.Size(20, 24);
            this.pb_FindByPID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByPID.TabIndex = 46;
            this.pb_FindByPID.TabStop = false;
            this.pb_FindByPID.Click += new System.EventHandler(this.pb_FindByPID_Click);
            // 
            // pb_FindByName
            // 
            this.pb_FindByName.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByName.Image")));
            this.pb_FindByName.Location = new System.Drawing.Point(356, 52);
            this.pb_FindByName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_FindByName.Name = "pb_FindByName";
            this.pb_FindByName.Size = new System.Drawing.Size(20, 24);
            this.pb_FindByName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByName.TabIndex = 47;
            this.pb_FindByName.TabStop = false;
            this.pb_FindByName.Click += new System.EventHandler(this.pb_FindByName_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Phone.Location = new System.Drawing.Point(127, 127);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(220, 20);
            this.txt_Phone.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Phone:";
            // 
            // uc_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_FindByName);
            this.Controls.Add(this.pb_FindByPID);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Patients);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.dTP_BD);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_PID);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_birthday);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_patient);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "uc_Patient";
            this.Size = new System.Drawing.Size(666, 440);
            this.Load += new System.EventHandler(this.uc_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Patients;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.DateTimePicker dTP_BD;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.PictureBox pb_FindByPID;
        private System.Windows.Forms.PictureBox pb_FindByName;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}
