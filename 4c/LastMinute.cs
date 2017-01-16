using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4c
{
    class LastMinute:Podroz
    {
        public override double KosztPoRabacie()
        {
            return koszt * 0.75;
        }
        public override string ToString()
        {
            return base.ToString()+Environment.NewLine+"LastMinute";
        }
    }
}
