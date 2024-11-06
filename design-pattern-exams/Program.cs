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
            //bir inek fabrikası oluştur ve kullan
            IHayvanFabrikasi fabrikasi = new InekFabrikasi();
            IHayvan hayvan = fabrikasi.HayvanOlustur();
            hayvan.SesCikar();

            fabrikasi = new KediFabrikasi();
            hayvan = fabrikasi.HayvanOlustur();
            hayvan.SesCikar();

            Console.ReadLine();

        }

        //hayvan için soyut sınıf
        public interface IHayvan
        {
            void SesCikar();
        }

        //hayvan fabrikası için soyut sınıf
        public interface IHayvanFabrikasi
        {
            IHayvan HayvanOlustur();
        }


        //inek sınıfı
        public class Inek : IHayvan
        {
            public void SesCikar()
            {
                Console.WriteLine("möö!");
            }
        }

        //kedi sınıfı
        public class Kedi: IHayvan
        {
            public void SesCikar()
            {
                Console.WriteLine("miyav!");
            }
        }


        //inek fabrikası
        public class InekFabrikasi: IHayvanFabrikasi
        {
            public IHayvan HayvanOlustur()
            {
                return new Inek();
            }
        }


        //kedi fabrikası
        public class KediFabrikasi: IHayvanFabrikasi
        {
            public IHayvan HayvanOlustur()
            {
                return new Kedi();
            }
        }
  
    }
}
