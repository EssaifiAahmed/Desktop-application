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
    public partial class Model : Form
    {
        Modele m;
        Gestion_des_incidentsEntities gi;
        public Model()
        {
            InitializeComponent();
            this.m = new Modele();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            var item = (from g in gi.Modeles select new { nummodele = g.idmodele, modele = g.modele1 });
            cmbM.DisplayMember = "nummodele";
            cmbM.ValueMember = "modele";
            cmbM.DataSource = item.ToList();
            this.show();
        }

        public void show()
        {
            var a = (from b in gi.Modeles select new { Nummodele=b.idmodele,modele=b.modele1 });
            dgv.DataSource = a.ToList();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Modele md = new Modele();
            md.idmodele = txtId.Text;
            md.modele1 = txtmodele.Text;
            gi.Modeles.Add(md);
            gi.SaveChanges();
            this.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtmodele.Text = string.Empty;
            cmbM.Text = null;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            m.idmodele = cmbM.Text;
            var a = (from b in gi.Modeles where b.idmodele == m.idmodele select new { Numero_de_Modele = b.idmodele, Modele = b.modele1 });
            dgv.DataSource = a.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.idmodele = txtId.Text;
            var result = (from z in gi.Modeles where z.idmodele == m.modele1 select z).Single();
            result.modele1 = txtId.Text;
            gi.SaveChanges();
            this.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.idmodele = txtId.Text;
            var a = (from b in gi.Modeles where b.idmodele == m.idmodele select b).FirstOrDefault();
            gi.Modeles.Remove(a);
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
            txtmodele.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }

    }
}
