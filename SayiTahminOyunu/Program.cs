using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmineray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");

            while (true)
            {
                int altSinir, ustSinir, hedefSayi, tahmin, kalanDeneme, skor=0, skormod ;
                string zorluk,tekrar;

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
                        ustSinir = 15;
                        kalanDeneme = 8;
                        skormod = 10;
                        Console.WriteLine(
                            "Kolay Moda Hoşgeldiniz.\n"+
                            "Bu modda En fazla 80 puan kazanabilirsiniz.");
                        break;
                    case "O":
                        altSinir = 1;
                        ustSinir = 50;
                        kalanDeneme = 7;
                        skormod = 20;
                        Console.WriteLine(
                               "Orta Moda Hoşgeldiniz.\n" +
                               "Bu modda En fazla 140 puan kazanabilirsiniz.");
                        break;
                    case "Z":
                        altSinir = 1;
                        ustSinir = 100;
                        kalanDeneme = 6;
                        skormod = 30;
                        Console.WriteLine(
                             "Zor Moda Hoşgeldiniz.\n" +
                             "Bu modda En fazla 180 puan kazanabilirsiniz.");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seviye seçimi. Varsayılan olarak Kolay seviyesi seçildi.");
                        Console.WriteLine(
                           "Kolay Moda Hoşgeldiniz.\n" +
                           "Bu modda En fazla 80 puan kazanabilirsiniz.");
                        altSinir = 1;
                        ustSinir = 10;
                        kalanDeneme = 7;
                        skormod = 10;
                        break;
                }

                Random eray = new Random();
                hedefSayi = eray.Next(altSinir, ustSinir+1);//0-100 arasında 100 üde dahil etsin diye +1 koyuyorum
               


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

                    if (tahmin < hedefSayi)
                    {
                        Console.WriteLine("Girdiğiniz Sayı düşük.Kalan hakkın:" +" "+ (--kalanDeneme));
                    }
                    else if (tahmin > hedefSayi)
                    {
                        Console.WriteLine("Girdiğiniz Sayı yüksek.Kalan hakkın:"+" " + (--kalanDeneme));
                    }

                if(kalanDeneme==1)
                    {
                        Console.WriteLine("Dikkat Son Denemeniz!!");
                    }
                    else if (kalanDeneme==0)
                    {
                        Console.WriteLine("Üzgünüm, doğru tahmin edemediniz. Bir sonraki sefer daha iyisini yapabilirsiniz.");
                    }

                    if (tahmin == hedefSayi)
                    {
                        
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");

                        skor = kalanDeneme * skormod;
                        break;
                    }
                }
                Console.WriteLine("Oyun bitti. Skorunuz: " + skor);

                Console.Write("Tekrar oynamak için (T) tuşuna basın, çıkmak için herhangi bir tuşa basın: ");
                 tekrar= Console.ReadLine().ToUpper();
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


