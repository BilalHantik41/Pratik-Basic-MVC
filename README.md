# Pratik Basic MVC

Pratik Basic MVC, **ASP.NET Core MVC** mimarisini öğrenmek ve denemek amacıyla oluşturulmuş, örnek bir web uygulamasıdır. Proje, Controller‑View‑Model katmanlarını yalın tutarak temel CRUD (Create, Read, Update, Delete) senaryolarını ve Razor View kullanımıyla sayfa oluşturmayı gösterir.

## İçindekiler

* [Özellikler](#özellikler)
* [Ön Koşullar](#ön-koşullar)
* [Kurulum](#kurulum)
* [Çalıştırma](#çalıştırma)
* [Proje Yapısı](#proje-yapısı)
* [Ekran Görüntüleri](#ekran-görüntüleri)
* [Katkı Sağlama](#katkı-sağlama)
* [Lisans](#lisans)

## Özellikler

* **MVC Mimarisi** — Model, View ve Controller katmanlarını düzenli biçimde ayırır.
* **Razor View Engine** — Dinamik HTML sayfaları için Razor sözdizimi.
* **Entity Framework Core (In‑Memory)** — Hızlı prototipleme için geçici veri saklama.
* **Bootstrap 5** — Responsive ve modern kullanıcı arayüzü.
* **Örnek Modüller** — Müşteri (Customer), Sipariş (Order) ve Ürün (Product) işlemleri.

## Ön Koşullar

| Araç                                              | Sürüm              |
| ------------------------------------------------- | ------------------ |
| [.NET SDK](https://dotnet.microsoft.com/download) | **8.0** veya üzeri |
| Git                                               | 2.35+              |

> 💡  VS Code veya Visual Studio 2022 kullanmanız önerilir.

## Kurulum

```bash
# Depoyu klonla
git clone https://github.com/BilalHantik41/Pratik-Basic-MVC.git
cd Pratik-Basic-MVC

# NuGet paketlerini geri yükle
dotnet restore
```

## Çalıştırma

```bash
# Geliştirme modunda derleyip çalıştır
dotnet run --project Pratik/Pratik.csproj

# Tarayıcınızda açın
açılan adres genellikle https://localhost:5001 veya http://localhost:5000 olacaktır.
```

Uygulama açıldığında ana sayfa üzerinden **Customers** sekmesine giderek tüm müşterileri tek ekranda görüntüleyebilir ve CRUD işlemlerini test edebilirsiniz.

## Proje Yapısı

```
Pratik-Basic-MVC/
├── Pratik.sln                # Çözüm dosyası
└── Pratik/                   # ASP.NET Core projesi
    ├── Controllers/          # Controller sınıfları
    ├── Models/               # Veri modelleri
    ├── Views/                # Razor View dosyaları
    │   └── Shared/           # Ortak layout & kısmi görünümler
    ├── wwwroot/              # Statik dosyalar (CSS, JS, img)
    ├── appsettings.json      # Konfigürasyon
    └── Program.cs            # Uygulama giriş noktası
```

## Ekran Görüntüleri

> Projeyi çalıştırdıktan sonra ekran görüntülerinizi README'ye ekleyebilirsiniz. Örneğin:
>
> ![Customers List](docs/screenshots/customers-list.png)

## Katkı Sağlama

1. **Fork** edin.
2. Yeni bir feature branch oluşturun: `git checkout -b özellik/yenilik`.
3. Değişikliklerinizi commit edin: `git commit -m "Özellik ekle: ..."`.
4. Branch'i push edin: `git push origin özellik/yenilik`.
5. Pull Request açın.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Ayrıntılar için `LICENSE` dosyasına göz atabilirsiniz.
