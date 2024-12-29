using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,lacivert,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü[] DiziAdı=new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Sari";
            //colors[1] = "Lacivert";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities=new string[5];

            //cities[0] ="Milano";
            //cities[1] ="Roma";
            //cities[2] ="Budapeşte";
            //cities[3] ="Madrid";
            //cities[4] ="Barcelona";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];
            //numbers[0] =50;
            //numbers[1] =48;
            //numbers[2] =698;
            //numbers[3] =24;
            //numbers[7] =748;

            //Console.WriteLine(numbers[7]);


            //string[] cities = { "Prag", "Roma","Atina","Ankara","Bursa" };
            //Console.WriteLine(cities[3]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Lacivert", "Beyaz", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 69, 735, 120, 635, 488, 520, 7456, 2356, 1120 };

            //for(int i=0;i<numbers.Length; i++)
            //{
            //    if (numbers[i] %3== 0) { Console.WriteLine(numbers[i]); }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f' };

            //for(int i=0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = {47,85,95,41,25,635,789,86,100};

            //int maxNumber=myArray[0];

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber= myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 76, 23, 36, 21, 34, 89, 65 };
            //Array.Sort(numbers);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 76, 23, 36, 21, 34, 89, 65 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "ahmet", "ayşe", "buse", "merve", "deniz","çınar" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 76, 23, 36, 21, 34, 89, 65 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //for(int i=0; i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]) ;
            //}

            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //}
            //Console.WriteLine(sum);

            int[] numbers = { 12, 34, 586, 785, 42, 69, 220, 987, 55, 54 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion
            Console.Read();
        }
    }
}
