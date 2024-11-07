# Observer Pattern Örneği - Cihaz Durum Takibi

Bu proje, **Observer Pattern** tasarım desenini cihaz durum takibi sistemi üzerinden açıklamaktadır. Observer Pattern, bir nesnenin durumundaki değişiklikleri birden fazla gözlemciye bildirme yeteneği sağlar ve bu sayede nesneler arasında gevşek bir bağlılık kurar.

## Observer Pattern Nedir?

**Observer Pattern** (Gözlemci Deseni), davranışsal bir tasarım desenidir. Bu desen, bir nesne üzerinde gerçekleşen durum değişikliklerinin birden fazla nesneye otomatik olarak bildirilmesini sağlar. Böylece gözlemciler, konu olan nesnenin durumunu izleyebilir ve değişikliklerden haberdar olabilir. Özellikle, bir nesnenin durumu değiştiğinde diğer nesneleri etkilemesi gereken sistemlerde bu desen oldukça faydalıdır.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `IGozlemci` Arabirimi

Bu arabirim, gözlemci olarak davranacak nesnelerin güncellemeleri alabilmesi için bir `Guncelle` metodunu tanımlar. Tüm gözlemciler bu arabirimi uygulayarak durumu takip edebilir.

### 2. `Cihaz` Sınıfı

`Cihaz` sınıfı, gözlemcileri eklemek ve çıkarmak için temel fonksiyonlar sağlar. Bu sınıf üzerinden gözlemciler `GozlemciEkle` ve `GozlemciCikar` metotları ile yönetilebilir. `BildirimYap` metodu ise tüm gözlemcilere cihaz durumundaki değişiklikleri iletir.

### 3. `Televizyon` ve `Radyo` Sınıfları

`Televizyon` ve `Radyo`, `Cihaz` sınıfını genişleten sınıflardır. Bu sınıflar, cihazların spesifik özelliklerini temsil eder ve durum değişikliklerini gözlemcilere iletir. Her cihaz sınıfında bir `DurumDegistir` metodu bulunur ve bu metod aracılığıyla cihazın durum değişikliği gözlemcilere bildirilir.

### 4. `Kanal` Sınıfı

`Kanal` sınıfı, `IGozlemci` arabirimini implement eder. Her bir `Kanal`, bir gözlemci olarak cihazların durum değişikliklerinden haberdar olur ve durumu kendi iç işleyişine göre değerlendirir. Örneğin, `Guncelle` metodu ile yeni durumu alır ve bu durumu ekrana yazdırır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. `Televizyon` ve `Radyo` cihazlarının durum değişiklikleri, gözlemci olarak eklenen kanallara iletilir.

## Neden Observer Pattern Kullanılır?

Bu projede, `Observer Pattern` sayesinde `Kanal` sınıfları, `Cihaz` sınıfındaki değişikliklerden otomatik olarak haberdar edilir. Bu yapı ile:

- Her cihazdaki durum değişikliği tüm gözlemcilere otomatik olarak bildirilir.
- Yeni gözlemciler kolayca eklenip çıkarılabilir.
- Cihazlar ve gözlemciler arasında güçlü bir bağ olmadan, birbiriyle ilişkili ancak bağımsız nesneler oluşturulur.


## İleride Yapılabilecek Geliştirmeler

Bu yapıya yeni cihaz türleri ekleyerek örneği genişletebiliriz. Örneğin, `Bilgisayar` veya `Akıllı Saat` gibi yeni cihazlar eklenebilir. Ayrıca, gözlemcilere daha fazla özelleştirme seçeneği sunulabilir veya her gözlemcinin kendi güncelleme stratejisini belirlemesine imkan tanınabilir.

## Sonuç

Bu proje, **Observer Pattern**’i anlamanıza yardımcı olacak basit bir örnektir. Observer Pattern, bir nesne üzerindeki değişiklikleri birden fazla gözlemciye bildirme yeteneği sağlar ve sisteminizin genişletilebilirliğini artırır. Uygulamalarınızda bu deseni kullanarak, kodunuzun yönetilebilirliğini ve modülerliğini artırabilirsiniz.




