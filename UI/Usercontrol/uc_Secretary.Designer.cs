namespace EF_Version.UI.Usercontrol
{
    partial class uc_Secretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Secretary));
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pb_FindByName = new System.Windows.Forms.PictureBox();
            this.pb_FindById = new System.Windows.Forms.PictureBox();
            this.dgv_Secretaries = new System.Windows.Forms.DataGridView();
            this.SecretaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_SID = new System.Windows.Forms.TextBox();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindById)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Secretaries)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Phone.Location = new System.Drawing.Point(185, 130);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(112, 20);
            this.txt_Phone.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "Phone:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.Location = new System.Drawing.Point(371, 84);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(96, 42);
            this.btn_Reload.TabIndex = 72;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(415, 324);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(67, 21);
            this.btn_Delete.TabIndex = 71;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Lime;
            this.btn_Save.Location = new System.Drawing.Point(234, 324);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(73, 21);
            this.btn_Save.TabIndex = 70;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(324, 324);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(67, 21);
            this.btn_Cancel.TabIndex = 69;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Edit.Location = new System.Drawing.Point(153, 324);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(58, 21);
            this.btn_Edit.TabIndex = 68;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add.Location = new System.Drawing.Point(78, 324);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(55, 21);
            this.btn_Add.TabIndex = 67;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pb_FindByName
            // 
            this.pb_FindByName.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindByName.Image")));
            this.pb_FindByName.Location = new System.Drawing.Point(324, 95);
            this.pb_FindByName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb_FindByName.Name = "pb_FindByName";
            this.pb_FindByName.Size = new System.Drawing.Size(30, 31);
            this.pb_FindByName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindByName.TabIndex = 66;
            this.pb_FindByName.TabStop = false;
            this.pb_FindByName.Click += new System.EventHandler(this.pb_FindByName_Click);
            // 
            // pb_FindById
            // 
            this.pb_FindById.Image = ((System.Drawing.Image)(resources.GetObject("pb_FindById.Image")));
            this.pb_FindById.Location = new System.Drawing.Point(280, 84);
            this.pb_FindById.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pb_FindById.Name = "pb_FindById";
            this.pb_FindById.Size = new System.Drawing.Size(28, 18);
            this.pb_FindById.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_FindById.TabIndex = 64;
            this.pb_FindById.TabStop = false;
            this.pb_FindById.Click += new System.EventHandler(this.pb_FindBySID_Click);
            // 
            // dgv_Secretaries
            // 
            this.dgv_Secretaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Secretaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecretaryID,
            this.FullName,
            this.Phone});
            this.dgv_Secretaries.Location = new System.Drawing.Point(78, 152);
            this.dgv_Secretaries.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_Secretaries.Name = "dgv_Secretaries";
            this.dgv_Secretaries.RowHeadersWidth = 51;
            this.dgv_Secretaries.RowTemplate.Height = 24;
            this.dgv_Secretaries.Size = new System.Drawing.Size(352, 143);
            this.dgv_Secretaries.TabIndex = 63;
            // 
            // SecretaryID
            // 
            this.SecretaryID.HeaderText = "SecretaryID";
            this.SecretaryID.Name = "SecretaryID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Name.Location = new System.Drawing.Point(185, 108);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(122, 20);
            this.txt_Name.TabIndex = 61;
            // 
            // txt_SID
            // 
            this.txt_SID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_SID.Location = new System.Drawing.Point(185, 84);
            this.txt_SID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txt_SID.Name = "txt_SID";
            this.txt_SID.Size = new System.Drawing.Size(93, 20);
            this.txt_SID.TabIndex = 60;
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(74, 81);
            this.lb_doctor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(109, 21);
            this.lb_doctor.TabIndex = 59;
            this.lb_doctor.Text = "Secretary ID:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(74, 105);
            this.lb_fullname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(88, 21);
            this.lb_fullname.TabIndex = 58;
            this.lb_fullname.Text = "Full name:";
            this.lb_fullname.Click += new System.EventHandler(this.lb_fullname_Click);
            // 
            // uc_Secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.pb_FindById);
            this.Controls.Add(this.dgv_Secretaries);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_SID);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.lb_fullname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uc_Secretary";
            this.Size = new System.Drawing.Size(619, 440);
            this.Load += new System.EventHandler(this.uc_Secretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindByName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FindById)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Secretaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.PictureBox pb_FindByName;
        private System.Windows.Forms.PictureBox pb_FindById;
        private System.Windows.Forms.DataGridView dgv_Secretaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_SID;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.Label lb_fullname;
    }
}
