// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1. ödev 


Console.WriteLine("bir sayı giriniz");
int sayı = Convert.ToInt32(Console.ReadLine());
if (sayı < 0 )
{
    Console.WriteLine("sayınız negatif");
}
else if (sayı > 0)
{
    Console.WriteLine("sayınız pozitif");
}
else if (0 == sayı)
{
    Console.WriteLine("sayınız 0'a eşit");
}

*/
//2. ödev

Console.WriteLine("1-7 arasından bir sayı girin");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("seçilen gün Pazartesi"); break;
    case 2: Console.WriteLine("seçilen gün Salı"); break;
    case 3: Console.WriteLine("seçilen gün Çarşamba"); break;
    case 4: Console.WriteLine("seçilen gün Perşembe"); break;
    case 5: Console.WriteLine("seçilen gün Cuma"); break;
    case 6: Console.WriteLine("seçilen gün Cumartesi"); break;
    case 7: Console.WriteLine("seçilen gün Pazar"); break;
    default: Console.WriteLine("geçerli bir numara değildir"); break;
}


//3. ödev
Console.WriteLine("işlem yapmak istediğiniz ilk sayıyı giriniz");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("işlem yapmak istediğiniz ikinci sayıyı giriniz");
double num2 = Convert.ToDouble(Console.ReadLine());
double sonuç = 0 ;

Console.WriteLine("işlem türünü seçin => (+, -, *, /):");
string işlem=Convert.ToString(Console.ReadLine());


switch (işlem)
{
    case "+":

        sonuç = num1 + num2;
        Console.WriteLine($"Sonuç: {num1} + {num2}= {sonuç}");
        break;

    case "-":

        sonuç = num1 - num2;
        Console.WriteLine($"sonuç:{num1}-{num2}={sonuç}");
        break;

    case "*":
        sonuç = num1 * num2;
        Console.WriteLine($"sonuç:{num1}*{num2}={sonuç}");
        break;

    case "/":
    
        if (num2 == 0)
        {
            Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
        }
        else
        {
            sonuç = num1 / num2;
            Console.WriteLine($"Sonuç: {num1} / {num2} = {sonuç}");
        }
        break;

    default:
        Console.WriteLine("geçersiz bir işlem türü seçtiniz");
        break;


}
 

//4. ödev
 Console.Write("Birinci sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı girin: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());


int enBuyuk = sayi1;

if (sayi2 > enBuyuk)
 {
   enBuyuk = sayi2;
 }
if (sayi3 > enBuyuk)
{
   enBuyuk = sayi3;
}


Console.WriteLine("En büyük sayı: " + enBuyuk);

//5.ödev

Console.Write("lütfen giriş yapmak için şifre oluşturun: ");
string sifre = Console.ReadLine();

 if (sifre.Length < 8)
 {
    Console.WriteLine(" Şifreniz 8 karakter veya daha fazla olmalı");
 }
 else if (!(sifre.Contains("@") || sifre.Contains("#") || sifre.Contains("$") || sifre.Contains("%")))
{
    Console.WriteLine(" Şifrenizde bu özel karakterlerin en az birini içermesi gerekir=> (@, #, $, %)");
}
else
{
    bool buyukHarf = false;

    for (int i = 0; i < sifre.Length; i++)
    {
        if (char.IsUpper(sifre[i]))
        {
            buyukHarf = true;
            break;
        }
    }

    if (!buyukHarf)
    {
        Console.WriteLine(" Şifrenizde büyük harf olmalı");
    }
    else
    {
        Console.WriteLine("tebrikler güçlü bir şifreniz var");
    }
}

