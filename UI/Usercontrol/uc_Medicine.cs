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
    public partial class uc_Medicine : UserControl
    {
        private BLLMedicine service = new BLLMedicine();
        private bool isAdd = false;
        private bool isEdit = false;
        string err;

        public uc_Medicine()
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
            dgv_Medicines_CellClick(null, null);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            double price;
            if (!double.TryParse(txt_Price.Text, out price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            Medicine medicine = new Medicine(txt_Name.Text, txt_Dosage.Text, price);
            if (isAdd)
            {
                try
                {
                    service.Add(medicine, out err);
                    LoadData();
                    MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    medicine.MedicineID = Int32.Parse(txt_MID.Text);
                    service.Update(medicine, out err);
                    LoadData();
                    MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Medicines.CurrentRow == null)
            {
                MessageBox.Show("Please select a medicine.");
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
            int r = dgv_Medicines.CurrentCell.RowIndex;
            int medicineId = Int32.Parse(dgv_Medicines.Rows[r].Cells[0].Value.ToString());
            try
            {
                service.Delete(medicineId, out err);
                LoadData();
                MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Search Methods
        private void pb_FindByMID_Click(object sender, EventArgs e)
        {
            var medicine = service.GetById(Int32.Parse(txt_MID.Text), out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (medicine != null)
            {
                dgv_Medicines.DataSource = new List<Medicine> { medicine };
            }
            else
            {
                MessageBox.Show("Medicine not found.");
                dgv_Medicines.DataSource = null;
            }
        }

        private void pb_FindByName_Click(object sender, EventArgs e)
        {
            dgv_Medicines.DataSource = service.GetByName(txt_Name.Text, out string err);
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
                dgv_Medicines.AutoGenerateColumns = false;

                dgv_Medicines.Columns[0].DataPropertyName = "MedicineID";
                dgv_Medicines.Columns[1].DataPropertyName = "Name";
                dgv_Medicines.Columns[2].DataPropertyName = "Dosage";
                dgv_Medicines.Columns[3].DataPropertyName = "Price";

                dgv_Medicines.DataSource = data;
                dgv_Medicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            txt_MID.Clear();
            txt_Name.Clear();
            txt_Dosage.Clear();
            txt_Price.Clear();
        }
        
        private void SetControlState(bool enabled)
        {
            txt_MID.Enabled = !enabled;
            txt_Dosage.Enabled = enabled;
            txt_Price.Enabled = enabled;
            btn_Save.Enabled = enabled;
            btn_Cancel.Enabled = enabled;
            btn_Add.Enabled = !enabled;
            btn_Edit.Enabled = !enabled;
            btn_Delete.Enabled = !enabled;
        }
        #endregion

        private void uc_Medicine_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Medicines.CurrentRow == null) return;
            if (dgv_Medicines.CurrentCell == null) return;

            int r = dgv_Medicines.CurrentCell.RowIndex;

            txt_MID.Text = dgv_Medicines.Rows[r].Cells[0].Value?.ToString() ?? string.Empty;
            txt_Name.Text = dgv_Medicines.Rows[r].Cells[1].Value?.ToString() ?? string.Empty;
            txt_Dosage.Text = dgv_Medicines.Rows[r].Cells[2].Value?.ToString() ?? string.Empty;
            txt_Price.Text = dgv_Medicines.Rows[r].Cells[3].Value?.ToString() ?? string.Empty;
        }
    }
}
