using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_
{
    class Commande
    {
        private int id;
        private DateTime date;
        private string heure;


        public Commande (int leId, DateTime laDate, string lHeure)
        {
            this.id = leId;
            this.date = laDate;
            this.heure = lHeure;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
    }
}
