﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        
        Random r = new Random();
 
        private void btn_reservation_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
    
            b.BackColor = Color.FromName("51; 51; 76");
            panel_accueil.BackColor = Color.Teal;
            panel_salon.BackColor = Color.FromName("39; 39; 56");
        }

        private void btn_reservation_MouseEnter(object sender, EventArgs e)
        {
            int ind = r.Next(Program.cr.Count);
            Button b = sender as Button;
            b.BackColor = Color.FromName(Program.cr[ind]);
            panel_accueil.BackColor = b.BackColor;
            ind = r.Next(Program.cr.Count);

            panel_salon.BackColor = Color.FromName(Program.cr[ind]);
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            int ind = r.Next(Program.cr.Count);
            Button b = sender as Button;
            b.BackColor = Color.FromName(Program.cr[ind]);
            panel_accueil.BackColor = b.BackColor;
            ind = r.Next(Program.cr.Count);

            panel_salon.BackColor = Color.FromName(Program.cr[ind]);
            Form f = new Reserver();
            if (b == btn_reservation)
            {
                ShowForm(f = new Reserver(),"Reserver");
            }
            if (b == btn_conecter)
            {
                ShowForm(f=new conecter(), "Se Connecter");
            }
            if (b == btn_inscrir)
            {
                ShowForm(f = new inscrire(), "S'inscrire");
            }
            if (b == btn_propos)
            {
                ShowForm(f = new propos(), "A propos");
            }
            if (b == btn_aide)
            {
                ShowForm(f = new aide(), "Aide");
            }
        }
        private Form activeForm = null;
        public void ShowForm(Form r,string t)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = r;
            r.TopLevel = false;
            r.FormBorderStyle = FormBorderStyle.None;
            r.Dock = DockStyle.Fill;
            panel1.Controls.Add(r);
            panel1.Tag = r;
            lb_home.Text = t;
            r.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
