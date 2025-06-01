namespace EF_Version.Presentation.Forms
{
    partial class frmPrescription
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_Medication = new System.Windows.Forms.DataGridView();
            this.PrescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_AID = new System.Windows.Forms.TextBox();
            this.txt_Diagnosis = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.lb_prescription = new System.Windows.Forms.Label();
            this.lb_appointment = new System.Windows.Forms.Label();
            this.lb_diagnosis = new System.Windows.Forms.Label();
            this.lb_note = new System.Windows.Forms.Label();
            this.btn_AddMedicine = new System.Windows.Forms.Button();
            this.btn_RemoveMedicine = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.txt_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medication)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(756, 937);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(260, 140);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(178, 927);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(260, 158);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgv_Medication
            // 
            this.dgv_Medication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrescriptionID,
            this.MedicineID,
            this.MedicineName,
            this.Dosage,
            this.Quantity,
            this.Frequency});
            this.dgv_Medication.Location = new System.Drawing.Point(130, 317);
            this.dgv_Medication.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dgv_Medication.Name = "dgv_Medication";
            this.dgv_Medication.RowHeadersWidth = 51;
            this.dgv_Medication.RowTemplate.Height = 24;
            this.dgv_Medication.Size = new System.Drawing.Size(1316, 577);
            this.dgv_Medication.TabIndex = 32;
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.HeaderText = "PrescriptionID";
            this.PrescriptionID.Name = "PrescriptionID";
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "MedicineID";
            this.MedicineID.Name = "MedicineID";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "MedicineName";
            this.MedicineName.Name = "MedicineName";
            // 
            // Dosage
            // 
            this.Dosage.HeaderText = "Dosage";
            this.Dosage.Name = "Dosage";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // txt_AID
            // 
            this.txt_AID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_AID.Location = new System.Drawing.Point(388, 150);
            this.txt_AID.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_AID.Name = "txt_AID";
            this.txt_AID.ReadOnly = true;
            this.txt_AID.Size = new System.Drawing.Size(312, 31);
            this.txt_AID.TabIndex = 31;
            // 
            // txt_Diagnosis
            // 
            this.txt_Diagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Diagnosis.Location = new System.Drawing.Point(872, 37);
            this.txt_Diagnosis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_Diagnosis.Name = "txt_Diagnosis";
            this.txt_Diagnosis.Size = new System.Drawing.Size(390, 31);
            this.txt_Diagnosis.TabIndex = 30;
            // 
            // txt_Note
            // 
            this.txt_Note.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Note.Location = new System.Drawing.Point(316, 263);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(544, 31);
            this.txt_Note.TabIndex = 28;
            // 
            // txt_PID
            // 
            this.txt_PID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_PID.Location = new System.Drawing.Point(352, 31);
            this.txt_PID.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.ReadOnly = true;
            this.txt_PID.Size = new System.Drawing.Size(312, 31);
            this.txt_PID.TabIndex = 27;
            // 
            // lb_prescription
            // 
            this.lb_prescription.AutoSize = true;
            this.lb_prescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prescription.Location = new System.Drawing.Point(88, 25);
            this.lb_prescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_prescription.Name = "lb_prescription";
            this.lb_prescription.Size = new System.Drawing.Size(124, 21);
            this.lb_prescription.TabIndex = 26;
            this.lb_prescription.Text = "Prescription ID:";
            // 
            // lb_appointment
            // 
            this.lb_appointment.AutoSize = true;
            this.lb_appointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appointment.Location = new System.Drawing.Point(88, 144);
            this.lb_appointment.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_appointment.Name = "lb_appointment";
            this.lb_appointment.Size = new System.Drawing.Size(142, 21);
            this.lb_appointment.TabIndex = 25;
            this.lb_appointment.Text = "Appointment ID:";
            // 
            // lb_diagnosis
            // 
            this.lb_diagnosis.AutoSize = true;
            this.lb_diagnosis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diagnosis.Location = new System.Drawing.Point(684, 31);
            this.lb_diagnosis.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_diagnosis.Name = "lb_diagnosis";
            this.lb_diagnosis.Size = new System.Drawing.Size(86, 21);
            this.lb_diagnosis.TabIndex = 24;
            this.lb_diagnosis.Text = "Diagnosis:";
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_note.Location = new System.Drawing.Point(104, 263);
            this.lb_note.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(53, 21);
            this.lb_note.TabIndex = 22;
            this.lb_note.Text = "Note:";
            // 
            // btn_AddMedicine
            // 
            this.btn_AddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMedicine.Location = new System.Drawing.Point(756, 96);
            this.btn_AddMedicine.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_AddMedicine.Name = "btn_AddMedicine";
            this.btn_AddMedicine.Size = new System.Drawing.Size(286, 52);
            this.btn_AddMedicine.TabIndex = 35;
            this.btn_AddMedicine.Text = "Add Medicine";
            this.btn_AddMedicine.UseVisualStyleBackColor = true;
            this.btn_AddMedicine.Click += new System.EventHandler(this.btn_AddMedicine_Click);
            // 
            // btn_RemoveMedicine
            // 
            this.btn_RemoveMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveMedicine.Location = new System.Drawing.Point(756, 163);
            this.btn_RemoveMedicine.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_RemoveMedicine.Name = "btn_RemoveMedicine";
            this.btn_RemoveMedicine.Size = new System.Drawing.Size(286, 52);
            this.btn_RemoveMedicine.TabIndex = 36;
            this.btn_RemoveMedicine.Text = "Remove Medicine";
            this.btn_RemoveMedicine.UseVisualStyleBackColor = true;
            this.btn_RemoveMedicine.Click += new System.EventHandler(this.btn_RemoveMedicine_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(1078, 129);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(272, 77);
            this.btn_Reload.TabIndex = 37;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // txt_Print
            // 
            this.txt_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Print.Location = new System.Drawing.Point(924, 224);
            this.txt_Print.Margin = new System.Windows.Forms.Padding(8);
            this.txt_Print.Name = "txt_Print";
            this.txt_Print.Size = new System.Drawing.Size(271, 77);
            this.txt_Print.TabIndex = 39;
            this.txt_Print.Text = "Print Prescription";
            this.txt_Print.UseVisualStyleBackColor = true;
            this.txt_Print.Click += new System.EventHandler(this.txt_Print_Click);
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 1219);
            this.Controls.Add(this.txt_Print);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_RemoveMedicine);
            this.Controls.Add(this.btn_AddMedicine);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgv_Medication);
            this.Controls.Add(this.txt_AID);
            this.Controls.Add(this.txt_Diagnosis);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_PID);
            this.Controls.Add(this.lb_prescription);
            this.Controls.Add(this.lb_appointment);
            this.Controls.Add(this.lb_diagnosis);
            this.Controls.Add(this.lb_note);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmPrescription";
            this.Text = "frmPrescription";
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgv_Medication;
        private System.Windows.Forms.TextBox txt_AID;
        private System.Windows.Forms.TextBox txt_Diagnosis;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label lb_prescription;
        private System.Windows.Forms.Label lb_appointment;
        private System.Windows.Forms.Label lb_diagnosis;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.Button btn_AddMedicine;
        private System.Windows.Forms.Button btn_RemoveMedicine;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.Button txt_Print;
    }
}