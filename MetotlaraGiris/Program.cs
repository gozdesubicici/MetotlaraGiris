using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraGiris
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Küpünü alacağınız sayıyı girin");
            int b =int.Parse(Console.ReadLine());
            Kupu(b);
          
            
            Console.ReadLine();
        }

        private static void Yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }

        private static void Veriler()
        {
            Console.WriteLine("Müdür: İclal Karatekin");
            Console.WriteLine("Öğretmen: Gözdesu Biçici");
            Console.WriteLine("Okul: Damla Ortaokulu");
            Console.WriteLine("Eğitsel Kol: Kütüphanecilik");
            Console.WriteLine("Şehir: California");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        private static int Kupu(int a)
        {
            int k = a*a*a;
            Console.WriteLine(k);
            return k;
          
            
        }
    }
}
