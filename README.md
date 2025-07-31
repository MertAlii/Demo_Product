# 🚀 ASP.NET Core OOP Temelleri: Katmanlı Mimari Projesi

Bu proje, **Murat Yücedağ'ın "C# İLE OOP TEMELLERİ: ADIM ADIM KATMANLI MİMARİ"** kursundan alınan eğitimler doğrultusunda geliştirilmiş kapsamlı bir web uygulamasıdır.

## 📋 Proje Hakkında

Bu proje, modern web geliştirme prensiplerini ve Object-Oriented Programming (OOP) kavramlarını uygulayan, katmanlı mimari (Layered Architecture) kullanılarak geliştirilmiş bir ASP.NET Core MVC uygulamasıdır.

## 🏗️ Proje Mimarisi

### Katmanlı Mimari (Layered Architecture)
Proje, aşağıdaki katmanlardan oluşmaktadır:

- **EntityLayer**: Veritabanı entity'leri ve domain modelleri
- **DataAccessLayer**: Veri erişim katmanı (Entity Framework Core)
- **BusinessLayer**: İş mantığı katmanı
- **Demo_Product**: Sunum katmanı (MVC)

## 🎯 Proje Özellikleri

### 🔐 Kimlik Doğrulama ve Yetkilendirme
- **ASP.NET Core Identity** entegrasyonu
- Kullanıcı kayıt ve giriş sistemi
- Rol tabanlı yetkilendirme
- Güvenli şifre yönetimi
- Oturum yönetimi

### 👥 Kullanıcı Yönetimi
- **Kayıt Sistemi**: Ad, soyad, kullanıcı adı, e-posta, şifre ve cinsiyet bilgileri
- **Giriş Sistemi**: Kullanıcı adı ve şifre ile güvenli giriş
- **Profil Yönetimi**: Kullanıcı bilgilerini görüntüleme ve düzenleme
- **Çıkış Sistemi**: Güvenli oturum kapatma

### 📦 Ürün Yönetimi
- **Ürün Listesi**: Tüm ürünleri görüntüleme
- **Ürün Ekleme**: Yeni ürün kaydı oluşturma
- **Ürün Güncelleme**: Mevcut ürün bilgilerini düzenleme
- **Ürün Silme**: Ürün kayıtlarını silme
- **FluentValidation**: Ürün verilerinin doğrulaması
- **Stok Takibi**: Ürün stok miktarlarının yönetimi
- **Fiyat Yönetimi**: Ürün fiyatlarının belirlenmesi

### 🏷️ Kategori Yönetimi
- **Kategori Listesi**: Tüm kategorileri görüntüleme
- **Kategori Ekleme**: Yeni kategori oluşturma
- **Kategori Güncelleme**: Kategori bilgilerini düzenleme
- **Kategori Silme**: Kategori kayıtlarını silme

### 👤 Müşteri Yönetimi
- **Müşteri Listesi**: Tüm müşterileri görüntüleme
- **Müşteri Ekleme**: Yeni müşteri kaydı oluşturma
- **Müşteri Güncelleme**: Müşteri bilgilerini düzenleme
- **Müşteri Silme**: Müşteri kayıtlarını silme
- **Meslek İlişkisi**: Müşterilerin meslek bilgileriyle ilişkilendirilmesi

### 💼 Meslek Yönetimi
- **Meslek Listesi**: Tüm meslekleri görüntüleme
- **Meslek Ekleme**: Yeni meslek oluşturma
- **Meslek Güncelleme**: Meslek bilgilerini düzenleme
- **Meslek Silme**: Meslek kayıtlarını silme
- **Meslek Detayları**: Meslek bilgilerini detaylı görüntüleme

## 🛠️ Teknolojiler ve Kütüphaneler

### Backend Teknolojileri
- **ASP.NET Core 7.0+**
- **Entity Framework Core**
- **ASP.NET Core Identity**
- **FluentValidation**
- **Microsoft.AspNetCore.Mvc**

### Frontend Teknolojileri
- **Bootstrap 5.3.0**
- **Bootstrap Icons**
- **Font Awesome 6.5.0**
- **jQuery**
- **jQuery Validation**

### Veritabanı
- **SQL Server** (Entity Framework Core ile)

## 📁 Proje Yapısı

```
Demo_Product/
├── BusinessLayer/          # İş mantığı katmanı
│   ├── Abstract/          # Interface'ler
│   ├── Concrete/          # Manager sınıfları
│   └── FluentValidation/  # Doğrulama kuralları
├── DataAccessLayer/       # Veri erişim katmanı
│   ├── Abstract/          # Repository interface'leri
│   ├── Concrete/          # Context sınıfı
│   ├── EntityFramework/   # EF Repository'leri
│   └── Repositories/      # Generic Repository
├── EntityLayer/           # Entity modelleri
│   └── Concrete/          # Domain modelleri
└── Demo_Product/          # MVC Projesi
    ├── Controllers/       # Controller'lar
    ├── Models/           # View Model'ler
    ├── Views/            # Razor View'lar
    └── wwwroot/          # Statik dosyalar
```

## 🔧 Kurulum ve Çalıştırma

### Gereksinimler
- .NET 7.0 SDK veya üzeri
- SQL Server
- Visual Studio 2022 veya VS Code

### Kurulum Adımları

1. **Projeyi Klonlayın**
   ```bash
   git clone https://github.com/MertAlii/Demo_Product.git
   cd Demo_Product
   ```

2. **Veritabanı Bağlantısını Yapılandırın**
   - `appsettings.json` dosyasındaki connection string'i güncelleyin

3. **Migration'ları Çalıştırın**
   ```bash
   dotnet ef database update
   ```

4. **Projeyi Çalıştırın**
   ```bash
   dotnet run
   ```

5. **Tarayıcıda Açın**
   ```
   https://localhost:7000
   ```

## 🎨 Kullanıcı Arayüzü Özellikleri

### Modern ve Responsive Tasarım
- **Bootstrap 5** ile modern tasarım
- **Responsive** layout (mobil uyumlu)
- **Dark theme** sidebar
- **Bootstrap Icons** ile görsel zenginlik

### Kullanıcı Deneyimi
- **Sidebar Navigation**: Kolay gezinme
- **Form Validasyonu**: Gerçek zamanlı doğrulama
- **Modal Dialoglar**: Kullanıcı dostu etkileşimler
- **Toast Bildirimleri**: İşlem sonuçları

### Güvenlik Özellikleri
- **Password Toggle**: Şifre görünürlük kontrolü
- **CSRF Protection**: Cross-site request forgery koruması
- **Input Validation**: Giriş verilerinin doğrulanması

## 📊 Veritabanı Modelleri (C# prop Şeklinde)

### AppUser (Kullanıcı)
```csharp
public class AppUser : IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
}
```

### Product (Ürün)
```csharp
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductStock { get; set; }
}
```

### Category (Kategori)
```csharp
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
```

### Customer (Müşteri)
```csharp
public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerSurname { get; set; }
    public string CustomerCity { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
}
```

### Job (Meslek)
```csharp
public class Job
{
    public int JobId { get; set; }
    public string JobName { get; set; }
    public List<Customer> Customers { get; set; }
}
```

## 🔒 Güvenlik Özellikleri

### Kimlik Doğrulama
- **ASP.NET Core Identity** ile güvenli kullanıcı yönetimi
- **Password Hashing**: Şifrelerin güvenli saklanması
- **Session Management**: Oturum yönetimi

### Yetkilendirme
- **[Authorize] Attribute**: Sayfa bazlı yetkilendirme
- **Role-based Access Control**: Rol tabanlı erişim kontrolü

### Veri Doğrulama
- **FluentValidation**: Server-side validation
- **Client-side Validation**: JavaScript ile anlık doğrulama
- **Model Validation**: ASP.NET Core model validation

## 🚀 Geliştirme Özellikleri

### Clean Architecture
- **Separation of Concerns**: Katmanların ayrılması
- **Dependency Injection**: Bağımlılık enjeksiyonu
- **Repository Pattern**: Veri erişim deseni

### Code Quality
- **Interface Segregation**: Interface'lerin ayrılması
- **Single Responsibility**: Tek sorumluluk prensibi
- **Open/Closed Principle**: Açık/kapalı prensibi

## 👨‍💻 Geliştirici

**Mert Ali Alkan**

## 📝 To-Do Listesi

- [x] Üyelik Sistemi (Identity)
- [x] Arama Listesi
- [x] Yardım Pop-up
- [x] Ayarlar
- [x] Çıkış Yap
- [x] Giriş Yap
- [x] Kayıt Ol
- [x] Admin Tablosu (Aspnet User)
- [ ] Proje canlıya taşınma

---
## Ekran Görüntüleri
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/3b49e9f1-db30-435d-a75f-020d077663a4" />
<img width="1920" height="1207" alt="image" src="https://github.com/user-attachments/assets/3a4217eb-61d8-41fc-ad42-201deff7262d" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/7c9f1c52-b7e3-442c-97f0-4fa33581778b" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/85b23e9c-c040-4ebc-b318-32dba059107c" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/56a30799-ef8b-4730-b03f-d73cc47ef27d" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/9533742f-e8e6-45bf-90f7-70a057849f38" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/73791014-2c11-4cb5-bad8-9fd10fb57c56" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/93b376ab-fe73-4746-8092-e6072c408502" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/5093f13b-88cb-4eb2-94c6-847ba85af122" />
<img width="1920" height="968" alt="image" src="https://github.com/user-attachments/assets/7e2707a5-da3f-466f-bd88-828c5feeaf96" />
<img width="1920" height="1055" alt="image" src="https://github.com/user-attachments/assets/9b89f80d-d618-4a69-a296-f373f10c7007" />











---
