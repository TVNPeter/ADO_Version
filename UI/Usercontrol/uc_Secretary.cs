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

namespace EF_Version.UI.Usercontrol
{
    public partial class uc_Secretary : UserControl
    {
        private BLLSecretary service = new BLLSecretary();
        private BLLAccount accountService = new BLLAccount();
        private bool isAdd = false;
        private bool isEdit = false;
        string err;

        public uc_Secretary()
        {
            InitializeComponent();
            SetControlState(false);
        }

        #region Buttons
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pb_FindBySID_Click(object sender, EventArgs e)
        {
            var secretary = service.GetById(Int32.Parse(txt_SID.Text), out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (secretary != null)
            {
                dgv_Secretaries.DataSource = new List<Secretary> { secretary };
            }
            else
            {
                MessageBox.Show("Secretary not found.");
                dgv_Secretaries.DataSource = null;
            }
        }

        private void pb_FindByName_Click(object sender, EventArgs e)
        {
            dgv_Secretaries.DataSource = service.GetByName(txt_Name.Text, out string err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            dgv_Secretaries_CellClick(null, null);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Secretary secretary = new Secretary(txt_Name.Text, txt_Phone.Text);
            if (isAdd)
            {
                try
                {
                    int newSecretaryId;
                    if (service.Add(secretary, out err, out newSecretaryId))
                    {
                        string username = txt_Phone.Text.Trim();
                        Account acc = new Account(username, txt_Phone.Text.Trim(), "Secretary", newSecretaryId);

                        if (accountService.AddAccount(acc, out err))
                        {
                            MessageBox.Show("Secretary and account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Secretary added but failed to add account: {err}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add secretary: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    secretary.SecretaryID = Int32.Parse(txt_SID.Text);
                    service.Update(secretary, out err);
                    LoadData();
                    MessageBox.Show("Secretary updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Secretaries.CurrentRow == null)
            {
                MessageBox.Show("Please select a secretary.");
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
            int r = dgv_Secretaries.CurrentCell.RowIndex;
            int secretaryId = Int32.Parse(dgv_Secretaries.Rows[r].Cells[0].Value.ToString());
            try
            {
                service.Delete(secretaryId, out err);
                LoadData();
                // Delete the associated account
                accountService.DeleteAccount(txt_Phone.Text.Trim(), out err);

                MessageBox.Show("Secretary deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error: {err}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Assistive Methods
        private void LoadData()
        {
            try
            {
                var data = service.GetAll(out string err);
                dgv_Secretaries.AutoGenerateColumns = false;

                dgv_Secretaries.Columns[0].DataPropertyName = "SecretaryID";
                dgv_Secretaries.Columns[1].DataPropertyName = "FullName";
                dgv_Secretaries.Columns[2].DataPropertyName = "Phone";

                dgv_Secretaries.DataSource = data;
                dgv_Secretaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            txt_SID.Clear();
            txt_Name.Clear();
            txt_Phone.Clear();
        }

        private void SetControlState(bool enabled)
        {
            txt_SID.Enabled = !enabled;
            txt_Name.Enabled = enabled;
            txt_Phone.Enabled = enabled;
            btn_Save.Enabled = enabled;
            btn_Cancel.Enabled = enabled;
            btn_Add.Enabled = !enabled;
            btn_Edit.Enabled = !enabled;
            btn_Delete.Enabled = !enabled;
        }
        #endregion

        private void uc_Secretary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_Secretaries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Secretaries.CurrentRow == null) return;
            int r = dgv_Secretaries.CurrentCell.RowIndex;

            txt_SID.Text = dgv_Secretaries.Rows[r].Cells[0].Value.ToString();
            txt_Name.Text = dgv_Secretaries.Rows[r].Cells[1].Value.ToString();
            txt_Phone.Text = dgv_Secretaries.Rows[r].Cells[2].Value.ToString();
        }

        private void lb_fullname_Click(object sender, EventArgs e)
        {

        }
    }
}
