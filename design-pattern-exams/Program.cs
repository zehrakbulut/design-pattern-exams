using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kumanda kumanda = new Kumanda();
            kumanda.KomutUygula(new IsikAcKomut());
            kumanda.KomutUygula(new IsikKapatKomut());
           
            Console.ReadLine();

        }

        public interface IKomut
        {
            void Calistir();
        }

        //ışığı açma komutu
        public class IsikAcKomut : IKomut
        {
            public void Calistir()
            {
                Console.WriteLine("ışık açıldı");
            }
        }

        //ışığı kapama komutu
        public class IsikKapatKomut : IKomut
        {
            public void Calistir()
            {
                Console.WriteLine("ışık kapandı");
            }
        }

        public class Kumanda
        {
            public void KomutUygula(IKomut komut)
            {
                komut.Calistir();   
            }
        }

    }
}
