PizzaciSon
PizzaciSon, bir pizzacı otomasyon sistemi olarak geliştirilmiş bir masaüstü uygulamasıdır. Bu sistem, bir pizzacının farklı operasyonel ihtiyaçlarını karşılamak üzere tasarlanmıştır ve masalar, stok takibi, raporlar, sipariş yönetimi ve günlük giderler gibi farklı modülleri içerir.

Özellikler

1. Masalar Modülü
Salon Masalar: Bu özellik, restoranın iç mekanındaki masaları yönetir. Kullanıcı, "Salon Masalar" butonuna tıkladığında, ilgili form açılır ve kullanıcının salon masaları ile ilgili işlemleri gerçekleştirmesi sağlanır.
Bahçe Masalar: Bahçe masaları, şimdilik devre dışı bırakılmıştır. İleride bahçe masaları ile ilgili fonksiyonlar eklenebilir.

2. Peşin Satış Modülü
Peşin Satış: Bu modül, peşin ödemeli siparişlerin yönetimini sağlar. Kullanıcı "Peşin Satış" butonuna tıkladığında, salon masaları seçili olarak gelir ve peşin satış işlemleri için gerekli form açılır.

3. Stok Takibi Modülü
Stok Takibi: Bu modül, pizzacıdaki malzemelerin stok durumlarını izlemek için kullanılır. "Stok Takibi" butonuna tıklanıldığında, stok takibi ana ekranı açılır ve kullanıcı stoklarla ilgili işlemleri gerçekleştirebilir.

4. Raporlar Modülü
Raporlar: Bu modül, pizzacının operasyonel performansını izlemek için çeşitli raporlar sağlar. Kullanıcı "Raporlar" butonuna tıkladığında, raporlama ekranı açılır ve kullanıcı farklı rapor türlerini görüntüleyebilir.

5. Günlük Giderler Modülü
Günlük Giderler: Bu modül, günlük giderlerin kaydedilmesi ve izlenmesi için kullanılır. "Günlük Giderler" butonuna tıklanıldığında, ilgili ekran açılır ve kullanıcı giderlerle ilgili işlemlerini yapabilir.

6. Ayarlar Modülü
Ayarlar: Bu bölüm, sistemin çeşitli ayarlarının yapılmasını sağlar. "Ayarlar" butonuna tıklanıldığında, ayarlar giriş ekranı açılır ve kullanıcı burada gerekli ayarları yapabilir.

7. Çıkış
Çıkış: Kullanıcı, uygulamadan çıkış yapmak istediğinde bu butonu kullanabilir. Uygulama güvenli bir şekilde kapatılır.

Kullanım

Uygulamayı çalıştırdığınızda, Anasayfa formu karşınıza çıkar. Bu formda, yukarıda belirtilen modüllere erişim sağlayan butonlar yer alır. Hangi işlemi yapmak istiyorsanız, ilgili butona tıklayarak o modüle geçiş yapabilirsiniz. Her modül için özel formlar açılır ve ana sayfa gizlenir.

Kod Detayları

Anasayfa.cs dosyası, uygulamanın ana formunu temsil eder. Bu formda, çeşitli modülleri açmak için kullanılan butonların olay işleyicileri (event handlers) tanımlanmıştır. Kod, her bir butonun tıklanması ile ilgili formu açar ve ana formu gizler. Bu sayede kullanıcı, arayüzde yalnızca o an üzerinde çalıştığı modülü görür.

Önemli Kod Parçaları

pesinSatis: Peşin satışların kontrolü için kullanılan bir bool değerdir.

Anasayfa_Load: Uygulama yüklendiğinde, kullanıcının pozisyonunu kontrol eder.

Buton Event Handlers: Her bir butonun tıklanmasıyla ilgili form açılır ve this.Hide(); ile ana form gizlenir.

Geliştirme

Bu projeyi kendi ihtiyaçlarınıza göre geliştirebilir ve genişletebilirsiniz. Proje, C# dili ile Windows Forms teknolojisini kullanarak oluşturulmuştur. Geliştirme için Visual Studio gibi bir IDE kullanabilirsiniz.

İletişim

Sorularınız veya geri bildirimleriniz için benimle iletişime geçebilirsiniz:

E-posta: alitokmak3535@gmail.com

GitHub: AlITOKMAK35 - https://github.com/AlITOKMAK35 -

