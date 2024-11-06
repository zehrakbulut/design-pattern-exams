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
            Cihaz televizyon = new Televizyon();
            Cihaz radyo = new Radyo();

            Kumanda tvKumanda = new Kumanda(televizyon);
            GelismisKumanda radyoKumanda = new GelismisKumanda(radyo);

            //tv aç/kapat
            tvKumanda.AcKapat();

            //radyoyu aç, ses seviyesini ayarla
            radyoKumanda.AcKapat();
            radyoKumanda.SesAyarla(5);

            //tv'yi kapat
            tvKumanda.AcKapat();

            Console.ReadLine();

        }

        public interface Cihaz
        {
            void Ac();
            void Kapat();
            void SesAyarla(int seviye);
            bool AcikMi();
        }

        public class Televizyon : Cihaz
        {
            private bool acik = false;
            private int sesSeviyesi = 0;
            public void Ac()
            {
                acik = true;
                Console.WriteLine("televizyon açıldı");
            }

            public bool AcikMi()
            {
                return acik;        
            }

            public void Kapat()
            {
                acik = false;
                Console.WriteLine("televizyon kapandı");
            }

            public void SesAyarla(int seviye)
            {
                sesSeviyesi = seviye;
                Console.WriteLine($"televizyon ses seviyesi {sesSeviyesi} olarak ayarlandı.");
            }
        }

        public class Radyo : Cihaz
        {
            private bool acik = false;
            private int sesSeviyesi = 0;

            public void Ac()
            {
                acik=true;
                Console.WriteLine("radyo açıldı");
            }

            public bool AcikMi()
            {
                return acik;
            }

            public void Kapat()
            {
                acik=false;
                Console.WriteLine("radyo kapandı");
            }

            public void SesAyarla(int seviye)
            {
                sesSeviyesi = seviye;
                Console.WriteLine($"Radyo ses seviyesi {sesSeviyesi} olarak ayarlandı");
            }
        }

        public class Kumanda
        {
            protected Cihaz _cihaz;

            public Kumanda(Cihaz cihaz)
            {
                _cihaz = cihaz;
            }

            public void AcKapat()
            {
                if (_cihaz.AcikMi())
                {
                    _cihaz.Kapat();
                }
                else
                {
                    _cihaz.Ac();
                }
            }
        }

        public class GelismisKumanda : Kumanda
        {
            public GelismisKumanda(Cihaz cihaz) : base(cihaz)
            {
            }

            public void SesAyarla(int seviye)
            {
                _cihaz.SesAyarla(seviye);
            }
        }
    }
}
