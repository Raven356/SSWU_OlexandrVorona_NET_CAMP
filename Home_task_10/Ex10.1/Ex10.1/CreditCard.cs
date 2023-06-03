using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10._1
{
    internal class CreditCard
    {
        private string _distributor;
        private string _number;



        public CreditCard(string distributor, string number)
        {
            _distributor = distributor;
            _number = number;
        }

        public string Number { get => _number; }
        public string Distributor { get => _distributor; }
    }
}
