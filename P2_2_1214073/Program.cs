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
            Console.WriteLine("Masukan Gajih Mu : ");
           double gajihkaryawan, tunjangan, bonus, ppha, totalgajihkaryawan,gajihbersih;
           gajihkaryawan = Convert.ToDouble(Console.ReadLine());
           tunjangan =(gajihkaryawan * 20) / 100;
           bonus =(gajihkaryawan * 15) / 15;
           ppha = (gajihkaryawan *3.5) / 100;
           totalgajihkaryawan = gajihkaryawan + tunjangan + bonus;
           gajihbersih = (gajihkaryawan + tunjangan + bonus) - ppha ;

           Console.WriteLine("Gajih Pokok Karyawan Sebesar :" + gajihkaryawan);
           Console.WriteLine("Tunjangan 20% sebesar :" + tunjangan);
           Console.WriteLine("Bonus kerja rodi dari Bos sebesar : " + bonus);
           Console.WriteLine("PPH sebesar :" + ppha);
           Console.WriteLine("Total Gajih karyawan sebelum di potong PPH sebesar :" + totalgajihkaryawan);
           Console.WriteLine("Gajih bersih karyawan sebesar :" + gajihbersih);
           Console.ReadKey();
        }
    }
}
