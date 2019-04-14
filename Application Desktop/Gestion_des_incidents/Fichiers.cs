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
    public partial class Fichiers : Form
    {
        Fichier fc;
        Gestion_des_incidentsEntities gi;
        public Fichiers()
        {
            InitializeComponent();
            this.gi = new Gestion_des_incidentsEntities();
            this.fc = new Fichier();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fichier fi = new Fichier();
            fi.idfichier = int.Parse(txtIdFichier.Text);
            fi.Nincident = int.Parse(txtIncident.Text);
            fi.famille = cmbFa.Text;
            fi.equipement = cmbEq.Text;
            fi.marque = cmbMa.Text;
            fi.modele = cmbMo.Text;
            fi.NP = txtNP.Text;
            fi.NS = txtNS.Text;
            fi.Servicee = txtService.Text;
            fi.Utilisateur = txtUtilisateur.Text;
            fi.NT = txtNT.Text;
            fi.DT = DateTime.Parse(dtpDD.Text);
            fi.DA = DateTime.Parse(dtpDA.Text);
            fi.DCT = DateTime.Parse(dtpDCT.Text);
            fi.DTT = int.Parse(txtDTT.Text);
            fi.remarque = txtRemarque.Text;
            gi.Fichiers.Add(fi);
            gi.SaveChanges();
            MessageBox.Show("Cette Fichier a été bien ajouter", "Ajouter");
        }

        private void Fichiers_Load(object sender, EventArgs e)
        {
            using (Gestion_des_incidentsEntities gi = new Gestion_des_incidentsEntities())
            {
                var f = (from i in gi.Familles select new {famille=i.famille1,numfamille=i.idfamille });
                cmbFa.DisplayMember = "numfamille";
                cmbFa.ValueMember = "Famille";
                cmbFa.DataSource = f.ToList();

                var eq = (from i in gi.Equipements select new { numequipement = i.idequipement, equipement = i.equipement1 });
                cmbEq.DisplayMember = "numequipement";
                cmbEq.ValueMember = "equipement";
                cmbEq.DataSource = eq.ToList();

                var m = (from i in gi.Marques select new { nummarque = i.idmarque, marque = i.marque1 });
                cmbMa.DisplayMember = "nummarque";
                cmbMa.ValueMember = "marque";
                cmbMa.DataSource = m.ToList();

                var mo = (from i in gi.Modeles select new { nummodele = i.idmodele, modele = i.modele1 });
                cmbMo.DisplayMember = "nummodele";
                cmbMo.ValueMember = "modele";
                cmbMo.DataSource = mo.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fc.idfichier=int.Parse(txtIdFichier.Text);
            var f = (from r in gi.Fichiers where r.idfichier == fc.idfichier select r).Single();
            f.famille = cmbFa.Text;
            f.famille = cmbFa.Text;
            f.equipement = cmbEq.Text;
            f.marque = cmbMa.Text;
            f.modele = cmbMo.Text;
            f.NP = txtNP.Text;
            f.NS = txtNS.Text;
            f.Servicee = txtService.Text;
            f.Utilisateur = txtUtilisateur.Text;
            f.NT = txtNT.Text;
            f.DT = DateTime.Parse(dtpDD.Text);
            f.DA = DateTime.Parse(dtpDA.Text);
            f.DCT = DateTime.Parse(dtpDCT.Text);
            f.DTT = int.Parse(txtDTT.Text);
            f.remarque = txtRemarque.Text;
            gi.SaveChanges();
            MessageBox.Show("cette fichier a été mis à jours avec succés", "Modification");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Email_au_Fournisseur ef = new Email_au_Fournisseur();
            ef.ShowDialog();
        }
    }
}
