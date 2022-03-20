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

        }

        private void panel_inside_AutoSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                //this.Size.Width = 500;
                //this.Size.Height = 500;
            }
        }
    }
}
