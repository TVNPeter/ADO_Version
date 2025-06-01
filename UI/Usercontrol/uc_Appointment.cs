using EF_Version.BLL;
using EF_Version.Presentation.Forms;
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
    public partial class uc_Appointment : UserControl
    {
        private BLLAppointment service = new BLLAppointment();
        private BLLPatient patientService = new BLLPatient();
        private BLLDoctor doctorService = new BLLDoctor();
        string err;
        List<Appointment> data = new List<Appointment>();
        public uc_Appointment()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        #region ComboBox Loading
        private void LoadComboBoxes()
        {
            LoadPatients();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            try
            {
                var patients = patientService.GetAll(out string error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Error loading patients", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cb_PID.DataSource = patients;
                cb_PID.DisplayMember = "PatientID";
                cb_PID.ValueMember = "PatientID";
                cb_PID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading patients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                var doctors = doctorService.GetAll(out string error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Error loading doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cb_DID.DataSource = doctors;
                cb_DID.DisplayMember = "DoctorID";
                cb_DID.ValueMember = "DoctorID";
                cb_DID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Buttons
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cb_PID.SelectedIndex == -1 || cb_DID.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            Appointment appointment = new Appointment
            {
                AppointmentDate = dTP_AD.Value,
                Status = "Scheduled",
                PatientID = Convert.ToInt32(cb_PID.SelectedValue),
                DoctorID = Convert.ToInt32(cb_DID.SelectedValue)
            };
            try
            {
                service.Add(appointment, out err);
                LoadData();

                MessageBox.Show("Appointment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if(service.UpdateStatus(txt_AID.Text.Trim(), "Cancelled", out err))
                {
                    LoadData();
                    MessageBox.Show("Appointment cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error cancelling appointment: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        #endregion
        #region Search Methods 
        private void pb_FindByAID_Click(object sender, EventArgs e)
        {
            Appointment appointment = service.GetById(Int32.Parse(txt_AID.Text), out err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (appointment != null)
            {
                data = new List<Appointment> { appointment };
                dgv_Appointments.DataSource = data;
            }
            else
            {
                MessageBox.Show("Appointment not found.");
                data = null;
                dgv_Appointments.DataSource = data;
            }
        }
        private void pb_FindByPID_Click(object sender, EventArgs e)
        {
            data = service.GetByPatientID(Convert.ToInt32(cb_PID.SelectedValue), out err);
            dgv_Appointments.DataSource = data;
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_FindByDID_Click(object sender, EventArgs e)
        {
            data = service.GetByDoctorID(Convert.ToInt32(cb_DID.SelectedValue), out err);
            dgv_Appointments.DataSource = data;
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_FindByAD_Click(object sender, EventArgs e)
        {
            try
            {
                data = service.GetByDate(dTP_AD.Value, out err);
                
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                dgv_Appointments.DataSource = data;
                
                if (data == null || data.Count == 0)
                {
                    MessageBox.Show($"No appointments found for {dTP_AD.Value.ToShortDateString()}.", 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while searching appointments: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Assistive Methods
        private void LoadData()
        {
            try
            {
                data = service.GetAll();
                dgv_Appointments.AutoGenerateColumns = false;

                dgv_Appointments.Columns[0].DataPropertyName = "AppointmentID";
                dgv_Appointments.Columns[1].DataPropertyName = "AppointmentDate";
                dgv_Appointments.Columns[2].DataPropertyName = "Status";
                dgv_Appointments.Columns[3].DataPropertyName = "PatientID";
                dgv_Appointments.Columns[4].DataPropertyName = "DoctorID";
                dgv_Appointments.Columns[5].DataPropertyName = "Fee";

                dgv_Appointments.DataSource = data;
                dgv_Appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ResetFields();
                LoadComboBoxes();
            }
        }
        private void ResetFields()
        {
            txt_AID.Clear();
            cb_Status.SelectedIndex = -1;
            cb_PID.SelectedIndex = -1;
            cb_DID.SelectedIndex = -1;
            dTP_AD.Value = DateTime.Now;
        }
        #endregion

        private void dgv_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Appointments.CurrentRow == null) return;
            int r = dgv_Appointments.CurrentCell.RowIndex;

            txt_AID.Text = dgv_Appointments.Rows[r].Cells[0].Value.ToString();
            dTP_AD.Value = Convert.ToDateTime(dgv_Appointments.Rows[r].Cells[1].Value);
            cb_DID.Text = dgv_Appointments.Rows[r].Cells[3].Value.ToString();
            cb_PID.Text = dgv_Appointments.Rows[r].Cells[4].Value.ToString();
        }
        private void uc_Appointment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data == null || cb_Status.SelectedIndex == -1)
                return;

            if (!string.IsNullOrEmpty(cb_Status.Text))
            {
                var filteredData = data.Where(a => a.Status.Trim().Equals(cb_Status.Text.Trim(), 
                    StringComparison.OrdinalIgnoreCase)).ToList();
                    
                dgv_Appointments.DataSource = filteredData;
            }
            else
            {
                dgv_Appointments.DataSource = data;
            }
        }

        private void btn_EditPrescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AID.Text) || !int.TryParse(txt_AID.Text, out int appointmentId))
            {
                MessageBox.Show("Please enter a valid Appointment ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prescriptionForm = new frmPrescription(appointmentId);
            prescriptionForm.ShowDialog();
        }

        private void btn_Completed_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateStatus(txt_AID.Text.Trim(), "Completed", out err);
                LoadData();
                MessageBox.Show("Appointment marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
