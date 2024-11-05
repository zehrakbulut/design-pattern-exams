using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOyuncak oyuncak = OyuncakFabrikasi.OyuncakYap("bebek");
            oyuncak.Oyna();//çıktı: araba ile oynuyorsun
        }


        //oyuncak için arayüz
        public interface IOyuncak
        {
            void Oyna();
        }

        //farklı türde oyuncaklar
        public class ArabaOyuncak : IOyuncak
        {
            public void Oyna()
            {
                Console.WriteLine("araba ile oynuyorsun");
            }
        }

        public class BebekOyuncak : IOyuncak
        {
            public void Oyna()
            {
                Console.WriteLine("bebek ile oynuyorsun");
            }
        }



        //fabrika
        public class OyuncakFabrikasi
        {
            public static IOyuncak OyuncakYap(string tur)
            {
                if (tur == "araba")
                {
                    return new ArabaOyuncak();
                }
                else if (tur == "bebek")
                {
                    return new BebekOyuncak();
                }
                else
                {
                    throw new Exception("bilinmiyen oyuncak türü");
                }
            }
        }
    }
}
