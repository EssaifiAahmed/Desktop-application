namespace Gestion_des_incidents
{
    partial class Email_au_Fournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email_au_Fournisseur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtsujet = new System.Windows.Forms.TextBox();
            this.textfrom = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bt_Close);
            this.groupBox1.Controls.Add(this.bt_send);
            this.groupBox1.Controls.Add(this.txtmessage);
            this.groupBox1.Controls.Add(this.txtsujet);
            this.groupBox1.Controls.Add(this.textfrom);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 412);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envoyer gmail au Fournisseur";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(553, 37);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(256, 26);
            this.txtpassword.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "mot de passe:";
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Image = ((System.Drawing.Image)(resources.GetObject("bt_Close.Image")));
            this.bt_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Close.Location = new System.Drawing.Point(650, 356);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(159, 49);
            this.bt_Close.TabIndex = 7;
            this.bt_Close.Text = "    Quitter";
            this.bt_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_send
            // 
            this.bt_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Image = ((System.Drawing.Image)(resources.GetObject("bt_send.Image")));
            this.bt_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_send.Location = new System.Drawing.Point(485, 356);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(159, 49);
            this.bt_send.TabIndex = 6;
            this.bt_send.Text = "Envoyer Email";
            this.bt_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmessage.Location = new System.Drawing.Point(111, 153);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(698, 154);
            this.txtmessage.TabIndex = 5;
            // 
            // txtsujet
            // 
            this.txtsujet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsujet.Location = new System.Drawing.Point(111, 114);
            this.txtsujet.Name = "txtsujet";
            this.txtsujet.Size = new System.Drawing.Size(698, 26);
            this.txtsujet.TabIndex = 4;
            // 
            // textfrom
            // 
            this.textfrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfrom.Location = new System.Drawing.Point(111, 37);
            this.textfrom.Name = "textfrom";
            this.textfrom.Size = new System.Drawing.Size(314, 26);
            this.textfrom.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(111, 75);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(698, 26);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Message :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Votre gmail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Sujet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Envoyer a :";
            // 
            // Email_au_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(841, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Email_au_Fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email_au_Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtsujet;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textfrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
    }
}