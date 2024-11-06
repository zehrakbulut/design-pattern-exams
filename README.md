# Decorator Pattern Örneği - Dondurma Zenginleştirme

Bu proje, Decorator Pattern tasarım desenini basit bir dondurma zenginleştirme örneği üzerinden açıklamaktadır. Decorator Pattern, bir nesnenin davranışını, onu değiştirmeden ek fonksiyonellikler ekleyerek geliştiren bir tasarım desenidir. Bu desen sayesinde, var olan nesneleri genişletmek için alt sınıflar oluşturmak yerine, nesnelerin davranışlarını dinamik olarak değiştirebilirsiniz.


## Decorator Pattern Nedir?

**Decorator Pattern** (Dekoratör Deseni), bir nesnenin fonksiyonelliklerini genişletmek için kullanılan bir tasarım desenidir. Bu desen, var olan nesnenin davranışını değiştirmeden ona yeni işlevsellikler eklemeye olanak tanır. Dekoratörler, istemci kodunun yeni işlevsellik eklemesini sağlar, ancak bu değişiklikler nesnelerin orijinal yapısını değiştirmez.


## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. IDondurma Arayüzü

Dondurma nesnelerinin temel işlevini tanımlar. `ServisEt()` metodu, dondurmayı servis etmeyi sağlar.

### 2. SadeDondurma Sınıfı

Dondurmanın sade halini temsil eder. `ServisEt()` metodu, sade dondurma servis eder.

### 3. CikolataDekorator Sınıfı

Dondurmaya çikolata ekleyen dekoratördür. Bu sınıf, `IDondurma` arayüzünü uygular ve `ServisEt()` metodunu genişleterek çikolata ekler.

### 5. Program Sınıfı

Programın ana akışını içerir. `Main()` metodunda, sade dondurma üzerine çikolata dekoratörü eklenir ve dondurma servis edilir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. Program.cs dosyasındaki Main() metodunu çalıştırın.
3. Sade dondurma üzerine çikolata eklenmiş olarak sonuç ekrana yazdırılacaktır.
   
## Neden Decorator Pattern Kullanılır?

Bu örnekte, **Decorator Pattern** sayesinde, mevcut `SadeDondurma` nesnesine çikolata eklenerek fonksiyonellik genişletilmiş olur. Bu sayede:

- Dondurmanın temel yapısı değiştirilmeden yeni özellikler eklenir.
- Yeni işlevsellikler, var olan sınıfları değiştirmeden eklenebilir.
- Kodun esnekliği artar ve genişletilebilirlik sağlanır.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için, başka dekoratörler eklenebilir. Örneğin, vanilya, meyve veya fındık gibi yeni dekoratörler ekleyerek dondurmayı zenginleştirebilirsiniz. Her yeni dekoratör için ayrı bir sınıf yazılabilir ve aynı temel `IDondurma` arayüzü üzerinden yeni özellikler eklenebilir.

## Sonuç

Bu proje, Decorator Pattern'i anlamanızı sağlayacak basit bir örnek sunar. Decorator Pattern, mevcut nesnelere yeni özellikler eklerken, sınıfları değiştirmeden esneklik sağlar. Uygulamalarınızda bu deseni kullanarak, fonksiyonellikleri dinamik olarak genişletebilir ve daha sürdürülebilir bir kod yapısı oluşturabilirsiniz.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
