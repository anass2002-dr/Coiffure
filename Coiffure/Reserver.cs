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
        private void Reserver_Load(object sender, EventArgs e)
        {
            panel_inside.BackColor = Color.FromArgb(100, 0, 0, 0);
            lb_salon.BackColor = System.Drawing.Color.Transparent;
            lb_style.BackColor = System.Drawing.Color.Transparent;
            lb_temps.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;
            lb_prix_total.BackColor = System.Drawing.Color.Transparent;
            lb_nom_client.BackColor = System.Drawing.Color.Transparent;
            lb_nom_coiffure.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.MinDate = DateTime.Now;

            //StreamReader red = new StreamReader("Appsetting.txt");
            //chemin = red.ReadToEnd();

            //cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));

            //cn.Open();
            //SqlCommand com = new SqlCommand("select * from client where id_client=" + Program.id, cn);
            //SqlDataReader re = com.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(re);

            //txt_nom_client.DataBindings.Add("Text", dt, "nom");
            //txt_prenom.DataBindings.Add("Text", dt, "prenom");
            //txt_nom.DataBindings.Add("Text", dt, "nom");
            //txt_password.DataBindings.Add("Text", dt, "password");
            //txt_ville.DataBindings.Add("Text", dt, "ville");
            //cn.Close();
            //re.Close();
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
    }
}
