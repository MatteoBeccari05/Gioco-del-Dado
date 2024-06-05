using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDelDado
{
    internal class Giocatore
    {
        string _nome;//Dichiarazioni variabile nome di tipo stringa
        int _punti;//Dichiarazione variabile punti di tipo intero

        public Giocatore(string nome)//Costruttore giocatore che passa comme parametro il nome
        {
            _nome = nome;
        }

        public string Nome { get => _nome; }//Proprietà per il nome del giocatore in questo caso solo get perchè il nome di un giocatore non può essere cambiato
        public int Punti { get => _punti; set => _punti = value; }//Proprietà per Punti ottenuti dal giocatore
    }
}
