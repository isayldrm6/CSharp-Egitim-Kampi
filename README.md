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

## 🔥 **Proje 16: Entity Framework - Location İşlemleri**
Location tablosu için bir form oluşturuldu ve aşağıdaki işlemler gerçekleştirildi:
- Kayıtları listeleme
- Yeni kayıt ekleme
- Mevcut kayıtları silme
- Kayıt güncelleme
- ID'ye göre veri getirme
- ID'ye göre tabloya veri listeleme

---

## 🔥 **Proje 17: Entity Framework ve LINQ ile İstatistik Takibi**
Bu projede, Entity Framework ve LINQ sorgularıyla bir Windows Form uygulaması oluşturuldu:
- Veritabanından alınan dinamik istatistikler listelendi.
- İstatistikler, kullanıcı dostu bir arayüzde görselleştirildi.

![İstatistik Görseli](https://github.com/user-attachments/assets/92f98d5a-8879-4f8f-b9d3-07ce09a0a3ad)

---

## 🔥 **Proje 18: EntityState Komutları ve Generic Repository**
- **DataAccessLayer** içerisinde bir `Repository` klasörü oluşturuldu.
- Bu klasörde, `GenericRepository` sınıfı tanımlandı ve CRUD işlemleri genelleştirildi.
- Entity Framework ve LINQ sorgularıyla veritabanı işlemleri tamamlandı.

---

## 🔥 **Proje 19: Business Katmanı ve Logic Kuralları**
- **BusinessLayer** içerisinde iki ana klasör oluşturuldu:
  - **Abstract**:  
    - `GenericService` adlı genel bir arayüz tanımlandı.  
    - Her entity için ayrı servis arayüzleri tasarlandı.
  - **Concrete**:  
    - Abstract arayüzlerinden türeyen Manager sınıfları oluşturuldu.  
    - Manager sınıflarında Dependency Injection kullanılarak veritabanı atamaları yapıldı.
- **Validasyon İşlemleri**:
  - Manager sınıfları kullanılarak validasyon işlemleri uygulandı.
  - Business katmanı validasyon ve logic kurallarının merkezi olarak yapılandırıldı.

 ---
 
## 🔥 **Proje 20: Dependency Injection (Bağımlılık Enjeksiyonu)**
### Dependency Injection (DI) Nedir?  
Bağımlılık enjeksiyonu, sınıfın ihtiyaç duyduğu bağımlılıkları dışarıdan almasını sağlayan bir tasarım desenidir.  
- **Avantajları:**
  - **Kod Modülerliği:** Daha az bağımlı ve esnek kod yapıları.
  - **Test Edilebilirlik:** Mock nesnelerle kolay entegrasyon.
  - **Yeniden Kullanılabilirlik:** Bileşenlerin farklı bağlamlarda tekrar kullanımı.

### Uygulama
- **Constructor Metodu:** Servisler ve `EfCategoryDal` gibi bağımlılıklar enjekte edilerek `CategoryService` üzerinde işlemler tamamlandı.
- **Kategori Form İşlemleri:**
  - Veri ekleme, silme, güncelleme, listeleme ve ID’ye göre veri çekme işlemleri yapıldı.

---

## 🔥 **Proje 21: Entity'e Özgü Metot Yazmak**
### **`GetProductsWithCategory` Metodu**
- **Amacı:** Ürünlerin bağlı olduğu kategori adını listelemelerde göstermek.
- **Çözüm:**  
  - `ProductWithCategoryDTO` tasarlandı.  
  - DTO ile ürün bilgileri ve kategori adını içeren bir yapı oluşturuldu.

---

## 🔥 **Proje 22-23: C# ile Dapper Kullanımı**
- **FrmProduct:** ID'ye göre getir, ekle ve güncelle işlemleri tamamlandı.
- **DTO Sınıfları:** `ResultDTO`, `AddDTO` ve `UpdateDTO` eklendi.
- **Asenkron İşlemler:** Repository altyapısı asenkron metotlarla desteklendi.
- **Dapper ile İstatistik Sorguları:**  
  - CRUD işlemleri tamamlandı.  
  - 3 farklı istatistik sorgusu oluşturularak görselleştirildi.

---

## 🔥 **Proje 24-25: MongoDB ile Çalışma**
- **MongoDB Temelleri:** BSON yapısı öğrenildi.  
- **WinForm:** MongoDB ile CRUD işlemleri uygulandı.  
- **Sonuç:** MongoDB'nin ilişkisel olmayan veritabanı yönetimi üzerine uygulamalar tamamlandı.

---

## 🔥 **Proje 26-27: PostgreSQL ile Çalışma**
### PostgreSQL Nedir?  
Açık kaynaklı, ölçeklenebilir ve güvenilir bir ilişkisel veritabanı sistemi.  

### Yapılan Çalışmalar:
- PostgreSQL’de tablo ve veritabanı tasarımı yapıldı.
- **CRUD İşlemleri:**  
  - Tablolar arası ilişkiler kurularak formlar oluşturuldu.
  - Dinamik `ComboBox` ile çalışan-departman ilişkilendirmesi yapıldı.

---

## 🔥 **Proje 28-30: Finansal CRM Uygulaması**
### Uygulamanın Özellikleri
1. **Dashboard:**  
   - **Timer:** Fatura döngüleri ve toplam bakiye görüntülendi.  
   - **Chart:** Banka bakiyeleri ve faturalar görselleştirildi.  

2. **Eklenen Modüller:**
   - 🗂️ **Category**: Kategorileri yönetme.  
   - 💰 **Spending**: Harcamalar takibi.  
   - ⚙️ **Settings**: Ayarlar ve yapılandırma.  
   - 🔑 **Login**: Giriş modülü.  
   - 🏦 **Bank Transactions**: Banka hareketleri.  

---

## 📸 **Proje Görselleri**
![Login](https://github.com/user-attachments/assets/1b31d165-306a-4d0c-89bb-6e816af57a41)
![Banks](https://github.com/user-attachments/assets/beff595a-7113-41c9-a061-bbdc6cd0a09c)
![Dashboard](https://github.com/user-attachments/assets/7aded7df-25d1-400e-b45b-1bca53b8b4e8)
![Category](https://github.com/user-attachments/assets/c963043e-118c-4cc7-82ee-2574acf61806)
![Billing](https://github.com/user-attachments/assets/3d67eb47-8939-42ff-b02f-b2a28226de06)
![BanksMovements](https://github.com/user-attachments/assets/57c4b527-4254-4337-933f-55824fde54b3)
![Spending](https://github.com/user-attachments/assets/30f504d6-fec0-440f-b76a-ead41cab7838)
![Settings](https://github.com/user-attachments/assets/709e49fe-d415-41b5-bbcc-bc73a71dda35)






