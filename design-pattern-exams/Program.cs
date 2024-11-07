using System;
using System.Collections.Generic;

namespace design_pattern_exams
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Koleksiyonu yaratıyoruz
            Collection collection = new Collection();

            IIterator iterator = collection.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.ReadLine();
        }

        // Koleksiyonun arayüzü
        public interface IAggregate
        {
            IIterator CreateIterator(); // Yineleyici yaratmak için bir metod
        }

        // Koleksiyonun somut sınıfı
        public class Collection : IAggregate
        {
            private List<string> _items = new List<string>();

            public Collection()
            {
                _items.Add("elma");
                _items.Add("armut");
                _items.Add("muz");
                _items.Add("çilek");
            }

            public IIterator CreateIterator()
            {
                return new ConcreteIterator(this); // Yineleyici döndür
            }

            public int Count => _items.Count; // Koleksiyon eleman sayısı
            public string this[int index] => _items[index]; // İndeksleyici
        }

        // Yineleyici arayüzü
        public interface IIterator
        {
            bool HasNext(); // Bir sonraki eleman var mı?
            object Next();  // Bir sonraki elemana geç
        }

        // Somut Yineleyici
        public class ConcreteIterator : IIterator
        {
            private Collection _collection;
            private int _current = 0;

            public ConcreteIterator(Collection collection)
            {
                _collection = collection;
            }

            public bool HasNext()
            {
                return _current < _collection.Count; // Sonraki eleman var mı?
            }

            public object Next()
            {
                if (HasNext())
                {
                    return _collection[_current++]; // Bir sonraki elemanı döndür
                }
                return null; // Sonraki eleman yoksa null döner
            }
        }
    }
}
