using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBanque
{
    class CompteCredit : Compte
    {
        public decimal Taux_Interet { get; set; }
        public decimal Limite_Credit { get; set; }

        public CompteCredit(Client client):base(client)
        {
            
        }
    }
}
