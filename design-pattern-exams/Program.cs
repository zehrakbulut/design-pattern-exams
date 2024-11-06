using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            //orijina bir kedi nesnesi oluşturuluyor.
            Kedi orjinalKedi = new Kedi { Renk = "Siyah", Cins = "Van Kedisi" };
            Console.WriteLine("Orijinal kedi");
            orjinalKedi.BilgiVer();


            //orijinal kedi nesnesini klonlıyarak yeni bir kedi nesnesi oluşturuluyor
            Kedi kopyaKedi = orjinalKedi.Klonla();
            Console.WriteLine("\nKopya Kedi");
            kopyaKedi.BilgiVer();


            //kopya üzerinden değişiklik yapılabilir, ancak orijinali etkilemez
            kopyaKedi.Renk = "Beyaz";
            Console.WriteLine("\nKopy Kedinin rengi değiştirildi");
            kopyaKedi.BilgiVer();


            Console.WriteLine("\nOrijinal Kedi: ");
            orjinalKedi.BilgiVer(); //orijinal nesne değişmeden kalır!

            Console.ReadLine();

        }

        public class Kedi
        {
            public string Renk { get; set; }
            public string Cins { get; set; }

            //klonlu metodu, mevcut kedi nesnesinin yüzeysel bir kopyasını döndürür.
            public Kedi Klonla()
            {
                return (Kedi)this.MemberwiseClone(); //aynı özelliklere sahip yeni bir kedi nesnesi oluşturur.
            }

            public void BilgiVer()
            {
                Console.WriteLine($"kedi özellikleri - renk: {Renk}, Cins: {Cins}");
            }
        }
  
    }
}
