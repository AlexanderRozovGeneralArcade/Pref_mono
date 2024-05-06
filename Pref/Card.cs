using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pref
{
    public class Card
    {

        public string Suit { get; set; }
        public string Value { get; set; }

        public Card(string s, string v) 
        {
            Suit = s;
            Value = v;
        }


    }
}
