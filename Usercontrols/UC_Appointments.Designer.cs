namespace hospitalss.Usercontrols
{
    partial class UC_Appointments
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
            this.lb_totalfee = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_appointment = new System.Windows.Forms.Label();
            this.cb_doctorid = new System.Windows.Forms.Label();
            this.lb_patient = new System.Windows.Forms.Label();
            this.lb_appointments = new System.Windows.Forms.Label();
            this.txt_appointment = new System.Windows.Forms.TextBox();
            this.txt_totalfeee = new System.Windows.Forms.TextBox();
            this.cb_patientid = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dgv_appointments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_totalfee
            // 
            this.lb_totalfee.AutoSize = true;
            this.lb_totalfee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalfee.Location = new System.Drawing.Point(3, 264);
            this.lb_totalfee.Name = "lb_totalfee";
            this.lb_totalfee.Size = new System.Drawing.Size(99, 23);
            this.lb_totalfee.TabIndex = 4;
            this.lb_totalfee.Text = "Total Fee";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(3, 214);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(68, 23);
            this.lb_status.TabIndex = 5;
            this.lb_status.Text = "Status";
            // 
            // lb_appointment
            // 
            this.lb_appointment.AutoSize = true;
            this.lb_appointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointment.Location = new System.Drawing.Point(3, 172);
            this.lb_appointment.Name = "lb_appointment";
            this.lb_appointment.Size = new System.Drawing.Size(193, 23);
            this.lb_appointment.TabIndex = 6;
            this.lb_appointment.Text = "Appointment date";
            // 
            // cb_doctorid
            // 
            this.cb_doctorid.AutoSize = true;
            this.cb_doctorid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_doctorid.Location = new System.Drawing.Point(3, 128);
            this.cb_doctorid.Name = "cb_doctorid";
            this.cb_doctorid.Size = new System.Drawing.Size(108, 23);
            this.cb_doctorid.TabIndex = 7;
            this.cb_doctorid.Text = "Doctor ID:";
            // 
            // lb_patient
            // 
            this.lb_patient.AutoSize = true;
            this.lb_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patient.Location = new System.Drawing.Point(3, 82);
            this.lb_patient.Name = "lb_patient";
            this.lb_patient.Size = new System.Drawing.Size(109, 23);
            this.lb_patient.TabIndex = 8;
            this.lb_patient.Text = "Patient ID:";
            // 
            // lb_appointments
            // 
            this.lb_appointments.AutoSize = true;
            this.lb_appointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointments.Location = new System.Drawing.Point(3, 40);
            this.lb_appointments.Name = "lb_appointments";
            this.lb_appointments.Size = new System.Drawing.Size(170, 23);
            this.lb_appointments.TabIndex = 9;
            this.lb_appointments.Text = "Appointment ID:";
            // 
            // txt_appointment
            // 
            this.txt_appointment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_appointment.Location = new System.Drawing.Point(186, 43);
            this.txt_appointment.Name = "txt_appointment";
            this.txt_appointment.Size = new System.Drawing.Size(118, 22);
            this.txt_appointment.TabIndex = 10;
            // 
            // txt_totalfeee
            // 
            this.txt_totalfeee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_totalfeee.Location = new System.Drawing.Point(108, 267);
            this.txt_totalfeee.Name = "txt_totalfeee";
            this.txt_totalfeee.Size = new System.Drawing.Size(118, 22);
            this.txt_totalfeee.TabIndex = 11;
            // 
            // cb_patientid
            // 
            this.cb_patientid.FormattingEnabled = true;
            this.cb_patientid.Location = new System.Drawing.Point(118, 81);
            this.cb_patientid.Name = "cb_patientid";
            this.cb_patientid.Size = new System.Drawing.Size(121, 24);
            this.cb_patientid.TabIndex = 12;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(90, 214);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 24);
            this.cb_status.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(118, 131);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 14;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(202, 172);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 22);
            this.date.TabIndex = 15;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(289, 310);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(289, 361);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(186, 310);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 21;
            this.btn_Change.Text = "change";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(186, 361);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(90, 310);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // dgv_appointments
            // 
            this.dgv_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appointments.Location = new System.Drawing.Point(379, 3);
            this.dgv_appointments.Name = "dgv_appointments";
            this.dgv_appointments.RowHeadersWidth = 51;
            this.dgv_appointments.RowTemplate.Height = 24;
            this.dgv_appointments.Size = new System.Drawing.Size(610, 416);
            this.dgv_appointments.TabIndex = 24;
            // 
            // UC_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_appointments);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.date);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_patientid);
            this.Controls.Add(this.txt_totalfeee);
            this.Controls.Add(this.txt_appointment);
            this.Controls.Add(this.lb_appointments);
            this.Controls.Add(this.lb_patient);
            this.Controls.Add(this.cb_doctorid);
            this.Controls.Add(this.lb_appointment);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_totalfee);
            this.Name = "UC_Appointments";
            this.Size = new System.Drawing.Size(992, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_totalfee;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_appointment;
        private System.Windows.Forms.Label cb_doctorid;
        private System.Windows.Forms.Label lb_patient;
        private System.Windows.Forms.Label lb_appointments;
        private System.Windows.Forms.TextBox txt_appointment;
        private System.Windows.Forms.TextBox txt_totalfeee;
        private System.Windows.Forms.ComboBox cb_patientid;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_appointments;
    }
}
