using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            //singleton örneğini alalım
            Singleton singleton1=Singleton.GetInstance();
            singleton1.SingletonYap();  //çıktı: singleton işlemi gerçekleştiriliyor


            Singleton singleton2=Singleton.GetInstance();
            singleton2.SingletonYap();

            Console.WriteLine(ReferenceEquals(singleton1, singleton2)
                ? "singleton1 ve singleton2 aynı nesne"
                : "singleton1 ve singleton2 farklı nesneler");

            Console.ReadLine();

        }

        public class Singleton
        {
            //singleton sınıfının tek örneğini saklamak için bir statik değişken
            private static Singleton _instance;


            //özel yapıcı: dışarıdan yeni bir singleton nesnesini oluşturulamıyor
            private Singleton()
            {
                Console.WriteLine("singleton nesnesi oluşturuldu");
            }

            //singleton örneğine erişim sağlıyan public metot
            public static Singleton GetInstance()
            {
                //eğer örnek daha önce oluşturulmadıysa, yeni bir örnek oluştur
                if(_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance; //tekil örneği döndür
            }


            public void SingletonYap()
            {
                Console.WriteLine("singleton işlemi gerçekleştiriliyor.");
            }
        }
        
    }
}
