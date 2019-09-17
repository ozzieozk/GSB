using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_
{
    class Entrer
    {
        private int id;
        private DateTime date;
        private string heure;
        private int quantite;

        public Entrer(int leId, DateTime laDate,  string lHeure, int laQuantite)
        {
            this.id = leId;
            this.date = laDate;
            this.heure = lHeure;
            this.quantite = laQuantite;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
