# Composite Pattern Örneği - Dosya ve Klasör Yapısı

Bu proje, **Composite Pattern** (Bileşik Desen) tasarım desenini basit bir dosya ve klasör yapısı ile açıklamaktadır. Composite Pattern, nesneleri ağaç yapısında düzenleyerek bir nesne grubunu tek bir nesne gibi işlemeye olanak tanır. Bu desen, özellikle hiyerarşik yapılarda, tekil ve bileşik nesnelerle çalışmayı kolaylaştırır.


## Composite Pattern Nedir?

**Composite Pattern** (Bileşik Desen), nesnelerin ağaç yapısında düzenlenmesine ve bileşik nesnelerle aynı şekilde işlem yapılmasına izin veren bir tasarım desenidir. Composite Pattern genellikle şu durumlarda kullanılır:

- Hiyerarşik yapılar: Nesnelerin birbirine bağlı olduğu ve ağaç yapısında düzenlenmesi gerektiği durumlarda.
- Tekdüze erişim: Tekil ve bileşik nesnelerin aynı arayüzle erişilebilmesi için.
- Esneklik: Nesne gruplarının ve tekil nesnelerin aynı işlemi desteklemesi gerektiğinde.
  
Bu desen, hem tekil nesnelerin hem de bileşik nesnelerin aynı işlemler için aynı arayüzü kullanmasını sağlar. Örneğin, bir dosya ve klasör yapısında hem dosya hem de klasör "göster" işlemini destekler.


## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. IDosya Arayüzü

Dosya ve klasör nesneleri için temel arayüzdür. `Goster()` metodu, dosya veya klasör adını ekrana yazdırır.


### 2. Dosya Sınıfı

Dosyaları temsil eden sınıftır. `Goster()` metodunu kullanarak dosyanın adını ekrana yazdırır.


### 3. Klasor Sınıfı

Birden fazla dosya ve alt klasör içerebilen klasör nesnelerini temsil eder. `Ekle()` metodu ile içine yeni dosyalar veya alt klasörler eklenebilir. `Goster()` metodu, klasör ve içeriğindeki tüm dosya ve klasörleri ekrana yazdırır.

### 4. Program Sınıfı
Programın ana akışını içerir. `Main()` metodunda, bir ana klasör, alt klasör ve dosyalar eklenerek bileşik yapı oluşturulur.


## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Ana klasör, alt klasör ve dosyaların isimleri hiyerarşik bir yapıda ekrana yazdırılacaktır.
   
## Neden Composite Pattern Kullanılır?

**Composite Pattern**'in kullanılmasının nedenleri şunlardır:

- **Tekdüze Erişim**: Dosyalar ve klasörler, aynı arayüzü kullanarak işlemlerini gerçekleştirir.
- **Esneklik**: Tekil dosyalar ve iç içe geçmiş klasör yapıları tek bir yapıda birleştirilebilir.
- **Kolay Yönetim**: Klasör yapısı, bileşik bir yapıda nesneleri daha kolay yönetmenizi sağlar. Örneğin, bir klasörü gösterdiğinizde içindeki tüm dosya ve klasörler otomatik olarak listelenir.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için yeni işlevler eklenebilir.

- Silme İşlemi: Dosya veya klasörlerin Sil() metodunu ekleyerek içerikleri silinebilir.
- Arama İşlemi: Klasörlerde belirli bir dosyayı aramak için bir Ara() metodu eklenebilir.
- Erişim Logları: Dosya veya klasöre yapılan erişimi kaydeden bir log mekanizması eklenebilir.
  
Her yeni özellik, Composite Pattern yapısını koruyarak eklenebilir. Bu şekilde, dosya ve klasör yapısını daha esnek ve dinamik hale getirmek mümkün olur.




## Sonuç

Composite Pattern, nesneleri tekil veya bileşik yapılarla işlem yapabilecek şekilde organize etmenizi sağlar. Dosya ve klasör yapısında olduğu gibi, hiyerarşik yapılarda esneklik ve yönetim kolaylığı sunar. Bu örnekte, dosya ve klasörlerin bileşik bir yapı halinde nasıl kullanılabileceğini, Composite Pattern'in avantajlarını göstererek açıklamaktadır.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
