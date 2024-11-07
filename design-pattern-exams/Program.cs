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
            IIsleyici duzey3Isleyici = new Duzey3Isleyici();
            IIsleyici duzey2Isleyici= new Duzey2Isleyici(duzey3Isleyici);
            IIsleyici duzey1Isleyici= new Duzey1Isleyici(duzey2Isleyici);

            //bir talep gönderiyoruz
            int talepTutari = 3000;
            duzey1Isleyici.TalepIste(talepTutari);

            //farklı bir talep gönderiyoruz
            talepTutari = 7000;
            duzey1Isleyici.TalepIste(talepTutari);
           
            Console.ReadLine();
        }

        //isleyici(handler) arayüzü
        public interface IIsleyici
        {
            void TalepIste(int tutar);
        }

        //somut isleyici   
        public class Duzey1Isleyici : IIsleyici
        {
            private IIsleyici _sonrakiIsleyici;

            public Duzey1Isleyici(IIsleyici sonrakiIsleyici)
            {
                _sonrakiIsleyici = sonrakiIsleyici;
            }

            public void TalepIste(int tutar)
            {
                if (tutar < 1000)
                {
                    Console.WriteLine($"Düzey1Isleyici: {tutar} tutarındaki talep işlendi.");
                }
                else if(_sonrakiIsleyici != null)
                {
                    _sonrakiIsleyici.TalepIste(tutar); //talebi bir sonraki işleyiciye gönder
                }
            }
        }

        public class Duzey2Isleyici : IIsleyici
        {
            private IIsleyici _sonrakiIsleyici;

            public Duzey2Isleyici(IIsleyici sonrakiIsleyici)
            {
                _sonrakiIsleyici= sonrakiIsleyici;
            }

            public void TalepIste(int tutar)
            {
                if(tutar >= 1000 && tutar <5000)
                {
                    Console.WriteLine($"Duzey2Isleyici: {tutar} tutarındaki talep işlendi.");
                }
                else if(_sonrakiIsleyici != null)
                {
                    _sonrakiIsleyici.TalepIste(tutar);
                }
            }
        }

        public class Duzey3Isleyici : IIsleyici
        {
            public void TalepIste(int tutar)
            {
                if(tutar >= 5000)
                {
                    Console.WriteLine($"Duzey3Isleyici: {tutar} tutarındaki talep işlendi.");
                }
                else
                {
                    Console.WriteLine("Bu tutar için bir işleyici mevcut değil.");
                }
            }
        }
    }
}
