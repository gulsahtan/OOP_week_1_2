# 🎯 Nesne Tabanlı Programlama – Hafta 1 & 2 | C# Console Uygulamaları

Bu proje, **Nesne Tabanlı Programlama (Object-Oriented Programming – OOP)** dersi kapsamında işlenen temel kavramları C# ve .NET Console uygulamaları üzerinden uygulamalı olarak öğretmek amacıyla hazırlanmıştır.

Proje içerisinde iki farklı uygulama bulunmaktadır:

- 📚 **Hafta 1 – Kitap Sınıfı:** Sınıf oluşturma, değişken tanımlama, erişim belirleyicileri, metot oluşturma ve nesne kullanımı.
- 📐 **Hafta 2 – Kare Sınıfı:** Kullanıcıdan veri alma, nesne değişkenlerine değer atama, alan ve çevre hesaplama, metotlardan değer döndürme ve koşullu ifadeler.

---

## 📌 Bu Haftalarda İşlenen Konular

- Nesne tabanlı programlamanın temel mantığı
- Sınıf (`class`) ve nesne (`object`) kavramları
- Visual Studio üzerinde Console projesi oluşturma
- Projeye yeni sınıf ekleme (`Add → Class`)
- Sınıf içerisinde değişken (field) tanımlama
- Erişim belirleyicileri (`public`, `private`)
- Metot oluşturma ve çağırma
- `void` ve değer döndüren metotlar
- `new` anahtar kelimesi ile nesne oluşturma
- Nesne üzerinden değişkenlere değer atama
- Nokta (`.`) operatörü ile sınıf üyelerine erişme
- `Console.ReadLine()` ile klavyeden veri alma
- `Convert.ToInt32()` ile tip dönüşümü
- `if`, `else if`, `else` koşullu ifadeleri

---

## 🧠 Nesne Tabanlı Programlama Nedir?

Nesne tabanlı programlama, yazılımın sınıflar ve bu sınıflardan oluşturulan nesneler üzerinden geliştirilmesini sağlayan bir programlama yaklaşımıdır.

Gerçek hayattaki varlıkların özellikleri ve davranışları yazılım içerisinde modellenebilir.

Örneğin bir **Kitap** düşünelim.

Kitabın özellikleri:

- Kitap adı
- Yazar
- Sayfa sayısı
- Basım yılı

Kitabın davranışı:

- Bilgilerini ekrana yazdırma

Bu özellikler ve davranışlar bir `Kitap` sınıfı içerisinde tanımlanabilir.

### 🔹 Sınıf (Class) Nedir?

Sınıf, nesnelerin hangi özelliklere ve davranışlara sahip olacağını belirleyen bir şablondur.

```csharp
public class Kitap
{
    public string kitapAdi;
    public string yazar;
    public int sayfaSayisi;

    public void BilgileriGoster()
    {
        Console.WriteLine(kitapAdi);
        Console.WriteLine(yazar);
        Console.WriteLine(sayfaSayisi);
    }
}
```

Burada:

- `class` → sınıf tanımlamak için kullanılır.
- `Kitap` → sınıfın adıdır.
- `kitapAdi`, `yazar`, `sayfaSayisi` → sınıfın değişkenleridir.
- `BilgileriGoster()` → sınıfın metodudur.

**Önemli:** Sınıf tanımlamak, tek başına bir kitap nesnesi oluşturmaz. Nesne oluşturmak için sınıfın örneklenmesi gerekir.

### 🔹 Nesne (Object) Nedir?

Nesne, bir sınıftan oluşturulan örnektir.

```csharp
Kitap kitap1 = new Kitap();
```

Bu satırda:

| Kod | Açıklama |
|---|---|
| `Kitap` | Nesnenin türünü belirleyen sınıf |
| `kitap1` | Nesneyi tutan referans değişkeni |
| `new` | Yeni bir nesne oluşturur |
| `Kitap()` | Sınıfın constructor'ını çağırır |

`new` anahtar kelimesi ile yeni bir nesne oluşturulur. Oluşturulan nesnenin referansı `kitap1` değişkenine atanır.

Aynı sınıftan birden fazla nesne oluşturulabilir:

```csharp
Kitap kitap1 = new Kitap();
Kitap kitap2 = new Kitap();
```

Bu iki nesne birbirinden bağımsızdır.

---

## 🛠️ Visual Studio'da Console Projesi Oluşturma

**Adım 1:** Visual Studio uygulamasını açın.

**Adım 2:** `Create a new project` seçeneğine tıklayın.

**Adım 3:** Proje şablonlarından `Console App` (.NET Framework) seçin.

**Adım 4:** `Next` butonuna tıklayın.

**Adım 5:** Proje adını girin.

Örnek:

`Hafta1-KitapOrnegi`

**Adım 6:** Kullanılacak .NET sürümünü seçin ve `Create` butonuna tıklayın.

**Adım 7:** Visual Studio tarafından oluşturulan `Program.cs` dosyasını inceleyin.

Console uygulamasının çalıştırılabilir giriş noktası, kullanılan proje şablonuna göre `Main()` metodu veya üst düzey ifadeler (top-level statements) olabilir. Ders örneklerimizde `Main()` metodunu kullanacağız.

---

## 📂 Projeye Yeni Sınıf Nasıl Eklenir?

Visual Studio içerisinde yeni bir sınıf oluşturmak için:

1. Sağ taraftaki **Solution Explorer** penceresini açın.
2. Sınıf eklemek istediğiniz **projenin üzerine sağ tıklayın**.
3. `Add → Class` seçeneğini seçin.
4. Sınıfın adını yazın. Örneğin `Kitap.cs`.
5. `Add` butonuna tıklayın.

> Bazı Visual Studio sürümlerinde `Add → New Item → Class` yolunu kullanmanız gerekebilir.

Visual Studio aşağıdakine benzer bir sınıf dosyası oluşturacaktır:

```csharp
namespace Hafta1
{
    public class Kitap
    {
    }
}
```

Artık bu sınıf içerisine değişkenler ve metotlar eklenebilir.

**Not:** Dosya adının sınıf adıyla aynı olması C# dilinde zorunlu değildir. Ancak kodun düzenli ve anlaşılır olması açısından önerilir.

---

# 📚 HAFTA 1 – Kitap Sınıfı Uygulaması

## 🎯 Uygulamanın Amacı

Bu uygulamada öğrenciler:

- Yeni sınıf oluşturmayı
- Sınıf içerisine değişken eklemeyi
- `public` ve `private` kavramlarını
- `void` metot tanımlamayı
- `Program.cs` içerisinde nesne oluşturmayı
- Nesnenin değişkenlerine değer atamayı
- Nesne üzerinden metot çağırmayı

öğreneceklerdir.

## 1️⃣ Sınıf İçerisinde Değişken Tanımlama

`Kitap.cs` dosyasını açın ve aşağıdaki değişkenleri ekleyin:

```csharp
public string kitapAdi;
public string yazar;
public int sayfaSayisi;
public int basimYili;
```

Burada `string` metinsel verileri, `int` ise tam sayıları saklamak için kullanılır.

Sınıf içerisinde doğrudan tanımlanan bu değişkenlere **field (alan)** adı verilir.

## 2️⃣ Erişim Belirleyicileri: public ve private

C# dilinde erişim belirleyicileri, sınıflara ve sınıf üyelerine nerelerden erişilebileceğini kontrol eder.

### 🔹 public

`public` olarak tanımlanan bir sınıf üyesine, erişilebilir bir nesne üzerinden sınıf dışından da ulaşılabilir.

```csharp
public string kitapAdi;
```

`Program.cs` içerisinde:

```csharp
Kitap kitap1 = new Kitap();
kitap1.kitapAdi = "Suç ve Ceza";
```

Bu kullanım geçerlidir.

### 🔹 private

`private` olarak tanımlanan bir sınıf üyesine yalnızca tanımlandığı sınıf içerisinden doğrudan erişilebilir.

```csharp
private int stokAdedi;
```

`Program.cs` içerisinde:

```csharp
kitap1.stokAdedi = 10; // HATA
```

Bu satır derleme hatasına neden olur.

Ancak `Kitap` sınıfının kendi metotları `stokAdedi` değişkenini kullanabilir.

| Erişim belirleyicisi | Aynı sınıf içerisinden | Başka sınıftan doğrudan |
|---|---|---|
| `public` | Erişilebilir | Erişilebilir |
| `private` | Erişilebilir | Erişilemez |

**Not:** Bu örneklerde öğrenme kolaylığı açısından `public` field kullanılmıştır. Daha sonraki haftalarda veri gizleme ve kapsülleme (`encapsulation`) kapsamında `private` field ve property (`get`, `set`) yapıları ele alınacaktır.

## 3️⃣ Metot Nedir ve Nasıl Tanımlanır?

Metot, belirli bir işlemi gerçekleştirmek için yazılan kod bloğudur.

Genel metot tanımlama yapısı:

```csharp
erisimBelirleyici donusTipi MetotAdi()
{
    // Yapılacak işlemler
}
```

Kitap bilgilerini yazdırmak için:

```csharp
public void BilgileriGoster()
{
    Console.WriteLine("Kitap Adı: " + kitapAdi);
    Console.WriteLine("Yazar: " + yazar);
    Console.WriteLine("Sayfa Sayısı: " + sayfaSayisi);
    Console.WriteLine("Basım Yılı: " + basimYili);
}
```

Burada:

- `public` → metoda sınıf dışından erişilmesini sağlar.
- `void` → metodun çağırana değer döndürmediğini belirtir.
- `BilgileriGoster` → metodun adıdır.
- `()` → metot parametrelerinin tanımlandığı bölümdür. Bu örnekte parametre bulunmamaktadır.

## 4️⃣ Program.cs İçerisinde Nesne Oluşturma

Sınıfımız hazır olduğuna göre `Program.cs` dosyasını açalım.

```csharp
Kitap kitap1 = new Kitap();
```

Nesne oluşturulduktan sonra nokta (`.`) operatörü kullanılarak erişilebilir sınıf üyelerine ulaşılır.

```csharp
kitap1.kitapAdi = "Suç ve Ceza";
kitap1.yazar = "Fyodor Dostoyevski";
kitap1.sayfaSayisi = 687;
kitap1.basimYili = 1866;
```

### 🔍 Nokta (.) Operatörü Ne İşe Yarar?

Nokta operatörü, nesnenin erişilebilir üyelerine ulaşmak için kullanılır.

```csharp
kitap1.kitapAdi
```

Bu ifade, `kitap1` nesnesinin `kitapAdi` değişkenine erişir.

```csharp
kitap1.BilgileriGoster();
```

Bu ifade ise `kitap1` nesnesinin `BilgileriGoster()` metodunu çalıştırır.

---

# 📐 HAFTA 2 – Kare Sınıfı ile Alan ve Çevre Hesaplama

## 🎯 Uygulamanın Amacı

Bu uygulamada öğrenciler, sınıf ve nesne kullanımını kullanıcı etkileşimiyle birleştireceklerdir.

Uygulama:

1. Kullanıcıdan iki sayı alır.
2. Bu sayıları nesnenin değişkenlerine atar.
3. Kullanıcıya işlem seçtirir.
4. `1` seçildiğinde alanı hesaplar.
5. `2` seçildiğinde çevreyi hesaplar.
6. Hesaplanan sonucu ekrana yazdırır.

**Matematiksel not:** Bu örnekte iki kenar uzunluğu kullanıldığı için hesaplamalar dikdörtgene aittir. Sınıf adı, ders örneğine uygun olarak `Kare` bırakılmıştır. Gerçek bir kare modelinde tek kenar uzunluğu yeterlidir.

## 1️⃣ Kare Sınıfını Oluşturma

Visual Studio üzerinde:

`Solution Explorer → Projeye sağ tık → Add → Class`

Sınıf adı:

`Kare.cs`

## 2️⃣ Sınıf Değişkenlerini Tanımlama

```csharp
public int kenar1;
public int kenar2;
```

Bu değişkenler kullanıcıdan alınacak kenar uzunluklarını saklayacaktır.

## 3️⃣ Alan Hesaplama Metodu

```csharp
public int AlanHesapla()
{
    int alan = kenar1 * kenar2;
    return alan;
}
```

Bu metotta:

- `public` → metot sınıf dışından çağrılabilir.
- `int` → metot tam sayı türünde sonuç döndürür.
- `AlanHesapla()` → metodun adıdır.
- `return alan;` → hesaplanan sonucu çağıran kod bölümüne gönderir.

Kullanım:

```csharp
int sonuc = kare1.AlanHesapla();
Console.WriteLine(sonuc);
```

Bu metot iki kenar uzunluğuna göre çevreyi hesaplar.

## Klavyeden Veri Alma

```csharp
Console.Write("1. sayıyı giriniz: ");
kare1.kenar1 = Convert.ToInt32(Console.ReadLine());
```

Kodun çalışma sırası:

1. `Console.Write()` kullanıcıya mesaj gösterir.
2. `Console.ReadLine()` klavyeden girilen veriyi metin olarak okur.
3. `Convert.ToInt32()` girilen metni tam sayıya dönüştürür.
4. `=` operatörü dönüştürülen değeri nesnenin değişkenine atar.

Örneğin kullanıcı `5` girerse:

```csharp
kare1.kenar1 = 5;
```

işlemi gerçekleştirilmiş olur.

**Dikkat:** `Convert.ToInt32()` geçersiz bir metin girildiğinde hata oluşturabilir. Bu haftanın örneğinde kullanıcının geçerli tam sayılar girdiği varsayılmaktadır. Güvenli veri giriş yöntemleri ilerleyen haftalarda ele alınabilir.

## Kullanıcıya İşlem Seçtirme

```csharp
Console.WriteLine("1 - Alan Hesapla");
Console.WriteLine("2 - Çevre Hesapla");

Console.Write("Seçiminiz: ");
int secim = Convert.ToInt32(Console.ReadLine());
```

Kullanıcının seçimine göre `if` ve `else if` blokları çalıştırılır.

```csharp
if (secim == 1)
{
    Console.WriteLine(kare1.AlanHesapla());
}
else if (secim == 2)
{
    Console.WriteLine(kare1.CevreHesapla());
}
else
{
    Console.WriteLine("Hatalı seçim!");
}
```

## ⚙️ Kullanılan Temel C# Yapıları

| Yapı | Açıklama | Örnek |
|---|---|---|
| `class` | Sınıf oluşturur | `class Kitap` |
| `public` | Erişimi uygun bağlamlarda dışarı açar | `public int kenar1;` |
| `private` | Erişimi tanımlandığı sınıfla sınırlar | `private int stok;` |
| `new` | Yeni nesne oluşturur | `new Kitap()` |
| `void` | Metodun değer döndürmediğini belirtir | `public void Yazdir()` |
| `int` | Tam sayı türüdür | `int sayi = 5;` |
| `string` | Metin türüdür | `string ad = "Ali";` |
| `return` | Metottan değer döndürür | `return alan;` |
| `Console.Write()` | Ekrana yazar, satır değiştirmez | `Console.Write("Sayı: ");` |
| `Console.WriteLine()` | Ekrana yazar ve yeni satıra geçer | `Console.WriteLine("Merhaba");` |
| `Console.ReadLine()` | Klavyeden bir satır okur | `Console.ReadLine()` |
| `Convert.ToInt32()` | Uygun değeri tam sayıya dönüştürür | `Convert.ToInt32("5")` |
| `if / else` | Koşula göre işlem yapar | `if (secim == 1)` |
| `.` | Nesne üyelerine erişir | `kitap1.kitapAdi` |

---

## 🧠 Öğrenme Kazanımları

Bu iki haftanın sonunda öğrenciler:

- Nesne tabanlı programlamanın temel mantığını açıklayabilecek,
- Sınıf ve nesne arasındaki farkı kavrayabilecek,
- Visual Studio'da yeni sınıf oluşturabilecek,
- Sınıf içerisinde değişken ve metot tanımlayabilecek,
- `public` ve `private` erişim belirleyicilerinin farkını açıklayabilecek,
- `new` anahtar kelimesiyle nesne oluşturabilecek,
- Nesne üzerinden değişkenlere değer atayabilecek,
- Nokta operatörü ile metot çağırabilecek,
- `void` ve değer döndüren metotları ayırt edebilecek,
- Klavyeden veri alıp hesaplama işlemlerinde kullanabilecek,
- Koşullu ifadelerle farklı metotları çalıştırabileceklerdir.

---
