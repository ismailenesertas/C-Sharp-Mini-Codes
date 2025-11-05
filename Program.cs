namespace ücgenalanı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taban Uzunluğunu Giriniz");
            string tabanstr = Console.ReadLine();

            Console.WriteLine("Yüksekliği giriniz");
            string yukseklikstr = Console.ReadLine();

            double taban = double.Parse(tabanstr);
            double yukseklik = double.Parse(yukseklikstr);
            UcgenAlanHesapla(taban, yukseklik);

        }

        static void UcgenAlanHesapla(double parmt1, double parmt2)
        {
            Console.WriteLine("Alanımız : {0}", (parmt2 * parmt1)/ 2);
        }
    }
}
