﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") {
            //    Console.WriteLine("şfire doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış! ");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Bilgi! ");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış. ");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1. Sınav: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "Sonuç kötü. ";
            //}
            //if(average >50 & average <= 70)
            //{
            //    result = "Sonuç Orta.";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result =  "Sonuç İyi. ";
            //}
            //if(average > 84)
            //{
            //    result = "Sonuç Çok İyi... ";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else {
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. Syaının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) 
            //{
            //    Console.WriteLine("Sayı çift. ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}





            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuuItem = Console.ReadLine();

            //if (menuuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Pilav Fasulye");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-----Ana Yemekler-----");

            //    Console.WriteLine();
            //}
            //if (menuuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("-----Çorbalar-----");

            //    Console.WriteLine();
            //}
            //if (menuuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-----Pizzalar-----");

            //    Console.WriteLine();
            //}
            //if (menuuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-----İçecekler-----");

            //    Console.WriteLine();
            //}
            //if (menuuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-----Tatlılar-----");

            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case 

            //Console.Write("Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı giriş."); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " +result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}







            #endregion

            Console.Read();
        }
    }
}
