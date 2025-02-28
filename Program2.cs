// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1. ödev
Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;

for (int temp = Math.Abs(sayi); temp > 0; temp /= 10)
{
    toplam += temp % 10;
}

Console.WriteLine("Rakamların toplamı: " + toplam);



// 2. ödev

int sayi;

while (true)
{
    Console.Write("10 ile 100 arasında bir sayı giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi >= 10 && sayi <= 100)
    {
        Console.WriteLine("Geçerli sayı girdiniz: " + sayi);
        break; 
    }
    else
    {
        Console.WriteLine("Hatalı giriş! Lütfen 10 ile 100 arasında bir sayı giriniz.");
    }
}

//3. ödev
int[] yaslar = { 5, 16, 25, 40, 70, 12, 19, 65 }; 

foreach (int yas in yaslar)
{
    string kategori;

    if (yas >= 0 && yas <= 12)
        kategori = "Çocuk";
    else if (yas >= 13 && yas <= 19)
        kategori = "Genç";
    else if (yas >= 20 && yas <= 64)
        kategori = "Yetişkin";
    else
        kategori = "Yaşlı";

    Console.WriteLine($"Yaş: {yas} - Kategori: {kategori}");
}
//4.ödev 
int[] dizi = { 1, 2, 3, 4, 5, 6, 3, 2, 7, 8, 9, 1 };


HashSet<int> tekrarEdenler = new HashSet<int>();
HashSet<int> bulunanlar = new HashSet<int>();
foreach (int eleman in dizi)
{
    if (!bulunanlar.Add(eleman))
    {
        tekrarEdenler.Add(eleman);
    }
}


Console.WriteLine("Tekrar eden elemanlar:");
foreach (int eleman in tekrarEdenler)
{
    Console.WriteLine(eleman);
}

//5. ödev


   string[] kelimeler = { "elma", "armut", "kiraz", "çilek", "karpuz", "muz", "şeftali", "üzüm" };

   if (kelimeler.Length == 0)
   {
       Console.WriteLine("Dizi boş!");
       return;
   }

   string enUzun = kelimeler[0];
   string enKisa = kelimeler[0];

   foreach (string kelime in kelimeler)
   {
       if (kelime.Length > enUzun.Length)
           enUzun = kelime;

       if (kelime.Length < enKisa.Length)
           enKisa = kelime;
   }

   Console.WriteLine($"En Uzun Kelime: {enUzun}");
   Console.WriteLine($"En Kısa Kelime: {enKisa}");

//6. ödev
Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();


string[] kelimeler = cumle.Split(' ');


Array.Sort(kelimeler);


Console.WriteLine("\nAlfabetik sıralanmış kelimeler:");
foreach (string kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

//7. ödev
List<string> kelimelerListesi = new List<string> { "elma", "armut", "muz" };


Console.WriteLine("Yeni kelime giriniz (bitirmek için 'quit' yazın):");
string input;


while ((input = Console.ReadLine()) != "quit")
{
    kelimelerListesi.Add(input); 
}


Console.WriteLine("\nKelime Listesi:");
foreach (var kelime in kelimelerListesi)
{
    Console.WriteLine(kelime);
}

//8. ödev
List<string> kelimelerListesi = new List<string>();

Console.WriteLine("Kelimeleri giriniz (bitirmek için 'quit' yazın):");
string input;

while ((input = Console.ReadLine()) != "quit")
{
    kelimelerListesi.Add(input); // Listeye yeni kelime ekle
}

Console.WriteLine("\nKelimeler Tersten:");
kelimelerListesi.Reverse();
foreach (var kelime in kelimelerListesi)
{
    Console.WriteLine(kelime); 
}

//9. ödev
List<int> sayilarListesi = new List<int>();
string input;

Console.WriteLine("Sayılara başlayın (bitirmek için 'quit' yazın):");

while (true)
{
    Console.Write("Bir sayı girin: ");
    input = Console.ReadLine();

    if (input.ToLower() == "quit") 
        break;

    if (int.TryParse(input, out int sayi)) 
    {
        sayilarListesi.Add(sayi);
    }
    else
    {
        Console.WriteLine("Geçerli bir sayı giriniz.");
    }
}

if (sayilarListesi.Count > 0)
{
    double ortalama = sayilarListesi.Average();
    Console.WriteLine("\nSayılarnın Ortalaması: " + ortalama);
}
else
{
    Console.WriteLine("\nHiç sayı girilmedi.");
    return;
}

sayilarListesi.Sort();

Console.WriteLine("\nSayılara küçükten büyüğe sıralı olarak:");
foreach (var sayi in sayilarListesi)
{
    Console.WriteLine(sayi);
}
//10. ödev
List<int> sayilarListesi = new List<int> { 5, 12, 3, 18, 9, 20, 7, 15 };

sayilarListesi.RemoveAll(sayi => sayi < 10);

Console.WriteLine("10'dan büyük olan sayılar:");
foreach (var sayi in sayilarListesi)
{
    Console.WriteLine(sayi);
}


//11. ödev
List<int> ogrenciNotlari = new List<int> { 40, 55, 70, 45, 30, 60, 85, 20 };

for (int i = 0; i < ogrenciNotlari.Count; i++)
{
    if (ogrenciNotlari[i] < 50)
    {
        ogrenciNotlari[i] = 50; 
    }
}

Console.WriteLine("Güncellenen Öğrenci Notları:");
foreach (var notu in ogrenciNotlari)
{
    Console.WriteLine(notu);
}