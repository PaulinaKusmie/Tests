using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Figury
    {

        

        public class Prostokaot
        {
            public double szerkosc;
            public double wysokosc;
            public double ObliczPowieszchnie()
            {
                return szerkosc * wysokosc;
            }

            public void ObliczProstokat()
            {

                 Console.WriteLine("{0}", szerkosc);
                 Console.WriteLine( "{0}", wysokosc);
                Console.WriteLine("{0}", ObliczPowieszchnie());
            }
          
        }

        public class Kwadrat
        {

            public double krawedz;

            public double obliczKwadrat()
            {
                return krawedz * krawedz;

            }

            public void pokazKwadrat()
            {
                Console.WriteLine("Krawedz to {0} a powiesznia kwadratu to {1}", krawedz, obliczKwadrat());
            }


        }
    
        
        
    }
}
