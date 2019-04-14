using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_incidents
{
    public partial class FormCR : Form
    {
        public FormCR()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
