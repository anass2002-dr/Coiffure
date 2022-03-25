using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        bool modefier = false;
        private void Configuration_Load(object sender, EventArgs e)
        {

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
                active(false);
                btn_modefier_sauvgarder.Text = "Modifier";
                btn_annule.Visible = false;
                modefier = false;
            }
        }
        public void active(bool a)
        {
            txt_email.Enabled = a;
            txt_nom_prenom.Enabled = a;
            txt_password.Enabled = a;
            txt_ville.Enabled = a;
        }
        private void btn_annule_Click_1(object sender, EventArgs e)
        {
            btn_modefier_sauvgarder.Text = "Modifier";
            modefier = false;
            btn_annule.Visible = false;
        }
    }
}
