using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDelDado
{
    internal class Dado
    {
        int _facce = 6;//Inizializzazione variabile (attributo) intero dado con valore 6 perchè il dado ha solo 6 facce
        Random random;//Random per generale facce casuali

        public Dado(int facce)//Costruttore dado della classe Dado che passa come parametro il variabile intero facce
        {
            random = new Random();
            _facce = facce;
        }


        /// <summary>
        /// Ritorna un intero da 1 a 6 per le facce del dado
        /// </summary>
        /// <returns></returns>
        public int LancioDadi()//Metodo Lancio dadi
        {
            int numEstratto = random.Next(1, _facce + 1);//Random per generare facce cuali
            return numEstratto;
        }
    }
}
