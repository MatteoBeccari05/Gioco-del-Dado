using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDelDado
{
    public partial class Form1 : Form
    {
        //Dichiarazioni di attributi 
        Partita partita;
        Giocatore g1;
        Giocatore g2;
        int valore;
        Image[] facce = new Image[6];   //Array di immagini che conterrà le immagini delle facce del dado
        string[] files = Directory.GetFileSystemEntries(Environment.CurrentDirectory + "\\Immagini" + "\\Facce");  //Array per memorizzare tutti i percorsi delle immagini
        int numround = 1;

        public Form1()
        {
            InitializeComponent();
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            btnLancioDadi.Enabled = false;
            numericUpDown.Maximum = 10;
            lblVincitore.Text = string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLancioDadi.Enabled = false;
            for (int i = 0; i < facce.Length; i++)
            {
                facce[i] = Image.FromFile(files[i]);  //Inserisco i percorsi delle immagini in un array
            }
            Accesso accesso = new Accesso();
            if (accesso.ShowDialog() == DialogResult.OK)  //Form per richiedere nome e cognome
            {
                g1 = new Giocatore(accesso.Giocatore1);  //Passo i parametri dal form accesso a questo form 
                g2 = new Giocatore(accesso.Giocatore2);
                lblGiocatore1.Text = g1.Nome;
                lblGiocatore2.Text = g2.Nome;
            }
            else
            {
                Close();
            }
        }

        private void btnLancioDadi_Click(object sender, EventArgs e)
        {
            Giocatore vincitore = partita.Round();    //Partita.Round() mi ritorna il giocatore vincitore
            cartaGiocatore1.Image = facce[partita.Estratti[0] - 1];  //Inserisco l'immagine nella picture box 
            cartaGiocatore2.Image = facce[partita.Estratti[1] - 1];  //Inserisco l'immagine nella picture box 
            lblNumRound.Text = numround.ToString();

            if (vincitore != null)   
            {
                lblPunti1.Text = g1.Punti.ToString();
                lblPunti2.Text = g2.Punti.ToString();
            }

            if (partita.FineGara)  
            {
                if (g1.Punti > g2.Punti)
                {
                    vincitore = g1;     //Assegno come vincitore a g1
                    lblVincitore.Text = "VINCITORE: " + partita.Winner;  //Scrivo il vincitore
                }
                else if (g2.Punti > g1.Punti)
                {
                    vincitore = g2;         //Assegno come vincitore a g2
                    lblVincitore.Text = "VINCITORE: " + partita.Winner;     //Scrivo il vincitore
                }
                else if (g1.Punti == g2.Punti)
                {
                    lblVincitore.Text = "VINCITORE: " + partita.Winner;  //In caso di pareggio 
                }
                timer1.Interval = 5000;//Imposto il timer 
                timer1.Start();
                timer2.Start();
                btnLancioDadi.Enabled = false;
                numround = 1;
            }
            numround++;//Ogni giro avvenuta con successo incremento il numero di round
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Value > 0)
            {
                valore = (int)numericUpDown.Value;  //Converto il valore dell'updown in int tramite il cast
            }
            else
            {
                numericUpDown.Value = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)  //Timer 1, finita la partita e decretato il vincitore, 5 secondi dopo mi chiede se voglio
        {                                                      // Iniziare una nuova partita con gli stessi giocatori o cambiarli
            btnLancioDadi.Enabled = true;
            timer1.Stop();
            timer2.Stop();
            lblVincitore.BackColor = Color.Transparent;
            if (MessageBox.Show($"Vuoi cambiare i giocatori?", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)  //chiedo se si vuole continuare con gli stessi giocatori
            {
                g1 = null;
                g2 = null;
                Accesso accesso = new Accesso();
                if (accesso.ShowDialog() == DialogResult.OK)
                {
                    g1 = new Giocatore(accesso.Giocatore1);
                    g2 = new Giocatore(accesso.Giocatore2);
                    lblGiocatore1.Text = g1.Nome;
                    lblGiocatore2.Text = g2.Nome;
                }
            }

            partita.ResetGame();   //Resetto la partita 
            btnInizia.Enabled = true;
            btnLancioDadi.Enabled = false;
            numericUpDown.Enabled = true;
            lblPunti1.Text = g1.Punti.ToString();
            lblPunti2.Text = g2.Punti.ToString();
            lblNumRound.Text = "1";
            lblVincitore.Text = string.Empty;
            numround = 1;
            cartaGiocatore1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Immagini\\dadi.gif");  //rimetto le gif dei dadi 
            cartaGiocatore2.Image = Image.FromFile(Environment.CurrentDirectory + "\\Immagini\\dadi.gif");
        }

        private void btnReinizia_Click(object sender, EventArgs e)  //Inizia la partita 
        {
            if (valore != 0 && g1 != null && g2 != null)  //Se il numero di round è corretto
            {
                partita = new Partita(g1, g2, valore);   //Creo la partita
                btnLancioDadi.Enabled = true;
                btnInizia.Enabled = false;
                numericUpDown.Enabled = false;
                lblNumRound.Text = "1";
                lblVincitore.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Inserire entrambi i nomi dei giocatori \n e un numero accettabile di round", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void timer2_Tick(object sender, EventArgs e)  //Timer 2 mi fa cambiare il colore di sfondo della label del vincitore 
        {
            Random colore = new Random();
            lblVincitore.BackColor = Color.FromArgb(colore.Next(1, 255), colore.Next(1, 255), colore.Next(1, 255), colore.Next(1, 255));   //cambio di colore sulla label del vincitore
        }

        private void cartaGiocatore2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//Mi fa chiudere il programma tramite un bottone
        {
            Close();
        }
    }
}
