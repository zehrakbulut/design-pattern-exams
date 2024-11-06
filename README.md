# Abstract Factory Pattern Örneği - Hayvan Fabrikası

Bu proje, **Abstract Factory Pattern** tasarım desenini basit bir hayvan fabrikası örneği üzerinden açıklamaktadır. Abstract Factory Pattern, nesne yaratma sürecini merkezi bir sınıfa (soyut fabrika) devrederek, kullanıcıların nesneleri nasıl oluşturacaklarını bilmeden ihtiyaç duydukları nesneleri elde etmelerini sağlar. Ayrıca, ilgili nesnelerden oluşan gruplar halinde nesne oluşturma yeteneği sunar.


## Abstract Factory Pattern Nedir?

**Abstract Factory Pattern** (Soyut Fabrika Deseni), birbirleriyle ilişkili veya bağımlı nesnelerin gruplar halinde yaratılmasını sağlayan bir tasarım desenidir. Nesne oluşturma işlemleri, somut sınıflara bağımlı olmadan yapılır ve kullanıcı, yalnızca hangi soyut fabrika sınıfını kullanacağını seçer. Bu desen, özellikle farklı türlerde nesneler üretirken daha esnek ve genişletilebilir bir yapı sağlamak amacıyla tercih edilir.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. IHayvan Arayüzü

Bu arayüz, tüm hayvan türlerinin sahip olması gereken bir metodu tanımlar. Her hayvan sınıfı, `SesCikar()` adlı bir metod içerir. Bu, farklı hayvan türlerinin kendi seslerini çıkarabilmesini sağlar.

### 2. Inek ve Kedi Sınıfı

Bu sınıflar, `IHayvan` arayüzünü uygular ve kendi `SesCikar()` metodlarını içerir. Böylece, her hayvan türü farklı bir davranış sergileyebilir (örneğin, inek "möö" sesi çıkarırken kedi "miyav" sesi çıkarır).

### 3. IHayvanFabrikasi Arayüzü

Bu arayüz, hayvan üretim sürecini yöneten bir soyut fabrika görevi görür. `HayvanOlustur()` metodunu içerir ve farklı hayvan fabrikaları, bu metodu uygulayarak belirli hayvan türlerini üretir.

### 4. InekFabrikasi ve KediFabrikasi Sınıfları

Bu sınıflar, `IHayvanFabrikasi` arayüzünü uygular. Her bir fabrika, belirli bir hayvan türünü üretir (`InekFabrikasi` bir inek üretirken, `KediFabrikasi` bir kedi üretir). Bu sayede, farklı fabrika sınıfları kullanılarak ihtiyaç duyulan hayvan türleri dinamik olarak oluşturulabilir.

### 5. Program Sınıfı

Bu sınıf, ana program akışını içerir. `Main()` metodu içinde, istenen hayvan türüne göre bir fabrika seçilir ve bu fabrika aracılığıyla hayvanlar oluşturulup ses çıkarmaları sağlanır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. Program.cs dosyasındaki Main() metodunu çalıştırın.
3. İlk olarak bir Inek oluşturulup "möö" sesi çıkartacak, ardından bir Kedi oluşturulup "miyav" sesi çıkaracaktır.
   
## Neden Abstract Factory Pattern Kullanılır?

Bu örnekte, `IHayvanFabrikasi` arayüzü ve onu implement eden `InekFabrikasi` ile `KediFabrikasi` sınıfları sayesinde, hangi tür hayvanın yaratılacağına dair tüm bilgiler fabrikada saklanır. Bu sayede:

- Kod daha esnek hale gelir: Yeni hayvan türleri eklemek istediğinizde, sadece yeni bir sınıf ve fabrika eklemek yeterli olacaktır.
- Genişletilebilir bir yapı sağlanır: Herhangi bir değişiklik yapmadan yeni fabrika sınıfları oluşturabilirsiniz.
- Bağımlılık azaltılır: İstemci kod, hangi hayvan sınıfının yaratılacağı bilgisine sahip olmadan çalışabilir.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için, farklı hayvan türleri veya hayvan grupları (örneğin `EvcilHayvanFabrikasi` veya `VahsiHayvanFabrikasi`) eklenebilir. Ayrıca, her fabrika farklı özelliklere sahip hayvan türleri üretecek şekilde genişletilebilir. Yeni bir hayvan türü eklemek için, yeni bir hayvan sınıfı ve fabrika sınıfı tanımlamak yeterlidir.


## Sonuç

Bu proje, Abstract Factory Pattern'i anlamanıza yardımcı olacak basit bir örnektir. Abstract Factory Pattern, nesne yaratma sürecini soyutlayarak, kodun yeniden kullanılabilirliğini artırmak ve farklı nesne gruplarını yaratmada esneklik sağlamak için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha modüler ve yönetilebilir hale getirebilirsiniz.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
