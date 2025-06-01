namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Appointment));
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTP_AD = new System.Windows.Forms.DateTimePicker();
            this.cb_DID = new System.Windows.Forms.ComboBox();
            this.cb_PID = new System.Windows.Forms.ComboBox();
            this.txt_AID = new System.Windows.Forms.TextBox();
            this.lb_appointments = new System.Windows.Forms.Label();
            this.lb_patient = new System.Windows.Forms.Label();
            this.cb_doctorid = new System.Windows.Forms.Label();
            this.lb_appointment = new System.Windows.Forms.Label();
            this.pb_FindByAD = new System.Windows.Forms.PictureBox();
            this.pb_FindByAID = new System.Windows.Forms.PictureBox();
            this.pb_FindByPID = new System.Windows.Forms.PictureBox();
            this.pb_FindByDID = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_EditPrescription = new System.Windows.Forms.Button();
            this.btn_Completed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByAID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByDID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.AppointmentDate,
            this.Status,
            this.PatientID,
            this.DoctorID,
            this.Fee});
            this.dgv_Appointments.Location = new System.Drawing.Point(32, 277);
            this.dgv_Appointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.RowHeadersWidth = 51;
            this.dgv_Appointments.RowTemplate.Height = 24;
            this.dgv_Appointments.Size = new System.Drawing.Size(1206, 529);
            this.dgv_Appointments.TabIndex = 42;
            this.dgv_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Appointments_CellClick);
            // 
            // AppointmentID
            // 
            this.AppointmentID.HeaderText = "ID";
            this.AppointmentID.Name = "AppointmentID";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.HeaderText = "Date";
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            // 
            // DoctorID
            // 
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            // 
            // dTP_AD
            // 
            this.dTP_AD.Location = new System.Drawing.Point(386, 204);
            this.dTP_AD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP_AD.Name = "dTP_AD";
            this.dTP_AD.Size = new System.Drawing.Size(356, 31);
            this.dTP_AD.TabIndex = 36;
            // 
            // cb_DID
            // 
            this.cb_DID.FormattingEnabled = true;
            this.cb_DID.Location = new System.Drawing.Point(258, 144);
            this.cb_DID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_DID.Name = "cb_DID";
            this.cb_DID.Size = new System.Drawing.Size(136, 33);
            this.cb_DID.TabIndex = 35;
            // 
            // cb_PID
            // 
            this.cb_PID.FormattingEnabled = true;
            this.cb_PID.Location = new System.Drawing.Point(258, 90);
            this.cb_PID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_PID.Name = "cb_PID";
            this.cb_PID.Size = new System.Drawing.Size(136, 33);
            this.cb_PID.TabIndex = 33;
            // 
            // txt_AID
            // 
            this.txt_AID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_AID.Location = new System.Drawing.Point(334, 37);
            this.txt_AID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_AID.Name = "txt_AID";
            this.txt_AID.Size = new System.Drawing.Size(168, 31);
            this.txt_AID.TabIndex = 31;
            // 
            // lb_appointments
            // 
            this.lb_appointments.AutoSize = true;
            this.lb_appointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointments.Location = new System.Drawing.Point(52, 35);
            this.lb_appointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_appointments.Name = "lb_appointments";
            this.lb_appointments.Size = new System.Drawing.Size(142, 21);
            this.lb_appointments.TabIndex = 30;
            this.lb_appointments.Text = "Appointment ID:";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(52, 88);
            this.lb_patient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(92, 21);
            this.lb_patient.TabIndex = 29;
            this.lb_patient.Text = "Patient ID:";
            // 
            // cb_doctorid
            // 
            this.cb_doctorid.AutoSize = true;
            this.cb_doctorid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_doctorid.Location = new System.Drawing.Point(52, 146);
            this.cb_doctorid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cb_doctorid.Name = "cb_doctorid";
            this.cb_doctorid.Size = new System.Drawing.Size(89, 21);
            this.cb_doctorid.TabIndex = 28;
            this.cb_doctorid.Text = "Doctor ID:";
            // 
            // lb_appointment
            // 
            this.lb_appointment.AutoSize = true;
            this.lb_appointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointment.Location = new System.Drawing.Point(52, 204);
            this.lb_appointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_appointment.Name = "lb_appointment";
            this.lb_appointment.Size = new System.Drawing.Size(164, 21);
            this.lb_appointment.TabIndex = 27;
            this.lb_appointment.Text = "Appointment date:";
            // 
            // pb_FindByAD
            // 
            this.pb_FindByAD.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByAD.Image")));
            this.pb_FindByAD.Location = new System.Drawing.Point(754, 204);
            this.pb_FindByAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_FindByAD.Name = "pb_FindByAD";
            this.pb_FindByAD.Size = new System.Drawing.Size(40, 46);
            this.pb_FindByAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByAD.TabIndex = 46;
            this.pb_FindByAD.TabStop = false;
            this.pb_FindByAD.Click += new System.EventHandler(this.pb_FindByAD_Click);
            // 
            // pb_FindByAID
            // 
            this.pb_FindByAID.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByAID.Image")));
            this.pb_FindByAID.Location = new System.Drawing.Point(536, 37);
            this.pb_FindByAID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_FindByAID.Name = "pb_FindByAID";
            this.pb_FindByAID.Size = new System.Drawing.Size(40, 46);
            this.pb_FindByAID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByAID.TabIndex = 47;
            this.pb_FindByAID.TabStop = false;
            this.pb_FindByAID.Click += new System.EventHandler(this.pb_FindByAID_Click);
            // 
            // pb_FindByPID
            // 
            this.pb_FindByPID.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByPID.Image")));
            this.pb_FindByPID.Location = new System.Drawing.Point(406, 85);
            this.pb_FindByPID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_FindByPID.Name = "pb_FindByPID";
            this.pb_FindByPID.Size = new System.Drawing.Size(40, 46);
            this.pb_FindByPID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByPID.TabIndex = 48;
            this.pb_FindByPID.TabStop = false;
            this.pb_FindByPID.Click += new System.EventHandler(this.pb_FindByPID_Click);
            // 
            // pb_FindByDID
            // 
            this.pb_FindByDID.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByDID.Image")));
            this.pb_FindByDID.Location = new System.Drawing.Point(406, 144);
            this.pb_FindByDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_FindByDID.Name = "pb_FindByDID";
            this.pb_FindByDID.Size = new System.Drawing.Size(40, 46);
            this.pb_FindByDID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByDID.TabIndex = 49;
            this.pb_FindByDID.TabStop = false;
            this.pb_FindByDID.Click += new System.EventHandler(this.pb_FindByDID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(796, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Status:";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Scheduled",
            "Cancelled",
            "Completed"});
            this.cb_Status.Location = new System.Drawing.Point(956, 29);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(164, 33);
            this.cb_Status.TabIndex = 51;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(848, 223);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(318, 46);
            this.btn_Reload.TabIndex = 54;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(1046, 90);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 77);
            this.btn_Cancel.TabIndex = 53;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Lime;
            this.btn_Add.Location = new System.Drawing.Point(602, 90);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 77);
            this.btn_Add.TabIndex = 52;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_EditPrescription
            // 
            this.btn_EditPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditPrescription.ForeColor = System.Drawing.Color.Blue;
            this.btn_EditPrescription.Location = new System.Drawing.Point(848, 175);
            this.btn_EditPrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditPrescription.Name = "btn_EditPrescription";
            this.btn_EditPrescription.Size = new System.Drawing.Size(318, 46);
            this.btn_EditPrescription.TabIndex = 55;
            this.btn_EditPrescription.Text = "Edit Prescription";
            this.btn_EditPrescription.UseVisualStyleBackColor = true;
            this.btn_EditPrescription.Click += new System.EventHandler(this.btn_EditPrescription_Click);
            // 
            // btn_Completed
            // 
            this.btn_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Completed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Completed.Location = new System.Drawing.Point(820, 90);
            this.btn_Completed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Completed.Name = "btn_Completed";
            this.btn_Completed.Size = new System.Drawing.Size(120, 77);
            this.btn_Completed.TabIndex = 56;
            this.btn_Completed.Text = "Done";
            this.btn_Completed.UseVisualStyleBackColor = true;
            this.btn_Completed.Click += new System.EventHandler(this.btn_Completed_Click);
            // 
            // uc_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Completed);
            this.Controls.Add(this.btn_EditPrescription);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_FindByDID);
            this.Controls.Add(this.pb_FindByPID);
            this.Controls.Add(this.pb_FindByAID);
            this.Controls.Add(this.pb_FindByAD);
            this.Controls.Add(this.dgv_Appointments);
            this.Controls.Add(this.dTP_AD);
            this.Controls.Add(this.cb_DID);
            this.Controls.Add(this.cb_PID);
            this.Controls.Add(this.txt_AID);
            this.Controls.Add(this.lb_appointments);
            this.Controls.Add(this.lb_patient);
            this.Controls.Add(this.cb_doctorid);
            this.Controls.Add(this.lb_appointment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_Appointment";
            this.Size = new System.Drawing.Size(1242, 846);
            this.Load += new System.EventHandler(this.uc_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByAID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.DateTimePicker dTP_AD;
        private System.Windows.Forms.ComboBox cb_DID;
        private System.Windows.Forms.ComboBox cb_PID;
        private System.Windows.Forms.TextBox txt_AID;
        private System.Windows.Forms.Label lb_appointments;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Label cb_doctorid;
        private System.Windows.Forms.Label lb_appointment;
        private System.Windows.Forms.PictureBox pb_FindByAD;
        private System.Windows.Forms.PictureBox pb_FindByAID;
        private System.Windows.Forms.PictureBox pb_FindByPID;
        private System.Windows.Forms.PictureBox pb_FindByDID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_EditPrescription;
        private System.Windows.Forms.Button btn_Completed;
    }
}
