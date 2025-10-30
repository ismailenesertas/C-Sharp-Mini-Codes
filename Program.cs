using System;

namespace collections

/*Kullanıcıdan 5 tane şehir ismi girmesini isteyiniz. 
Bu şehirleri liste koleksiyonuna ekleyiniz. 
Kullanıcının girmiş olduğu şehir isimleri içerisinde Artvin şehri varsa listeyi büyükten küçüğe doğru sıralayınız
Kullanıcının girmiş olduğu şehir isimleri içerisinde Artvin şehri yoksa küçükten büyüğe doğru sıralayınız. 
Listenin son halini ekrana yazdırınız*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 Tane City Giriniz\n");

            List<string> sehirler = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. Şehri Giriniz:\n ");
                string sehir = Console.ReadLine();
                sehirler.Add(sehir);
            }

            if (sehirler.Contains("Artvin"))
            {
                sehirler.Sort();
                
                

            }
            else
            {
                sehirler.Sort();
                sehirler.Reverse();
            }
            Console.WriteLine("Sıralanan Şehirler Böyle Sıralandı");

            foreach (var sehir in sehirler)
            {
                
                Console.WriteLine("\n:" + sehir);
            }
        }
    }
}
