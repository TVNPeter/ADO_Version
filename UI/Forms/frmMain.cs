using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_Version.Presentation;
using EF_Version.Presentation.Usercontrol;
using EF_Version.UI.Usercontrol;
namespace EF_Version.Presentation.Forms
{
    public partial class frmMain : Form
    {
        string role;
        int userid;
        private void InitializeDatabase()
        {
            using (var context = new ClinicContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
        public frmMain()
        {
            InitializeComponent();
            InitializeDatabase(); // Call the method to initialize the database
        }
        public frmMain(string role, int userid) : this()
        {
            this.role = role;
            this.userid = userid;
            AddUserControlToPanel(new uc_DashBoard(role, userid));
            if(role == "Doctor")
            {
                btn_Secretary.Enabled = false;
                btn_Doctor.Enabled = false;
                btn_Patients.Enabled = false;
            }
            else if(role == "Secretary")
            {
                btn_Secretary.Enabled = false;
                btn_Doctor.Enabled = false;
            }
            else if(role == "Admin")
            {
                btn_Medicines.Enabled = false;
                btn_Patients.Enabled = false;
                btn_Appointments.Enabled = false;
            }
        }
        private void AddUserControlToPanel(UserControl userControl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
        private void btn_Patients_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_Patient());
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_Doctor());
        }

        private void btn_Appointments_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_Appointment());
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Medicines_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_Medicine());
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_DashBoard(role, userid));
        }

        private void btn_Secretary_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel(new uc_Secretary());
        }
    }
}
