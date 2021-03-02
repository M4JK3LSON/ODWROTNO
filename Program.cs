using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODWROTNO___Odwrotność_liczby
{
    class Program 
    {
        public static int odwroc(int n, int p)//Funckja
        {
            int value = 0;//wartość docelowa (m)
            for(int m=1; ; m++)//pętla szukająca odpowiedniego (m)
            {
                int wynik = (m * n) % p;//wynik liczacy wartosc wyrazenia (n*m) mod p
                if (wynik == 1)// porównanie czy wynik =1
                {
                    value = m;// przypisanie wartosci iteracyjna 
                    break;//przerwanie wykonania petli
                }
            }

            return value;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());//pętla testow 
            {
                string dane = Console.ReadLine();//odczytanie linii
                string[] daneStr = dane.Split(' ');// podział linii na komorki
                int n = int.Parse(daneStr[1]);//przypisanie n do zmiennej
                int p = int.Parse(daneStr[0]);//przypisanie p do zmiennej
                Console.WriteLine(odwroc(n, p));// wywolanie funkcji odwroc
            }
            Console.ReadKey();
        }
    }
}
