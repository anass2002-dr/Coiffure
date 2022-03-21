using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coiffure
{
    public partial class conecter : Form
    {
        string cs = @"Data Source =DESKTOP-U2EH85I\SQL ;initial catalog=salon ;user id=sa;password=123456";
        public conecter()
        {
            InitializeComponent();
        }
        bool p = false;
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        bool exist = false;
        string chemine = @"Data Source=DESKTOP-AD61IOL\SQLEXPRESS;Initial Catalog=salon;User ID=sa;Password=123456";
        private void txt_email_MouseClick(object sender, MouseEventArgs e)
        {
            //if (p == false)
            //{
            //    txt_email.Text = "";
            //    p = true;
            //}
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            //if (txt_password.PasswordChar != '*')
            //{
            //    txt_password.Text = "";
            //    txt_password.PasswordChar = '*';
            //}

            
        }

        private void conecter_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            lb_coneceter.BackColor = System.Drawing.Color.Transparent;
            panel_email.BackColor = System.Drawing.Color.Transparent;
            panel_password.BackColor = System.Drawing.Color.Transparent;
            btn_close.BackColor = System.Drawing.Color.Transparent;
            //btn_conecter.BackColor = System.Drawing.Color.Transparent;
            btn_oublier.BackColor = System.Drawing.Color.Transparent;
            txt_email.BackColor = this.BackColor;
            txt_password.BackColor = this.BackColor;
            lk_incrire.BackColor = System.Drawing.Color.Transparent;
            lb_compte_non.BackColor = System.Drawing.Color.Transparent;
            //btn_conecter.ForeColor = Color.LightSeaGreen;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conecter_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(chemine);
            cn.Open();
            SqlCommand com = new SqlCommand("select * from client where email like '"+txt_email.Text+"'", cn);
            SqlDataReader re = com.ExecuteReader();
            while (re.Read())
            {

                exist = true;
            }
            if (exist)
            {
                if (re["password"].ToString() == txt_password.Text)
                {

                }
            }
            //if (txt_email.Text == ds.Tables["client"].["email"])
            //{

            //}           


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lk_incrire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form f;
            //Program.ShowForm(f = new inscrire(), "S'inscrire", panel1, Program.lb_home);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == txt_email)
            {
                if(txt_email.Text== "Entrez Votre Email")
                {
                    txt_email.Text = "";
                }
            }
            else
            {
                if (txt_password.Text == "Mot de passe")
                {
                    txt_password.Text = "";
                    txt_password.PasswordChar = '*';
                }
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == txt_email)
            {
                if (txt_email.Text == "")
                {
                    txt_email.Text = "Entrez Votre Email";
                }
            }
            else
            {
                if (txt_password.Text == "")
                {
                    txt_password.Text = "Mot de passe";
                    txt_password.PasswordChar = '\0';

                }
            }
        }
    }
}
