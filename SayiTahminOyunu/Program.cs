using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");

            while (true)
            {
                int altSinir, ustSinir, hedefSayi, tahmin, kalanDeneme, skor, skormod;
                string zorluk, tekrar;

                Console.Write(
                    "Seviyesini seçiniz:\n" +
                    "Kolay (K)\n" +
                    "Orta (O) \n" +
                    "Zor (Z) \n" +
                    "Uygulamayı kapatmak İçin (C)\n");

                zorluk = Console.ReadLine().ToUpper();

                if (zorluk == "C")
                {
                    Console.WriteLine("Oyundan çıkılıyor...");
                    Environment.Exit(0);
                }
                switch (zorluk)
                {
                    case "K":
                        altSinir = 1;
                        ustSinir = 10;
                        kalanDeneme = 7;
                        skormod = 10;
                        break;
                    case "O":
                        altSinir = 1;
                        ustSinir = 50;
                        kalanDeneme = 6;
                        skormod = 20;
                        break;
                    case "Z":
                        altSinir = 1;
                        ustSinir = 100;
                        kalanDeneme = 5;
                        skormod = 30;
                        break;

                    default:
                        Console.WriteLine("Geçersiz seviye seçimi. Varsayılan olarak Kolay seviyesi seçildi.");
                        altSinir = 1;
                        ustSinir = 10;
                        kalanDeneme = 7;
                        skormod = 10;
                        break;
                }

                Random eray = new Random();
                hedefSayi = eray.Next(altSinir, ustSinir + 1);
                skor = 100;


                while (kalanDeneme > 0)
                {
                    Console.Write($"Tahmininizi yapınız ({altSinir}-{ustSinir}): ");
                    tahmin = int.Parse(Console.ReadLine());

                    Console.WriteLine(hedefSayi);

                    if (tahmin < altSinir || tahmin > ustSinir)
                    {
                        Console.WriteLine("Geçersiz tahmin. Lütfen belirtilen aralıkta bir sayı giriniz.");
                        continue;
                    }

                    else if (tahmin < hedefSayi)
                    {
                        Console.WriteLine("Girdiğiniz Sayı Çok düşük.Kalan hakkın:" + " " + (--kalanDeneme));
                    }
                    else if (tahmin > hedefSayi)
                    {
                        Console.WriteLine("Girdiğiniz Sayı Çok Yüksek.Kalan hakkın:" + " " + (--kalanDeneme));
                    }

                    else if (tahmin == hedefSayi)
                    {

                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");

                        skor = skor + kalanDeneme * skormod;
                        break;
                    }

                }

                Console.WriteLine("Oyun bitti. Skorunuz: " + skor);



                Console.Write("Tekrar oynamak için (T) tuşuna basın, çıkmak için herhangi bir tuşa basın: ");
                tekrar = Console.ReadLine().ToUpper();
                if (tekrar == "T")
                {
                    continue;
                }
                else
                    break;


                // seviye 1-2-3 kolay orta zor
                //hak
                //puan// 100 puan olucak bilemedikçe 100 den geri düşücek seviye sistemiine entegre et

            }

        }
    }
}

