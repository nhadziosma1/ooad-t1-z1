using System;

namespace ConsoleApp1
{
    class Program
    {
        const int CVOR_METARA = 1852;

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite brzinu broda u čvorovima: ");
            int brzinaUCvorovima = Convert.ToInt32(Console.ReadLine());
            //1cvor = 1 morskaMilja/h
            Console.WriteLine("brod ide {0:F2} km/h", (brzinaUCvorovima*(CVOR_METARA/1000.0)));
            Console.ReadLine();
        }
    }
}
