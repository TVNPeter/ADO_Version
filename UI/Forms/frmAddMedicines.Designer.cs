namespace EF_Version.Presentation.Forms
{
    partial class frmAddMedicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMedicines));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.dgv_Medicines = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Dosage = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Frequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_MID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(578, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(232, 44);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(337, 20);
            this.txt_Name.TabIndex = 52;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(44, 44);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(62, 21);
            this.lb_fullname.TabIndex = 49;
            this.lb_fullname.Text = "Name:";
            // 
            // dgv_Medicines
            // 
            this.dgv_Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.Dosage,
            this.Price});
            this.dgv_Medicines.Location = new System.Drawing.Point(18, 164);
            this.dgv_Medicines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Medicines.Name = "dgv_Medicines";
            this.dgv_Medicines.RowTemplate.Height = 24;
            this.dgv_Medicines.Size = new System.Drawing.Size(1164, 531);
            this.dgv_Medicines.TabIndex = 59;
            this.dgv_Medicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicines_CellClick);
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
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Quantity.Location = new System.Drawing.Point(836, 19);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(337, 20);
            this.txt_Quantity.TabIndex = 63;
            // 
            // txt_Dosage
            // 
            this.txt_Dosage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Dosage.Location = new System.Drawing.Point(232, 81);
            this.txt_Dosage.Name = "txt_Dosage";
            this.txt_Dosage.ReadOnly = true;
            this.txt_Dosage.Size = new System.Drawing.Size(337, 20);
            this.txt_Dosage.TabIndex = 62;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(45, 81);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(74, 21);
            this.lb_doctor.TabIndex = 61;
            this.lb_doctor.Text = "Dosage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Quantity:";
            // 
            // txt_Frequency
            // 
            this.txt_Frequency.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Frequency.Location = new System.Drawing.Point(836, 83);
            this.txt_Frequency.Name = "txt_Frequency";
            this.txt_Frequency.Size = new System.Drawing.Size(337, 20);
            this.txt_Frequency.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Frequency:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(766, 703);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 70);
            this.btn_Cancel.TabIndex = 66;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_OK.Location = new System.Drawing.Point(369, 703);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(112, 77);
            this.btn_OK.TabIndex = 67;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_MID
            // 
            this.txt_MID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_MID.Location = new System.Drawing.Point(235, 7);
            this.txt_MID.Name = "txt_MID";
            this.txt_MID.Size = new System.Drawing.Size(337, 20);
            this.txt_MID.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Medicine ID:";
            // 
            // frmAddMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 846);
            this.Controls.Add(this.txt_MID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Frequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Dosage);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Medicines);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_fullname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddMedicines";
            this.Text = "frmMedicines";
            this.Load += new System.EventHandler(this.frmAddMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.DataGridView dgv_Medicines;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Dosage;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Frequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TextBox txt_MID;
        private System.Windows.Forms.Label label3;
    }
}