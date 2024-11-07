using System;
using System.Collections.Generic;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dosya sistemi oluşturma
            var root = new Klasor("Root");
            var subFolder1 = new Klasor("Documents");
            var subFolder2 = new Klasor("Pictures");

            root.Ekle(subFolder1);
            root.Ekle(subFolder2);
            subFolder1.Ekle(new Dosya("Resume.pdf", 120));
            subFolder1.Ekle(new Dosya("CoverLetter.docx", 80));
            subFolder2.Ekle(new Dosya("Vacation.png", 240));
            subFolder2.Ekle(new Dosya("Profile.jpg", 150));

            // Boyut hesaplama ziyaretçisini kullanma
            var boyutHesaplaVisitor = new BoyutHesaplaVisitor();
            root.Accept(boyutHesaplaVisitor);
            Console.WriteLine($"Toplam Boyut: {boyutHesaplaVisitor.ToplamBoyut}KB");

            // Detay görüntüleme ziyaretçisini kullanma
            var detayGoruntuleVisitor = new DetayGoruntuleVisitor();
            root.Accept(detayGoruntuleVisitor);

            Console.ReadLine();
        }

        // Ziyaretçi Arayüzü
        public interface IVisitor
        {
            void Visit(Dosya dosya);
            void Visit(Klasor klasor);
        }

        // Dosya Sistemi Elemanı Arayüzü
        public interface IDosyaSistemiElemani
        {
            void Accept(IVisitor visitor);
        }

        // Dosya Sınıfı
        public class Dosya : IDosyaSistemiElemani
        {
            public string Ad { get; set; }
            public int Boyut { get; set; }

            public Dosya(string ad, int boyut)
            {
                Ad = ad;
                Boyut = boyut;
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        // Klasör Sınıfı
        public class Klasor : IDosyaSistemiElemani
        {
            public string Ad { get; set; }
            public List<IDosyaSistemiElemani> Elemanlar { get; set; } = new List<IDosyaSistemiElemani>();

            public Klasor(string ad)
            {
                Ad = ad;
            }

            public void Ekle(IDosyaSistemiElemani eleman)
            {
                Elemanlar.Add(eleman);
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
                foreach (var eleman in Elemanlar)
                {
                    eleman.Accept(visitor);
                }
            }
        }

        // Boyut Hesaplama Ziyaretçisi
        public class BoyutHesaplaVisitor : IVisitor
        {
            public int ToplamBoyut { get; private set; }

            public void Visit(Dosya dosya)
            {
                ToplamBoyut += dosya.Boyut;
            }

            public void Visit(Klasor klasor)
            {
                // Klasörlerde ayrıca boyut eklemiyoruz, sadece içindeki elemanları hesaplıyoruz
            }
        }

        // Detay Görüntüleme Ziyaretçisi
        public class DetayGoruntuleVisitor : IVisitor
        {
            private int _indentLevel = 0;

            public void Visit(Dosya dosya)
            {
                Console.WriteLine(new string(' ', _indentLevel * 2) + $"- Dosya: {dosya.Ad}, Boyut: {dosya.Boyut}KB");
            }

            public void Visit(Klasor klasor)
            {
                Console.WriteLine(new string(' ', _indentLevel * 2) + $"+ Klasör: {klasor.Ad}");
                _indentLevel++;
                foreach (var eleman in klasor.Elemanlar)
                {
                    eleman.Accept(this);
                }
                _indentLevel--;
            }
        }
    }
}
