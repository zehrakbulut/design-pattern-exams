# Visitor Pattern Örneği - Dosya Sistemi Yönetimi

Bu proje, **Visitor Pattern** tasarım desenini bir dosya sistemi örneği üzerinden açıklamaktadır. Visitor Pattern, nesnelerin sınıf yapısına dokunmadan, üzerine yeni işlemler eklemeyi sağlar. Bu örnekte, bir dosya sistemi üzerinden boyut hesaplama ve detay görüntüleme işlemlerini gerçekleştiren ziyaretçiler (visitor) oluşturulmuştur.

## Visitor Pattern Nedir?

**Visitor Pattern** (Ziyaretçi Deseni), bir nesne yapısının sınıflarına yeni işlemler eklemek için kullanılan bir davranışsal tasarım desenidir. Bu desen, sınıfların davranışını değiştirmeden, üzerlerinde yeni işlemler yürütülmesini sağlar. Nesneler üzerine ek işlevsellik eklemek istediğimizde, her bir nesne sınıfını değiştirmeden ziyareti gerçekleştiren bir sınıf oluştururuz. Böylece nesneler üzerine eklenen işlemler, nesne sınıflarından ayrılır.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `IVisitor` Arayüzü

`IVisitor`, dosya ve klasör nesnelerine uygulanabilecek işlemler için bir şablon sağlar. Bu arayüz, dosya ve klasör için ayrı `Visit` metotları içerir. Her ziyaretçi bu metotları kendine göre tanımlar.

### 2. `IDosyaSistemiElemani` Arayüzü

Bu arayüz, dosya sistemindeki elemanlar (dosya veya klasör) için `Accept` metodunu tanımlar. Bu metod, elemanın bir ziyaretçiyi kabul etmesine olanak tanır.

### 3. `Dosya` ve `Klasor` Sınıfları

- `Dosya` sınıfı, dosya ismi ve boyut gibi özellikleri içerir.
- `Klasor` sınıfı, alt elemanları içerebilen bir yapıdır ve alt elemanları (dosya veya klasör) bir liste halinde tutar.

### 4. `BoyutHesaplaVisitor` ve `DetayGoruntuleVisitor` Sınıfları

- `BoyutHesaplaVisitor`: Tüm dosya ve klasörlerin toplam boyutunu hesaplar.
- `DetayGoruntuleVisitor`: Dosya ve klasör yapısını hiyerarşik olarak görüntüler.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Çalıştırdığınızda:
   - Dosya ve klasörlerin toplam boyutu `BoyutHesaplaVisitor` kullanılarak hesaplanır ve ekrana yazdırılır.
   - `DetayGoruntuleVisitor` kullanılarak dosya ve klasör yapısı, detaylı bir şekilde ekrana yazdırılır.

## Neden Visitor Pattern Kullanılır?

Bu örnekte Visitor Pattern kullanılarak dosya ve klasör yapısına, onları değiştirmeden yeni işlevler eklenmiştir. Böylece:

- Dosya sistemi yapısı değişmeden, yeni işlemler (örneğin dosya boyutu hesaplama veya detay görüntüleme) eklenebilir.
- Dosya ve klasör yapısına yeni işlevsellik eklendiğinde, mevcut kod yapısına dokunulmadan esnek bir genişletilebilirlik sağlanır.

## İleride Yapılabilecek Geliştirmeler

- Farklı ziyaretçiler ekleyerek, dosya sisteminde yeni analizler veya raporlamalar yapılabilir.
- Klasör boyutunu dahil eden bir ziyaretçi eklenebilir.

## Sonuç

Bu proje, **Visitor Pattern**'in nasıl kullanılacağını anlamanıza yardımcı olacak bir dosya sistemi örneği sunar. Visitor Pattern, sınıf yapılarının değiştirilmesine gerek kalmadan yeni işlevler eklemek için güçlü bir araçtır. Uygulamalarınızda bu deseni kullanarak kodunuzu daha modüler ve genişletilebilir hale getirebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
