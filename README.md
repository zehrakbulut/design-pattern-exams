# Ödeme Sistemi - Strategy Pattern

Bu proje, **Strategy Pattern** tasarım desenini bir ödeme sistemi örneği üzerinden açıklamaktadır. Strategy Pattern, bir işlevin farklı algoritmalarını bir arada tutarak çalışma zamanında uygun olanı seçmenize olanak tanır. Bu örnekte, ödeme işlemlerini farklı stratejilerle (Kredi Kartı, Nakit) yönetebilen bir sistem geliştirilmiştir.

## Strategy Pattern Nedir?

**Strategy Pattern**, aynı görevi yerine getiren alternatif algoritmalar arasında seçim yapabilmeyi sağlayan bir tasarım desenidir. Bu desen, kodun esnekliğini artırarak, her bir algoritmanın bağımsız olarak geliştirilmesine ve eklenmesine olanak tanır. Bu projede, farklı ödeme stratejileriyle ödeme yapılabilir ve sistem çalışma zamanında strateji değiştirilebilir.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `IOdemeStratejisi` Arayüzü

`IOdemeStratejisi` arayüzü, ödeme stratejilerinin temel işlevini tanımlar. Farklı ödeme yöntemleri (kredi kartı, nakit vb.) bu arayüzü uygulayarak, her ödeme yönteminin `OdemeYap` metodunu farklı şekilde gerçekleştirmesini sağlar.

### 2. `KrediKartiOdeme` ve `NakitOdeme` Sınıfları

Bu sınıflar, `IOdemeStratejisi` arayüzünü uygulayarak farklı ödeme yöntemlerini (kredi kartı ve nakit) tanımlar. Her sınıf kendine özgü ödeme işlevini yerine getirir.

### 3. `OdemeYapici` Sınıfı

`OdemeYapici` sınıfı, ödeme stratejisini kabul eden ve bu strateji ile ödeme işlemi gerçekleştiren bir yapıdır. `OdemeStratejisiAyarla` metodu ile çalışma zamanında ödeme stratejisi değiştirilip farklı bir ödeme yöntemi seçilebilir.

## Kullanım

1. Projeyi Visual Studio veya istediğiniz bir IDE ile açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. İlk olarak kredi kartı ile ödeme yapacak, ardından nakit ödeme stratejisi ile ödeme işlemi yapılacaktır.

Bu örnekte, önce kredi kartı ile ödeme yapılıyor, sonra nakit ödeme stratejisi ile işlem yapılmaktadır.

## Neden Strategy Pattern Kullanılır?

**Strategy Pattern** kullanarak ödeme sisteminde aşağıdaki avantajlar sağlanır:

- **Esneklik:** Yeni ödeme stratejileri eklemek oldukça kolaydır. Örneğin, mobil ödeme, banka transferi gibi yeni yöntemler eklenebilir.
- **Bağımsız Geliştirme:** Her ödeme yöntemi, kendi başına bağımsız olarak geliştirilip değiştirilebilir.
- **Kodun Yönetilebilirliği:** Her ödeme stratejisi kendi sınıfında yönetildiği için, kod daha modüler ve okunabilir olur.

## Geliştirme Önerileri

- **Yeni Ödeme Yöntemleri:** Mobil ödeme veya banka transferi gibi yeni ödeme stratejileri eklenebilir.
- **Ödeme Doğrulama:** Ödeme işlemi öncesinde doğrulama eklenebilir, örneğin kredi kartı numarasının doğruluğu veya yeterli bakiye kontrolü yapılabilir.
- **Ödeme Geçmişi:** Yapılan ödemelerin bir geçmişi tutulabilir ve görüntülenebilir.

## Sonuç

Bu proje, **Strategy Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Strategy Pattern, uygulamalarınızda farklı algoritmalar arasında geçiş yaparak esnek ve yönetilebilir kodlar yazmanıza olanak tanır. Ödeme sistemleri gibi gerçek dünya problemlerinde bu deseni kullanarak yazılımınızı daha modüler ve genişletilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
