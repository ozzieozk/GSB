using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GSB_
{
	class entreeStock
	{
        private int id;
        private DateTime date;
        private string heure;
        private int quantite;

        public entreeStock(int unID, DateTime uneDate, string uneHeure, int uneQuantite)
        {
            this.id = unID;
            this.date = uneDate;
            this.heure = uneHeure;
            this.quantite = uneQuantite;
        }
	}
}
