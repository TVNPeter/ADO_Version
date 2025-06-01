using EF_Version.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Version.Presentation.Usercontrol
{
    public partial class uc_Doctor : UserControl
    {
        private BLLDoctor service = new BLLDoctor();
        private BLLAccount accountService = new BLLAccount();
        private bool isAdd = false;
        private bool isEdit = false;
        string err;
        public uc_Doctor()
        {
            InitializeComponent();
            SetControlState(false);
        }
        #region Buttons
        private void btn_Add_Click(object sender, EventArgs e)
        {
            SetControlState(true);
            isAdd = true;
            isEdit = false;
            ResetFields();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SetControlState(true);
            isAdd = false;
            isEdit = true;
            ResetFields();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            SetControlState(false);
            dgv_Doctors_CellClick(null, null);
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) || cb_Specialty.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Doctor doctor = new Doctor
            {
                FullName = txt_Name.Text.Trim(),
                Specialty = cb_Specialty.Text.Trim(),
                Phone = txt_Phone.Text.Trim()
            };
            if (isAdd)
            {
                try
                {
                    int newDoctorId;
                    if (service.Add(doctor, out err, out newDoctorId))
                    {
                        string phone = txt_Phone.Text.Trim();
                        Account acc = new Account(phone, phone, "Doctor", newDoctorId);

                        if (accountService.AddAccount(acc, out err))
                        {
                            MessageBox.Show("Doctor and account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Doctor added but failed to add account: {err}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add doctor: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isEdit)
            {
                try
                {
                    doctor.DoctorID = Int32.Parse(txt_DID.Text);
                    service.Update(doctor, out err);
                    LoadData();
                    MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Doctors.CurrentRow == null)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            DialogResult response;
            response = MessageBox.Show("Are you sure to delete this record?", "Response",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                MessageBox.Show("Deleting...");
            }
            else
            {
                return;
            }
            int r = dgv_Doctors.CurrentCell.RowIndex;
            int doctorId = Int32.Parse(dgv_Doctors.Rows[r].Cells[0].Value.ToString());
            try
            {
                service.Delete(doctorId, out err);
                LoadData();
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Delete the associated account
                accountService.DeleteAccount(txt_Phone.Text.Trim(), out err);
                MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Search Methods
        private void pb_FindById_Click(object sender, EventArgs e)
        {
            var doctor = service.GetById(Int32.Parse(txt_DID.Text), out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (doctor != null)
            {
                dgv_Doctors.DataSource = new List<Doctor> { doctor };
            }
            else
            {
                MessageBox.Show("Doctor not found.");
                dgv_Doctors.DataSource = null;
            }
        }
        private void pb_FindBySpecialty_Click(object sender, EventArgs e)
        {
            var doctor = service.GetBySpecialty(cb_Specialty.Text, out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (doctor != null)
            {
                dgv_Doctors.DataSource = doctor;
            }
            else
            {
                MessageBox.Show("Doctor not found.");
                dgv_Doctors.DataSource = null;
            }
        }
        private void pb_FindByName_Click(object sender, EventArgs e)
        {
            var doctor = service.GetByName(txt_Name.Text, out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (doctor != null)
            {
                dgv_Doctors.DataSource = doctor;
            }
            else
            {
                MessageBox.Show("Doctor not found.");
                dgv_Doctors.DataSource = null;
            }
        }
        #endregion
        #region Assistive Methods
        private void LoadData()
        {
            try
            {
                var data = service.GetAll(out string err);
                dgv_Doctors.AutoGenerateColumns = false;

                dgv_Doctors.Columns[0].DataPropertyName = "DoctorID";
                dgv_Doctors.Columns[1].DataPropertyName = "FullName";
                dgv_Doctors.Columns[2].DataPropertyName = "Specialty";
                dgv_Doctors.Columns[3].DataPropertyName = "Phone";

                dgv_Doctors.DataSource = data;
                dgv_Doctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetControlState(false);
                ResetFields();
            }
        }
        private void ResetFields()
        {
            txt_DID.Clear();
            txt_Name.Clear();
            cb_Specialty.SelectedIndex = -1;
            txt_Phone.Clear();
        }
        private void SetControlState(bool enabled)
        {
            txt_DID.Enabled = !enabled;
            txt_Phone.Enabled = enabled;
            btn_Save.Enabled = enabled;
            btn_Cancel.Enabled = enabled;
            btn_Add.Enabled = !enabled;
            btn_Edit.Enabled = !enabled;
            btn_Delete.Enabled = !enabled;
        }
        #endregion

        private void uc_Doctor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_Doctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Doctors.CurrentRow == null) return;
            int r = dgv_Doctors.CurrentCell.RowIndex;

            txt_DID.Text = dgv_Doctors.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Doctors.Rows[r].Cells[1].Value.ToString();
            cb_Specialty.Text = dgv_Doctors.Rows[r].Cells[2].Value.ToString();
            txt_Phone.Text = dgv_Doctors.Rows[r].Cells[3].Value.ToString();
        }

        
    }
}
