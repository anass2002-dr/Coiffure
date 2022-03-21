
namespace Coiffure
{
    partial class propos
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
            this.btnconditionc = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnconditionc
            // 
            this.btnconditionc.Location = new System.Drawing.Point(47, 56);
            this.btnconditionc.Name = "btnconditionc";
            this.btnconditionc.Size = new System.Drawing.Size(102, 27);
            this.btnconditionc.TabIndex = 0;
            this.btnconditionc.Text = "C.G.U";
            this.btnconditionc.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(47, 14);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(102, 26);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contactez-nous";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.btnconditionc);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 179);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "C.G.U";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // propos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 430);
            this.Controls.Add(this.panel1);
            this.Name = "propos";
            this.Text = "propos";
            this.Load += new System.EventHandler(this.propos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconditionc;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}