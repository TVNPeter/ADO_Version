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
namespace EF_Version.Presentation.Forms
{
    public partial class frmAddMedicines : Form
    {
        int prepID;
        BLLPrescriptionDetail servicePrepDetail = new BLLPrescriptionDetail();
        BLLMedicine serviceMedicine = new BLLMedicine();
        public frmAddMedicines()
        {
            InitializeComponent();
        }
        public frmAddMedicines(int PrepID)
        {
            InitializeComponent();
            prepID = PrepID;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MID.Text) || 
                string.IsNullOrWhiteSpace(txt_Quantity.Text) || 
                string.IsNullOrWhiteSpace(txt_Frequency.Text))
            {
                MessageBox.Show("Please fill in all required fields (Medicine ID, Quantity, and Frequency).", 
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_MID.Text, out int mid))
            {
                MessageBox.Show("Medicine ID must be a valid number.", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Quantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a valid number.", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string frequency = txt_Frequency.Text.Trim();

            try
            {
                var medicine = serviceMedicine.GetById(mid, out string errMedicine);
                if (medicine == null)
                {
                    MessageBox.Show($"Medicine with ID {mid} does not exist. {errMedicine}", 
                        "Invalid Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingDetail = servicePrepDetail.GetByIds(prepID, Int32.Parse(txt_MID.Text), out string errDetails);
                if (existingDetail != null)
                {
                    DialogResult result = MessageBox.Show("This medicine is already in the prescription. Do you want to update it?", 
                        "Medicine Already Added", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        existingDetail.Quantity = quantity;
                        existingDetail.Frequency = frequency;
                        if (servicePrepDetail.Update(existingDetail, out string errUpdate))
                        {
                            MessageBox.Show("Medicine updated successfully.", 
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"Error updating medicine: {errUpdate}", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                PrescriptionDetail newPrepDetail = new PrescriptionDetail
                {
                    PrescriptionID = prepID,
                    MedicineID = mid,
                    Quantity = quantity,
                    Frequency = frequency,
                };

                string err;
                if (servicePrepDetail.Add(newPrepDetail, out err))
                {
                    MessageBox.Show("Medicine added successfully.", 
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error adding medicine: {err}", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Medicines.CurrentRow == null) return;
            int r = dgv_Medicines.CurrentCell.RowIndex;

            txt_MID.Text = dgv_Medicines.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Medicines.Rows[r].Cells[1].Value.ToString();
            txt_Dosage.Text = dgv_Medicines.Rows[r].Cells[2].Value.ToString();
        }
        private void LoadData()
        {
            var data = serviceMedicine.GetAll(out string err);
            if (err != string.Empty)
            {
                MessageBox.Show($"Error loading medicines: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_Medicines.AutoGenerateColumns = false;

            dgv_Medicines.Columns[0].DataPropertyName = "MedicineID";
            dgv_Medicines.Columns[1].DataPropertyName = "Name";
            dgv_Medicines.Columns[2].DataPropertyName = "Dosage";
            dgv_Medicines.Columns[3].DataPropertyName = "Price";

            dgv_Medicines.DataSource = data;
            dgv_Medicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAddMedicines_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
