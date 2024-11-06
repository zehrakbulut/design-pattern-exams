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
            Klasor anaKlasor = new Klasor("Ana Klasör");

            Dosya dosya1 = new Dosya("Dosya1.txt");
            Dosya dosya2 = new Dosya("Dosya2.txt");

            Klasor altKlasor = new Klasor("Alt Klasör");
            altKlasor.Ekle(new Dosya("Dosya3.txt"));

            anaKlasor.Ekle(dosya1);
            anaKlasor.Ekle(dosya2);
            anaKlasor.Ekle(altKlasor);

            anaKlasor.Goster();

            Console.ReadLine();

        }

        public interface IDosya
        {
            void Goster();
        }

        public class Dosya: IDosya
        {
            private string _isim;

            public Dosya(string isim)
            {
                _isim = isim;
            }

            public void Goster()
            {
                Console.WriteLine(_isim);
            }
        }

        public class Klasor : IDosya
        {
            private string _isim;
            private List<IDosya> _dosyalar = new List<IDosya>();

            public Klasor(string isim)
            {
                _isim = isim;
            }

            public void Ekle(IDosya dosya)
            {
                _dosyalar.Add(dosya);
            }

            public void Goster()
            {
                Console.WriteLine($"Klasör: {_isim}");
                foreach(var dosya in _dosyalar)
                {
                    dosya.Goster();
                }
            }
        }
    }
}
