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
            //Facade kullanarak tv'yi açıyoruz
            TelevizyonFacade tv = new TelevizyonFacade();
            tv.TelevizyonuAc();

            Console.ReadLine();

        }

        public class Ekran
        {
            public void Ac()
            {
                Console.WriteLine("ekran açıldı");
            }
        }

        public class Ses
        {
            public void Ayarla()
            {
                Console.WriteLine("ses ayarlandı");
            }
        }

        public class Kanal
        {
            public void Ayarla()
            {
                Console.WriteLine("kanal ayarlandı");
            }
        }

        public class TelevizyonFacade  //bu sınıf tüm işlemleri tek bir arayüzle yönetir
        {
            private readonly Ekran _ekran=new Ekran();
            private readonly Ses _ses=new Ses();
            private readonly Kanal _kanal=new Kanal();

            public void TelevizyonuAc()
            {
                _ekran.Ac();
                _ses.Ayarla();
                _kanal.Ayarla();
            }
        }
  
    }
}
