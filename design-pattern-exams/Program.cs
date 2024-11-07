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
            OdemeYapici odeme = new OdemeYapici(new KrediKartiOdeme());
            odeme.OdemeYap(100);

            odeme.OdemeStratejisiAyarla(new NakitOdeme());
            odeme.OdemeYap(100);

            Console.ReadLine();

        }

        //ödeme stratejisi arayüzü
        public interface IOdemeStratejisi
        {
            void OdemeYap(decimal tutar);
        }

        //kredi kartı ile ödeme
        public class KrediKartiOdeme : IOdemeStratejisi
        {
            public void OdemeYap(decimal tutar)
            {
                Console.WriteLine($"kredi kartı ile {tutar} TL ödeme yapıldı");
            }
        }

        //nakit ödeme
        public class NakitOdeme : IOdemeStratejisi
        {
            public void OdemeYap(decimal tutar)
            {
                Console.WriteLine($"nakit olarak {tutar} TL ödeme yapıldı");
            }
        }

        //ödeme yapan sınıf
        public class OdemeYapici
        {
            private IOdemeStratejisi _odemeStratejisi;

            public OdemeYapici(IOdemeStratejisi odemeStratejisi)
            {
                _odemeStratejisi = odemeStratejisi;
            }

            public void OdemeYap(decimal tutar)
            {
                _odemeStratejisi.OdemeYap(tutar);
            }

            public void OdemeStratejisiAyarla(IOdemeStratejisi yeniStrateji)
            {
                _odemeStratejisi= yeniStrateji;
            }
        }
    }
}
