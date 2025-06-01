using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Version.BLL;

namespace EF_Version.Presentation.Usercontrol
{
    public partial class uc_Patient : UserControl
    {
        private BLLPatient service = new BLLPatient();
        private bool isAdd = false;
        private bool isEdit = false;
        string err;

        public uc_Patient()
        {
            InitializeComponent();
            SetControlState(false);
        }
        #region Buttons
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
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
            dgv_Patients_CellClick(null, null);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) || cb_Gender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Patient patient = new Patient(txt_Name.Text, cb_Gender.Text, dTP_BD.Value, txt_Address.Text, txt_Phone.Text);
            if (isAdd)
            {
                try
                {
                    service.Add(patient, out err);
                    LoadData();
                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    patient.PatientID = Int32.Parse(txt_PID.Text);
                    service.Update(patient, out err);
                    LoadData();
                    MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Patients.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient.");
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
            int r = dgv_Patients.CurrentCell.RowIndex;
            int patientId = Int32.Parse(dgv_Patients.Rows[r].Cells[0].Value.ToString());
            try
            {
                service.Delete(patientId, out err);
                LoadData();
                MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Search Methods

        private void pb_FindByPID_Click(object sender, EventArgs e)
        {
            var patient = service.GetById(Int32.Parse(txt_PID.Text), out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (patient != null)
            {
                dgv_Patients.DataSource = new List<Patient> { patient };
            }
            else
            {
                MessageBox.Show("Patient not found.");
                dgv_Patients.DataSource = null;
            }

        }
        private void pb_FindByName_Click(object sender, EventArgs e)
        {
            dgv_Patients.DataSource = service.GetByName(txt_Name.Text, out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Assistive Methods
        private void LoadData()
        {
            try
            {
                var data = service.GetAll(out string err);
                dgv_Patients.AutoGenerateColumns = false;

                dgv_Patients.Columns[0].DataPropertyName = "PatientID";
                dgv_Patients.Columns[1].DataPropertyName = "FullName";
                dgv_Patients.Columns[2].DataPropertyName = "Gender";
                dgv_Patients.Columns[3].DataPropertyName = "BirthDate";
                dgv_Patients.Columns[4].DataPropertyName = "Address";
                dgv_Patients.Columns[5].DataPropertyName = "Phone";

                dgv_Patients.DataSource = data;
                dgv_Patients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
            txt_PID.Clear();
            txt_Name.Clear();
            cb_Gender.SelectedIndex = -1;
            dTP_BD.Value = DateTime.Now;
            txt_Phone.Clear();
            txt_Address.Clear();
        }
        private void SetControlState(bool enabled)
        {
            txt_PID.Enabled = !enabled;
            txt_Phone.Enabled = enabled;
            cb_Gender.Enabled = enabled;
            dTP_BD.Enabled = enabled;
            txt_Address.Enabled = enabled;
            btn_Save.Enabled = enabled;
            btn_Cancel.Enabled = enabled;
            btn_Add.Enabled = !enabled;
            btn_Edit.Enabled = !enabled;
            btn_Delete.Enabled = !enabled;
        }
        #endregion
        private void uc_Patient_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_Patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Patients.CurrentRow == null) return;
            int r = dgv_Patients.CurrentCell.RowIndex;

            txt_PID.Text = dgv_Patients.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Patients.Rows[r].Cells[1].Value.ToString();
            cb_Gender.Text = dgv_Patients.Rows[r].Cells[2].Value.ToString();
            dTP_BD.Value = Convert.ToDateTime(dgv_Patients.Rows[r].Cells[3].Value);
            txt_Phone.Text = dgv_Patients.Rows[r].Cells[4].Value.ToString();
            txt_Address.Text = dgv_Patients.Rows[r].Cells[5].Value.ToString();
        }
    }
}
