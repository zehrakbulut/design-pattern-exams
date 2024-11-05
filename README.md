# Singleton Pattern Örneği - Ayar Yönetimi

Bu proje, **Singleton Pattern** tasarım desenini basit bir ayar yönetimi örneği üzerinden açıklamaktadır. Singleton Pattern, bir sınıftan yalnızca bir örneğin oluşturulmasını sağlayarak, bu örneğe global erişim imkanı tanır. 

## Singleton Pattern Nedir?

**Singleton Pattern** (Tekil Desen), bir sınıfın yalnızca bir örneğinin olmasını ve bu örneğe global erişim sağlamayı garanti eden bir tasarım desenidir. Bu desen, özellikle paylaşılan kaynakların yönetimi veya uygulama genelinde tekil nesnelerin kullanılması gereken durumlarda faydalıdır. Örneğin, bir uygulamada yalnızca bir adet ayar yönetimi nesnesi olması gerektiğinde kullanılır.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `Singleton` Sınıfı

Bu sınıf, tekil nesnenin saklandığı yerdir. `GetInstance()` metodu, sınıfın yalnızca bir örneğinin oluşturulmasını sağlayarak, bu örneğe erişim imkanı tanır. Özel yapıcı metodu sayesinde dışarıdan yeni bir nesne oluşturulamaz.

### 2. `Main` Metodu

Bu metod, `Singleton` sınıfını kullanarak bir nesne oluşturmak ve bu nesne üzerinden işlem yapmak için kullanılır. Burada, Singleton nesnesi oluşturulacak ve onun metodları çağrılarak işlemler gerçekleştirilecektir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. İlk kez bir Singleton nesnesi oluşturulacak ve `"singleton işlemi gerçekleştiriliyor."` çıktısını göreceksiniz. 
4. İkinci kez nesne alındığında, aynı nesne dönecek ve yine aynı işlem gerçekleştirilecektir.

## Neden Singleton Pattern Kullanılır?

Bu örnekte, `Singleton` sınıfı bir nesnenin tekil olmasını sağlıyor. Bu sayede:

- Uygulama içinde paylaşılan kaynaklar daha verimli bir şekilde yönetilir.
- Tekil nesneye global erişim sağlanarak, her yerden aynı nesne kullanılabilir.
- Kod daha düzenli ve okunabilir hale gelir; çünkü her yerde yeni nesne yaratma gerekliliği ortadan kalkar.

## İleride Yapılabilecek Geliştirmeler

Bu yapıya ek olarak, Singleton sınıfına farklı ayar metodları veya özellikleri ekleyebiliriz. Örneğin, Singleton nesnesine ayarları değiştiren bir metod eklemek, uygulamanızın ayar yönetimini daha da geliştirebilir.

## Sonuç

Bu proje, **Singleton Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Singleton Pattern, uygulama genelinde tekil nesnelerin yönetimini sağlamanın yanı sıra kodun yeniden kullanılabilirliğini artırmak için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha modüler ve yönetilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
