using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Tests.Figury;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)

        {
            Prostokaot pr = new Prostokaot();
            pr.wysokosc = 4.5;
            pr.szerkosc = 3.5;
            pr.ObliczProstokat();

            Console.ReadKey();

            Kwadrat kr = new Kwadrat();

            kr.krawedz = 15.0;
            kr.pokazKwadrat();

            Console.ReadKey();



            /*

             Console.WriteLine("Co chcesz robić?");
             Console.WriteLine("Porozmawiać - wciśnij 1" +
                 "Wyliczanka -wciśnij 2" +
                 "Lotto - wciśnij 3");



                     string b;
                     string a;

                     One: Console.WriteLine("Podaj swoje imie");
                     b = Console.ReadLine();

                     if (b != "")
                     {
                         Console.WriteLine("Cześć " + b + " jak Ci minął dzień?");
                     }
                     else

                     {
                         Console.WriteLine("Wszyscy wiemy Bombelku że masz jakieś imie, każdy ma ");
                         goto One;
                     }

                     two: a = Console.ReadLine();

                     if (a != "")
                     {

                         Console.WriteLine("Dzień minał Ci " + a);
                         Console.WriteLine("Super!");
                         Console.ReadKey();

                         goto three;
                     }

                     else

                     {

                         Console.WriteLine("Na pewno nie było aż tak źle ;) ");
                         Console.WriteLine(b + " jak Ci minął dzień?");
                         goto two;
                     }

                     three: Console.Clear();

                     double d = 0.0;
                     double c;
                     string s;

                     Console.WriteLine("A teraz " + b + " zrobimy wyliczankę, ile liczb  w kolejności chcesz wyświtelić?");
                     s = Console.ReadLine();


                     double.TryParse(s, out c);

                     do
                     {
                         d++;
                         Console.WriteLine(d);

                     } while (d < c);




                     Console.ReadKey();



                     Console.Clear();

                     Random Rnd = new Random();

                     Console.WriteLine("Witam w totoloktu! Oto Twoje szczśliwe numery:");

                     int totolotek = Rnd.Next();
                     Console.WriteLine("Lotto:");
                     for (int los = 1; los <= 7; los++)
                     {
                         Console.WriteLine("{0, 6}", Rnd.Next(1, 100));

                     }

                     Console.WriteLine("Mulitlotek:");
                     for (int lot = 1; lot <= 20; lot++)
                     {
                         Console.WriteLine("{0, 20}", Rnd.Next(1, 100));
                         if (lot % 5 == 0) Console.WriteLine();
                     }


                     Console.ReadKey();        
             */
        }     

    }
}
