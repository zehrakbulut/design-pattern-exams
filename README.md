# Command Pattern (Komut Deseni)

**Command Pattern** (Komut Deseni), bir işlemi (komut) nesne olarak paketlememizi sağlar. Bu sayede komutları kaydedebilir, geri alabilir veya sırasıyla çalıştırabiliriz. Özellikle, istemcilerin doğrudan bir işlemi çağırmak yerine bu işlemi bir komut nesnesi aracılığıyla çalıştırması gerektiğinde kullanılır. Bu desen, komutların parametrelerle birlikte iletilmesini ve zamanla daha karmaşık işlemlerin yönetilmesini kolaylaştırır.

## Command Pattern Nedir?

**Command Pattern**, bir işlemi (komutu) nesne olarak paketleyerek istemci ile alıcı (receiver) arasındaki bağı azaltan bir yapısal tasarım desenidir. Komutlar, nesnelerin içinde tutulur ve gerektiğinde çalıştırılır. Bu sayede, işlemlerin sırasının değiştirilmesi, işlemlerin geri alınması veya yeniden çalıştırılması gibi esneklikler sağlanabilir.

## Projedeki Bileşenler

### 1. `IKomut` Arabirimi

Bu arabirim, tüm komutların uygulaması gereken bir `Calistir` metodunu tanımlar. `Calistir` metodu, komutun gerçekleştireceği işlemi içerir.

### 2. `IsikAcKomut` ve `IsikKapatKomut` Sınıfları

Bu sınıflar, `IKomut` arabirimini implement eder ve her biri kendi açma ve kapama işlemini gerçekleştirir.

### 3. `Kumanda` Sınıfı

`Kumanda` sınıfı, bir komutu alarak onu çalıştıran bir yapıdır. Kumanda, komutların çalıştırılmasını sağlayan bir kontrol yapısıdır.

## Kullanım

1. Projeyi bir C# IDE (örneğin Visual Studio) ile açın.
2. `Program.cs` dosyasındaki `Main` metodunu çalıştırarak, komutları test edin.
   - Işık açma ve kapama işlemleri, komutlar aracılığıyla sırasıyla yapılacaktır.

## Neden Command Pattern Kullanılır?

- **Geri Alma ve Yeniden Uygulama:** Komutlar, işlem sırasına göre tutulabilir ve gerektiğinde geri alınabilir. Örneğin, bir ışık açma komutu, daha sonra geri alındığında ışığı kapatma komutuna dönüşebilir.
- **Komutların Parametrelerle Kullanılması:** Komutlar parametreler alabilir, böylece daha esnek bir yapı oluşturulabilir.
- **İşlemlerin Sırasıyla Çalıştırılması:** Birden fazla komut sırasıyla çalıştırılabilir, böylece birden fazla işlem bir arada yapılabilir.
- **Yeni İşlemlerin Eklenmesi:** Yeni komutlar eklemek kolaydır ve mevcut kumanda yapısı üzerinde değişiklik yapılmasına gerek yoktur.

## Sonuç

**Command Pattern**, işlem nesnelerinin yönetilmesini kolaylaştıran, esneklik sağlayan ve genişletilebilirliği artıran güçlü bir tasarım desenidir. Bu desen, özellikle GUI uygulamalarında ve istemci-sunucu yapılarında sıklıkla kullanılır. Komutlar aracılığıyla kullanıcı etkileşimlerini kontrol etmek, işlemleri sırasıyla uygulamak ve geri almak gibi fonksiyonları yönetmek mümkündür.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
