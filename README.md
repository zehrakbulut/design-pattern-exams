# Mediator Pattern (Arabulucu Deseni)

## Tanım
**Mediator Pattern** (Arabulucu Deseni), nesneler arasındaki iletişimi merkezi bir arabulucu aracılığıyla yönetmeyi amaçlayan bir tasarım desenidir. Bu desen, nesneler arasındaki doğrudan etkileşimi ortadan kaldırır ve tüm iletişimi bir "arabulucu" aracılığıyla yönlendirir. Böylece, sınıflar arasındaki bağımlılıkları azaltır ve daha modüler bir sistem tasarımı sağlar.

## Ne Zaman Kullanılır?
Mediator Pattern şu durumlarda kullanılır:
- **Çok sayıda nesne arasında karmaşık iletişim** varsa ve bu iletişimi merkezi bir noktada yönetmek istiyorsanız.
- Nesneler arasındaki doğrudan bağlantıları azaltarak, iletişimi daha yönetilebilir ve anlaşılır hale getirmek istiyorsanız.
- Sistemin bakımını ve genişletilmesini kolaylaştırmak amacıyla bağımlılıkları ortadan kaldırmak istiyorsanız.

## Faydaları
- **Azaltılmış Bağımlılıklar**: Nesneler, birbirleriyle doğrudan iletişim kurmak yerine merkezi bir arabulucuya bağımlı hale gelir.
- **Basitleştirilmiş İletişim**: Nesneler arasındaki mesajlaşma merkezi bir noktada yönetildiği için, sistem daha anlaşılır ve bakımı daha kolay hale gelir.
- **Esneklik ve Genişletilebilirlik**: Yeni nesneler eklemek veya mevcut nesneleri değiştirmek, arabulucuya yapılan küçük bir güncelleme ile mümkün olur. Bu, sistemin daha esnek ve genişletilebilir olmasını sağlar.

## Desenin İşleyişi
Mediator Pattern, temel olarak şu şekilde çalışır:
1. **Arabulucu** (Mediator) sınıfı, iletişimi yönlendiren merkezi bir sınıftır. Diğer sınıflar (katılımcılar, sistem elemanları vb.) doğrudan birbirleriyle iletişim kurmak yerine arabulucuya başvurur.
2. **Katılımcılar** (Participants), mesaj göndermek istediklerinde, bu mesajları doğrudan diğer katılımcılara iletmek yerine arabulucuya iletir. Arabulucu, mesajı alır ve tüm katılımcılara iletir.
3. Katılımcılar sadece **MesajAl** ve **MesajGonder** gibi işlemlerle arabulucu ile etkileşime girerler.

## Kullanım
Aşağıda, Mediator Pattern kullanımına dair bir örnek verilmiştir. Bu örnekte, iki katılımcının bir sohbet arabulucusu aracılığıyla mesajlaştığı basit bir sohbet uygulaması gösterilmektedir.

### 1. Arabulucu Arayüzü
Arabulucu arayüzü, katılımcılar arasındaki mesajlaşmayı yönlendiren metodu tanımlar:
- `MesajGonder(Katilimci gonderen, string mesaj)`: Bir katılımcı mesaj gönderdiğinde, bu mesajı diğer katılımcılara ileten metoddur.

### 2. Katılımcı Sınıfı
Katılımcılar, mesaj göndermek için arabulucuya başvurur. Her katılımcının bir ismi vardır ve arabulucu aracılığıyla diğer katılımcılara mesaj gönderir.
- `MesajGonder(string mesaj)`: Katılımcı, bu metod aracılığıyla arabulucuya mesaj gönderir.
- `MesajAl(string mesaj)`: Katılımcı, diğer katılımcılardan gelen mesajları bu metodla alır.

### 3. Sohbet Arabulucusu
Sohbet arabulucusu, tüm katılımcıları tutar ve bir katılımcı mesaj gönderdiğinde, bu mesajı diğer tüm katılımcılara ileterek iletişimi sağlar.
- `KatilimciEkle(Katilimci katilimci)`: Katılımcı eklemek için kullanılan metoddur.
- `MesajGonder(Katilimci gonderen, string mesaj)`: Bir katılımcı mesaj gönderdiğinde, bu mesajı tüm katılımcılara ileten metoddur.

### 4. Kullanıcı Etkileşimi
Katılımcılar bir arabulucuya katıldıklarında, mesajlarını birbirlerine iletmek için sadece arabulucuya başvururlar. Katılımcılar arabulucu üzerinden mesajlarını iletmekte ve alabilmektedirler.

### Çıktı
Bir katılımcı bir mesaj gönderdiğinde, mesaj diğer katılımcıya iletilir. Örneğin:
- Ayşe, "Selam" mesajını gönderdiğinde, Mehmet mesajı alır ve ekrana şu şekilde yazılır: `Mehmet mesaj aldı: Ayşe: Selam`

## Diğer Kullanım Alanları
Mediator Pattern, farklı senaryolarda da etkili bir şekilde kullanılabilir:
- **Çalışanlar Arasındaki İletişim**: Farklı çalışanlar veya sistem elemanları arasındaki bilgi akışını merkezi bir yönetici (arabulucu) aracılığıyla yönlendirebilirsiniz.
- **Oyunlar**: Oyun karakterleri arasındaki etkileşimleri merkezi bir noktada toplamak ve yönetmek için arabulucu kullanabilirsiniz.
- **UI Bileşenleri**: Kullanıcı arayüzündeki bileşenlerin birbirleriyle etkileşime girmesini sağlayan merkezi bir yapı kurabilirsiniz.

## Sonuç
**Mediator Pattern**, nesneler arasındaki doğrudan bağımlılıkları ortadan kaldırarak, daha modüler ve anlaşılır bir sistem tasarımı sağlar. Bu desen sayesinde, sistemin karmaşıklığı azaltılır, bakım kolaylaştırılır ve genişletilebilirlik sağlanır.

Mediatör deseni, özellikle büyük ve karmaşık projelerde, nesneler arasındaki iletişimi yönetmek için faydalıdır. Arabulucu sınıfı, tüm etkileşimleri merkezi bir noktada toplar ve sistemin daha esnek hale gelmesine yardımcı olur.

Saygılarımla 🧠👣👩🏻‍💻🙋🏼‍♀💐
