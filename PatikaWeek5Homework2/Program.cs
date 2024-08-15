
// string tipinde liste tanımlanıyor..
List<string> guests=new List<string>();

//ziyaretçi listesine bilgiler giriliyor..
while (true)
{
    Console.WriteLine("\nZiyaretçi ad-soyad giriniz veya işlemden çıkmak için 'bitti' yazınız..:");
    string guest = Console.ReadLine();
    if (guest == "bitti")
    {
        break;
    }
    else
    {
        guests.Add(guest);
    }
}

//Ziyaretçiler ekrana yazdırılıyor...

Console.WriteLine("\nZiyaretçiler--------");

foreach(string guest  in guests)
{
    Console.WriteLine($"{guest}");
}