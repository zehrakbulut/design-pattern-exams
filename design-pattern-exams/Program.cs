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
            //Amerikan prizi Türk prizine uyumlu hale getiriliyor
            ITurkPriz priz = new PrizAdapter(new AmerikanPriz());
            priz.TakVeCalistir();

            Console.ReadLine();

        }

        //Türk prizini temsil eden arayüz
       public interface ITurkPriz
        {
            void TakVeCalistir();
        }


        public class TurkPriz : ITurkPriz   //Türkiyedeki priz  
        {
            public void TakVeCalistir()
            {
                Console.WriteLine("Türk prizine bağlandınız");
            }
        }

        public class AmerikanPriz        //Amerikan prizini temsil eden sınıf
        { 
            public void PlugIn()
            {
                Console.WriteLine("Amerikan prizine bağlandınız");
            }
        }

        //Adaptör sınıfı
        public class PrizAdapter : ITurkPriz
        {
            private readonly AmerikanPriz _amerikanPriz;

            public PrizAdapter(AmerikanPriz amerikanPriz)
            {
                _amerikanPriz = amerikanPriz;
            }

            public void TakVeCalistir()
            {
                _amerikanPriz.PlugIn();
            }
        }
  
    }
}
