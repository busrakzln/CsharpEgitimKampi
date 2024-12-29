using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            // bir yapınnın metot olup olamdığını anlamak için sonunda mutlaka  açılıp () kapanması gerekiyor 

            //2'ye ayrılır.

            //1-Geriye Değer Döndürmeyen Metotlar
            //Customer-->Lİstele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Elmas Kara");



            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surName);
            //}
            //CustomerCard("Elmas", "Kara");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region 2- Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Elmas Kara";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren  String Parametreli Metotlar

            //string CounrtyCard(string counrtyname,string capital,string flagcolor)
            //{
            //    string cardInfo = "Ülke" + counrtyname + " - Başkent: " + capital + " - Bayrak Rengi " + flagcolor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CounrtyCard(x, y, z));

            //Console.WriteLine(CounrtyCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren  Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));
            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result=(exam1+exam2 + exam3)/3;
            //    if(result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 26, 45, 36));
            //Console.WriteLine(ExamResult("Ayşe", 36, 85, 33));
            #endregion
            Console.Read();
        }
    }
}
