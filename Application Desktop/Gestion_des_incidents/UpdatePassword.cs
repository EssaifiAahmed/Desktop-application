using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Gestion_des_incidents
{
    public partial class UpdatePassword : Form
    {
        Gestion_des_incidentsEntities gi;
        public UpdatePassword()
        {
            InitializeComponent();
            this.gi = new Gestion_des_incidentsEntities(); 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (EmailUser.Text != "")
            {
                var a = (from b in gi.Comptes select b).ToList();
                bool email = false;
                foreach (var result in a)
                {
                    if (result.email.Equals(EmailUser.Text))
                    {
                        UpdatePassword2 p = new UpdatePassword2();
                        p.ShowDialog();
                        email = true;
                        break;
                    }
                }
                if (email == false)
                {
                    MessageBox.Show("votre email n'est pas correct");
                }
            }
            else
            {
                MessageBox.Show("Il ne fait pas laisser le champ vide", "Attention!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
