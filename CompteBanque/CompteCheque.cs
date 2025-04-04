using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBanque
{
    class CompteCheque : Compte
    {
        public string Succursalle { get; set; }

        public CompteCheque(Client client) : base(client)
        {

        }
    }
}
