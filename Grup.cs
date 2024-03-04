using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMardaleBiancaElena
{
    [Serializable]
    class Grup
    {
        private int idGrup;
        private List<Utilizator> listaUtilizatori;
        private List<string> listaDrepturi;

        public Grup(int idGrup, List<Utilizator> listaUtilizatori, List<string> listaDrepturi)
        {
            this.idGrup = idGrup;
            this.listaUtilizatori = listaUtilizatori;
            this.listaDrepturi = listaDrepturi;
        }

        public Grup()
        {
            idGrup = 0;
            listaDrepturi = new List<string>();
            listaUtilizatori = new List<Utilizator>();
        }

        public int IdGrup
        {
            get => idGrup;
            set => idGrup = value;
        }

        public List<Utilizator> ListaUtilizatori
        {
            get => listaUtilizatori;
            set => listaUtilizatori = value;
        }

        public List<string> ListaDrepturi
        {
            get => listaDrepturi;
            set => listaDrepturi = value;
        }

        public override string ToString()
        {
            string afisare = "";
            afisare += "Grupul " + idGrup + " are urmatoarea structura: " + Environment.NewLine;
            afisare += "Utilizatori: " + Environment.NewLine;
            foreach (Utilizator u in listaUtilizatori)
            {
                afisare += u.ToString() + Environment.NewLine;
            }
            afisare += "Drepturi: " + Environment.NewLine;
            foreach (string s in listaDrepturi)
            {
                afisare += s.ToString() + Environment.NewLine;
            }
            return afisare;
        }

        public Utilizator this[int k]
        {
            get => k < listaUtilizatori.Count ? listaUtilizatori[k] : throw new IndexOutOfRangeException();
            set
            {
                if(listaUtilizatori[k] != value)
                {
                    listaUtilizatori[k] = value;
                }
            }
        }
    }

}
