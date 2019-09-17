using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_
{
    class Article
    {
        private int id;
        private int quantite;
        private string nom;


        public Article(int leId, int laQuantite, string leNom)
        {
            this.id = leId;
            this.quantite = laQuantite;
            this.nom = leNom;
        }

        public int Id { get => id; set => id = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}