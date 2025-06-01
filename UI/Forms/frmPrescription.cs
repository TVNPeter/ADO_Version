using EF_Version.BLL;
using EF_Version.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Version.Presentation.Forms
{
    public partial class frmPrescription : Form
    {
        private int PreID;
        private int AID;
        Prescription prescription;
        BLLAppointment appointment = new BLLAppointment();
        BLLPrescription service = new BLLPrescription();
        BLLPrescriptionDetail serviceDetail = new BLLPrescriptionDetail();
        public frmPrescription()
        {
            InitializeComponent();
        }
        public frmPrescription(int aID)
        {
            InitializeComponent();
            AID = aID;
            prescription = service.GetByAppointmentId(AID, out string err);
            if (prescription == null)
            {
                MessageBox.Show($"No prescription found for Appointment ID {AID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            PreID = prescription.PrescriptionID;
            txt_AID.Text = AID.ToString();
            txt_PID.Text = PreID.ToString();
            txt_Note.Text = prescription.Notes;
            txt_Diagnosis.Text = prescription.Diagnosis;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Note.Text) || string.IsNullOrWhiteSpace(txt_Diagnosis.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            
            prescription.Notes = txt_Note.Text;
            prescription.Diagnosis = txt_Diagnosis.Text;
            prescription.DateIssued = DateTime.Now;
            string err;
            
            try
            {
                // 1. Cập nhật thông tin đơn thuốc
                bool success = service.Update(prescription, out err);
                if (!success)
                {
                    MessageBox.Show($"Error updating prescription: {err}");
                    return;
                }
                
                // 2. Tính tổng chi phí thuốc
                BLLAppointment appointmentService = new BLLAppointment();
                double totalMedicationCost = serviceDetail.CalculateTotalMedicationCost(PreID, out err);
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show($"Error calculating medication cost: {err}");
                    return;
                }
                
                // 3. Cập nhật Fee trong Appointment
                if (appointmentService.UpdateFee(AID, totalMedicationCost, out err))
                {
                    MessageBox.Show($"Prescription updated successfully. Total fee: {totalMedicationCost:C}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Prescription updated but failed to update fee: {err}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_RemoveMedicine_Click(object sender, EventArgs e)
        {
            if (dgv_Medication.CurrentRow == null) return;
            int r = dgv_Medication.CurrentCell.RowIndex;

            int prescriptionID = Convert.ToInt32(dgv_Medication.Rows[r].Cells[0].Value);
            int medicineID = Convert.ToInt32(dgv_Medication.Rows[r].Cells[1].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to remove this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            try
            {
                if (serviceDetail.Delete(prescriptionID, medicineID, out string err))
                {
                    try
                    {
                        BLLAppointment appointmentService = new BLLAppointment();
                        double totalMedicationCost = serviceDetail.CalculateTotalMedicationCost(PreID, out err);
                        appointmentService.UpdateFee(AID, totalMedicationCost, out err);
                        
                        // Hiển thị kết quả
                        LoadData();
                        MessageBox.Show($"Medicine removed successfully. Updated fee: {totalMedicationCost:C}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating fee: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Error removing medicine: {err}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }

        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            frmAddMedicines addMedicinesForm = new frmAddMedicines(PreID);
            if (addMedicinesForm.ShowDialog() == DialogResult.OK)
            {
                // Sau khi thêm thuốc thành công, cập nhật Fee
                try
                {
                    BLLAppointment appointmentService = new BLLAppointment();
                    double totalMedicationCost = serviceDetail.CalculateTotalMedicationCost(PreID, out string err);
                    appointmentService.UpdateFee(AID, totalMedicationCost, out err);
                    
                    // Hiển thị kết quả
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating fee: {ex.Message}");
                }
            }
        }
        private void LoadData()
        {
            try
            {
                // Lấy dữ liệu chi tiết kê đơn kèm thông tin thuốc
                var data = serviceDetail.GetByPrescriptionId(PreID, out string err);
                
                // Tạo danh sách hiển thị với thông tin chi tiết hơn
                var displayData = data.Select(d => new {
                    PrescriptionID = d.PrescriptionID,
                    MedicineID = d.MedicineID,
                    MedicineName = d.Medicine?.Name ?? "Unknown",
                    Dosage = d.Medicine?.Dosage ?? "Unknown",
                    Price = d.Medicine?.Price ?? 0,
                    Quantity = d.Quantity,
                    Frequency = d.Frequency,
                    TotalPrice = (d.Medicine?.Price ?? 0) * d.Quantity
                }).ToList();

                dgv_Medication.AutoGenerateColumns = false;

                // Cập nhật DataPropertyName cho từng cột
                dgv_Medication.Columns[0].DataPropertyName = "PrescriptionID";
                dgv_Medication.Columns[1].DataPropertyName = "MedicineID";
                dgv_Medication.Columns[2].DataPropertyName = "MedicineName";
                dgv_Medication.Columns[3].DataPropertyName = "Dosage";
                dgv_Medication.Columns[4].DataPropertyName = "Quantity";
                dgv_Medication.Columns[5].DataPropertyName = "Frequency";

                dgv_Medication.DataSource = displayData;
                dgv_Medication.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                double totalCost = displayData.Sum(d => d.TotalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool UpdateMedicationFee(out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                BLLAppointment appointmentService = new BLLAppointment();
                double totalMedicationCost = serviceDetail.CalculateTotalMedicationCost(PreID, out errorMessage);
                if (!string.IsNullOrEmpty(errorMessage)) return false;

                return appointmentService.UpdateFee(AID, totalMedicationCost, out errorMessage);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private void txt_Print_Click(object sender, EventArgs e)
        {
            frmViewPreDetail viewPreDetailForm = new frmViewPreDetail(PreID);
            viewPreDetailForm.ShowDialog();
        }
    }
}
