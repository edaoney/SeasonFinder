Console.WriteLine("MEVSİM BULUCU");
  
  
Console.Write("Ayı giriniz: ");
int month = int.Parse(Console.ReadLine());
  
  
if(month <= 2 || month == 12 )
{
    Console.WriteLine("Kış");
}

if (month >= 3 && month <= 5)
{
    Console.WriteLine("İlkbahar");
}

if (month >= 6 && month <= 8)
{
    Console.WriteLine("Yaz");
}

if (month >= 9 && month <= 11)
{
    Console.WriteLine("Sonbahar");
}