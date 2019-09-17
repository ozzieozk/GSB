using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_
{
    class Parapharmacie: Officine
    {
        public Parapharmacie(int leId, string leCodepostal, string laVille, string leTelephone, string leNom) : base(leId, leCodepostal, laVille, leTelephone, leNom)
        {
            
        }
    }
}
