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
    public partial class equipment : Form
    {
        Equipement eq;
        Gestion_des_incidentsEntities gi;
        public equipment()
        {
            InitializeComponent();
            this.eq = new Equipement();
        }

        private void equipment_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            var eq = (from i in gi.Equipements select new { Num_de_equipement= i.idequipement, equipement = i.equipement1 });
            cmbEquip.DisplayMember = "Num_de_equipement";
            cmbEquip.ValueMember = "equipement";
            cmbEquip.DataSource = eq.ToList();
            this.show();
        }

        private void show()
        {
            var equipement = (from e in gi.Equipements select new {e.idequipement,e.equipement1 });
            dgv.DataSource = equipement.ToList();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Equipement eq = new Equipement();
            eq.idequipement =txtId.Text;
            eq.equipement1 = txtEquip.Text;
            gi.Equipements.Add(eq);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette equipement a été bien ajouter", "Ajouter");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtEquip.Text = "";
            cmbEquip.Text = null;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            eq.idequipement = cmbEquip.Text;
            var q = (from v in gi.Equipements where v.idequipement==eq.idequipement select new {Numero_de_equipement=v.idequipement,Equipement=v.equipement1 });
            dgv.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eq.idequipement = txtId.Text;
            var q = (from v in gi.Equipements where v.idequipement==eq.idequipement select v).Single();
            q.equipement1 = txtEquip.Text;
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette equipement a été mis à jour avec succés", "Modification");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eq.idequipement = txtId.Text;
            var q = (from v in gi.Equipements where v.idequipement==eq.idequipement select v).FirstOrDefault();
            gi.Equipements.Remove(q);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Cette equipement a été supprimeé avec succés", "Suppression");
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtEquip.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
