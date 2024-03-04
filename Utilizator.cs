using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMardaleBiancaElena
{
    [Serializable]
    public class Utilizator
    {
        private int id;
        private string nume;
        private string numeUtilizator;
        private string parola;

        public Utilizator()
        {
            id = 0;
            nume = "Necunoscut";
            numeUtilizator = "Necunoscut";
            parola = "Necunoscut";
        }

        public Utilizator(int id, string nume, string numeUtilizator, string parola)
        {
            this.id = id;
            this.nume = nume;
            this.numeUtilizator = numeUtilizator;
            this.parola = parola;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        
        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public string NumeUtilizator
        {
            get => numeUtilizator;
            set => numeUtilizator = value;
        }

        public string Parola
        {
            get => parola;
            set => parola = value;
        }

        public override string ToString()
        {
            return "Id: " + id + " Nume: " + nume + 
                " Nume utilizator: " + numeUtilizator + " Parola: " + parola;
        }
    }
}
