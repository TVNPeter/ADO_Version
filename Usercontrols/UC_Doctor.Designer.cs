namespace hospitalss.Usercontrols
{
    partial class UC_Doctor
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
            this.lb_workingday = new System.Windows.Forms.Label();
            this.lb_speciality = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_doctor = new System.Windows.Forms.Label();
            this.txt_doctor = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_working = new System.Windows.Forms.TextBox();
            this.cb_speciality = new System.Windows.Forms.ComboBox();
            this.dgv_doctor = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_workingday
            // 
            this.lb_workingday.AutoSize = true;
            this.lb_workingday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workingday.Location = new System.Drawing.Point(3, 226);
            this.lb_workingday.Name = "lb_workingday";
            this.lb_workingday.Size = new System.Drawing.Size(137, 23);
            this.lb_workingday.TabIndex = 1;
            this.lb_workingday.Text = "Working days";
            // 
            // lb_speciality
            // 
            this.lb_speciality.AutoSize = true;
            this.lb_speciality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speciality.Location = new System.Drawing.Point(3, 169);
            this.lb_speciality.Name = "lb_speciality";
            this.lb_speciality.Size = new System.Drawing.Size(103, 23);
            this.lb_speciality.TabIndex = 2;
            this.lb_speciality.Text = "Speicality";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(3, 111);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(106, 23);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "Full name";
            // 
            // lb_doctor
            // 
            this.lb_doctor.AutoSize = true;
            this.lb_doctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doctor.Location = new System.Drawing.Point(3, 48);
            this.lb_doctor.Name = "lb_doctor";
            this.lb_doctor.Size = new System.Drawing.Size(108, 23);
            this.lb_doctor.TabIndex = 4;
            this.lb_doctor.Text = "Doctor ID:";
            // 
            // txt_doctor
            // 
            this.txt_doctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_doctor.Location = new System.Drawing.Point(115, 51);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.Size = new System.Drawing.Size(118, 22);
            this.txt_doctor.TabIndex = 6;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_fullname.Location = new System.Drawing.Point(115, 114);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(118, 22);
            this.txt_fullname.TabIndex = 7;
            // 
            // txt_working
            // 
            this.txt_working.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_working.Location = new System.Drawing.Point(146, 229);
            this.txt_working.Name = "txt_working";
            this.txt_working.Size = new System.Drawing.Size(118, 22);
            this.txt_working.TabIndex = 8;
            // 
            // cb_speciality
            // 
            this.cb_speciality.FormattingEnabled = true;
            this.cb_speciality.Location = new System.Drawing.Point(115, 172);
            this.cb_speciality.Name = "cb_speciality";
            this.cb_speciality.Size = new System.Drawing.Size(121, 24);
            this.cb_speciality.TabIndex = 9;
            // 
            // dgv_doctor
            // 
            this.dgv_doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doctor.Location = new System.Drawing.Point(288, 3);
            this.dgv_doctor.Name = "dgv_doctor";
            this.dgv_doctor.RowHeadersWidth = 51;
            this.dgv_doctor.RowTemplate.Height = 24;
            this.dgv_doctor.Size = new System.Drawing.Size(701, 416);
            this.dgv_doctor.TabIndex = 10;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(45, 306);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(126, 351);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(126, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(207, 351);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(207, 306);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 20;
            this.btn_Change.Text = "change";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // UC_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_doctor);
            this.Controls.Add(this.cb_speciality);
            this.Controls.Add(this.txt_working);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_doctor);
            this.Controls.Add(this.lb_doctor);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.lb_speciality);
            this.Controls.Add(this.lb_workingday);
            this.Name = "UC_Doctor";
            this.Size = new System.Drawing.Size(992, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_workingday;
        private System.Windows.Forms.Label lb_speciality;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_doctor;
        private System.Windows.Forms.TextBox txt_doctor;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_working;
        private System.Windows.Forms.ComboBox cb_speciality;
        private System.Windows.Forms.DataGridView dgv_doctor;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Change;
    }
}
