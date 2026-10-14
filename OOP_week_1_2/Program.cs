using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_week_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kitap sınıfından nesne oluşturma
            Kitap kitap1 = new Kitap();

            // Nesnenin değişkenlerine değer atama
            kitap1.kitapAdi = "Suç ve Ceza";
            kitap1.yazar = "Fyodor Dostoyevski";
            kitap1.sayfaSayisi = 687;
            kitap1.basimYili = 1866;

            // Nesnenin metodunu çağırma
            kitap1.BilgileriGoster();

            Console.WriteLine();

            // İkinci kitap nesnesi
            Kitap kitap2 = new Kitap();

            kitap2.kitapAdi = "Kürk Mantolu Madonna";
            kitap2.yazar = "Sabahattin Ali";
            kitap2.sayfaSayisi = 160;
            kitap2.basimYili = 1943;

            kitap2.BilgileriGoster();

            

            // Kare sınıfından nesne oluşturma
            Kare kare1 = new Kare();

            // Kullanıcıdan kenar bilgilerini alma
            Console.Write("1. sayıyı giriniz: ");
            kare1.kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            kare1.kenar2 = Convert.ToInt32(Console.ReadLine());

            // İşlem seçimi
            Console.WriteLine("1 - Alan Hesapla");
            Console.WriteLine("2 - Çevre Hesapla");

            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                int sonuc = kare1.AlanHesapla();
                Console.WriteLine("Alan: " + sonuc);
            }
            else if (secim == 2)
            {
                int sonuc = kare1.CevreHesapla();
                Console.WriteLine("Çevre: " + sonuc);
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız!");
            }

          //  Console.ReadKey();

        }
    }
}
