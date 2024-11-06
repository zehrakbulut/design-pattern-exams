# Prototype Pattern Örneği - Kedi Klonlama

Bu proje, **Prototype Pattern** tasarım desenini basit bir kedi klonlama örneği üzerinden açıklamaktadır. **Prototype Pattern**, var olan bir nesnenin kopyalarını oluşturarak aynı özelliklere sahip yeni nesneler yaratmayı sağlar.

## Prototype Pattern Nedir?

**Prototype Pattern** (Prototip Deseni), bir nesnenin mevcut özelliklerini koruyarak kopyasını oluşturmak için kullanılan bir tasarım desenidir. Karmaşık nesnelerin sürekli yeniden oluşturulması yerine, var olan nesneler üzerinden hızlıca kopyalar oluşturulmasını sağlar. Örneğin, bir resim düzenleme uygulamasında aynı özelliklere sahip çok sayıda kedi nesnesi gerekiyorsa, her seferinde yeni bir kedi nesnesi oluşturmak yerine mevcut bir kedi nesnesini klonlayarak hız kazanabiliriz.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:


### 1. `Kedi` Sınıfı

Kedi sınıfı, klonlanabilir özelliklere sahip bir kedi nesnesini temsil eder. Bu sınıf, kopyalama işlemini kolaylaştırmak için bir Klonla metodu sağlar ve şu özellikleri içerir:

-`Renk`: Kedinin rengi
-`Cins`: Kedinin cinsi
Ayrıca `BilgiVer` metodu ile kedi özellikleri ekrana yazdırılabilir.

### 2. `Kedi.Klonla()` Metodu

Bu metot, mevcut `Kedi` nesnesinin aynısını oluşturan klonlama fonksiyonudur. **Prototype Pattern** sayesinde, var olan bir nesne baz alınarak hızlıca aynı özelliklere sahip yeni bir nesne yaratılabilir. Bu metod, `MemberwiseClone()` kullanılarak yüzeysel bir kopya döndürür.

### 3. `Main` Metodu

`Main` metodu, `Kedi` sınıfını kullanarak bir orijinal kedi nesnesi oluşturur, ardından bu nesneyi klonlıyarak bir kopyasını alır ve üzerinde değişiklikler yapar. Bu sayede, klonlanan nesne orijinali etkilemeden kullanılabilir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Oluşturulan orijinal ve klon kedi bilgilerini görüceksiniz.

## Neden Prototype Pattern Kullanılır?

Prototype Pattern, belirli özelliklere sahip nesneleri yeniden ve hızlı bir şekilde oluşturmak için oldukça kullanışlıdır. Özellikle aynı türden çok sayıda nesne oluşturulması gereken durumlarda hem bellek kullanımı hem de hız açısından avantaj sağlar.

- Verimlilik: Mevcut bir nesne üzerinden kopya yaratmak, sıfırdan nesne oluşturmaktan daha hızlıdır.
- Esneklik: Klonlanan nesne üzerinde yapılan değişiklikler orijinal nesneyi etkilemez. Bu da esneklik sağlar.

## İleride Yapılabilecek Geliştirmeler

Bu yapı üzerine yeni kedi türleri veya özellikler eklenebilir. Ayrıca, derin kopya yapısını desteklemek için `MemberwiseClone` yerine özel klonlama yöntemleri oluşturulabilir.

## Sonuç

Bu örnek, **Prototype Pattern**'i anlamanız için basit bir uygulama sunar. Bu desen sayesinde nesneleri klonlayarak farklı versiyonlarını hızlıca oluşturabilir ve esnek bir nesne yönetimi sağlayabilirsiniz.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
