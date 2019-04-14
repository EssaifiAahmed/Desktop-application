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
    public partial class UpdatePassword2 : Form
    {
        Gestion_des_incidentsEntities gi;
        public UpdatePassword2()
        {
            InitializeComponent();
            this.gi = new Gestion_des_incidentsEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmailUser.Text != "" && Passwordtxt.Text != "")
            {
                var a = (from b in gi.Comptes select b).ToList();
                foreach (var result in a)
                {
                    if (result.email.Equals(EmailUser.Text))
                    {
                        result.MP = Passwordtxt.Text;
                        gi.SaveChanges();
                        MessageBox.Show("votre mot de passe a bien modifier","Modification");
                    }
                }
            }
            else
            {
                MessageBox.Show("Il ne faut pas laisser les champs vides", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
