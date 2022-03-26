using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Coiffure
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        bool modefier = false;
        string chemin = "";
        SqlConnection cn;
        private void Configuration_Load(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));

            if (Program.ClientVisiblity)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from client where id_client=" + Program.id, cn);
                SqlDataReader re = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(re);

                txt_email.DataBindings.Add("Text", dt, "email");
                txt_prenom.DataBindings.Add("Text", dt, "prenom");
                txt_nom.DataBindings.Add("Text", dt, "nom");
                txt_password.DataBindings.Add("Text", dt, "password");
                txt_ville.DataBindings.Add("Text", dt, "ville");
                cn.Close();
                re.Close();
                
            }
            else if (Program.CoiffeurVisiblity)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from coiffeur where id_coiffeur=" + Program.id, cn);
                SqlDataReader re = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(re);
                
                txt_email.DataBindings.Add("Text", dt, "email");
                txt_prenom.DataBindings.Add("Text", dt, "prenom");
                txt_nom.DataBindings.Add("Text", dt, "nom");
                txt_password.DataBindings.Add("Text", dt, "password");
                txt_ville.DataBindings.Add("Text", dt, "ville");
                cn.Close();
                re.Close();
            }
        }



        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_modefier_sauvgarder_Click_1(object sender, EventArgs e)
        {
            if (!modefier)
            {
                active(true);
                btn_modefier_sauvgarder.Text = "Sauvagarder";
                btn_annule.Visible = true;
                modefier = true;

            }
            else
            {
                if (vide())
                {
                    StreamReader red = new StreamReader("Appsetting.txt");
                    chemin = red.ReadToEnd();

                    cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
                    if (Program.ClientVisiblity && vide())
                    {
                        cn.Open();
                        SqlCommand com = new SqlCommand("update client set email=@email,nom=@nom,prenom=@prenom," +
                            "password=@password,ville=@ville where id_client=" + Program.id, cn);
                        com.Parameters.AddWithValue("@email", txt_email.Text);
                        com.Parameters.AddWithValue("@nom", txt_nom.Text);
                        com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                        com.Parameters.AddWithValue("@ville", txt_ville.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);

                        com.ExecuteNonQuery();
                        MessageBox.Show("la modification est bien effectue");
                        cn.Close();


                    }
                    else if (Program.CoiffeurVisiblity && vide())
                    {
                        cn.Open();
                        SqlCommand com = new SqlCommand("update coiffeur set email=@email,nom=@nom,prenom=@prenom," +
                            "password=@password,ville=@ville where id_coiffeur=" + Program.id, cn);
                        com.Parameters.AddWithValue("@email", txt_email.Text);
                        com.Parameters.AddWithValue("@nom", txt_nom.Text);
                        com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                        com.Parameters.AddWithValue("@ville", txt_ville.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("la modification est bien effectue");
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("plais remplire tout les zone !");
                }
               
                active(false);
                btn_modefier_sauvgarder.Text = "Modifier";
                btn_annule.Visible = false;
                modefier = false;
            }
        }
        public void active(bool a)
        {
            txt_email.Enabled = a;
            txt_nom.Enabled = a;
            txt_password.Enabled = a;
            txt_ville.Enabled = a;
            txt_prenom.Enabled = a;
        }
        public bool vide()
        {
            if(txt_nom.Text!="" || txt_prenom.Text != "" || txt_ville.Text != "" || txt_email.Text != "" || txt_password.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_annule_Click_1(object sender, EventArgs e)
        {
            btn_modefier_sauvgarder.Text = "Modifier";
            modefier = false;
            btn_annule.Visible = false;
            active(false);
        }
    }
}
