# Builder Pattern Örneği - Pizza Yönetimi

Bu proje, **Builder Pattern** tasarım desenini basit bir pizza oluşturma örneği üzerinden açıklamaktadır. Builder Pattern, karmaşık nesnelerin aşama aşama ve parçalar halinde oluşturulmasını sağlayarak daha okunabilir ve yönetilebilir bir yapı sunar.

## Builder Pattern Nedir?

**Builder Pattern** (Kurucu Desen), bir nesnenin oluşturulmasını kolaylaştırmak için kullanılan bir tasarım desenidir. Özellikle, nesne oluşturma sürecinin karmaşık olduğu durumlarda faydalıdır. Builder Pattern, bir nesnenin özelliklerini ayrı ayrı ayarlamak ve bu özelliklerin kombinasyonları ile esnek bir şekilde nesne oluşturmak için kullanılır.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `Pizza` Sınıfı

Bu sınıf, pizzanın özelliklerini tutar. Aşağıdaki özellikleri içerir:
- `Hamur`: Pizza hamuru türü.
- `Peynir`: Kullanılan peynir türü.
- `Sos`: Pizza üzerindeki sos.
- `Malzeme`: Eklenen malzemeler.

`BilgiVer` metodu, pizzanın bilgilerini konsola yazdırır.

### 2. `PizzaBuilder` Sınıfı

Bu sınıf, pizza nesnesini oluşturmak için gerekli yöntemleri sağlar. Her bir özellik için ayrı metodlar içerir:
- `HamurEkle(string hamur)`: Hamuru ayarlamak için kullanılır.
- `PeynirEkle(string peynir)`: Peyniri ayarlamak için kullanılır.
- `SosEkle(string sos)`: Sosu ayarlamak için kullanılır.
- `MalzemeEkle(string malzeme)`: Malzemeyi ayarlamak için kullanılır.
- `Build()`: Oluşturulan pizza nesnesini döndürür.

### 3. `Main` Metodu

Bu metod, `PizzaBuilder` sınıfını kullanarak bir pizza nesnesi oluşturmak ve bu nesne üzerinden işlem yapmak için kullanılır. Burada, pizza özellikleri ayarlanacak ve oluşturulan pizza bilgileri ekrana yazdırılacaktır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Oluşturulan pizza bilgilerini göreceksiniz.

## Neden Builder Pattern Kullanılır?

Bu örnekte, `PizzaBuilder` sınıfı ile pizza nesnesinin özellikleri adım adım ayarlanmaktadır. Bu sayede:

- Nesne oluşturma süreci daha okunabilir hale gelir.
- Her bir özelliğin ayrı ayrı ayarlanması, nesne oluşturma esnekliği sağlar.
- Metot zincirlemesi ile daha akıcı bir arayüz sunar.

## İleride Yapılabilecek Geliştirmeler

Bu yapıya ek olarak, farklı pizza türleri veya soslar ekleyebiliriz. Ayrıca, pizza nesnesine başka özellikler ekleyerek, kullanıcıların daha fazla özelleştirme yapmasına olanak tanıyabiliriz.

## Sonuç

Bu proje, **Builder Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Builder Pattern, nesne oluşturma sürecini daha esnek ve yönetilebilir hale getirmek için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha modüler ve sürdürülebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
