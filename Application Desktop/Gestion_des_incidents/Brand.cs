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
    public partial class Brand : Form
    {
        Marque ma;
        Gestion_des_incidentsEntities gi;
        public Brand()
        {
            InitializeComponent();
            this.ma = new Marque();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            var m = (from i in gi.Marques select new {idmarque=i.idmarque,marque=i.marque1 });
            cmbS.DisplayMember = "idmarque";
            cmbS.ValueMember = "marque";
            cmbS.DataSource = m.ToList();
            this.show();
        }

        private void show() 
        {
            var marque = (from m in gi.Marques select new {Numero_de_Marque=m.idmarque,marque=m.marque1 });
            dgv.DataSource = marque.ToList();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Marque m = new Marque();
            m.idmarque = txtId.Text;
            m.marque1 = txtmarque.Text;
            gi.Marques.Add(m);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette marque a été bien ajouter", "Ajouter");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtmarque.Text = "";
            cmbS.Text = null;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            ma.idmarque = cmbS.Text;
            var a = (from j in gi.Marques where j.idmarque == ma.idmarque select new {Numero_de_Marque=j.idmarque,Marque=j.marque1 });
            dgv.DataSource = a.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ma.idmarque = txtId.Text;
            var a = (from j in gi.Marques where j.idmarque == ma.idmarque select j).Single();
            a.marque1 = txtmarque.Text;
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette marque a été mis à jour avec succés", "Modification");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ma.idmarque = txtId.Text;
            var a = (from j in gi.Marques where j.idmarque == ma.idmarque select j).FirstOrDefault();
            gi.Marques.Remove(a);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette marque a été supprimeé avec succés", "Suppresion");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtmarque.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
