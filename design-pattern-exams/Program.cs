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
            //başlangıçta sade dondurma
            IDondurma dondurma = new SadeDondurma();

            //çikolata dekoratörü ile dondurmayı zenginleştir
            dondurma = new CikolataDekorator(dondurma);

            //sonucu ekrana yazdır
            Console.WriteLine(dondurma.ServisEt());

            Console.ReadLine();

        }

       public interface IDondurma
        {
            string ServisEt();
        }

        public class SadeDondurma: IDondurma
        {
            public string ServisEt()
            {
                return "sade dondurma";
            }
        }

        //dondurmaya ekleme yapabiliceğimiz bir dekoratör sınıfı oluşturuyoruz
        public class CikolataDekorator: IDondurma
        {
            private readonly IDondurma _dondurma;
            public CikolataDekorator(IDondurma dondurma)
            {
                _dondurma= dondurma;
            }

            public string ServisEt()
            {
                return _dondurma.ServisEt() + " + çikolata";
            }
        }
  
    }
}
