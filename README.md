# Iterator Pattern Örneği - Koleksiyon Üzerinde Yineleyici

Bu proje, **Iterator Pattern** tasarım desenini bir koleksiyon üzerinden yineleyici kullanarak açıklamaktadır. Iterator Pattern, bir koleksiyonun elemanlarına erişimi soyutlayarak, koleksiyona özel olmayan bir şekilde elemanlar üzerinde gezinmeyi sağlar. Bu sayede koleksiyonun nasıl yapıldığından bağımsız olarak elemanlara ulaşılabilir.

## Iterator Pattern Nedir?

**Iterator Pattern** (Yineleyici Deseni), bir koleksiyonun elemanlarına sırasıyla erişim sağlayan bir desen olup, koleksiyon yapısının dışına çıkmadan elemanlara ulaşılmasını sağlar. Bu desen, bir koleksiyonun iç yapısını gizler ve her türlü koleksiyona (array, liste, vs.) yönelik genel bir gezinme arayüzü sunar.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `IAggregate` Arabirimi

`IAggregate` arabirimi, bir koleksiyonun üzerinde gezinmek için bir `IIterator` nesnesi oluşturulmasını sağlayan metodu tanımlar.

### 2. `Collection` Sınıfı

Bu sınıf, koleksiyonun somut bir temsilidir ve `IAggregate` arabirimini implement eder. İçerisinde bir liste tutar ve bu liste üzerinde gezinmek için bir `IIterator` oluşturur.

### 3. `IIterator` Arabirimi

`IIterator` arabirimi, koleksiyon üzerinde gezinmeyi sağlayan temel işlemleri tanımlar. `HasNext()` ile bir sonraki elemana geçip geçilemeyeceği kontrol edilir, `Next()` ile bir sonraki elemana geçilir.

### 4. `ConcreteIterator` Sınıfı

`ConcreteIterator` sınıfı, koleksiyonu ve yineleyicinin durumunu yönetir. Bu sınıf, `IIterator` arabirimini implement ederek koleksiyon üzerinde gezinme işlemini gerçekleştirir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Koleksiyon üzerinde gezinmek için `Iterator` kullanın. Koleksiyondaki elemanlar sırasıyla ekrana yazdırılacaktır.

## Neden Iterator Pattern Kullanılır?

Bu örnekte, koleksiyon ve yineleyici arasındaki ilişki soyutlanmıştır. Bu sayede:

- Koleksiyon yapıları değiştirildiğinde, yineleyici kodunda herhangi bir değişiklik yapılmasına gerek kalmaz.
- Farklı koleksiyon türleri (listeler, diziler, setler, vb.) üzerinde aynı şekilde gezinilebilir.
- Uygulamanın esnekliği artar ve yeni koleksiyon türleri eklenmesi kolaylaşır.

## İleride Yapılabilecek Geliştirmeler

- Farklı koleksiyon türleri (örneğin, kümeler veya diziler) eklenerek mevcut yapıya yeni koleksiyonlar entegre edilebilir.
- `ConcreteIterator` sınıfına farklı gezinme stratejileri (örneğin geri yönde gezinme) eklenebilir.

## Sonuç

Bu proje, **Iterator Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Iterator Pattern, koleksiyonlar üzerinde gezinmeyi soyutlayarak kodun esnekliğini ve yönetilebilirliğini artırmak için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, koleksiyonlarınızı daha modüler ve genişletilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
