using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Made by Albin Fyhr, god incarnate

            char firstLetter = 'A'; //A som i Albin
            char secondLetter = 'F'; //F som i Fyhr! :)))
            float floatNumber = 4.5F;
            int intNumber = 5; //nice number som inte ens används. synd
            int[] numbers = new int[10]; //cool lista

            Console.WriteLine("Min array lista:"); //ger värden till min lista
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i;
            }
            foreach(int number in numbers) //skriver ut värdena från min lista
            {
                Console.WriteLine(number); //kunde skrivas som Console.WriteLine(i) i den förra loopen, men okay
            }

            Console.WriteLine(" "); //nice space

            if (floatNumber < 4) //VAD ÄR MITT NUMBER??? wowowo
            {
                Console.WriteLine("Float number är < 4");
            }
            else if(floatNumber == 4.5F) //spoiler alert: this is the one
            {
                Console.WriteLine("Float number är = 4.5");
            }
            else
            {
                Console.WriteLine("Float är större än 4.5");
            }

            Console.WriteLine(" "); //nice space yet again

            Console.Write("Gjort av "); //NICE CREDITS
            Console.Write(firstLetter);
            Console.Write("."); //TOTAL WASTE OF VALUABLE COMPUTER SPACE BUT WHO CARES XDD
            Console.Write(secondLetter);
            Console.Write(" (aka, Albin Fyhr)"); //NEXT GEN CREDITS
            Console.ReadLine(); //TADA, script done
        }
    }
}
