using EF_Version.BLL;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EF_Version.UI.Usercontrol
{
    public partial class uc_DashBoard : UserControl
    {
        BLLDoctor bllDoctor = new BLLDoctor();
        BLLAdmin bllAdmin = new BLLAdmin();
        BLLSecretary bllSecretary = new BLLSecretary();
        public uc_DashBoard()
        {
            InitializeComponent();
        }
        public uc_DashBoard(string role, int userid)
        {
            InitializeComponent();
            lbl_Role.Text = role;
            lbl_ID.Text = userid.ToString();
            if (role == "Doctor")
            {
                try
                {
                    var person = bllDoctor.GetById(userid, out string err);
                    lbl_Name.Text = person.FullName;
                    lbl_Phone.Text = person.Phone;
                    lbl_Specialty.Text = person.Specialty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Doctor", userid + ".png"); 
                if (File.Exists(imagePath))
                {
                    pb_Avatar.Image = Image.FromFile(imagePath);
                }
            }
            else if (role == "Admin")
            {
                try
                {
                    var person = bllAdmin.GetAdminById(userid, out string err);
                    if(person == null)
                    {
                        MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lbl_Name.Text = person.FullName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lbl_Phone.Visible = false;
                lbl_P.Visible = false;
                lbl_S.Visible = false;
                lbl_Specialty.Visible = false; 
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Admin", userid + ".png");
                if (File.Exists(imagePath))
                {
                    pb_Avatar.Image = Image.FromFile(imagePath);
                }
            }
            else if (role == "Secretary")
            {
                try
                {
                    var person = bllSecretary.GetById(userid, out string err);
                    lbl_Name.Text = person.FullName;
                    lbl_Phone.Text = person.Phone;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading secretary data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lbl_S.Visible = false;
                lbl_Specialty.Visible = false;
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "Secretary", userid + ".png");
                if (File.Exists(imagePath))
                {
                    pb_Avatar.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
