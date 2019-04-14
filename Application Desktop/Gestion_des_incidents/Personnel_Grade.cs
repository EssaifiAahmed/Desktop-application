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

namespace Gestion_des_incidents
{
    public partial class Personnel_Grade : Form
    {

        Grade g;
        Gestion_des_incidentsEntities gi;
        public Personnel_Grade()
        {
            InitializeComponent();
            this.g = new Grade();
        }

        private void Personnel_Grade_Load(object sender, EventArgs e)
        {
            gi = new Gestion_des_incidentsEntities();
                var item = (from g in gi.Grades select new { numgrade = g.idgrade, grade = g.grade1 });
                cmbG.DisplayMember = "numgrade";
                cmbG.ValueMember = "grade";
                cmbG.DataSource = item.ToList();
                this.show();
        }
        public void show() 
        {
            var a = (from b in gi.Grades orderby b.idgrade select new {b.idgrade,b.grade1 });
            dgv.DataSource = a.ToList();
            
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
           
            Grade g = new Grade();
            g.idgrade = txtId.Text;
            g.grade1 = txtGrade.Text;
            gi.Grades.Add(g);
            gi.SaveChanges();
            this.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtGrade.Text = string.Empty;
            cmbG.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.idgrade = txtId.Text;
            var a = (from b in gi.Grades where b.idgrade == g.idgrade select b).FirstOrDefault();
            gi.Grades.Remove(a);
            gi.SaveChanges();
            this.show();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            g.idgrade = cmbG.Text;
            var a = (from b in gi.Grades where b.idgrade == g.idgrade select new { idGrade = b.idgrade, Grade = b.grade1 });
            dgv.DataSource = a.ToList();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.idgrade = txtId.Text;
            var result = (from z in gi.Grades where z.idgrade == g.idgrade select z).Single();
            result.grade1 = txtId.Text;
            gi.SaveChanges();
            this.show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtGrade.Text=dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
