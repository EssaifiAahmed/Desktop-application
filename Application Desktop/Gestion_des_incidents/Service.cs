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
    public partial class Service : Form
    {
        Servicee s;
        Gestion_des_incidentsEntities gi;
        public Service()
        {
            InitializeComponent();
            this.s = new Servicee();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            this.show();
            var s = (from S in gi.Servicees select new { numService = S.idservicee, Service = S.servicee1 });
            cmbS.DisplayMember = "numservice";
            cmbS.ValueMember = "Service";
            cmbS.DataSource = s.ToList();
        }
        public void show() 
        {
            var a = (from b in gi.Servicees select new { b.idservicee, b.servicee1 });
            dgv.DataSource = a.ToList();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Servicee s = new Servicee();
            s.idservicee = txtId.Text;
            s.servicee1 = txtService.Text;
            gi.Servicees.Add(s);
            gi.SaveChanges();
            this.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtService.Text = string.Empty;
            cmbS.Text = null;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            s.idservicee = cmbS.Text;
            var a = (from b in gi.Servicees where b.idservicee == s.idservicee select new { idService = b.idservicee, Service = b.servicee1 });
            dgv.DataSource = a.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.idservicee = txtId.Text;
            var result = (from z in gi.Servicees where z.idservicee == s.idservicee select z).Single();
            result.servicee1 = txtService.Text;
            gi.SaveChanges();
            this.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.idservicee = txtId.Text;
            var result = (from z in gi.Servicees where z.idservicee == s.idservicee select z).FirstOrDefault();
            gi.Servicees.Remove(result);
            gi.SaveChanges();
            this.show();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtService.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
