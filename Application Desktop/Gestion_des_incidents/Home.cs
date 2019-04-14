using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_incidents
{
    public partial class Home : Form
    {
        Gestion_des_incidentsEntities gi = new Gestion_des_incidentsEntities();
        public Home()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            t.Abort();
        }

        public void Start() 
        {
            Application.Run(new ScreenForm());
        }

        ////private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        ////{
        ////    Creer_un_compte cr = new Creer_un_compte();
        ////    cr.ShowDialog();
        ////}

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personnel_Grade g = new Personnel_Grade();
            g.ShowDialog();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.ShowDialog();
        }

        private void déclarationDesIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s i = new s();
            i.ShowDialog();
        }

        private void pesonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Personnel p = new Personnel();
            p.ShowDialog();
        }

        private void lesIncidesntsDeclarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes_des_incidents lsi = new Listes_des_incidents();
            lsi.ShowDialog();
        }

        private void informationFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fournisseur f = new Fournisseur();
            f.ShowDialog();
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapport a = new Rapport();
            a.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            espaceDAdministrationToolStripMenuItem.Enabled = false;
            espaceDeTachnicienToolStripMenuItem.Enabled = false;
            espaceDUtilisateurToolStripMenuItem.Enabled = false;
        }
       
        private void espaceDAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void espaceDUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void espaceDeTachnicienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (txtMatricule.Text != "" && txtPassword.Text != "" && cmbState.Text != null)
            {
                var a = (from b in gi.Comptes select b).ToList();
                bool login = false;
                foreach (var item in a)
                {
                    if (item.Matricule.Equals(txtMatricule.Text) && item.MP.Equals(txtPassword.Text) && item.TP.Equals(cmbState.Text))
                    {
                        if (cmbState.Text == "Admin")
                        {
                            espaceDAdministrationToolStripMenuItem.Enabled = true;
                            label1.Text = "ADM  IN :" + item.nom + " " + item.prenom.ToString();
                        }
                        else if (cmbState.Text == "Utilisateur")
                        {
                            espaceDUtilisateurToolStripMenuItem.Enabled = true;
                            label1.Text = "UTILISATEUR :" + item.nom + " " + item.prenom.ToString();
                        }
                        else if (cmbState.Text == "Technicien")
                        {
                            espaceDeTachnicienToolStripMenuItem.Enabled = true;
                            label1.Text = "TECHNICIEN :" + item.nom + " " + item.prenom.ToString();
                        }
                        login = true;
                        groupBox1.Hide();
                        break;
                    }
                }
                if (login == false)
                    MessageBox.Show("Votre informations ne sont pas correct", "Erreur Authentification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Il ne faut pas laisser les champs vide", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           UpdatePassword up = new UpdatePassword();
            up.ShowDialog();
        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            txtMatricule.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbState.Text = null;
            label1.Text = string.Empty;
            espaceDAdministrationToolStripMenuItem.Enabled = false;
            espaceDeTachnicienToolStripMenuItem.Enabled = false;
            espaceDUtilisateurToolStripMenuItem.Enabled = false;
            groupBox1.Show();
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Family f = new Family();
            f.ShowDialog();
        }

        private void equipementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipment eq = new equipment();
            eq.ShowDialog();
        }

        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.ShowDialog();
        }

        private void modéleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model m = new Model();
            m.ShowDialog();
        }
    }
}
