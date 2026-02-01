# 📦 Task 1: Basic Product API (Monolithic Layered Architecture)

Bu döküman, **Backend Developer Case Study - 1. Aşama** kapsamında geliştirilen temel API servisinin detaylarını içerir. Bu aşamada temel backend prensipleri, REST API standartları ve veritabanı işlemleri hedeflenmiştir.

---

## 🎯 Proje Amacı
Temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren, Katmanlı Mimari (Layered Architecture) prensiplerine uygun, SOLID prensiplerini gözeten bir Web API geliştirmektir.

---

## 🛠️ Kullanılan Teknolojiler
* **Framework:** .NET 6+ (.NET Core Web API)
* **Dil:** C#
* **Veritabanı:** PostgreSQL (Entity Framework Core ile)
* **ORM:** EF Core (Code-First yaklaşımı)
* **Dokümantasyon:** Swagger (OpenAPI)

---

## 🏗️ Mimari Yapı (Layered Architecture)

Proje, sorumlulukların ayrılması (SoC) ilkesine uygun olarak 3 ana katmana ayrılmıştır:

1.  **Controller Layer (API):**
    * Dış dünyadan gelen HTTP isteklerini karşılar.
    * Gelen veriyi doğrular (Validation) ve Service katmanına iletir.
    * `ProductsController` üzerinden uç noktalar (endpoints) sunar.

2.  **Service Layer (Business Logic):**
    * İş mantığının işlendiği katmandır.
    * Repository'den veriyi alır, işler ve Controller'a DTO (Data Transfer Object) olarak döner.
    * Dependency Injection (DI) ile Repository katmanını kullanır.

3.  **Repository Layer (Data Access):**
    * Veritabanı ile doğrudan iletişim kuran katmandır.
    * `DbContext` kullanarak CRUD işlemlerini gerçekleştirir.

---

## 🔌 API Uç Noktaları (Endpoints)

| Metot | URL | Açıklama |
| :--- | :--- | :--- |
| `POST` | `/api/products` | Yeni bir ürün ekler. |
| `GET` | `/api/products` | Tüm ürünleri listeler. |
| `GET` | `/api/products/{id}` | ID'ye göre ürün detayını getirir. |
| `DELETE` | `/api/products/{id}` | ID'ye göre ürünü siler. |

---

## ⚙️ Teknik Özellikler

* **Asenkron Programlama:** Tüm veritabanı işlemleri `async/await` kullanılarak non-blocking (bloklamayan) şekilde tasarlanmıştır.
* **Model-DTO Ayrımı:** Veritabanı varlıkları (Entity) doğrudan dışarı açılmamış, DTO (Data Transfer Object) pattern kullanılmıştır.
* **Migration Yönetimi:** Veritabanı şeması `dotnet ef migrations` komutları ile kod üzerinden yönetilmiştir.
* **Exception Handling:** Hatalar için Try-Catch blokları veya Global Exception Handler kullanılmıştır.

---

## 🚀 Kurulum ve Çalıştırma

1.  `appsettings.json` dosyasındaki Connection String'i kendi veritabanınıza göre düzenleyin.
2.  Migrationları uygulayın:
    ```bash
    dotnet ef database update
    ```
3.  Projeyi ayağa kaldırın:
    ```bash
    dotnet run
    ```
4.  Tarayıcıda `https://localhost:7001/swagger` adresine giderek API'yi test edebilirsiniz.

---
**Geliştirici:** Adil Can