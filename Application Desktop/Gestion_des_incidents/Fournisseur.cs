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
    public partial class Fournisseur : Form
    {
        InfoFE fe;
        Gestion_des_incidentsEntities gi;
        public Fournisseur()
        {
            InitializeComponent();
            this.fe = new InfoFE();
            gi = new Gestion_des_incidentsEntities();
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            var a = (from b in gi.InfoFEs select new { idFE = b.idfe, FE = b.FE });
            cmbIdFE.DisplayMember = "idFE";
            cmbIdFE.ValueMember = "FE";
            cmbIdFE.DataSource = a.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdFichier.Text = "";
            txtIdFE.Text = "";
            txtFE.Text = "";
            dtpDD.Text = DateTime.Today.ToString();
            dtpDR.Text = DateTime.Today.ToString();
            txtDR.Text = "";
            txtNR.Text = "";
            cmbIdFE.Text = null;
            txtRemarque.Text = "";
            txtTF.Text = "";
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            fe.idfichier = int.Parse(txtIdFichier.Text);
            fe.idfe = int.Parse(txtIdFE.Text);
            fe.FE = txtFE.Text;
            fe.DD = DateTime.Parse(dtpDD.Text);
            fe.TF = txtTF.Text;
            fe.DR = DateTime.Parse(dtpDR.Text);
            fe.NR = txtNR.Text;
            fe.DRF =int.Parse(txtDR.Text);
            fe.remarque = txtRemarque.Text;
            gi.InfoFEs.Add(fe);
            gi.SaveChanges();
            MessageBox.Show("L'ajout de fourinisseur a été bien ajouter", "Information");
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fe.idfe = int.Parse(txtIdFE.Text);
            var a = (from b in gi.InfoFEs where b.idfe == fe.idfe select b).FirstOrDefault();
            gi.InfoFEs.Remove(a);
            gi.SaveChanges();
            MessageBox.Show("bien Supprimer", "Supprimer");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            fe.idfe = int.Parse(txtIdFE.Text);
            var a = (from b in gi.InfoFEs where b.idfe == fe.idfe select b).Single();
            a.FE = txtFE.Text;
            a.DD = DateTime.Parse(dtpDD.Text);
            a.TF = txtTF.Text;
            a.DR = DateTime.Parse(dtpDR.Text);
            a.NR = txtNR.Text;
            a.DRF = int.Parse(txtDR.Text);
            a.remarque = txtRemarque.Text;
            gi.SaveChanges();
            MessageBox.Show("votre informations a été bien modifier","Modification");
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            fe.idfe = int.Parse(cmbIdFE.Text);
            var a = (from b in gi.InfoFEs where b.idfe == fe.idfe select b).ToList();
            foreach (var item in a)
            {
                txtIdFichier.Text = item.idfichier.ToString();
                txtIdFE.Text = item.idfe.ToString();
                txtFE.Text = item.FE.ToString();
                dtpDD.Text = item.DD.ToString();
                txtTF.Text = item.TF.ToString();
                dtpDR.Text = item.DR.ToString();
                txtNR.Text = item.NR.ToString();
                txtDR.Text = item.DRF.ToString();
                txtRemarque.Text = item.remarque.ToString();
            }
        }
    }
}
