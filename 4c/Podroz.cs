using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4c
{
    class Podroz:IStacja
    {
        protected Queue<Stacja> stacje = new Queue<Stacja>();
        protected double koszt = 75;
        public Podroz() { }
        public virtual double KosztPoRabacie()
        {
            return koszt * 0.85;
        }
        public override string ToString()
        {
            string info = "Podróż:";
            foreach(var elem in stacje)
            {
                info += Environment.NewLine + elem.ToString();  
            }
            info += Environment.NewLine + "Koszt po rabacie: " + KosztPoRabacie();
            return info;
        }
        public void DodajStacje(string nazwa, bool oplata)
        {
            stacje.Enqueue(new Stacja(nazwa,oplata));
            if (oplata)
            {
                koszt += 22;
            }
        }
        public void Powrot()
        {
            //Stacja powrotna = stacje.
            //Stacja powrotna = stacje.Peek().Clone;
            Stacja powrotna = stacje.Peek();
            stacje.Enqueue(powrotna);
        }
        public void UsunStacje()
        {
            if (stacje.Count > 0)
            {
                stacje.Dequeue();
            }    
        }
        public void ZapiszPodroz()
        {
            using (StreamWriter sw = new StreamWriter("podroz.txt"))
            {
                sw.Write(ToString());
            }
        }
    }
}
