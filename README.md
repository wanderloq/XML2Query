# XML to MSSQL Query Converter

Bu proje, XML formatındaki verileri alarak, MSSQL sorgularına dönüştüren bir C# uygulamasıdır. XML verisi, özellikle büyük ve karmaşık veri setlerinin taşınması ve yönetilmesinde yaygın olarak kullanılır. Ancak bu verilerin veritabanı yönetim sistemlerine aktarılması, genellikle elle yapılan bir işlem olabilmektedir. Bu uygulama, XML verilerini analiz ederek, bunları otomatik bir şekilde MSSQL sorgularına dönüştürmeyi sağlar.

![Proje Görseli](https://prnt.sc/T8fXPxEwl-t6)  <!-- Burada görselinize bağlantı ekleyebilirsiniz -->

## Özellikler
- **XML Verisini MSSQL Sorgusuna Çevirme:** Kullanıcılar, belirli bir XML dosyasını veya XML stringini sisteme yükleyebilir. Uygulama, veriyi analiz eder ve uygun SQL sorgusuna dönüştürür.
- **Dinamik Sorgu Oluşturma:** XML içeriğine göre dinamik ve optimize edilmiş `INSERT`, `UPDATE` gibi SQL komutlarını üretir.
- **Kolay Kullanım:** Sadece birkaç adımda XML verisini MSSQL uyumlu sorgulara dönüştürür.
- **Gelişmiş Hata Yönetimi:** Hatalı veya uyumsuz XML formatları için ayrıntılı hata mesajları sunar.

## Teknolojiler
- **Dil:** C#
- **Veritabanı:** MSSQL
- **Kütüphaneler:**
  - `System.Xml` (C# için XML işleme kütüphanesi)

## Kurulum

Projeyi yerel bilgisayarınıza klonladıktan sonra, aşağıdaki adımları izleyerek uygulamayı çalıştırabilirsiniz:

1. **Projeyi GitHub'dan Klonlayın:**

   ```bash
   git clone https://github.com/username/xml-to-mssql-query-converter.git
