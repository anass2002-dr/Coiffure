using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Coiffure
{
    public partial class Reserver : Form
    {
        public Reserver()
        {
            InitializeComponent();
        }
        string chemin = "";
        SqlConnection cn;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        private void Reserver_Load(object sender, EventArgs e)
        {
            panel_inside.BackColor = Color.FromArgb(100, 0, 0, 0);
            lb_salon.BackColor = System.Drawing.Color.Transparent;
            lb_style.BackColor = System.Drawing.Color.Transparent;
            lb_temps.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;
            lb_prix_total.BackColor = System.Drawing.Color.Transparent;
            lb_nom_client.BackColor = System.Drawing.Color.Transparent;
            lb_nom_coiffeur.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.MinDate = DateTime.Now;

            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            //client
            cn.Open();
            SqlCommand com = new SqlCommand("select * from client where id_client=" + Program.id, cn);
            SqlDataReader re = com.ExecuteReader();
            
            dt1.Load(re);

            txt_nom_client.DataBindings.Add("Text", dt1, "nom");
            //txt_prenom.DataBindings.Add("Text", dt, "prenom");
            //txt_nom.DataBindings.Add("Text", dt, "nom");
            //txt_password.DataBindings.Add("Text", dt, "password");
            //txt_ville.DataBindings.Add("Text", dt, "ville");
            cn.Close();
            re.Close();

            //coiffure
            cn.Open();
            SqlCommand com2 = new SqlCommand("select * from coiffure c inner join ville v on c.id_ville=v.id_ville inner join coiffeur" +
                "cr on cr.id_coiffeur=c.id_coiffeur" + Program.id, cn);
            SqlDataReader re2 = com.ExecuteReader();
            dt2.Load(re2);
            cb_salon.DisplayMember = "salon";
            cb_salon.ValueMember = "id_coiffure";
            cb_salon.DataSource = dt2;

            cb_ville.DisplayMember = "ville";
            cb_ville.ValueMember = "id_coiffure";
            cb_ville.DataSource = dt2;

            cn.Close();
            re2.Close();

            //style
            cn.Open();
            SqlCommand com3 = new SqlCommand("select * from style_coiffure" + Program.id, cn);
            SqlDataReader re3 = com.ExecuteReader();
            dt3.Load(re3);
            cb_type_style.DisplayMember ="nom_style";
            cb_type_style.ValueMember = "id_style";
            cb_type_style.DataSource = dt3;

            txt_nom_style_panel_right.DataBindings.Add("Text", dt3, "nom_style");
            txt_prix_panel_right.DataBindings.Add("Text", dt3, "prix");

            txt_style.DataBindings.Add("Text", dt3, "nom_style");
            txt_prix_total.DataBindings.Add("Text", dt3, "prix");
            cn.Close();
            re3.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_type_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string chemin = @"C:\Users\bismilah\Desktop\mini_projet\Coiffure\images\2.jpg";
            //int indix = cb_type_style.SelectedIndex+1;
            //pictureBox1.Image = Bitmap.FromFile(chemin);
            //pictureBox1.ImageLocation = @"C:\Users\bismilah\Desktop\mini_projet\Coiffure\images\1.jpg";
        }

        private void btn_reserver_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {

        }
    }
}
