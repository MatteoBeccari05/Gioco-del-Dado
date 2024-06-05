using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDelDado
{
    internal class Partita
    {
        //Dichiarazioni di attributi
        Giocatore _giocatore1;
        Giocatore _giocatore2;
        int _numeroRound;
        Dado _dado;
        int[] _numeriEstratti = new int[2];

        public Partita(Giocatore g1, Giocatore g2, int round)//Costruttore della classe partita che passa come parametro il numero di round,il g1 e il g2
        {
            _giocatore1 = g1;
            _giocatore2 = g2;
            _numeroRound = round;
            ResetGame();//Metodo resetGame per ripartire una nuova partita
        }

        public int NumeroRound { get => _numeroRound; set => _numeroRound = value; }//Proprietà numero round

        public int[] Estratti { get => _numeriEstratti; private set => _numeriEstratti = value; }//Proprietà per numeri estratti

        /// <summary>
        /// Determina se la partita è finita 
        /// </summary>
        public bool FineGara //proprietà utilizzata per determinare il fine della gara
        {
            get
            {
                if (_numeroRound == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Ritorna il nome del vincitore
        /// </summary>
        public string Winner// Ritorna il nome del vincitore, lo stato di parità o lo stato della partita se in corso                   
        {
            get
            {
                if (_giocatore1.Punti > _giocatore2.Punti)//Condizione per verificare la vincita del giocatore 1 
                {
                    return _giocatore1.Nome;//In caso di vincita ritorna il nome del giocatore 1 

                }
                else if (_giocatore1.Punti < _giocatore2.Punti)//Condizione per verificare la vincita del giocatore 2
                {
                    return _giocatore2.Nome;//In caso ritorna il nome del giocatore 2
                }
                else//Punti uguali stampa pareggio
                {
                    return "Pareggio";
                }
            }
        }


        /*Un round consiste nel lancio del dado da entrambi i giocatori, nel determinarne il vincitore e
        nell’incremento delle gare vinte da ciascun giocatore(in caso di parità incrementare le vincite di ogni giocatore).*/
        /// <summary>
        /// Esegue un round della partita, ritorna un giocatore
        /// </summary>
        /// <returns></returns>
        public Giocatore Round()//Metodo per eseguire un round della partita
        {
            _dado = new Dado(6);
            _numeriEstratti[0] = _dado.LancioDadi();//Lancia il dado sia da una parte e dall'altra 
            _numeriEstratti[1] = _dado.LancioDadi();//Grazie al metodo lancio dado
            if (_numeroRound != 0)//Solose numero round è diverso da zero verifica le condizioni successive
            {
                _numeroRound--;
                if (_numeriEstratti[0] > _numeriEstratti[1])//Se la faccia estratta dal giocatore 1 è > di giocatore 2
                {
                    _giocatore1.Punti++;//Incrementa i punteggio per giocatore 1
                    return _giocatore1;//Ritorna il giocatore 1
                }
                else if (_numeriEstratti[0] < _numeriEstratti[1])//Se la faccia estratta dal giocatore 2 è > di giocatore 1 
                {
                    _giocatore2.Punti++;//Incrementa il punteggio del giocatore 2
                    return _giocatore2;//Ritorna il giocatore 2
                }
            }
            
            return null;
        }

        /// <summary>
        /// Resetta la partita
        /// </summary>
        public void ResetGame()  //Metodo per resettare la partita
        {
            _giocatore1.Punti = 0;//Dove il punteggio del giocatore 1 viene resettato a zero
            _giocatore2.Punti = 0;//Dove anche il punteggio del gioctore 2 viene resettato a zero
        }
    }
}
