
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
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_salon = new System.Windows.Forms.ComboBox();
            this.cb_temps = new System.Windows.Forms.ComboBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_inside = new System.Windows.Forms.Panel();
            this.btn_reserver = new System.Windows.Forms.Button();
            this.txt_prix_total = new System.Windows.Forms.TextBox();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_nom_client = new System.Windows.Forms.TextBox();
            this.txt_nom_coiffeur = new System.Windows.Forms.TextBox();
            this.txt_nom_salon = new System.Windows.Forms.TextBox();
            this.lb_prix_total = new System.Windows.Forms.Label();
            this.lb_temps = new System.Windows.Forms.Label();
            this.lb_style = new System.Windows.Forms.Label();
            this.lb_salon = new System.Windows.Forms.Label();
            this.lb_nom_client = new System.Windows.Forms.Label();
            this.lb_nom_coiffeur = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.txt_prix_panel_right = new System.Windows.Forms.TextBox();
            this.txt_nom_style_panel_right = new System.Windows.Forms.TextBox();
            this.cb_type_style = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_temps_header = new System.Windows.Forms.Label();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.lb_salon_header = new System.Windows.Forms.Label();
            this.lb_date_header = new System.Windows.Forms.Label();
            this.lb_ville = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.panel_inside.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ville
            // 
            this.cb_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Location = new System.Drawing.Point(80, 30);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(126, 21);
            this.cb_ville.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_salon
            // 
            this.cb_salon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_salon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salon.FormattingEnabled = true;
            this.cb_salon.Location = new System.Drawing.Point(355, 32);
            this.cb_salon.Name = "cb_salon";
            this.cb_salon.Size = new System.Drawing.Size(141, 21);
            this.cb_salon.TabIndex = 5;
            // 
            // cb_temps
            // 
            this.cb_temps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_temps.FormattingEnabled = true;
            this.cb_temps.Location = new System.Drawing.Point(80, 63);
            this.cb_temps.Name = "cb_temps";
            this.cb_temps.Size = new System.Drawing.Size(126, 21);
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
            this.panel_inside.Controls.Add(this.txt_nom_coiffeur);
            this.panel_inside.Controls.Add(this.txt_nom_salon);
            this.panel_inside.Controls.Add(this.lb_prix_total);
            this.panel_inside.Controls.Add(this.lb_temps);
            this.panel_inside.Controls.Add(this.lb_style);
            this.panel_inside.Controls.Add(this.lb_salon);
            this.panel_inside.Controls.Add(this.lb_nom_client);
            this.panel_inside.Controls.Add(this.lb_nom_coiffeur);
            this.panel_inside.Location = new System.Drawing.Point(21, 37);
            this.panel_inside.Name = "panel_inside";
            this.panel_inside.Size = new System.Drawing.Size(374, 275);
            this.panel_inside.TabIndex = 14;
            // 
            // btn_reserver
            // 
            this.btn_reserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.btn_reserver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reserver.FlatAppearance.BorderSize = 0;
            this.btn_reserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_reserver.Image = global::Coiffure.Properties.Resources.reserve_24px_2;
            this.btn_reserver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reserver.Location = new System.Drawing.Point(231, 226);
            this.btn_reserver.Name = "btn_reserver";
            this.btn_reserver.Size = new System.Drawing.Size(126, 23);
            this.btn_reserver.TabIndex = 13;
            this.btn_reserver.Text = "Reserver";
            this.btn_reserver.UseVisualStyleBackColor = false;
            this.btn_reserver.Visible = false;
            this.btn_reserver.Click += new System.EventHandler(this.btn_reserver_Click);
            // 
            // txt_prix_total
            // 
            this.txt_prix_total.Enabled = false;
            this.txt_prix_total.Location = new System.Drawing.Point(138, 175);
            this.txt_prix_total.Multiline = true;
            this.txt_prix_total.Name = "txt_prix_total";
            this.txt_prix_total.Size = new System.Drawing.Size(219, 20);
            this.txt_prix_total.TabIndex = 12;
            // 
            // txt_temps
            // 
            this.txt_temps.Enabled = false;
            this.txt_temps.Location = new System.Drawing.Point(138, 140);
            this.txt_temps.Multiline = true;
            this.txt_temps.Name = "txt_temps";
            this.txt_temps.Size = new System.Drawing.Size(219, 20);
            this.txt_temps.TabIndex = 11;
            // 
            // txt_style
            // 
            this.txt_style.Enabled = false;
            this.txt_style.Location = new System.Drawing.Point(138, 105);
            this.txt_style.Multiline = true;
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(219, 20);
            this.txt_style.TabIndex = 10;
            // 
            // txt_nom_client
            // 
            this.txt_nom_client.Enabled = false;
            this.txt_nom_client.Location = new System.Drawing.Point(138, 75);
            this.txt_nom_client.Multiline = true;
            this.txt_nom_client.Name = "txt_nom_client";
            this.txt_nom_client.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_client.TabIndex = 9;
            // 
            // txt_nom_coiffeur
            // 
            this.txt_nom_coiffeur.Enabled = false;
            this.txt_nom_coiffeur.Location = new System.Drawing.Point(138, 45);
            this.txt_nom_coiffeur.Multiline = true;
            this.txt_nom_coiffeur.Name = "txt_nom_coiffeur";
            this.txt_nom_coiffeur.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_coiffeur.TabIndex = 8;
            // 
            // txt_nom_salon
            // 
            this.txt_nom_salon.Enabled = false;
            this.txt_nom_salon.Location = new System.Drawing.Point(138, 15);
            this.txt_nom_salon.Multiline = true;
            this.txt_nom_salon.Name = "txt_nom_salon";
            this.txt_nom_salon.Size = new System.Drawing.Size(219, 20);
            this.txt_nom_salon.TabIndex = 7;
            // 
            // lb_prix_total
            // 
            this.lb_prix_total.AutoSize = true;
            this.lb_prix_total.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prix_total.Location = new System.Drawing.Point(11, 175);
            this.lb_prix_total.Name = "lb_prix_total";
            this.lb_prix_total.Size = new System.Drawing.Size(87, 17);
            this.lb_prix_total.TabIndex = 6;
            this.lb_prix_total.Text = "Le prix total :";
            // 
            // lb_temps
            // 
            this.lb_temps.AutoSize = true;
            this.lb_temps.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temps.Location = new System.Drawing.Point(11, 143);
            this.lb_temps.Name = "lb_temps";
            this.lb_temps.Size = new System.Drawing.Size(70, 17);
            this.lb_temps.TabIndex = 5;
            this.lb_temps.Text = "Le temps :";
            // 
            // lb_style
            // 
            this.lb_style.AutoSize = true;
            this.lb_style.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_style.Location = new System.Drawing.Point(11, 111);
            this.lb_style.Name = "lb_style";
            this.lb_style.Size = new System.Drawing.Size(96, 17);
            this.lb_style.TabIndex = 4;
            this.lb_style.Text = "Nom de style :";
            // 
            // lb_salon
            // 
            this.lb_salon.AutoSize = true;
            this.lb_salon.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salon.Location = new System.Drawing.Point(11, 15);
            this.lb_salon.Name = "lb_salon";
            this.lb_salon.Size = new System.Drawing.Size(102, 17);
            this.lb_salon.TabIndex = 3;
            this.lb_salon.Text = "Nom de salon :";
            // 
            // lb_nom_client
            // 
            this.lb_nom_client.AutoSize = true;
            this.lb_nom_client.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom_client.Location = new System.Drawing.Point(11, 79);
            this.lb_nom_client.Name = "lb_nom_client";
            this.lb_nom_client.Size = new System.Drawing.Size(101, 17);
            this.lb_nom_client.TabIndex = 2;
            this.lb_nom_client.Text = "Nom de client :";
            // 
            // lb_nom_coiffeur
            // 
            this.lb_nom_coiffeur.AutoSize = true;
            this.lb_nom_coiffeur.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom_coiffeur.Location = new System.Drawing.Point(11, 47);
            this.lb_nom_coiffeur.Name = "lb_nom_coiffeur";
            this.lb_nom_coiffeur.Size = new System.Drawing.Size(115, 17);
            this.lb_nom_coiffeur.TabIndex = 1;
            this.lb_nom_coiffeur.Text = "Nom de coiffeur :";
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
            this.panel_right.Location = new System.Drawing.Point(423, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(293, 329);
            this.panel_right.TabIndex = 0;
            // 
            // txt_prix_panel_right
            // 
            this.txt_prix_panel_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_prix_panel_right.Enabled = false;
            this.txt_prix_panel_right.Location = new System.Drawing.Point(157, 272);
            this.txt_prix_panel_right.Name = "txt_prix_panel_right";
            this.txt_prix_panel_right.Size = new System.Drawing.Size(124, 20);
            this.txt_prix_panel_right.TabIndex = 12;
            // 
            // txt_nom_style_panel_right
            // 
            this.txt_nom_style_panel_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_nom_style_panel_right.Enabled = false;
            this.txt_nom_style_panel_right.Location = new System.Drawing.Point(157, 227);
            this.txt_nom_style_panel_right.Name = "txt_nom_style_panel_right";
            this.txt_nom_style_panel_right.Size = new System.Drawing.Size(124, 20);
            this.txt_nom_style_panel_right.TabIndex = 11;
            // 
            // cb_type_style
            // 
            this.cb_type_style.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_type_style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_style.FormattingEnabled = true;
            this.cb_type_style.Location = new System.Drawing.Point(13, 37);
            this.cb_type_style.Name = "cb_type_style";
            this.cb_type_style.Size = new System.Drawing.Size(268, 21);
            this.cb_type_style.TabIndex = 10;
            this.cb_type_style.SelectedIndexChanged += new System.EventHandler(this.cb_type_style_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Image = global::Coiffure.Properties.Resources.hair_clip_24px;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(12, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "type de style :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Image = global::Coiffure.Properties.Resources.expensive_price_24px;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(26, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Le prix de style :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Image = global::Coiffure.Properties.Resources.barber_scissors_24px;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(30, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom de style :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::Coiffure.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(13, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_temps_header
            // 
            this.lb_temps_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temps_header.Image = global::Coiffure.Properties.Resources.clock_24px;
            this.lb_temps_header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_temps_header.Location = new System.Drawing.Point(6, 61);
            this.lb_temps_header.Name = "lb_temps_header";
            this.lb_temps_header.Size = new System.Drawing.Size(77, 21);
            this.lb_temps_header.TabIndex = 7;
            this.lb_temps_header.Text = "temps :";
            this.lb_temps_header.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.btn_rechercher.FlatAppearance.BorderSize = 0;
            this.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rechercher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_rechercher.Image = global::Coiffure.Properties.Resources.search_more_24px;
            this.btn_rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rechercher.Location = new System.Drawing.Point(570, 61);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(134, 23);
            this.btn_rechercher.TabIndex = 6;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // lb_salon_header
            // 
            this.lb_salon_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_salon_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salon_header.Image = global::Coiffure.Properties.Resources.barber_chair_24px;
            this.lb_salon_header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_salon_header.Location = new System.Drawing.Point(212, 29);
            this.lb_salon_header.Name = "lb_salon_header";
            this.lb_salon_header.Size = new System.Drawing.Size(137, 29);
            this.lb_salon_header.TabIndex = 2;
            this.lb_salon_header.Text = "Salon de coiffure :";
            this.lb_salon_header.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_date_header
            // 
            this.lb_date_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_date_header.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_header.Image = global::Coiffure.Properties.Resources.pay_date_24px;
            this.lb_date_header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_date_header.Location = new System.Drawing.Point(502, 33);
            this.lb_date_header.Name = "lb_date_header";
            this.lb_date_header.Size = new System.Drawing.Size(79, 25);
            this.lb_date_header.TabIndex = 1;
            this.lb_date_header.Text = "La date :";
            this.lb_date_header.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_ville
            // 
            this.lb_ville.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ville.Image = global::Coiffure.Properties.Resources.city_24px;
            this.lb_ville.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ville.Location = new System.Drawing.Point(3, 25);
            this.lb_ville.Name = "lb_ville";
            this.lb_ville.Size = new System.Drawing.Size(71, 30);
            this.lb_ville.TabIndex = 0;
            this.lb_ville.Text = "Ville :";
            this.lb_ville.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel_header.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_inside.ResumeLayout(false);
            this.panel_inside.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_nom_coiffeur;
        private System.Windows.Forms.TextBox txt_nom_salon;
        private System.Windows.Forms.Label lb_prix_total;
        private System.Windows.Forms.Label lb_temps;
        private System.Windows.Forms.Label lb_style;
        private System.Windows.Forms.Label lb_salon;
        private System.Windows.Forms.Label lb_nom_client;
        private System.Windows.Forms.Label lb_nom_coiffeur;
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