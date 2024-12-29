using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number =4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi ***** ");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyati:" + applePrice+"TL");
            //Console.WriteLine("----- Portakal Birim Fiyati:" + orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyati:" + strawberryPrice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyati:" + potatoPrice + "TL");
            //Console.WriteLine("----- Domates Birim Fiyati:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberyyGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberyyGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double stawberyyTotalPrice = strawberyyGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyati: " + applePrice + " - Gramaj: " +
            //    appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Porakal - " + "Birim Fiyati: " + orangePrice + " - Gramaj: " +
            //    orangeGram + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyati: " + strawberryPrice + " - Gramaj: " +
            //    strawberyyGram + " Toplam Tutar: " + stawberyyTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyati: " + potatoPrice + " - Gramaj: " +
            //    potatoGram + "Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyati: " + tomatoPrice + " - Gramaj:  " +
            //    tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + stawberyyTotalPrice +
            //    potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş TOplam Tutar:" + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict=Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity=Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge=Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber=Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "Yolcu Adı Soyadı: "
            //    + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + 
            //    passengerCity + " " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;


            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice =shoesCount*shoePrice + computerCount*computerPrice
            //    +chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödenmesi Gereken Tutar: " + totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("LÜtfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("LÜtfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("LÜtfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());


            //Console.WriteLine("Seçtiğiniz cinsiyet: "+ gender);
            #endregion
            Console.Read();
        }
    }
}
