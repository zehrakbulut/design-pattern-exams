# Factory Pattern Örneği - Oyuncak Fabrikası

Bu proje, **Factory Pattern** tasarım desenini basit bir oyuncak fabrikası örneği üzerinden açıklamaktadır. Factory Pattern, nesne yaratma sürecini merkezi bir sınıfa (fabrika) devrederek, kullanıcıların nesneleri nasıl oluşturacaklarını bilmeden ihtiyaç duydukları nesneleri elde etmelerini sağlar. 

## Factory Pattern Nedir?

**Factory Pattern** (Fabrika Deseni), nesne oluşturma işlemlerini merkezi bir sınıfa devrederek kodun daha esnek ve yönetilebilir olmasını sağlayan bir tasarım desenidir. Kullanıcı, hangi tür nesneye ihtiyaç duyduğunu belirtir; fabrikanın nasıl çalıştığını bilmesine gerek yoktur. Bu desen, büyük ve karmaşık projelerde nesne yaratma süreçlerini yönetmek için oldukça kullanışlıdır.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `IOyuncak` Arayüzü

Bu arayüz, tüm oyuncak türlerinin sahip olması gereken bir metodu tanımlar. Arayüzler, farklı sınıfların benzer bir yapıya sahip olmasını sağlar.

### 2. `ArabaOyuncak` ve `BebekOyuncak` Sınıfları

Bu sınıflar, `IOyuncak` arayüzünü uygular ve her biri kendi `Oyna()` metodunu içerir. Böylece, oyuncak türüne göre farklı davranışlar sergileyebilirler.

### 3. `OyuncakFabrikasi` Sınıfı

Bu sınıf, kullanıcıdan gelen talebe göre doğru türde oyuncağı yaratır. `OyuncakYap()` metodu, istenen türde oyuncağı yaratıp geri döndürür. 

### 4. `Program` Sınıfı

Bu sınıf, fabrikayı kullanarak bir oyuncak yaratmak ve çalıştırmak için `Main()` metodunu içerir. Burada, `OyuncakFabrikasi` sınıfı kullanılarak istenen türde bir oyuncak üretilir ve oynanır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. `"araba"` türünde bir oyuncak oluşturulacak ve `"Araba ile oynuyorsun."` çıktısını göreceksiniz.

## Neden Factory Pattern Kullanılır?

Bu örnekte, `OyuncakFabrikasi` sınıfı farklı oyuncak türlerini yaratma işlemini yönetiyor. Bu sayede:

- Kod daha düzenli ve okunabilir hale gelir.
- Yeni bir oyuncak türü eklemek istenirse, yalnızca yeni bir sınıf oluşturmak ve fabrikanın bu sınıfı tanımasını sağlamak yeterlidir.
- Kodumuz farklı nesne türleri arasında kolayca genişletilebilir ve yönetilebilir olur.

## İleride Yapılabilecek Geliştirmeler

Bu yapıya ek olarak, `OyuncakFabrikasi` sınıfını dinamik hale getirebilir veya yeni oyuncak türleri ekleyebiliriz. Örneğin, yeni bir `TopOyuncak` sınıfı oluşturup fabrikanın bu sınıfı tanımasını sağlamak, yeni bir oyuncak türünü sisteme entegre etmek için yeterli olacaktır.

## Sonuç

Bu proje, **Factory Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Factory Pattern, nesne oluşturma sürecini kontrol etmenin yanı sıra kodun yeniden kullanılabilirliğini artırmak için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha modüler ve yönetilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
