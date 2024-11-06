# Proxy Pattern Örneği - İnternet Erişimi Kontrolü

Bu proje, **Proxy Pattern** (Vekil Deseni) tasarım desenini basit bir internet erişimi kontrolü üzerinden açıklamaktadır. Proxy Pattern, bir nesneye erişimi kontrol etmek veya bu nesnenin yerine başka bir işlem yapmak için kullanılan bir tasarım desenidir. Bu desen, bir nesneye doğrudan erişmek yerine, bu nesnenin arkasında bir vekil (proxy) nesnesi kullanarak işlemi kontrol etmenizi sağlar.


## Proxy Pattern Nedir?

**Proxy Pattern** (Vekil Deseni), bir nesnenin yerine geçerek ona farklı bir işlem uygulamanızı sağlayan bir tasarım desenidir. Vekil, genellikle aşağıdaki durumlar için kullanılır:

- Erişim kontrolü: Nesneye erişimi denetlemek için.
- Performans artırma: Gerçek nesneye erişimi geciktirerek zaman kazanmak için.
- Güvenlik: Nesneye yapılacak erişimleri sınırlamak için.
- Diğer nesnelerin yerine geçme: Gerçek nesneye yapılan işlemleri yönetmek için.

Bu desen, gerçek nesneye yapılan erişimi, proxy (vekil) sınıfının kontrol etmesini sağlar. Proxy sınıfı, gerçek nesnenin yerine geçer, erişim öncesinde bazı işlemler yapabilir veya doğrudan nesneye yönlendirme yapabilir.


## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. GercekInternet Sınıfı

Gerçek internet bağlantısı işlevini temsil eder. `Baglan()` metodu, internete bağlanma işlemini gerçekleştirir.


### 2. ProxyInternet Sınıfı

Gerçek internet bağlantısını proxy aracılığıyla kontrol eder. Proxy sınıfı, `Baglan()` metodunu genişleterek internet erişimini yönetir. Örneğin, yasaklı sitelere erişimi engeller.


### 5. Program Sınıfı

Programın ana akışını içerir. `Main()` metodunda, proxy aracılığıyla internet erişimi kontrol edilir.


## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. İlk olarak, izin verilen bir siteye bağlanma işlemi gerçekleşir.
4. Ardından, yasaklı bir siteye bağlanmak istendiğinde, erişim engellenecektir.
   
## Neden Proxy Pattern Kullanılır?

**Proxy Pattern**'in kullanılmasının nedenleri şunlardır:

**Erişim Kontrolü**: Proxy, belirli koşullara göre (örneğin, yasaklı sitelere erişim) erişim kısıtlamaları getirebilir.
**Performans İyileştirme**: Proxy, bazı işlemleri önceden gerçekleştirebilir, böylece gerçek nesnenin gereksiz yere çalışmasını engelleyebilir.
**Esneklik**: Proxy, gerçek nesneye ek özellikler veya davranışlar eklemenizi sağlar. Örneğin, `ProxyInternet` sınıfı, internet bağlantısı gerçekleştirilmeden önce ek kontroller yapar.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için, yeni proxy türleri eklenebilir. 

- Erişim Günlüğü Proxy: Gerçek internet bağlantısına yapılan her erişimi kaydeden bir proxy eklenebilir. Bu proxy, her bağlantıyı bir log dosyasına yazarak erişim geçmişini takip eder.

- Zaman Kontrolü Proxy: İnternet erişimini yalnızca belirli saatlerde sağlayan bir proxy sınıfı eklenebilir. Örneğin, sadece iş saatleri içinde internet erişimine izin verilebilir.

- Erişim Sınırlama Proxy: Belirli sitelere yalnızca belirli bir süre boyunca erişime izin veren bir proxy sınıfı eklenebilir. Bu proxy, zaman kısıtlamaları ile internet erişimini yönetir.


Her yeni proxy sınıfı, ProxyInternet sınıfını genişleterek daha fazla kontrol ekleyebilir. Bu şekilde, internet erişimini farklı kriterlere göre kontrol etmek mümkün olur.




## Sonuç

Proxy Pattern, nesnelerin işlevselliğini değiştirmeden, başka bir nesne üzerinden ek işlemler yapmanıza olanak tanır. Gerçek nesnenin yerine geçen bir proxy sınıfı kullanarak, davranışları esnek ve dinamik bir şekilde yönetebilirsiniz. Bu örnekte, internet erişiminin proxy aracılığıyla kontrol edilmesi, proxy pattern'in nasıl işlediğini ve avantajlarını göstermektedir.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
