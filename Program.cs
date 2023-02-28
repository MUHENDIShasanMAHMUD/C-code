using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dortgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y; //bizim kenarlarımız girdik .
            Console.WriteLine("ENTER X :  "); //userden kısa kenar girmesini istedik .
            x = double.Parse(Console.ReadLine()); // bizim bilinmeyeli X user tarafından girdiği değer verdik. 
            Console.WriteLine("ENTER THE SECOND LEGENTH : "); //userden uzun kenar girmesini istedik .
            y = double.Parse(Console.ReadLine()); // bizim bilinmeyeli Y user tarafından girdiği değer verdik. 
            Console.WriteLine("THE RECTANGLE AREA İS : ");
            Console.WriteLine(x * y); //dörtgenin alanı hesapladık ve ekran çıktısında yazdık.
            Console.ReadKey(); //konsul kapatmması için.
        }
    }
}
