# Memento Pattern Örneği - Oyun Karakteri Durumu Yönetimi

Bu proje, **Memento Pattern** tasarım desenini bir oyun karakterinin durumunu kaydetme ve geri yükleme senaryosu üzerinden açıklamaktadır. Memento Pattern, nesnelerin durumlarını bir nesne olarak saklamayı ve gerektiğinde bu duruma geri dönmeyi sağlar. Bu örnekte, bir oyun karakterinin sağlığı ve pozisyon bilgisi gibi durumlarının nasıl kaydedilip geri yükleneceği gösterilmiştir.

## Memento Pattern Nedir?

**Memento Pattern** (Hatıra Deseni), bir nesnenin iç durumunu dışarıya sızdırmadan kaydetmeye ve daha sonra bu duruma geri dönmeye olanak tanıyan bir davranışsal tasarım desenidir. Bu desen, nesnenin durumunu kaydedip gerektiğinde "geri al" veya "ileri al" işlevselliği sağlar ve böylece nesnenin önceki hallerine dönülmesine imkan tanır.

## Projedeki Bileşenler

Bu projede üç ana bileşen bulunmaktadır:

### 1. `GameCharacter` Sınıfı

`GameCharacter` sınıfı, oyun karakterinin adını, sağlığını ve pozisyonunu tutar. Ayrıca, karakterin mevcut durumunu bir `Memento` nesnesi olarak kaydedebilen (`SaveState`) ve kaydedilen bir durumu geri yükleyebilen (`RestoreState`) yöntemleri içerir.

### 2. `Memento` Sınıfı

`Memento` sınıfı, `GameCharacter` nesnesinin durumunu saklayan bir yapıdır. Karakterin sağlığı ve pozisyonu gibi durum bilgilerini içerir ve bu bilgiler dışarıya sızdırılmadan saklanır.

### 3. `GameCaretaker` Sınıfı

`GameCaretaker`, karakterin geçmiş durumlarını saklayan bir sınıftır. Bu sınıf, `Memento` nesnelerinin yığını (stack) olarak tutulduğu bir yapıdır ve kaydedilen durumların sırasıyla geri alınmasını sağlar.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Oyun karakteri durumlarını kaydetmek ve geri almak için `SaveState` ve `RestoreState` yöntemlerini kullanın.
   - Karakterin sağlığı ve pozisyonu değiştikten sonra eski durumlara geri dönebilir.

## Neden Memento Pattern Kullanılır?

Bu örnekte, `GameCharacter` nesnesinin durumu kaydedilerek, istenildiğinde eski durumlara dönme imkanı sağlanmıştır. Bu sayede:

- Karakterin sağlığı ve pozisyonu gibi bilgilerin kaydedilmesi, değişikliklerin izlenebilirliğini sağlar.
- Geri al veya ileri al işlemleri gibi geri dönüş işlevleri kolayca uygulanabilir.
- Uygulamanın esnekliği ve genişletilebilirliği artar, çünkü karakterin geçmiş durumları güvenli bir şekilde saklanır ve gerektiğinde geri yüklenebilir.

## İleride Yapılabilecek Geliştirmeler

- Karakterin durumuna ek olarak deneyim puanı veya seviye gibi özellikler eklenebilir.
- `GameCaretaker` sınıfına belirli durumların kaydedilmesi veya zamanlanması gibi özellikler eklenerek kayıt yönetimi özelleştirilebilir.

## Sonuç

Bu proje, **Memento Pattern**'i anlamanıza yardımcı olacak basit bir örnektir. Memento Pattern, nesnenin iç durumunu güvenli bir şekilde saklamayı ve gerektiğinde geri dönmeyi sağlayarak, kodun daha modüler ve yönetilebilir hale gelmesine olanak tanır. Bu deseni kullanarak uygulamalarınıza "geri al" işlevi ekleyebilir, veri değişikliklerini izleyebilir ve gerektiğinde önceki durumlara dönebilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
