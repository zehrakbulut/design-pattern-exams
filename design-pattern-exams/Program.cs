using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static design_pattern_exams.Program.CayDemleme;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            //siyah çay demlemek için bir nesne oluşturuluyor
            CayDemleme siyahCay = new SiyahCay();
            siyahCay.Demle();

            Console.WriteLine();

            //yeşil çay demlemek için bir nesne oluşturuluyor
            CayDemleme yesilCay = new YesilCay();
            yesilCay.Demle();
           
            Console.ReadLine();

        }

        //çay demleme şablonu
        public abstract class CayDemleme
        {
            //algoritmanın şablon metodu. Bu metodun adımları sabittir
            public void Demle()
            {
                SuIsit();
                CayEkle();
                SogumayaBirak();
            }

            //sabit adımlar
            protected void SuIsit()
            {
                Console.WriteLine("Su ısıtıldı.");
            }

            protected void SogumayaBirak()
            {
                Console.WriteLine("Çay demleniyor");
            }

            //alt sınıfların özelleştiriliceği adım
            protected abstract void CayEkle();

            public class SiyahCay: CayDemleme
            {
                //alt sınıf, şablondaki soyut metodu kendisine özel bir şekilde implement eder.
                protected override void CayEkle()
                {
                    Console.WriteLine("Siyah çay eklendi.");
                }
            }

            public class YesilCay : CayDemleme
            {
                //yeşil çay için farklı çay ekleme işlemi
                protected override void CayEkle()
                {
                    Console.WriteLine("Yeşil çay eklendi.");
                }
            }
        }
    }
}
