using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1Slett9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kall på metodene som er definert under.
            //Der hvor det er en return, opprett variabel for å holde på returverdien
            SkrivHei();

            Console.WriteLine("Skriv Sarpsborg er best<3");
            var teksten = Console.ReadLine();
            SkrivNoe(teksten);

            Console.WriteLine("Skriv 1 tall");
            var tall1 =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv 1 tall til");
            var tall2 = Convert.ToInt32(Console.ReadLine());
            AddNoReturn(tall1, tall2);
            






            Console.ReadLine();//for at consolet ikke skal stenges
        }

        public static void SkrivHei()
        {
            //Skriv kodelinjen som skriver hei ut til console
            Console.WriteLine(ReturnerHei());

        }

        
        public static string ReturnerHei()
        {
            string bolle = "Hei";
            return bolle;
        }

        public static void SkrivNoe(string tekst)
        {
            Console.WriteLine(tekst);
        }

        
        public static int Add(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        public static void AddNoReturn(int num1, int num2)
        {
            Console.Write(num1+num2);
        }
    }
}
