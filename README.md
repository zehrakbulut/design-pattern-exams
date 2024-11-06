# Adapter Pattern Örneği - Priz Adaptörü

Bu proje, **Adapter Pattern** tasarım desenini basit bir priz adaptörü örneği üzerinden açıklamaktadır. Adapter Pattern, birbirinden uyumsuz iki arayüzün birbirine uyumlu hale getirilmesini sağlayan bir yapıdır. Bu desen, eski sistemlerle yeni sistemlerin uyumsuzluklarını giderirken, mevcut sınıfları değiştirmeye gerek kalmadan çalışabilen çözümler sunar.


## Adapter Pattern Nedir?

**Adapter Pattern** (Adaptör Deseni), uyumsuz iki arayüzü birbirine uyumlu hale getiren bir tasarım desenidir. Bu desen, mevcut sistemleri değiştirmeden, yeni bir sistemle uyumlu çalışabilmesi için gerekli adaptasyonu yapar. Adapter, istemci kodunun yeni sistemin arayüzünü kullanabilmesini sağlar, böylece istemci eski sistemle uyumsuz olsa bile doğru şekilde çalışabilir.


## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. ITurkPriz Arayüzü

Bu arayüz, Türk prizi ile uyumlu cihazların sahip olması gereken bir metodu tanımlar. `TakVeCalistir()` metodu, prizin takılması ve cihazın çalıştırılması için gerekli işlemi başlatır.

### 2. TurkPriz Sınıfı

Bu sınıf, `ITurkPriz` arayüzünü implement eder ve Türk prizi ile uyumlu cihazların bağlanmasını sağlar. Bu sınıf, `TakVeCalistir()` metodunu içerir.

### 3. AmerikanPriz Sınıfı

Bu sınıf, Amerikan prizini temsil eder ve eski bir sistemdir. `PlugIn()` metodu, cihazı Amerikan prizine bağlamak için kullanılır. Ancak, bu arayüz Türk priziyle uyumsuzdur ve bu yüzden doğrudan kullanılamaz.

### 4.PrizAdapter Sınıfı

Bu sınıf, Adapter Pattern'in kendisidir ve `ITurkPriz` arayüzünü implement eder. `PrizAdapter` sınıfı, Amerikan prizi ile Türk prizini uyumlu hale getirir. `TakVeCalistir()` metodu, Amerikan prizine bağlama işlemini yaparak uyumlu hale getirir.

### 5. Program Sınıfı

Bu sınıf, programın ana akışını içerir. `Main()` metodunda, Amerikan prizi için bir adaptör oluşturulur ve bu adaptör üzerinden prizin Türk prizi gibi çalışması sağlanır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. Program.cs dosyasındaki Main() metodunu çalıştırın.
3. İlk olarak, bir Amerikan prizi Türk prizine adapte edilecek ve "Amerikan prizine bağlandınız" mesajı konsola yazdırılacaktır.
   
## Neden Adapter Pattern Kullanılır?

Bu örnekte, `PrizAdapter` sınıfı, Türk prizi ile Amerikan prizini uyumlu hale getirmek için kullanılır. Bu sayede:

- Eski sistemleri değiştirmeye gerek kalmadan yeni sistemle uyum sağlanır: Amerikan prizini doğrudan kullanamayacak bir sistemde, bu adaptör sayesinde Türk prizine uyumlu bir hale gelir.
- Kodun esnekliği artar: Farklı sistemler arasında uyumsuzlukları çözerken, mevcut sınıflarda değişiklik yapmaya gerek kalmaz.
- Yüksek modülerlik sağlanır: Uyumsuz sistemler, adaptör sınıfları kullanılarak birbirine entegre edilebilir.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için, başka türde prizler veya cihazlar eklenebilir. Örneğin, Avrupa prizine uyumlu bir adaptör sınıfı oluşturulabilir. Her yeni priz türü için ayrı bir adaptör sınıfı eklemek mümkündür. Ayrıca, farklı cihaz türleri için de benzer adaptör sınıfları geliştirmek, sistemin genişletilebilirliğini artıracaktır.

## Sonuç

Bu proje, Adapter Pattern'i anlamanızı sağlayacak basit bir örnek sunar. Adapter Pattern, uyumsuz sistemlerin birbirine uyumlu hale getirilmesinde güçlü bir araçtır ve mevcut kodu değiştirmeden yeni sistemlerle çalışabilmesini sağlar. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha esnek ve sürdürülebilir hale getirebilirsiniz.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
