# Facade Pattern Örneği - Televizyon Açma

Bu proje, **Facade Pattern** tasarım desenini basit bir televizyon açma örneği üzerinden açıklamaktadır. Facade Pattern, alt sistemlerin karmaşık yapısını gizleyerek daha basit bir arayüz sunar. Bu sayede kullanıcı, karmaşık işlemleri bilmeden kolayca kullanabilir.


## Facade Pattern Nedir?

**Facade Pattern** (Fasada Deseni), bir alt sistemin karmaşık işlemlerini tek bir basit arayüzle kapsülleyen bir tasarım desenidir. Bu desen, istemci kodunun birden fazla sınıfla etkileşime girmesi yerine, karmaşık işlemleri tek bir sınıf üzerinden yönetmesini sağlar. Facade, istemcinin sadece temel işlevleri kullanmasını sağlar, alt sistemin detaylarını gizler.


## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. Ekran Sınıfı

Televizyonun ekranını temsil eder. `Ac()` metodu ekranı açar.

### 2. Ses Sınıfı

Televizyonun sesini ayarlar. `Ayarla()` metodu sesi ayarlar.

### 3. Kanal Sınıfı

Televizyonun kanalını ayarlar. `Ayarla()` metodu kanalı ayarlar.

### 4. TelevizyonFacade Sınıfı

Bu sınıf, **Facade Pattern**'in kendisidir. `TelevizyonuAc()` metodu, ekranı açmak, sesi ayarlamak ve kanalı ayarlamak gibi işlemleri tek bir noktada yönetir. İstemci, sadece bu metodu çağırarak televizyonu açabilir.


### 5. Program Sınıfı

Bu sınıf, programın ana akışını içerir. `Main()` metodunda, TelevizyonFacade sınıfı kullanılarak televizyon açılır.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. Program.cs dosyasındaki Main() metodunu çalıştırın.
3. Televizyon açılacak ve sırasıyla ekran açılacak, ses ayarlanacak ve kanal ayarlanacaktır.
   
## Neden Facade Pattern Kullanılır?

Bu örnekte, `TelevizyonFacade` sınıfı, televizyon açma işlemini basit bir hale getirir. Bu sayede:

- Karmaşık işlemleri tek bir metodda toplar: Ekran, ses ve kanal ayarları tek bir noktada yönetilir.
- Kullanıcı, karmaşık işlemleri bilmeden sadece tek bir arayüz üzerinden televizyonu açabilir.
- Kodun esnekliği artar: Alt sistemin detayları istemciden gizlenmiş olur.

## İleride Yapılabilecek Geliştirmeler

Bu yapıyı genişletmek için, daha fazla cihaz eklenebilir. Örneğin, bir ses sistemi veya uydu alıcısı da sisteme dahil edilebilir. Her yeni cihaz için benzer bir facade sınıfı eklemek mümkündür. Ayrıca, cihazların daha detaylı kontrolünü sağlamak için, her cihaz için ayrı metodlar da eklenebilir.

## Sonuç

Bu proje, Facade Pattern'i anlamanızı sağlayacak basit bir örnek sunar. Facade Pattern, karmaşık işlemleri tek bir noktada toplayarak kullanıcıya kolay ve basit bir arayüz sunar. Uygulamalarınızda bu deseni kullanarak, kodunuzu daha düzenli ve sürdürülebilir hale getirebilirsiniz.


Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
