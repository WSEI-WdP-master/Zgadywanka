
namespace WinFormsAppGra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.textBoxMinZakres = new System.Windows.Forms.TextBox();
            this.textBoxMaxZakres = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonOcena = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(25, 33);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // textBoxMinZakres
            // 
            this.textBoxMinZakres.Location = new System.Drawing.Point(6, 22);
            this.textBoxMinZakres.Name = "textBoxMinZakres";
            this.textBoxMinZakres.Size = new System.Drawing.Size(100, 23);
            this.textBoxMinZakres.TabIndex = 1;
            this.textBoxMinZakres.Text = "1";
            // 
            // textBoxMaxZakres
            // 
            this.textBoxMaxZakres.Location = new System.Drawing.Point(6, 61);
            this.textBoxMaxZakres.Name = "textBoxMaxZakres";
            this.textBoxMaxZakres.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxZakres.TabIndex = 2;
            this.textBoxMaxZakres.Text = "100";
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(129, 41);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 3;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMaxZakres);
            this.groupBox1.Controls.Add(this.buttonWylosuj);
            this.groupBox1.Controls.Add(this.textBoxMinZakres);
            this.groupBox1.Location = new System.Drawing.Point(25, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj propozycję:";
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(138, 193);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 23);
            this.textBoxPropozycja.TabIndex = 6;
            // 
            // buttonOcena
            // 
            this.buttonOcena.Location = new System.Drawing.Point(138, 235);
            this.buttonOcena.Name = "buttonOcena";
            this.buttonOcena.Size = new System.Drawing.Size(102, 23);
            this.buttonOcena.TabIndex = 7;
            this.buttonOcena.Text = "Sprawdź";
            this.buttonOcena.UseVisualStyleBackColor = true;
            this.buttonOcena.Click += new System.EventHandler(this.buttonOcena_Click);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(31, 290);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(38, 15);
            this.labelOdpowiedz.TabIndex = 8;
            this.labelOdpowiedz.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.labelOdpowiedz);
            this.Controls.Add(this.buttonOcena);
            this.Controls.Add(this.textBoxPropozycja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.TextBox textBoxMinZakres;
        private System.Windows.Forms.TextBox textBoxMaxZakres;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Button buttonOcena;
        private System.Windows.Forms.Label labelOdpowiedz;
    }
}

