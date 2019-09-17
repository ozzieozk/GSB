using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_
{
    class Officine
    {
        private int id;
        private string codepostal;
        private string ville;
        private string telephone;
        private string nom;

        public Officine(int leId, string leCodepostal, string laVille, string leTelephone, string leNom)
        {
            this.Id = leId;
            this.Codepostal = leCodepostal;
            this.Ville = laVille;
            this.Telephone = leTelephone;
            this.Nom = leNom;
        }
        public int Id { get => id; set => id = value; }
        public string Codepostal { get => codepostal; set => codepostal = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
