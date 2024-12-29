using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi adı

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 8795, 785, 4621, 357, 25, 46, 12, 1243, 45931 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers= { 45, 8795, 785, 4621, 357, 25, 46, 12, 1243, 45931 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;   
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav  Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            //Öğrencinin isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {i + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notlarını topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            //SInav Ortalamaları 

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin sınav ortalaması: {studentExamAvg[i]}");

                //Öğrencinin SInavdan Geçip Kalma Durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
            }
            Console.WriteLine("--------------------------------------------");

            #endregion
            Console.Read();
        }
    }
}
