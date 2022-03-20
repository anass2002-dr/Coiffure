
namespace Coiffure
{
    partial class Reserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_inside = new System.Windows.Forms.Panel();
            this.btn_reserver = new System.Windows.Forms.Button();
            this.txt_prix_total = new System.Windows.Forms.TextBox();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_nom_client = new System.Windows.Forms.TextBox();
            this.txt_nom_coiffure = new System.Windows.Forms.TextBox();
            this.txt_nom_salon = new System.Windows.Forms.TextBox();
            this.lb_prix_total = new System.Windows.Forms.Label();
            this.lb_temps = new System.Windows.Forms.Label();
            this.lb_style = new System.Windows.Forms.Label();
            this.lb_salon = new System.Windows.Forms.Label();
            this.lb_nom_client = new System.Windows.Forms.Label();
            this.lb_nom_coiffure = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.txt_prix_panel_right = new System.Windows.Forms.TextBox();
            this.txt_nom_style_panel_right = new System.Windows.Forms.TextBox();
            this.cb_type_style = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ville = new System.Windows.Forms.Label();
            this.lb_date_header = new System.Windows.Forms.Label();
            this.lb_salon_header = new System.Windows.Forms.Label();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_salon = new System.Windows.Forms.ComboBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.lb_temps_header = new System.Windows.Forms.Label();
            this.cb_temps = new System.Windows.Forms.ComboBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_body.SuspendLayout();
            this.panel_inside.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.BackgroundImage = global::Coiffure.Properties.Resources.pexels_josh_sorenson_9953001;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.Controls.Add(this.panel_inside);
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 100);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(716, 329);
            this.panel_body.TabIndex = 1;
            // 
            // panel_inside
            // 
            this.panel_inside.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_inside.BackColor = System.Drawing.Color.Silver;
            this.panel_inside.Controls.Add(this.btn_reserver);
            this.panel_inside.Controls.Add(this.txt_prix_total);
            this.panel_inside.Controls.Add(this.txt_temps);
            this.panel_inside.Controls.Add(this.txt_style);
            this.panel_inside.Controls.Add(this.txt_nom_client);
            this.panel_inside.Controls.Add(this.txt_nom_coiffure);
            this.panel_inside.Controls.Add(this.txt_nom_salon);
            this.panel_inside.Controls.Add(this.lb_prix_total);
            this.panel_inside.Controls.Add(this.lb_temps);
            this.panel_inside.Controls.Add(this.lb_style);
            this.panel_inside.Controls.Add(this.lb_salon);
            this.panel_inside.Controls.Add(this.lb_nom_client);
            this.panel_inside.Controls.Add(this.lb_nom_coiffure);
            this.panel_inside.Location = new System.Drawing.Point(21, 37);
            this.panel_inside.Name = "panel_inside";
            this.panel_inside.Size = new System.Drawing.Size(362, 275);
            this.panel_inside.TabIndex = 14;
            this.panel_inside.AutoSizeChanged += new System.EventHandler(this.panel_inside_AutoSizeChanged);
            // 
            // btn_reserver
            // 
            this.btn_reserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btn_reserver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reserver.FlatAppearance.BorderSize = 0;
            this.btn_reserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_reserver.Location = new System.Drawing.Point(237, 221);
            this.btn_reserver.Name = "btn_reserver";
            this.btn_reserver.Size = new System.Drawing.Size(105, 23);
            this.btn_reserver.TabIndex = 13;
            this.btn_reserver.Text = "Reserver";
            this.btn_reserver.UseVisualStyleBackColor = false;
            // 
            // txt_prix_total
            // 
            this.txt_prix_total.Location = new System.Drawing.Point(123, 175);
            this.txt_prix_total.Multiline = true;
            this.txt_prix_total.Name = "txt_prix_total";
            this.txt_prix_total.Size = new System.Drawing.Size(219, 20);
            this.txt_prix_total.TabIndex = 12;
            // 
            // txt_temps
            // 
            this.txt_temps.Location = new System.Drawing.Point(123, 140);
            this.txt_temps.Multiline = true;
            this.txt_temps.Name = "txt_temps";
            this.txt_temps.Size = new System.Drawing.Size(219, 20);
            this.txt_temps.TabIndex = 11;
            // 
            // txt_style
            // 
            this.txt_style.Location = new System.Drawing.Point(123, 105);
            this.txt_style.Multiline = true;
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(219, 20);
            this.txt_style.TabIndex = 10;
            // 
            // txt_nom_client
            // 
            this.txt_nom_client.Location = new System.Drawing.Point(123, 75);
            this.txt_nom_client.Multiline = true;
            this.txt_nom_client.Name = "txt_nom_client";
            this.txt_nom_client.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_client.TabIndex = 9;
            // 
            // txt_nom_coiffure
            // 
            this.txt_nom_coiffure.Location = new System.Drawing.Point(123, 45);
            this.txt_nom_coiffure.Multiline = true;
            this.txt_nom_coiffure.Name = "txt_nom_coiffure";
            this.txt_nom_coiffure.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_coiffure.TabIndex = 8;
            // 
            // txt_nom_salon
            // 
            this.txt_nom_salon.Location = new System.Drawing.Point(123, 15);
            this.txt_nom_salon.Multiline = true;
            this.txt_nom_salon.Name = "txt_nom_salon";
            this.txt_nom_salon.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_salon.TabIndex = 7;
            // 
            // lb_prix_total
            // 
            this.lb_prix_total.AutoSize = true;
            this.lb_prix_total.Location = new System.Drawing.Point(11, 175);
            this.lb_prix_total.Name = "lb_prix_total";
            this.lb_prix_total.Size = new System.Drawing.Size(67, 13);
            this.lb_prix_total.TabIndex = 6;
            this.lb_prix_total.Text = "Le prix total :";
            // 
            // lb_temps
            // 
            this.lb_temps.AutoSize = true;
            this.lb_temps.Location = new System.Drawing.Point(11, 143);
            this.lb_temps.Name = "lb_temps";
            this.lb_temps.Size = new System.Drawing.Size(56, 13);
            this.lb_temps.TabIndex = 5;
            this.lb_temps.Text = "Le temps :";
            // 
            // lb_style
            // 
            this.lb_style.AutoSize = true;
            this.lb_style.Location = new System.Drawing.Point(11, 111);
            this.lb_style.Name = "lb_style";
            this.lb_style.Size = new System.Drawing.Size(74, 13);
            this.lb_style.TabIndex = 4;
            this.lb_style.Text = "Nom de style :";
            // 
            // lb_salon
            // 
            this.lb_salon.AutoSize = true;
            this.lb_salon.Location = new System.Drawing.Point(11, 15);
            this.lb_salon.Name = "lb_salon";
            this.lb_salon.Size = new System.Drawing.Size(78, 13);
            this.lb_salon.TabIndex = 3;
            this.lb_salon.Text = "Nom de salon :";
            // 
            // lb_nom_client
            // 
            this.lb_nom_client.AutoSize = true;
            this.lb_nom_client.Location = new System.Drawing.Point(11, 79);
            this.lb_nom_client.Name = "lb_nom_client";
            this.lb_nom_client.Size = new System.Drawing.Size(78, 13);
            this.lb_nom_client.TabIndex = 2;
            this.lb_nom_client.Text = "Nom de client :";
            // 
            // lb_nom_coiffure
            // 
            this.lb_nom_coiffure.AutoSize = true;
            this.lb_nom_coiffure.Location = new System.Drawing.Point(11, 47);
            this.lb_nom_coiffure.Name = "lb_nom_coiffure";
            this.lb_nom_coiffure.Size = new System.Drawing.Size(88, 13);
            this.lb_nom_coiffure.TabIndex = 1;
            this.lb_nom_coiffure.Text = "Nom de coiffure :";
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel_right.Controls.Add(this.txt_prix_panel_right);
            this.panel_right.Controls.Add(this.txt_nom_style_panel_right);
            this.panel_right.Controls.Add(this.cb_type_style);
            this.panel_right.Controls.Add(this.label7);
            this.panel_right.Controls.Add(this.label6);
            this.panel_right.Controls.Add(this.label5);
            this.panel_right.Controls.Add(this.pictureBox1);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(440, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(276, 329);
            this.panel_right.TabIndex = 0;
            // 
            // txt_prix_panel_right
            // 
            this.txt_prix_panel_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_prix_panel_right.Location = new System.Drawing.Point(124, 243);
            this.txt_prix_panel_right.Name = "txt_prix_panel_right";
            this.txt_prix_panel_right.Size = new System.Drawing.Size(124, 20);
            this.txt_prix_panel_right.TabIndex = 12;
            // 
            // txt_nom_style_panel_right
            // 
            this.txt_nom_style_panel_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_nom_style_panel_right.Location = new System.Drawing.Point(124, 198);
            this.txt_nom_style_panel_right.Name = "txt_nom_style_panel_right";
            this.txt_nom_style_panel_right.Size = new System.Drawing.Size(124, 20);
            this.txt_nom_style_panel_right.TabIndex = 11;
            // 
            // cb_type_style
            // 
            this.cb_type_style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_style.FormattingEnabled = true;
            this.cb_type_style.Location = new System.Drawing.Point(97, 18);
            this.cb_type_style.Name = "cb_type_style";
            this.cb_type_style.Size = new System.Drawing.Size(144, 21);
            this.cb_type_style.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "type de style :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Le prix de style :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom de style :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coiffure.Properties.Resources.pexels_josh_sorenson_995300;
            this.pictureBox1.Location = new System.Drawing.Point(20, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ville
            // 
            this.lb_ville.AutoSize = true;
            this.lb_ville.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ville.Location = new System.Drawing.Point(12, 33);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(38, 16);
            this.lb_ville.TabIndex = 0;
            this.lb_ville.Text = "Ville :";
            // 
            // lb_date_header
            // 
            this.lb_date_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_date_header.AutoSize = true;
            this.lb_date_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_header.Location = new System.Drawing.Point(502, 33);
            this.lb_date_header.Name = "lb_date_header";
            this.lb_date_header.Size = new System.Drawing.Size(56, 16);
            this.lb_date_header.TabIndex = 1;
            this.lb_date_header.Text = "La date :";
            // 
            // lb_salon_header
            // 
            this.lb_salon_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_salon_header.AutoSize = true;
            this.lb_salon_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salon_header.Location = new System.Drawing.Point(239, 33);
            this.lb_salon_header.Name = "lb_salon_header";
            this.lb_salon_header.Size = new System.Drawing.Size(110, 16);
            this.lb_salon_header.TabIndex = 2;
            this.lb_salon_header.Text = "Salon de coiffure :";
            // 
            // cb_ville
            // 
            this.cb_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Location = new System.Drawing.Point(89, 30);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(144, 21);
            this.cb_ville.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cb_salon
            // 
            this.cb_salon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_salon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salon.FormattingEnabled = true;
            this.cb_salon.Location = new System.Drawing.Point(349, 32);
            this.cb_salon.Name = "cb_salon";
            this.cb_salon.Size = new System.Drawing.Size(144, 21);
            this.cb_salon.TabIndex = 5;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rechercher.Location = new System.Drawing.Point(574, 61);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(134, 23);
            this.btn_rechercher.TabIndex = 6;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            // 
            // lb_temps_header
            // 
            this.lb_temps_header.AutoSize = true;
            this.lb_temps_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temps_header.Location = new System.Drawing.Point(12, 66);
            this.lb_temps_header.Name = "lb_temps_header";
            this.lb_temps_header.Size = new System.Drawing.Size(62, 16);
            this.lb_temps_header.TabIndex = 7;
            this.lb_temps_header.Text = "le temps :";
            // 
            // cb_temps
            // 
            this.cb_temps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_temps.FormattingEnabled = true;
            this.cb_temps.Location = new System.Drawing.Point(89, 61);
            this.cb_temps.Name = "cb_temps";
            this.cb_temps.Size = new System.Drawing.Size(144, 21);
            this.cb_temps.TabIndex = 8;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.panel_header.Controls.Add(this.cb_temps);
            this.panel_header.Controls.Add(this.lb_temps_header);
            this.panel_header.Controls.Add(this.btn_rechercher);
            this.panel_header.Controls.Add(this.cb_salon);
            this.panel_header.Controls.Add(this.dateTimePicker1);
            this.panel_header.Controls.Add(this.cb_ville);
            this.panel_header.Controls.Add(this.lb_salon_header);
            this.panel_header.Controls.Add(this.lb_date_header);
            this.panel_header.Controls.Add(this.lb_ville);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(716, 100);
            this.panel_header.TabIndex = 0;
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 429);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserver";
            this.Text = "Reserver";
            this.Load += new System.EventHandler(this.Reserver_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_inside.ResumeLayout(false);
            this.panel_inside.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.ComboBox cb_type_style;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_prix_total;
        private System.Windows.Forms.TextBox txt_temps;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.TextBox txt_nom_client;
        private System.Windows.Forms.TextBox txt_nom_coiffure;
        private System.Windows.Forms.TextBox txt_nom_salon;
        private System.Windows.Forms.Label lb_prix_total;
        private System.Windows.Forms.Label lb_temps;
        private System.Windows.Forms.Label lb_style;
        private System.Windows.Forms.Label lb_salon;
        private System.Windows.Forms.Label lb_nom_client;
        private System.Windows.Forms.Label lb_nom_coiffure;
        private System.Windows.Forms.TextBox txt_prix_panel_right;
        private System.Windows.Forms.TextBox txt_nom_style_panel_right;
        private System.Windows.Forms.Button btn_reserver;
        private System.Windows.Forms.Panel panel_inside;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Label lb_date_header;
        private System.Windows.Forms.Label lb_salon_header;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_salon;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label lb_temps_header;
        private System.Windows.Forms.ComboBox cb_temps;
        private System.Windows.Forms.Panel panel_header;
    }
}