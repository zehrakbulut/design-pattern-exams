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
            ProxyInternet internet= new ProxyInternet();

            //izin verilen siteye bağlanma
            internet.Baglan("google.com");

            //yasaklı bir siteye bağlanma   
            internet.Baglan("yasaklisite.com");

            Console.ReadLine();

        }

        public class GercekInternet
        {
            public void Baglan(string url)
            {
                Console.WriteLine($"{url} adresine bağlanıldı.");
            }
        }

        public class ProxyInternet
        {
            private readonly GercekInternet _gercekInternet= new GercekInternet();

            public void Baglan(string url)
            {
                //yasaklı site kontrolü
                if (url == "yasaklisite.com")
                {
                    Console.WriteLine("bu siteye erişim yasaklandı");
                }
                else
                {
                    //gerçek internete bağlan
                    _gercekInternet.Baglan(url);
                }
            }
        }
    }
}
