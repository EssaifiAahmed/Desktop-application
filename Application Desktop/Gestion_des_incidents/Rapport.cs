using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Gestion_des_incidents
{
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            using (Gestion_des_incidentsEntities gi = new Gestion_des_incidentsEntities())
            {
                var fichier = (from f in gi.Fichiers select new {f.idfichier,f.Nincident,f.famille,f.equipement,f.marque,f.modele,f.NP,f.NS,f.Servicee,f.Utilisateur,f.NT,f.DA,f.DCT,f.DTT,f.DT,f.remarque});
                dgv.DataSource = fichier.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Exel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Exel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Exel.ActiveSheet;
            Exel.Visible = true;
            ws.Cells[1, 1] = "idfichier";
            ws.Cells[1, 2] = "Nincident";
            ws.Cells[1, 3] = "famille";
            ws.Cells[1, 4] = "equipement";
            ws.Cells[1, 5] = "marque";
            ws.Cells[1, 6] = "modele";
            ws.Cells[1, 7] = "nature de panne";
            ws.Cells[1, 8] = "numero de serie";
            ws.Cells[1, 9] = "service";
            ws.Cells[1, 10] = "utilisateur";
            ws.Cells[1, 11] = "numero de ticket";
            ws.Cells[1, 12] = "date d'ouverture ticket";
            ws.Cells[1, 13] = "date d'affectation au groupe OCP";
            ws.Cells[1, 14] = "date de colture de ticket";
            ws.Cells[1, 15] = "delais de traitement ticket";
            ws.Cells[1, 16] = "Remarque";

            for (int j = 2; j <= dgv.Rows.Count; j++)
            {
                for (int i = 2; i <= 16; i++)
                {
                    ws.Cells[j, i] = dgv.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
