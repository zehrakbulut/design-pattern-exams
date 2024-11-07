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
            SohbetArabulucu sohbet= new SohbetArabulucu();
            Katilimci ayse = new Katilimci("Ayşe", sohbet);
            Katilimci mehmet= new Katilimci("Mehmet",sohbet);

            sohbet.KatilimciEkle(ayse);
            sohbet.KatilimciEkle(mehmet);

            ayse.MesajGonder("Selam");
           
            Console.ReadLine();

        }

        public interface IArabulucu
        {
            void MesajGonder(Katilimci gonderen, string mesaj);
        }


        //katılımcı sınıfı
        public class Katilimci
        {
            private readonly IArabulucu _arabulucu;
            public string Isim { get; }

            public Katilimci(string isim, IArabulucu arabulucu)
            {
                Isim= isim;
                _arabulucu = arabulucu;
            }

            public void MesajGonder(string mesaj)
            {
                _arabulucu.MesajGonder(this,mesaj);
            }

            public void MesajAl(string mesaj)
            {
                Console.WriteLine($"{Isim} mesaj aldı: {mesaj}");
            }
        }


        public class SohbetArabulucu: IArabulucu
        {
            private List<Katilimci> _katilimcilar =new List<Katilimci>();

            public void KatilimciEkle(Katilimci katilimci)
            {
                _katilimcilar.Add(katilimci);
            }

            public void MesajGonder(Katilimci gonderen, string mesaj)
            {
                foreach(var katilimci in _katilimcilar)
                {
                    if(katilimci != gonderen)
                    {
                        katilimci.MesajAl($"{gonderen.Isim}: {mesaj}");
                    }
                }
            }
        }
    }
}
