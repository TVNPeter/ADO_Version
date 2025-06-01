namespace EF_Version.Presentation.Usercontrol
{
    partial class uc_Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Medicine));
            this.dgv_Medicines = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Dosage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_FindByName = new System.Windows.Forms.PictureBox();
            this.pb_FindByMID = new System.Windows.Forms.PictureBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_MID = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByMID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Medicines
            // 
            this.dgv_Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MName,
            this.Dosage,
            this.Price});
            this.dgv_Medicines.Location = new System.Drawing.Point(10, 78);
            this.dgv_Medicines.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_Medicines.Name = "dgv_Medicines";
            this.dgv_Medicines.RowTemplate.Height = 24;
            this.dgv_Medicines.Size = new System.Drawing.Size(449, 128);
            this.dgv_Medicines.TabIndex = 87;
            this.dgv_Medicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicines_CellClick);
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "ID";
            this.MedicineID.Name = "MedicineID";
            // 
            // MName
            // 
            this.MName.HeaderText = "Name";
            this.MName.Name = "MName";
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
            // txt_Dosage
            // 
            this.txt_Dosage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Dosage.Location = new System.Drawing.Point(92, 57);
            this.txt_Dosage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Dosage.Name = "txt_Dosage";
            this.txt_Dosage.Size = new System.Drawing.Size(87, 20);
            this.txt_Dosage.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 85;
            this.label2.Text = "Dosage:";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Price.Location = new System.Drawing.Point(242, 6);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(87, 20);
            this.txt_Price.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Price:";
            // 
            // pb_FindByName
            // 
            this.pb_FindByName.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByName.Image")));
            this.pb_FindByName.Location = new System.Drawing.Point(331, 6);
            this.pb_FindByName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb_FindByName.Name = "pb_FindByName";
            this.pb_FindByName.Size = new System.Drawing.Size(26, 21);
            this.pb_FindByName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByName.TabIndex = 82;
            this.pb_FindByName.TabStop = false;
            this.pb_FindByName.Click += new System.EventHandler(this.pb_FindByName_Click);
            // 
            // pb_FindByMID
            // 
            this.pb_FindByMID.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByMID.Image")));
            this.pb_FindByMID.Location = new System.Drawing.Point(157, 1);
            this.pb_FindByMID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb_FindByMID.Name = "pb_FindByMID";
            this.pb_FindByMID.Size = new System.Drawing.Size(22, 20);
            this.pb_FindByMID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByMID.TabIndex = 81;
            this.pb_FindByMID.TabStop = false;
            this.pb_FindByMID.Click += new System.EventHandler(this.pb_FindByMID_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(254, 47);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(87, 20);
            this.txt_Name.TabIndex = 80;
            // 
            // txt_MID
            // 
            this.txt_MID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_MID.Location = new System.Drawing.Point(68, 1);
            this.txt_MID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_MID.Name = "txt_MID";
            this.txt_MID.Size = new System.Drawing.Size(87, 20);
            this.txt_MID.TabIndex = 79;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(6, 25);
            this.lb_doctor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(107, 21);
            this.lb_doctor.TabIndex = 78;
            this.lb_doctor.Text = "Medicine ID:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(178, 6);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(62, 21);
            this.lb_fullname.TabIndex = 77;
            this.lb_fullname.Text = "Name:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(395, 21);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(114, 33);
            this.btn_Reload.TabIndex = 93;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(37, 262);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 21);
            this.btn_Delete.TabIndex = 92;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Lime;
            this.btn_Save.Location = new System.Drawing.Point(154, 226);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(62, 21);
            this.btn_Save.TabIndex = 91;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(254, 226);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(52, 21);
            this.btn_Cancel.TabIndex = 90;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Edit.Location = new System.Drawing.Point(82, 226);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(48, 21);
            this.btn_Edit.TabIndex = 89;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add.Location = new System.Drawing.Point(18, 226);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(49, 21);
            this.btn_Add.TabIndex = 88;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // uc_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Medicines);
            this.Controls.Add(this.txt_Dosage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_FindByName);
            this.Controls.Add(this.pb_FindByMID);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_MID);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.lb_fullname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Medicine";
            this.Size = new System.Drawing.Size(543, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByMID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Medicines;
        private System.Windows.Forms.TextBox txt_Dosage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_FindByName;
        private System.Windows.Forms.PictureBox pb_FindByMID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_MID;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
