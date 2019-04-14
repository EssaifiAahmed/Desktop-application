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
    public partial class s : Form
    {
        Gestion_des_incidentsEntities gi;
        public s()
        {
            InitializeComponent();
        }

        private void Incidents_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
            
                var s = (from S in gi.Servicees select new { numService = S.idservicee, service = S.servicee1 });
                cmbS.DisplayMember = "numservice";
                cmbS.ValueMember = "service";
                cmbS.DataSource = s.ToList();  
            
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Incident i = new Incident();
            i.Nincident = int.Parse(txtNI.Text);
            i.dateR = DateTime.Parse(dtp.Text);
            i.typee = txtType.Text;
            i.servicee = cmbS.Text;
            i.NC = txtNC.Text;
            i.descriptionn = txtDesc.Text;
            gi.Incidents.Add(i);
            gi.SaveChanges();
            MessageBox.Show("Cette incident a été bien ajouter", "Ajouter");
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
