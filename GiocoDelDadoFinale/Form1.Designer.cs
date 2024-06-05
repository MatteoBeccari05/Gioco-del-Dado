namespace GiocoDelDado
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNumRound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cartaGiocatore2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGiocatore1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnLancioDadi = new System.Windows.Forms.Button();
            this.btnInizia = new System.Windows.Forms.Button();
            this.cartaGiocatore1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPunti1 = new System.Windows.Forms.Label();
            this.lblGiocatore2 = new System.Windows.Forms.Label();
            this.lblVincitore = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPunti2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartaGiocatore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaGiocatore1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblNumRound
            // 
            this.lblNumRound.AutoSize = true;
            this.lblNumRound.BackColor = System.Drawing.Color.Transparent;
            this.lblNumRound.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRound.Location = new System.Drawing.Point(529, 45);
            this.lblNumRound.Name = "lblNumRound";
            this.lblNumRound.Size = new System.Drawing.Size(41, 41);
            this.lblNumRound.TabIndex = 15;
            this.lblNumRound.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "ROUND ATTUALE";
            // 
            // cartaGiocatore2
            // 
            this.cartaGiocatore2.BackColor = System.Drawing.Color.Transparent;
            this.cartaGiocatore2.Image = ((System.Drawing.Image)(resources.GetObject("cartaGiocatore2.Image")));
            this.cartaGiocatore2.Location = new System.Drawing.Point(746, 346);
            this.cartaGiocatore2.Name = "cartaGiocatore2";
            this.cartaGiocatore2.Size = new System.Drawing.Size(172, 157);
            this.cartaGiocatore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaGiocatore2.TabIndex = 9;
            this.cartaGiocatore2.TabStop = false;
            this.cartaGiocatore2.Click += new System.EventHandler(this.cartaGiocatore2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "ROUND PARTITA";
            // 
            // lblGiocatore1
            // 
            this.lblGiocatore1.AutoSize = true;
            this.lblGiocatore1.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore1.ForeColor = System.Drawing.Color.Black;
            this.lblGiocatore1.Location = new System.Drawing.Point(147, 115);
            this.lblGiocatore1.Name = "lblGiocatore1";
            this.lblGiocatore1.Size = new System.Drawing.Size(64, 49);
            this.lblGiocatore1.TabIndex = 7;
            this.lblGiocatore1.Text = "G1";
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.DarkGray;
            this.numericUpDown.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(620, 485);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(56, 41);
            this.numericUpDown.TabIndex = 18;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // btnLancioDadi
            // 
            this.btnLancioDadi.BackColor = System.Drawing.Color.Red;
            this.btnLancioDadi.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancioDadi.Location = new System.Drawing.Point(332, 538);
            this.btnLancioDadi.Name = "btnLancioDadi";
            this.btnLancioDadi.Size = new System.Drawing.Size(129, 50);
            this.btnLancioDadi.TabIndex = 20;
            this.btnLancioDadi.Text = "Lancia \r\nDadi";
            this.btnLancioDadi.UseVisualStyleBackColor = false;
            this.btnLancioDadi.Click += new System.EventHandler(this.btnLancioDadi_Click);
            // 
            // btnInizia
            // 
            this.btnInizia.BackColor = System.Drawing.Color.Black;
            this.btnInizia.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInizia.ForeColor = System.Drawing.Color.White;
            this.btnInizia.Location = new System.Drawing.Point(467, 538);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(127, 50);
            this.btnInizia.TabIndex = 21;
            this.btnInizia.Text = "Inizia \r\nPartita";
            this.btnInizia.UseVisualStyleBackColor = false;
            this.btnInizia.Click += new System.EventHandler(this.btnReinizia_Click);
            // 
            // cartaGiocatore1
            // 
            this.cartaGiocatore1.BackColor = System.Drawing.Color.Transparent;
            this.cartaGiocatore1.Image = ((System.Drawing.Image)(resources.GetObject("cartaGiocatore1.Image")));
            this.cartaGiocatore1.Location = new System.Drawing.Point(155, 346);
            this.cartaGiocatore1.Name = "cartaGiocatore1";
            this.cartaGiocatore1.Size = new System.Drawing.Size(172, 157);
            this.cartaGiocatore1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaGiocatore1.TabIndex = 8;
            this.cartaGiocatore1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblPunti1);
            this.panel1.Location = new System.Drawing.Point(192, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 96);
            this.panel1.TabIndex = 16;
            // 
            // lblPunti1
            // 
            this.lblPunti1.AutoSize = true;
            this.lblPunti1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti1.Location = new System.Drawing.Point(16, 18);
            this.lblPunti1.Name = "lblPunti1";
            this.lblPunti1.Size = new System.Drawing.Size(61, 63);
            this.lblPunti1.TabIndex = 3;
            this.lblPunti1.Text = "0";
            // 
            // lblGiocatore2
            // 
            this.lblGiocatore2.AutoSize = true;
            this.lblGiocatore2.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore2.ForeColor = System.Drawing.Color.Black;
            this.lblGiocatore2.Location = new System.Drawing.Point(683, 115);
            this.lblGiocatore2.Name = "lblGiocatore2";
            this.lblGiocatore2.Size = new System.Drawing.Size(74, 49);
            this.lblGiocatore2.TabIndex = 10;
            this.lblGiocatore2.Text = "G2";
            // 
            // lblVincitore
            // 
            this.lblVincitore.AutoSize = true;
            this.lblVincitore.BackColor = System.Drawing.Color.Transparent;
            this.lblVincitore.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVincitore.Location = new System.Drawing.Point(356, 254);
            this.lblVincitore.Name = "lblVincitore";
            this.lblVincitore.Size = new System.Drawing.Size(161, 31);
            this.lblVincitore.TabIndex = 22;
            this.lblVincitore.Text = "VINCITORE: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblPunti2);
            this.panel2.Location = new System.Drawing.Point(779, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 96);
            this.panel2.TabIndex = 17;
            // 
            // lblPunti2
            // 
            this.lblPunti2.AutoSize = true;
            this.lblPunti2.BackColor = System.Drawing.Color.Transparent;
            this.lblPunti2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti2.Location = new System.Drawing.Point(16, 18);
            this.lblPunti2.Name = "lblPunti2";
            this.lblPunti2.Size = new System.Drawing.Size(61, 63);
            this.lblPunti2.TabIndex = 3;
            this.lblPunti2.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblVincitore);
            this.panel3.Controls.Add(this.lblGiocatore2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.cartaGiocatore1);
            this.panel3.Controls.Add(this.btnInizia);
            this.panel3.Controls.Add(this.btnLancioDadi);
            this.panel3.Controls.Add(this.numericUpDown);
            this.panel3.Controls.Add(this.lblGiocatore1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cartaGiocatore2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblNumRound);
            this.panel3.Location = new System.Drawing.Point(-4, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1017, 623);
            this.panel3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(600, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "ESCI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 614);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gioco del Dado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartaGiocatore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaGiocatore1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblNumRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cartaGiocatore2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGiocatore1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnLancioDadi;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.PictureBox cartaGiocatore1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPunti1;
        private System.Windows.Forms.Label lblGiocatore2;
        private System.Windows.Forms.Label lblVincitore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPunti2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

