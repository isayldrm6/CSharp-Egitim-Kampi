# 🚀 **C# Eğitim Kampı Projeleri**

## 🔥 **Proje 1: Hello World!**
- Temel yazdırma işlemleri öğrenildi.
- `int` ve `string` değişkenleri kullanıldı.

---

## 🔥 **Proje 2: Variables**
- `double` ve `char` değişkenleri kullanımı öğrenildi.
- Klavyeden veri girişi ve çeşitli veri türleriyle işlemler yapıldı.

---

## 🔥 **Proje 3: Making Decision**
- `if-else` karar yapıları öğrenildi.
- Mod işlemleri ve `char` değişkenlerle örnekler yapıldı.
- Basit bir menü uygulaması geliştirildi.

---

## 🔥 **Proje 4: Loops**
- `for` ve `while` döngüleri kullanıldı.
- Rakamlar toplamını hesaplayan bir uygulama yapıldı.

---

## 🔥 **Proje 5: Loops with Stars**
- Yıldızlarla şekil oluşturma örnekleri yapıldı.
- Algoritma geliştirme çalışmaları yapıldı.

---

## 🔥 **Proje 6: Arrays**
- Dizilerle çalışmayı öğrenildi.
- Döngülerle dizi elemanları işlendi.

---

## 🔥 **Proje 7: Foreach Loop**
- `foreach` döngüsü kullanımı öğrenildi.
- Sınav sistemi uygulaması yapılarak pekiştirme sağlandı.

---

## 🔥 **Proje 8: Methods**
- Kodları düzenlemek için metotlar oluşturuldu.
- Parametre alıp sonuç döndüren metotlar yazıldı.

---

## 🔥 **Proje 9: Veri Tabanı Ürün-Kategori Bilgi Sistemi**
- MSSQL ile tablolar oluşturuldu.
- Konsol ekranında kullanıcı seçimine göre tablolar listelendi.

---

## 🔥 **Proje 10: Ürün-Kategori CRUD İşlemleri**
- MSSQL bağlantısı yapıldı.
- Kategori ve ürünler için ekleme, silme, güncelleme ve listeleme işlemleri yapıldı.

---

## 🔥 **Proje 11: OOP Modülü - Entity Layer**
- Veritabanında bulunacak tablolar tasarlanıp oluşturuldu.

---

## 🔥 **Proje 12: Data Access Layer ve Context Sınıfı**
- `Context` sınıfı oluşturuldu.
- App.config dosyasına bağlantı dizgisi eklendi.
- Bire-çok ilişkiler tanımlandı.

---

## 🔥 **Proje 13: Migration ve Abstract Interface Kullanımı**
- `Migration` işlemleri öğrenildi.
- `IGenericDal` interface ile generic yapı oluşturuldu.
- Her entity için ayrı bir interface tasarlandı.

---

## 🔥 **Proje 14: Entity Framework DB First ve Model Oluşturma**
- DB First yaklaşımı kullanılarak mevcut bir veritabanı projeye entegre edildi.

---

## 🔥 **Proje 15: Entity Framework Metotları ile Uygulama**
- Windows Forms üzerinde:
  - `DataGridView` ile veri görüntüleme,
  - `TextBox` ile veri ekleme,
  - ID ile veri çekme ve düzenleme işlemleri yapıldı.

# :fire: Proje 16 > Entity Framework: Tur Projesi Location İşlemleri
Location tablosu için bir form oluşturduk. Bu formda birkaç işlem gerçekleştirdik.Bu işlemler:
- Kayıtları listeleme
- Yeni kayıt ekleme
- Mevcut kayıtları silme
- Kayıt güncelleme
- ID'ye göre veri getirme
- ID'ye göre tabloya veri listeleme
# :fire: Proje 17 > Entity Framework ve LINQ ile İstatistik Takibi
Bu derste, Entity Framework ve LINQ sorguları kullanılarak bir Windows Form uygulamasında veri tabanından alınan istatistikler listelendi.İstatistikler, dinamik olarak oluşturulup uygulama arayüzünde gösterildi.
![aa](https://github.com/user-attachments/assets/92f98d5a-8879-4f8f-b9d3-07ce09a0a3ad)
# :fire: Proje 18 > EntityState Komutları, Generic Repository Sınıfı ve EF Sınıfları
DataAccessLayer içinde Repository isimli bir klasör oluşturduk ve içerisine GenericRepository sınıfını ekledik. Bu sınıf ile CRUD işlemlerini genel bir sınıfa toplamış olduk. Entity Framework ve LINQ sorguları kullanılarak CRUD işlemlerini tamamladık.
# :fire: Proje 19 > Business Katmanı ve Logic Kuralları
BusinessLayer içerisinde Abstract ve Concrete adında iki klasör oluşturduk.
- Abstract klasöründe, bir GenericService arayüzü tanımladık. Bu arayüzden türeyen her bir varlık (entity) için ayrı ayrı servis arayüzleri (interface) oluşturduk.
- Concrete klasöründe ise Abstract klasöründe tanımlanan arayüzlerin her biri için birer Manager sınıfı oluşturduk. Bu sınıflar, ilgili arayüzlerden kalıtım aldı.
Daha sonra Dependency Injection kullanarak, her bir Manager sınıfının constructor metodu aracılığıyla gerekli veritabanı atamalarını gerçekleştirdik. Bu Manager sınıflarını, Entity Framework'ün yöntemlerinden yararlanarak doldurduk. Ayrıca, BusinessLayer'ın validasyon işlemleri için kullanıldığını ve oluşturduğumuz Manager sınıfları üzerinden bu validasyon işlemlerini nasıl yapabileceğimizi öğrendik. 
# :fire: Proje 20 > Dependency Injection (Bağımlılık Enjeksiyonu)
## Dependency Injection (DI) Nedir?  
DI, bir sınıfın ihtiyaç duyduğu bağımlılıkları dışarıdan almasını sağlayan bir tasarım desenidir. Bu yöntem, projelerde bağımlılık yönetimini kolaylaştırır ve kodun test edilebilirliği ile yeniden kullanılabilirliğini artırır.  

### Neden Kullanılır?  
- **Bağımlılıkları Yönetmek:** Kodun modüler ve daha az bağımlı olmasını sağlar.  
- **Test Edilebilirlik:** Mock nesneler kolayca enjekte edilebilir.  
- **Yeniden Kullanılabilirlik:** Bileşenler farklı bağlamlarda kolayca kullanılabilir.  

## Constructor Metodu  
Projede, constructor metodu kullanılarak bağımlılıklar enjekte edildi.  
- **Amaç:** Form oluşturulurken ilgili servisi çağırmak ve gerekli sınıfları enjekte etmek.  
- **Uygulama:** `EfCategoryDal` sınıfını manuel olarak enjekte ederek `CategoryService` üzerinden işlemleri gerçekleştirdik.  

## Kategori Formu İşlemleri  
**Category (Kategori)** entity’si için bir form oluşturduk ve şu işlemleri gerçekleştirdik:  
- **Veri Ekleme:** Yeni kategori bilgilerini veritabanına kaydettik.  
- **Veri Silme:** Seçilen kategori bilgilerini sildik.  
- **Veri Güncelleme:** Mevcut bilgileri düzenleyerek güncelledik.  
- **Veri Listeleme:** Kayıtlı tüm kategorileri listeledik.  
- **ID’ye Göre Getirme:** Belirli bir ID’ye sahip kategori bilgilerini aldık.  

Bu işlemler **Entity Framework** ve `Manager` sınıfları kullanılarak gerçekleştirildi. Ayrıca, validasyonlar iş katmanında tanımlandı ve form işlemleri sırasında devreye alındı. 
# :fire: Proje 21 > Entity'e Özgü Metot Yazmak
Bu projede, **Ürünler (Products)** için bir form tasarladık ve listeleme işlemlerini gerçekleştirdik. Ancak, ürünlerin listelenmesi sırasında yalnızca `CategoryId` göründüğünden, kullanıcı deneyimini iyileştirmek için bir çözüm geliştirdik.

## Yapılan Çalışmalar  

### 1. `GetProductsWithCategory` Metodu  
- **Amacı:** Ürünlerin bağlı olduğu kategori adını listeleme sırasında göstermek.  
- **Uygulama:**  
  - `Product` entity'sine özel bir `GetProductsWithCategory` metodu yazıldı.  
  - Bu metod, ürünlerin kategori bilgilerini içeren bir liste döndürdü.  

### 2. `ProductWithCategoryDTO` Sınıfı  
- **Amacı:** Veritabanından dönen verileri daha anlamlı bir şekilde kullanıcıya sunmak.  
- **Uygulama:**  
  - DTO (Data Transfer Object) tasarımıyla, ürün bilgilerini ve kategori adını içeren bir yapı oluşturuldu.  
  - Listeleme işlemlerinde bu DTO sınıfı kullanılarak, kullanıcıya `CategoryId` yerine kategori adı gösterildi.  

### 3. Kullanıcı Dostu Listeleme  
- Ürünlerin bağlı olduğu kategori adını, `CategoryId` yerine kullanıcıya gösterdik.  
- Bu sayede, kullanıcıların verileri daha kolay anlaması ve işlemleri daha hızlı gerçekleştirmesi sağlandı.

## Katmanlı Mimari ve Esneklik  
- **Katmanlı mimari** sayesinde, entity'lere özel işlemler için esnek bir altyapı oluşturuldu.  
- **DTO kullanımı**, farklı veri ihtiyaçlarına yönelik özelleştirilmiş çözümler geliştirme imkânı sundu.  

---

💡 **Sonuç:**  
Kullanıcıya sunulan veriler daha anlamlı hale getirilmiş, proje kodunun okunabilirliği ve genişletilebilirliği artırılmıştır.  
# :fire: Proje 22 > C# ile Dapper Kullanımı
## Yapılan Çalışmalar  

### FrmProduct  
- Eksik kalan **"ID'ye Göre Getir"**, **"Ekle"** ve **"Güncelle"** işlemleri tamamlandı.  

### Dapper  
- **Dapper** hakkında bilgi edinildi ve yeni bir proje oluşturularak Dapper paketi kuruldu.  
- Proje içine şu klasörler eklendi:  
  - **Repository**  
  - **DTO**  

### DTO (Data Transfer Object)  
- **ResultDTO**, **AddDTO** ve **UpdateDTO** sınıfları tanımlandı.  

### Repository ve Asenkron İşlemler  
- Asenkron metodlar hakkında bilgi edinildi.  
- Asenkron bir interface oluşturularak bu interface'den miras alan bir sınıf yazıldı.  
# :fire: Proje 23 > Dapper İşlemlerinin Tamamlanması
## Yapılan Çalışmalar  

### CRUD İşlemleri  
- **Dapper** kullanarak, daha önce hazırlanan form üzerinde CRUD işlemleri yapıldı.  
- CRUD işlemleri, metodlar üzerinden gerçekleştirildi ve **DTO** kullanılarak listeleme yapıldı.  

### İstatistik Sorguları  
- CRUD işlemleri tamamlandıktan sonra, **3 farklı istatistik sorgusu** Dapper ile yazıldı ve forma eklendi.  

# :fire: Proje 24 > C# ile MongoDB Kullanımı 1
## Yapılan Çalışmalar  

### MongoDB Temelleri  
- **MongoDB** veritabanı sistemi hakkında bilgi edinildi.  
- **BSON** nedir, nasıl çalışır ve nerelerde kullanılır, incelendi.  

### WinForm Uygulaması  
- Yeni bir **WinForm** projesi oluşturuldu.  
- Projeye **Entities** ve **Services** klasörleri eklendi.  

### MongoDB ile Çalışma  
- MongoDB yapılandırması tamamlandı.  
- Bir **entity** oluşturularak veritabanına **Customer** kaydı eklendi.  
# :fire: Proje 25 > C# ile MongoDB Kullanımı 2  

## Yapılan Çalışmalar  

### CRUD İşlemleri  
- **Listeleme**, **Silme**, **Güncelleme** ve **ID'ye Göre Getirme** işlemlerinin MongoDB'de nasıl yapılacağı öğrenildi.  

### Sonuç  
- MongoDB'nin yapısı daha iyi kavrandı ve **CRUD** işlemleri başarıyla tamamlandı.  

# :fire: Proje 26 > C# ile PostgreSQL Kullanımı 1
## PostgreSQL Nedir?  
**PostgreSQL**, açık kaynaklı, ilişkisel bir veritabanı yönetim sistemidir (RDBMS). Yüksek performanslı, güvenli ve ölçeklenebilir bir sistem olarak, özellikle büyük ve karmaşık veri yapıları için tercih edilir. PostgreSQL, ACID uyumluluğu sağlayarak veritabanı işlemlerinde tutarlılık ve güvenilirlik sunar. Genellikle web uygulamaları, veri analiz sistemleri ve büyük ölçekli projelerde kullanılır.

### PostgreSQL Kullanım Alanları  
- Web uygulamaları  
- Veri analizi ve raporlama  
- İçerik yönetim sistemleri  
- Finansal ve e-ticaret platformları  

## Yapılan Çalışmalar  

### Veritabanı ve Tablo Oluşturma  
- **PostgreSQL** veritabanının ne işe yaradığını ve hangi durumlarda kullanıldığını öğrendik.  
- PostgreSQL’de bir **veritabanı** oluşturulup, **DDL (Data Definition Language)** komutları ile bir **tablo** oluşturuldu. Bu adımda veritabanı yapısını kurarak, verilerin nasıl organize edileceği üzerine çalıştık.  

### EntityFramework ile Entegrasyon  
- Projeye **EntityFramework6.Npgsql** paketi eklendi. Bu paket, PostgreSQL veritabanı ile **Entity Framework 6**'nın entegrasyonunu sağlar, veritabanı işlemlerinin daha kolay yönetilmesini mümkün kılar.  
- Entity Framework, veritabanı bağlantıları, sorgu işlemleri ve veritabanı yönetimi gibi işlemleri nesne odaklı bir şekilde yapmamıza olanak sağlar.  

### CRUD İşlemleri  
- **PostgreSQL** ile klasik **CRUD (Create, Read, Update, Delete)** işlemleri için bir form uygulaması oluşturuldu. Bu sayede kullanıcıların veritabanına veri ekleme, veri listeleme, veri güncelleme ve veri silme işlemleri nasıl yapılır öğrenildi.  
# :fire: Proje 27 > C# ile PostgreSQL Kullanımı 2
## Yapılan Çalışmalar  

### Tabloların Oluşturulması  
- **Employee** ve **Department** tabloları oluşturuldu ve bu tablolar arasında ilişki kurularak veritabanı yapısı daha tutarlı hale getirildi.  
- **DDL (Data Definition Language)** komutları kullanılarak tabloların yapısı belirlendi.  

### Employee Formu  
- **Çalışanları Listeleme** ve **Ekleme** işlemleri gerçekleştirildi.  
- Çalışan eklerken, ilişkili **Department** tablosundan bir departman seçimi yapılması gerektiği için bir **ComboBox** kullanıldı.  
- **ComboBox**, PostgreSQL'den veri çekilerek dinamik olarak dolduruldu.  

### Sonuç  
- Bu proje, PostgreSQL ile ilişkili tablolar üzerinde işlem yapmayı ve form elemanlarını veritabanı ile entegre etmeyi öğrenmemiz açısından önemli bir adım oldu.
  
# :fire: Proje 28 > Finansal CRM Uygulaması 1
## Yapılan Çalışmalar  

### Veritabanı ve Tablolar  
- **MS SQL** üzerinde gerekli veritabanı ve tablolar oluşturuldu.  
- Aşağıdaki tablolar tasarlandı ve tanımlandı:  
  - Banka İşlemleri  
  - Bankalar  
  - Faturalar  
  - Kategoriler  
  - Harcamalar  
  - Kullanıcılar  

### Windows Forms Projesi  
- **Windows Forms** projesi oluşturuldu ve iki form eklendi:  
  - **Dashboard**  
  - **Bank**  

### Bank Formu Tasarımı  
- **Bank** formunun tasarımı tamamlandı.  
- Form daha düzenli hale getirilmek için panellerle bölümlere ayrıldı ve her panel farklı renklerle renklendirildi.  
- Bu sayede, hem görsel olarak zengin hem de kullanıcı dostu bir arayüz oluşturuldu.  
# :fire: Proje 23 > Finansal CRM Uygulaması 2
## Yapılan Çalışmalar  

### Entity Framework ve Database-First Yaklaşımı  
- **Entity Framework** kullanılarak **Database-First** yaklaşımı ile bir model klasörü oluşturuldu.  
- Tasarlanan veritabanı başarıyla entegre edildi.  

### Faturalar (Bills) Formu  
- **Faturalar** formu oluşturularak CRUD işlemleri başarıyla tamamlandı.  
  - **Ekleme**, **Güncelleme**, **Silme**, ve **Listeleme** işlemleri gerçekleştirildi.  

### Formlar Arası Geçiş  
- Formlar arasında geçiş yapılabilmesi için gerekli ayarlamalar yapıldı.  

### Proje Düzenlemeleri  
- Projedeki olaylar ve metodlar işlevsel hale getirildi ve daha modüler bir yapıya kavuşturuldu.  

# :fire: Proje 23 > Finansal CRM Uygulaması 3 - Final
## Yapılan Çalışmalar  
### Dashboard Formu  
- **Dashboard** formu oluşturuldu.  
- Bu form üzerinden diğer formlara nasıl geçiş yapılabileceği öğrenildi.  

### Eklenen Özellikler  

- **Timer Kullanımı**: Faturalar sırayla gösterildi.  
- **Banka Hesap Bilgileri**: Toplam bakiye ve son gelen havale tutarı görüntülendi.  

### Chart Kullanımı  
- **Birinci Chart**: Banka bakiyeleri gösterildi.  
- **İkinci Chart**: Fatura tutarları gösterildi.  

### Sonuç  
- Bu dersle birlikte **chart kullanımı** ve **timer yapısı** öğrenildi.  
- Proje sonunda görsel açıdan zengin ve işlevsel bir dashboard oluşturuldu.  

# FinancialCRM Uygulamasının Tamamlanması

## Eklenen ve Kodlanan Formlar  
### 🗂️ Category (Kategori Formu)
### 💰 Spending (Harcamalar Formu)
### ⚙️ Settings (Ayarlar Formu)
### 🔑 Login (Giriş Formu)
### 🏦 Bank Transactions (Banka Hareketleri Formu)
---
## Proje Görüntüleri 📸
![login](https://github.com/user-attachments/assets/1b31d165-306a-4d0c-89bb-6e816af57a41)
![banks](https://github.com/user-attachments/assets/beff595a-7113-41c9-a061-bbdc6cd0a09c)
![Dashboard](https://github.com/user-attachments/assets/7aded7df-25d1-400e-b45b-1bca53b8b4e8)
![category](https://github.com/user-attachments/assets/c963043e-118c-4cc7-82ee-2574acf61806)
![Billing](https://github.com/user-attachments/assets/3d67eb47-8939-42ff-b02f-b2a28226de06)
![BanksMovements](https://github.com/user-attachments/assets/57c4b527-4254-4337-933f-55824fde54b3)
![Spending](https://github.com/user-attachments/assets/30f504d6-fec0-440f-b76a-ead41cab7838)
![settings](https://github.com/user-attachments/assets/709e49fe-d415-41b5-bbcc-bc73a71dda35)





