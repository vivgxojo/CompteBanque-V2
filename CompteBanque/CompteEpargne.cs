using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBanque
{
    class CompteEpargne: Compte
    {
        public decimal Taux_Interet { get; set; }

        public CompteEpargne(Client client) : base(client)
        {

        }
    }
}
