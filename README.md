# Chain of Responsibility Pattern - Talepleri İşleme

Bu proje, **Chain of Responsibility Pattern** tasarım desenini bir talep işleme örneği üzerinden açıklamaktadır. Chain of Responsibility Pattern, bir dizi işleyicinin (handler) sırasıyla bir talebi alıp işlemesine olanak tanır. Bu desen, her işleyicinin, kendisine gelen talebi işleyip bir sonraki işleyiciye iletmesini sağlar. Böylece, talep işleme zinciri oluşturulmuş olur ve her işleyici yalnızca kendisine uygun talep türünü işler.

## Chain of Responsibility Pattern Nedir?

**Chain of Responsibility Pattern** (Sorumluluk Zinciri Deseni), bir dizi işleyicinin (handler) sırasıyla bir talebi alıp işlemesine olanak tanıyan bir yapısal tasarım desenidir. Bu desende, her işleyici talebi kendi yetkisi dahilinde işler ve eğer talep işlenemezse, bir sonraki işleyiciye iletilir. Bu yapı, talep işleme işlemlerini birbirinden bağımsız yaparak kodun esnekliğini ve genişletilebilirliğini artırır.

Örneğin, bir taleple karşılaşıldığında, ilk işleyici talepleri düşük miktarda işlerken, daha yüksek miktar talepler bir sonraki işleyiciye yönlendirilir.

## Projedeki Bileşenler

Bu proje, bir talebin farklı işleyiciler tarafından nasıl işlendiğini göstermek için aşağıdaki bileşenleri içerir:

### 1. `IIsleyici` Arayüzü

`IIsleyici` arayüzü, talep işleme işlemini gerçekleştiren işleyiciler için bir temel sunar. Bu arayüzdeki `TalepIste` metodu, talep miktarına göre uygun işleyicinin işlem yapmasını sağlar.

### 2. `Duzey1Isleyici`, `Duzey2Isleyici`, `Duzey3Isleyici` Sınıfları

Bu sınıflar, `IIsleyici` arayüzünü implement eder ve belirli tutar aralıklarına göre talepleri işler. Her sınıfın görevi, belirli bir tutar aralığına sahip talepleri işlemek ve gerekirse bir sonraki işleyiciye yönlendirmektir.

### 3. `Main` Metodu

`Main` metodunda, farklı tutarlarda talepler gönderilir. Bu talepler sırasıyla işleyiciler tarafından işlenir. Eğer bir işleyici talebi işleyemezse, talep bir sonraki işleyiciye iletilir.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. `Duzey1Isleyici`, `Duzey2Isleyici`, ve `Duzey3Isleyici` sınıfları ile talepler gönderin.
   - 1000'den düşük tutarları `Duzey1Isleyici` işleyecek.
   - 1000 ile 5000 arasında olan tutarları `Duzey2Isleyici` işleyecek.
   - 5000'den yüksek tutarları `Duzey3Isleyici` işleyecek.

## Neden Chain of Responsibility Pattern Kullanılır?

Bu desende, taleplerin sırasıyla işlenmesi sağlanarak her işleyici yalnızca kendi sorumluluk alanına uygun talepleri işler. Bu sayede:

- Taleplerin işlenmesi sırasında esneklik sağlanır. Yeni işleyiciler eklemek, mevcut işleyicileri değiştirmeden yapılabilir.
- Her işleyici, yalnızca kendi sorumluluğunda olan talepleri işler, bu da kodun daha temiz ve sürdürülebilir olmasına olanak tanır.
- Talep işleme zincirinin farklı işleyicilerle genişletilmesi kolaydır.

## İleride Yapılabilecek Geliştirmeler

- Farklı işleyici türleri eklenerek, daha fazla talepten sorumlu olabilecek yeni işleyiciler entegre edilebilir.
- Her işleyiciye ek özellikler (örneğin hata mesajı döndürme, loglama) eklenebilir.
- İşleyiciler, daha gelişmiş işleme mantıkları eklenerek daha karmaşık talepleri ele alabilir.

## Sonuç

Bu proje, **Chain of Responsibility Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Bu desen, taleplerin işlenmesinde esneklik sağlar, yeni işleyiciler ekleyerek sistemi genişletmeyi kolaylaştırır. Bu yapıyı kullanarak, talepleri esnek bir şekilde işleyebilir ve kodunuzu daha modüler hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
