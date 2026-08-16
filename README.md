# SysmonCreator

![C#](https://img.shields.io/badge/C%23-.NET-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge)
![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-512BD4?style=for-the-badge)
![Sysmon](https://img.shields.io/badge/Microsoft-Sysmon-0078D4?style=for-the-badge)
![Security](https://img.shields.io/badge/Domain-Windows%20Security-8A2BE2?style=for-the-badge)

> Windows Sysmon için basit XML yapılandırması oluşturmayı ve mevcut yapılandırmayı `Sysmon64.exe` üzerinden yüklemeyi/güncellemeyi amaçlayan C# Windows Forms uygulaması.

## 📌 Proje Hakkında

**SysmonCreator**, Microsoft Sysmon'un XML tabanlı yapılandırmasını kullanıcı tarafından seçilen process/image filtreleriyle oluşturan eski nesil bir Windows masaüstü aracıdır.

Kaynak koduna göre uygulama üç temel işlem sağlar:

1. Kullanıcının girdiği image/process isimlerinden `BekraSysmon.xml` oluşturmak
2. Oluşturulan XML'i yerel `Sysmon64.exe -i BekraSysmon.xml` komutuyla Sysmon kurulumu için çalıştırmak
3. XML'i `Sysmon64.exe -c BekraSysmon.xml` ile mevcut Sysmon yapılandırmasına uygulamak

Proje **tam kapsamlı bir Sysmon yönetim platformu değildir**; temel bir XML oluşturucu ve Sysmon komut çalıştırma arayüzüdür.

## ✨ Özellikler

- 📝 Process/image filtreleri ekleme
- 🗑️ Listedeki filtreleri çift tıklamayla kaldırma
- 📄 Sysmon XML oluşturma
- 💾 `BekraSysmon.xml` dosyasını uygulama dizinine yazma
- 👁️ Oluşturulan XML'i uygulama içindeki WebBrowser kontrolünde görüntüleme
- ⚙️ Sysmon kurulumu için `Sysmon64.exe -i` çalıştırma
- 🔄 Sysmon yapılandırmasını güncellemek için `Sysmon64.exe -c` çalıştırma

## 🧰 Teknoloji Kartları

| Teknoloji | Kullanım |
|---|---|
| 🟢 **C#** | Ana programlama dili |
| 🪟 **Windows Forms** | Masaüstü kullanıcı arayüzü |
| 🔷 **.NET Framework 4.8** | Hedef framework |
| 🛡️ **Microsoft Sysmon** | Windows sistem izleme bileşeni |
| 📄 **XML** | Sysmon yapılandırma formatı |
| ⚙️ **System.Diagnostics.Process** | Sysmon64.exe çalıştırma |

Proje dosyası .NET Framework 4.8'i hedefler ve uygulama ikonunun `hacker.ico` olduğunu belirtir. fileciteturn252file0

## 📁 Proje Yapısı

```text
SysmonCreator/
├── SysmonCreator.sln
├── SysmonCreator/
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Program.cs
│   ├── App.config
│   ├── hacker.ico
│   └── Properties/
└── README.md
```

## 🔧 Oluşturulan XML Mantığı

Uygulama sabit bir Sysmon XML iskeleti oluşturur. Kullanıcı tarafından eklenen her değer şu yapıya dönüştürülür:

```xml
<Image condition="contains">ornek.exe</Image>
```

Oluşturulan yapı içerisinde kaynak kodunda özellikle şu filtreler bulunur:

- `ProcessCreate` — `exclude`
- `ProcessTerminate` — `include`
- `FileCreateTime` — `include`
- `NetworkConnect` — `exclude`

XML dosyası uygulamanın çalışma dizininde **`BekraSysmon.xml`** adıyla oluşturulur. fileciteturn251file0

## 🚀 Kurulum

Repository'yi klonlayın:

```bash
git clone https://github.com/ebubekirbastama/SysmonCreator.git
cd SysmonCreator
```

`SysmonCreator.sln` dosyasını Visual Studio ile açın ve .NET Framework 4.8 hedefleyen projeyi derleyin.

### Sysmon bileşeni

Kurulum/güncelleme menülerinin çalışabilmesi için uygulamanın çalışma dizininde **`Sysmon64.exe`** bulunması gerekir. Kaynak kodu bu dosyayı doğrudan:

```text
Application.StartupPath\Sysmon64.exe
```

yolundan çağırmaktadır. fileciteturn251file0

## ▶️ Kullanım

1. Uygulamayı çalıştırın.
2. Process/image adını giriş alanına yazın.
3. Listeye ekleyin.
4. Gerekirse listedeki bir öğeye çift tıklayarak kaldırın.
5. XML oluşturma seçeneğini çalıştırın.
6. `BekraSysmon.xml` dosyasını kontrol edin.
7. Yetkili bir yönetici ortamında gerekiyorsa Sysmon kurulum/güncelleme işlemini uygulayın.

## 🔄 Çalışma Akışı

```text
Kullanıcı
   │
   ▼
Process / Image Adı
   │
   ▼
ListBox
   │
   ▼
XML Generator
   │
   ▼
BekraSysmon.xml
   │
   ├──► Sysmon64.exe -i  → Kurulum
   │
   └──► Sysmon64.exe -c  → Yapılandırma Güncelleme
```

`Form1.cs` içerisinde XML üretimi ayrı bir thread üzerinde başlatılmakta, dosya yazılmakta ve Sysmon işlemleri yine ayrı thread üzerinden çalıştırılmaktadır. fileciteturn251file0

## ⚠️ Mevcut Kod Durumu

Bu proje **legacy / research** niteliğindedir.

Mevcut implementasyonda:

- `CheckForIllegalCrossThreadCalls = false` kullanılmıştır.
- `ProcessStartInfo` ile Sysmon komutları doğrudan çalıştırılır.
- Sysmon executable yolu sabittir.
- XML içeriği sınırlı bir şablon üzerinden oluşturulur.
- Kullanıcı girdileri XML escape işlemlerinden geçirilmeden `<Image>` içine yazılmaktadır.
- Process exit code / stderr/stdout kullanıcıya ayrıntılı şekilde raporlanmamaktadır.
- Yönetici yetkisi kontrolü uygulama seviyesinde yapılmamaktadır.

Bu nedenle README, projeyi üretime hazır bir Sysmon yönetim aracı olarak sunmamaktadır.

## 🔐 Güvenlik ve Yetkili Kullanım

Sysmon kurulumu ve yapılandırması sistem seviyesinde değişiklik oluşturabileceğinden uygulama yalnızca **yönetme yetkiniz bulunan Windows sistemlerinde** kullanılmalıdır.

Özellikle XML ve executable girdilerini güvenilmeyen kaynaklardan doğrudan çalıştırmayın.

## 🛠️ Modernizasyon Önerileri

- Modern .NET'e geçiş
- XML'i `XmlWriter` / `XDocument` ile güvenli şekilde üretme
- Kullanıcı girdilerini XML encode etme
- Sysmon sürüm/kurulum kontrolü
- Administrator privilege kontrolü
- Process exit code ve hata çıktılarının yakalanması
- Sysmon XML şablonunun yapılandırılabilir hale getirilmesi
- `async/await` tabanlı process yönetimi
- Sysmon event ID'leri için hazır şablonlar
- XML validation
- Unit testleri

## 📄 Lisans

Repository'deki `LICENSE` dosyasına bakınız.

## 👤 Geliştirici

**Ebubekir Bastama**  
GitHub: [@ebubekirbastama](https://github.com/ebubekirbastama)

---

⭐ Projeyi faydalı bulduysanız repository'ye yıldız bırakabilirsiniz.
