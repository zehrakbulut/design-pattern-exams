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
            //pizzabuilder kullanarak yeni bir pizza oluştur
            var pizza = new PizzaBuilder()
                .HamurEkle("ince")
                .PeynirEkle("kaşar")
                .SosEkle("domates")
                .MalzemeEkle("mısır")
                .Build();  //pizzayı oluştur

            //oluşturulan pizza bilgilerini göster
            pizza.BilgiVer();   

            Console.ReadLine();

        }


        public class Pizza
        {
            //pizzanın özellikleri
            public string Hamur { get; set; }
            public string Peynir { get; set; }
            public string Sos { get; set; }
            public string Malzeme { get; set; }

            //pizza bilgilerini ekrana yazdıran metod
            public void BilgiVer() =>
                Console.WriteLine($"Pizza: {Hamur},{Peynir},{Sos},{Malzeme}");
        }


        public class PizzaBuilder
        {
            //yeni bir pizza nesnesi
            private Pizza _pizza=new Pizza();

            //hamur eklemek için metod
            public PizzaBuilder HamurEkle(string hamur)
            {
                _pizza.Hamur = hamur; //hamuru ayarla
                return this;          //builder'ı döndür
            }


            //peynir eklemek için metot
            public PizzaBuilder PeynirEkle(string peynir)
            {
                _pizza.Peynir = peynir;
                return this;
            }


            //sos eklemek için metot
            public PizzaBuilder SosEkle(string sos)
            {
                _pizza.Sos= sos;
                return this;
            }


            //malzeme eklemek için metot
            public PizzaBuilder MalzemeEkle(string malzeme)
            {
                _pizza.Malzeme= malzeme;
                return this;
            }

            //oluşturulan pizza nesnesini döndürme metodu
            public Pizza Build() => _pizza;
        }
       
        
    }
}
