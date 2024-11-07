# State Pattern Örneği - Media Player

Bu proje, **State Pattern** tasarım desenini bir medya oynatıcı örneği üzerinden açıklamaktadır. State Pattern, bir nesnenin durumunu değiştiren ve bu değişim doğrultusunda farklı davranışlar sergilemesini sağlayan bir tasarım desenidir. Bu örnekte, medya oynatıcının farklı durumlarına (çalma, duraklatma, durdurma) göre davranışları değişmektedir.

## State Pattern Nedir?

**State Pattern** (Durum Deseni), bir nesnenin durumuna göre davranışını değiştiren bir tasarım desenidir. Nesne farklı durumlara sahip olabilir ve her durumda farklı şekilde tepki verir. Bu desen, nesneye ait durumların ayrı sınıflar halinde tanımlanmasıyla, kodun esnek ve genişletilebilir olmasını sağlar.

## Projedeki Bileşenler

Bu proje şu bileşenleri içerir:

### 1. `MediaPlayerContext` Sınıfı

`MediaPlayerContext` sınıfı, medya oynatıcının durumunu yöneten ana yapıdır. Başlangıç durumu olarak `StoppedState` (durdurulmuş) ile başlar ve `Play`, `Pause`, `Stop` gibi işlemleri sağlar. Bu işlemler sırasında oynatıcı, bağlı olduğu duruma göre farklı davranışlar sergiler.

### 2. `IMediaPlayerState` Arabirimi

`IMediaPlayerState` arabirimi, medya oynatıcısının sahip olabileceği tüm durumlar için bir şablon tanımlar. `Play`, `Pause`, ve `Stop` metotlarını içerir.

### 3. `PlayingState`, `PausedState`, ve `StoppedState` Sınıfları

Bu sınıflar, `IMediaPlayerState` arabirimini uygular ve medya oynatıcı her durumdayken nasıl davranması gerektiğini tanımlar:

- **PlayingState**: Medya oynatıcının oynatma modunda olduğu durumu temsil eder.
- **PausedState**: Medya oynatıcının duraklatıldığı durumu temsil eder.
- **StoppedState**: Medya oynatıcının durdurulmuş olduğu durumu temsil eder.

Her sınıf, oynatıcı o durumdayken `Play`, `Pause`, ve `Stop` metodlarının nasıl çalışacağını belirler.

## Kullanım

1. Projeyi Visual Studio'da açın.
2. `Program.cs` dosyasındaki `Main()` metodunu çalıştırın.
3. Medya oynatıcıyı sırasıyla çalma, duraklatma, devam etme ve durdurma gibi işlemleri gerçekleştirerek test edin. 
   - Duraklatılmış durumdayken oynatıcıyı durdurabilirsiniz.
   - Durdurulmuş bir oynatıcıyı duraklatmaya çalışırsanız hata mesajı alırsınız.

## Neden State Pattern Kullanılır?

Bu örnekte, medya oynatıcı duruma bağlı olarak farklı davranışlar sergiler. Bu sayede:

- Yeni bir durum eklendiğinde `MediaPlayerContext` sınıfında değişiklik yapılmasına gerek kalmaz.
- Medya oynatıcının her durumu için ayrı sınıflar kullanarak kod daha modüler hale getirilmiştir.
- Farklı durumlar arasında geçiş yapmak kolaylaşır ve kodun yönetilebilirliği artar.

## İleride Yapılabilecek Geliştirmeler

- Yeni durumlar (örneğin ileri sarma veya geri sarma) eklenebilir.
- Mevcut durumlara ek işlevsellikler entegre edilebilir.
- Her durumda oynatıcıya özgü farklı animasyonlar veya ses efektleri eklenebilir.

## Sonuç

Bu proje, **State Pattern**'i anlamanıza yardımcı olacak basit bir medya oynatıcı örneğidir. State Pattern, bir nesnenin durumuna göre davranışını ayarlama yeteneği sunarak, kodun esnekliğini ve genişletilebilirliğini artırır. Uygulamalarınızda bu deseni kullanarak, durumlara göre farklı davranışlar sergileyen sistemler oluşturabilirsiniz.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
