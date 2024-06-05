using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDelDado
{
    public partial class Accesso : Form
    {
        //Dichiarazione di due attributi giocatori
        string giocatore1;
        string giocatore2;
        public Accesso()
        {
            InitializeComponent();
        }
        public string Giocatore1 { get => giocatore1;}//Proprietà per gettare il nome del giocatore 1 nel Accesso.cs
        public string Giocatore2 { get => giocatore2;}//Proprità per gettare il nome del giocatore 2 

        private void label3_Click(object sender, EventArgs e)//Aggiungimento di un label dalla casella degli strumenti
        {
            //Condizione per verificare se inserimento degli nomi da entrambi i giocatori non sono vuote
            if (txt_giocatore1.Text != string.Empty && txt_giocatore2.Text != string.Empty)
            {
                giocatore1 = txt_giocatore1.Text;
                giocatore2 = txt_giocatore2.Text;
                DialogResult = DialogResult.OK;   
            }
            else
            {
                //Se la stringa è vuota stampa un errore
                MessageBox.Show("Inserire entrambi i nomi dei giocatori", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
