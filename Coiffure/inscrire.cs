using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class inscrire : Form
    {
        public inscrire()
        {
            InitializeComponent();
        }

        private void inscrire_Load(object sender, EventArgs e)
        {
            //btn_inscrir.BackColor = System.Drawing.Color.Transparent;
            btn_left.BackColor = System.Drawing.Color.Transparent;

            lb_nom.BackColor = System.Drawing.Color.Transparent;
            lb_confirmer.BackColor = System.Drawing.Color.Transparent;
            lb_email.BackColor = System.Drawing.Color.Transparent;
            lb_password.BackColor = System.Drawing.Color.Transparent;
            lb_prenom.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;

            //txt_confirmer.BackColor = System.Drawing.Color.Transparent;
            //txt_email.BackColor = System.Drawing.Color.Transparent;
            //txt_password.BackColor = System.Drawing.Color.Transparent;
            //txt_prenom.BackColor = System.Drawing.Color.Transparent;
            //cb_ville.BackColor = System.Drawing.Color.Transparent;

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
