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
    public partial class Listes_des_incidents : Form
    {
        public Listes_des_incidents()
        {
            InitializeComponent();
        }

        private void bt_Validate_Click(object sender, EventArgs e)
        {
            Fichiers f = new Fichiers();
            f.ShowDialog();
        }

        private void Listes_des_incidents_Load(object sender, EventArgs e)
        {
            using (Gestion_des_incidentsEntities gi = new Gestion_des_incidentsEntities())
            {
                var incident = (from i in gi.Incidents select new {i.Nincident,i.dateR,i.typee,i.servicee,i.NC,i.descriptionn });
                dgv.DataSource = incident.ToList();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
