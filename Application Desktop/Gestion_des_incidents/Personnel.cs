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
    public partial class Personnel : Form
    {
        Compte cp;
        Gestion_des_incidentsEntities gi;
        public Personnel()
        {
            InitializeComponent();
            this.gi = new Gestion_des_incidentsEntities();
            this.cp = new Compte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cp.Matricule = txtMatricule.Text;
            var f = (from j in gi.Comptes where j.Matricule == cp.Matricule select j).Single();
            f.nom = txtNom.Text;
            f.prenom = txtPrenom.Text;
            f.email = txtEmail.Text;
            f.tel = txtTelephone.Text;
            f.TP = cmbState.Text;
            f.grade = cmbG.Text;
            f.fonction = cmbF.Text;
            f.Profilee = cmbP.Text;
            f.MP = txtpassword.Text;
            f.servicee = cmbS.Text;
            gi.SaveChanges();
            this.show();
            MessageBox.Show("Ce compte a été mis à jour avec succès", "Mis à jour");
        }

        private void Personnel_Load(object sender, EventArgs e)
        {
            Gestion_des_incidentsEntities gi = new Gestion_des_incidentsEntities();
            this.show();
            var d = (from c in gi.Comptes select new {matricule=c.Matricule });
            cmbMatricule.DisplayMember = "matricule";
            cmbMatricule.DataSource = d.ToList();
            var l = (from b in gi.Grades select new { idGrade = b.idgrade, Grade = b.grade1 });
            cmbG.DisplayMember = "idgrade";
            cmbG.ValueMember = "Grade";
            cmbG.DataSource = l.ToList();
            var s = (from S in gi.Servicees select new { idService = S.idservicee, service = S.servicee1 });
            cmbS.DisplayMember = "idService";
            cmbS.ValueMember = "Service";
            cmbS.DataSource = s.ToList();
        }

        private void show() 
        {
            var a = (from b in gi.Comptes select new {b.Matricule,b.nom,b.prenom,b.email,b.tel,b.TP,b.grade,b.fonction,b.Profilee,b.MP,b.servicee });
            dgv.DataSource = a.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMatricule.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtpassword.Text = string.Empty;
            cmbState.Text = null;
            cmbF.Text = null;
            cmbG.Text = null;
            cmbP.Text = null;
            cmbS.Text = null;
            cmbMatricule.Text = null;
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
           
            Compte p = new Compte();
            p.Matricule = txtMatricule.Text;
            p.nom = txtNom.Text;
            p.prenom = txtPrenom.Text;
            p.email = txtEmail.Text;
            p.tel = txtTelephone.Text;
            p.TP = cmbState.Text;
            p.MP = txtpassword.Text;
            p.fonction = cmbF.Text;
            p.servicee = cmbS.Text;
            p.grade = cmbG.Text;
            p.Profilee = cmbP.Text;
            gi.Comptes.Add(p);
            gi.SaveChanges();
            this.show();
            MessageBox.Show("your account was saved successfully", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            cp.Matricule = cmbMatricule.Text;
            var result = (from g in gi.Comptes where g.Matricule == cp.Matricule select new {g.Matricule,g.nom,g.prenom,g.email,g.tel,g.TP,g.grade,g.fonction,g.Profilee,g.MP,g.servicee });
            foreach (var item in result)
            {
                txtMatricule.Text = item.Matricule.ToString();
                txtNom.Text = item.nom.ToString();
                txtPrenom.Text = item.prenom.ToString();
                txtEmail.Text = item.email.ToString();
                txtTelephone.Text = item.tel.ToString();
                cmbState.Text = item.TP.ToString();
                cmbG.Text = item.grade.ToString();
                cmbF.Text = item.fonction.ToString();
                cmbP.Text = item.Profilee.ToString();
                txtpassword.Text = item.MP.ToString();
                cmbS.Text = item.servicee.ToString();  
            }
            dgv.DataSource = result.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            cp.Matricule = txtMatricule.Text;
            var f = (from j in gi.Comptes where j.Matricule == cp.Matricule select j).FirstOrDefault();
            gi.Comptes.Remove(f);
            gi.SaveChanges();
            this.Show();
            MessageBox.Show("Ce compte a été supprimer avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
