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
    public partial class conecter : Form
    {
        public conecter()
        {
            InitializeComponent();
        }
        bool p = false;

        private void txt_email_MouseClick(object sender, MouseEventArgs e)
        {
            if (p == false)
            {
                txt_email.Text = "";
                p = true;
            }
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_password.PasswordChar != '*')
            {
                txt_password.Text = "";
                txt_password.PasswordChar = '*';
            }

            
        }

        private void conecter_Load(object sender, EventArgs e)
        {
            //lb_coneceter.BackColor = System.Drawing.Color.Transparent;
            panel_email.BackColor = System.Drawing.Color.Transparent;
            panel_password.BackColor = System.Drawing.Color.Transparent;
            panel3.BackColor = System.Drawing.Color.Transparent;
            btn_close.BackColor = System.Drawing.Color.Transparent;
            //btn_conecter.BackColor = System.Drawing.Color.Transparent;
            //btn_oublier.BackColor = System.Drawing.Color.Transparent;
            txt_email.BackColor = this.BackColor;
            txt_password.BackColor = this.BackColor;
            //btn_conecter.ForeColor = Color.LightSeaGreen;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conecter_Click(object sender, EventArgs e)
        {

        }
    }
}
