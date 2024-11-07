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
            HavaDurumu havaDurumu = new HavaDurumu();
            HaberKanal kanal1 = new HaberKanal("kanal 1");
            HaberKanal kanal2 = new HaberKanal("kanal 2");

            havaDurumu.GozlemciEkle(kanal1);
            havaDurumu.GozlemciEkle(kanal2);

            havaDurumu.GuncelleHavaDurumu("bugün hava güneşli");

            Console.ReadLine();

        }

        //gözlemci arayüzü
        public interface IGozlemci
        {
            void Guncelle(string mesaj);
        }

        //haber kanalı
        public class HaberKanal : IGozlemci
        {
            private string _isim;

            public HaberKanal(string isim)
            {
                _isim = isim;
            }

            public void Guncelle(string mesaj)
            {
                Console.WriteLine($"{_isim} kanalı güncellendi: {mesaj}");
            }
        }

        //hava durumu
        public class HavaDurumu
        {
            private List<IGozlemci> gozlemciler = new List <IGozlemci>();

            public void GozlemciEkle(IGozlemci gozlemci)
            {
                gozlemciler.Add(gozlemci);
            }

            public void GozlemciSil(IGozlemci gozlemci)
            {
                gozlemciler.Remove(gozlemci);
            }
            
            public void GuncelleHavaDurumu(string mesaj)
            {
                foreach(var gozlemci in gozlemciler)
                {
                    gozlemci.Guncelle(mesaj);
                }
            }
        }
    }
}
