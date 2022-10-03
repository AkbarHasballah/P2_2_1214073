using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P2_2_1214073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Gajih anda ! :");
            int gajih = int.Parse(Console.ReadLine());
            int tunjangan = (gajih * 20) / 100;
            int bonus = (gajih * 15) / 15;
            double pph = (gajih * 3.5) / 100;
            double totalgajihkaryawan = (gajih + tunjangan + bonus);
            double gajihbersih = (gajih + tunjangan + bonus) - pph;

            Console.WriteLine("Gajih Pokok Karyawan Sebesar :" + gajih);
            Console.WriteLine("Tunjangan 20% sebesar :" + tunjangan);
            Console.WriteLine("Bonus kerja rodi dari Bos sebesar : " + bonus);
            Console.WriteLine("PPH sebesar :" + pph);
            Console.WriteLine("Total Gajih karyawan sebelum di potong PPH sebesar :" + totalgajihkaryawan);
            Console.WriteLine("Gajih bersih karyawan sebesar :" + gajihbersih);
            
        }
    }
}
