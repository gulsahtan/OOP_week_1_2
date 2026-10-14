using System;

namespace OOP_week_1_2
{
    public class Kitap
    {
        // Sınıfa ait değişkenler
        public string kitapAdi;
        public string yazar;
        public int sayfaSayisi;
        public int basimYili;

        // Kitap bilgilerini ekrana yazdıran metot
        public void BilgileriGoster()
        {
            Console.WriteLine("Kitap Adı: " + kitapAdi);
            Console.WriteLine("Yazar: " + yazar);
            Console.WriteLine("Sayfa Sayısı: " + sayfaSayisi);
            Console.WriteLine("Basım Yılı: " + basimYili);
        }
    }
}
