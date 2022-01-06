using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    class Program
    {
        static void Main(string[] args)
        {
            double kucuk = 0, buyuk = 0, sonuc = 0, sonuc2 = 0;
            double[] sayılar = new double[10];
        
            for (int i = 1; i < 10; i++)
            {
                Console.Write("Sayıları Giriniz : ");
                sayılar[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            

            sonuc = sonuc / 10;

            sonuc2 = (kucuk + buyuk) / 2;

            Console.WriteLine("Sayıların Ortalaması = {0}", sonuc);
            Console.WriteLine("Büyük Ve Küçük Sayının Ortalaması = {0}", sonuc2);
            Console.WriteLine("Ortalamaların Farkı = {0}", sonuc - sonuc2);

            Console.ReadKey();
        }
    }
}
