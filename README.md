# Bridge Pattern Örneği - Cihaz Kontrolü

Bu proje, **Bridge Pattern** tasarım desenini bir cihaz kontrol sistemi örneği üzerinden açıklamaktadır. Bridge Pattern, soyutlama (abstraction) ve uygulama (implementation) arasındaki bağımsızlığı sağlayarak her iki kısmın birbirinden bağımsız olarak geliştirilebilmesini sağlar. Bu örnekte, farklı cihazları kontrol edebilen bir kumanda sistemi tasarlanmıştır.

## Bridge Pattern Nedir?

**Bridge Pattern** (Köprü Deseni), soyutlama ve uygulama arasındaki bağı bağımsızlaştırmayı sağlayan bir yapısal tasarım desenidir. Bu desen, bir nesnenin soyutlanmış yönleri ile uygulamasını (örneğin bir kumanda ile farklı cihazları) birbirinden ayırarak her iki tarafın bağımsız olarak genişletilebilmesine olanak tanır. Örneğin, bir kumanda nesnesinin televizyon veya radyo gibi farklı cihazları kontrol etmesini sağlar.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `Cihaz` Arabirimi

`Cihaz` arabirimi, kontrol edilebilecek cihazlar için temel işlemleri (açma, kapatma, ses ayarlama) tanımlar. Bu arabirimi uygulayan her cihaz, bu işlemleri kendine özgü şekilde gerçekleştirebilir.

### 2. `Televizyon` ve `Radyo` Sınıfları

Bu sınıflar, `Cihaz` arabirimini implement eder ve kendi açma, kapama ve ses ayarlama özelliklerini içerir.

### 3. `Kumanda` Sınıfı

`Kumanda` sınıfı, bir `Cihaz` nesnesi alarak ona ait temel işlemleri gerçekleştiren bir yapıdır. `AcKapat()` metodu sayesinde bağlı olan cihazı açabilir veya kapatabilir.

### 4. `GelismisKumanda` Sınıfı

`GelismisKumanda`, `Kumanda` sınıfını genişletir ve ekstra olarak `SesAyarla` metodunu içerir. Bu sayede ses seviyesi ayarı gibi ileri düzey kontroller yapılabilir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. `Televizyon` ve `Radyo` cihazlarını kontrol etmek için kumandaları kullanın.
   - Televizyonu açıp kapatabilir, radyoyu açabilir ve ses seviyesini ayarlayabilirsiniz.

## Neden Bridge Pattern Kullanılır?

Bu örnekte, `Kumanda` ve `Cihaz` nesneleri arasındaki bağ bağımsız hale getirilmiştir. Bu sayede:

- Yeni cihazlar eklendiğinde `Kumanda` yapısında bir değişiklik yapılmasına gerek kalmaz.
- Farklı türde cihazları kontrol etmek için aynı kumanda yapısı kullanılabilir.
- Uygulamanın esnekliği ve genişletilebilirliği artar; çünkü cihaz ve kumanda tarafları birbirinden bağımsız geliştirilmiştir.

## İleride Yapılabilecek Geliştirmeler

- Farklı cihaz türleri (örneğin klima veya akıllı lamba) eklenerek mevcut yapıya yeni cihazlar entegre edilebilir.
- `GelismisKumanda` sınıfına kanal değiştirme gibi ekstra özellikler eklenebilir.

## Sonuç

Bu proje, **Bridge Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Bridge Pattern, soyutlama ve uygulamanın bağımsız geliştirilmesine olanak tanıyarak, kodun esnekliğini ve yönetilebilirliğini artırmak için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha modüler ve genişletilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
