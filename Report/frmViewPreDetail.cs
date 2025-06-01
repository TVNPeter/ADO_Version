using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Version.Report
{
    public partial class frmViewPreDetail : Form
    {
        int ID = 0;
        public frmViewPreDetail()
        {
            InitializeComponent();
        }
        public frmViewPreDetail(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void frmViewPreDetail_Load(object sender, EventArgs e)
        {
            this.dataForPrescriptionDetailTableAdapter.Fill(this.dSPrescription.DataForPrescriptionDetail, 8);

            this.reportViewer1.RefreshReport();
        }
    }
}
