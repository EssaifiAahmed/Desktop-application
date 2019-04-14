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
    public partial class Family : Form
    {
        Famille fa;
        Gestion_des_incidentsEntities gi;
        public Family()
        {
            InitializeComponent();
            this.fa = new Famille();
        }

        private void Family_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            var f = (from i in gi.Familles select new { numfamille = i.idfamille, famille = i.famille1 });
            cmbFamille.DisplayMember = "numfamille";
            cmbFamille.ValueMember = "famille";
            cmbFamille.DataSource = f.ToList();
            this.show();
        }

        private void show()
        {
            var famille = (from m in gi.Familles select new {numero_de_famille=m.idfamille,famille=m.famille1 });
            dgv.DataSource = famille.ToList();
        }

        //private void bt_Save_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void bt_Search_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
            
        ////}

        //private void button3_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void bt_Cancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void bt_Save_Click_1(object sender, EventArgs e)
        {
            Famille f = new Famille();
            f.idfamille = txtId.Text;
            f.famille1 = txtfamille.Text;
            gi.Familles.Add(f);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette famille a été bien ajouter", "Ajouter");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtfamille.Text = "";
            cmbFamille.Text = null;
        }

        private void bt_Search_Click_1(object sender, EventArgs e)
        {
            fa.idfamille = cmbFamille.Text;
            var a = (from j in gi.Familles where j.idfamille == fa.idfamille select new { numero_de_famille = j.idfamille, famille = j.famille1 });
            dgv.DataSource = a.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fa.idfamille = txtId.Text;
            var a = (from j in gi.Familles where j.idfamille == fa.idfamille select j).Single();
            a.famille1 = txtfamille.Text;
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette famille a été mis à jour avec succés", "Modification");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fa.idfamille = txtId.Text;
            var a = (from j in gi.Familles where j.idfamille == fa.idfamille select j).FirstOrDefault();
            gi.Familles.Remove(a);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette famille a été supprimeé avec succés", "Suppresion");
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtfamille.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
