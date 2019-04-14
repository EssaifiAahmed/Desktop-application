using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Gestion_des_incidents
{
    public partial class Email_au_Fournisseur : Form
    {
        public Email_au_Fournisseur()
        {
            InitializeComponent();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(textfrom.Text, txtpassword.Text);
            mail.From = new MailAddress(textfrom.Text);
            mail.To.Add(new MailAddress(txtemail.Text));
            mail.Subject = txtsujet.Text;
            mail.Body = txtmessage.Text;
            client.Send(mail);
            MessageBox.Show("Votre email au fournisseur a  été bien envoyer", "Envoyer");
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
