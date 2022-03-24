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
    public partial class Reserver : Form
    {
        public Reserver()
        {
            InitializeComponent();
        }

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
