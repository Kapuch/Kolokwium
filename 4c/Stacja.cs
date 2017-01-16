using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4c
{
    class Stacja:ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;

        public Stacja(string nazwaStacji, bool oplataKlimatyczna)
        {
            this.nazwaStacji = nazwaStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;
        }
        public override string ToString()
        {
            return "Stacja: " + nazwaStacji + ", oplata klimatyczna: " + (oplataKlimatyczna ? "tak" : "nie");
        }
        public bool JakaOplata()
        {
            return oplataKlimatyczna;
        }
        public Object Clone() // mechanizm płykiej kopii
        {
            return MemberwiseClone();
        }
    }
}
