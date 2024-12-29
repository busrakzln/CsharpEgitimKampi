using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirme k istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("--------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open(); //bağlantıyı aç
            //datasource:bağlantı adresimiz ( sunucu )
            //initial catalog:veritabanı ismimiz
            //integrated security:bağlantının güvenli olduğunu gösterir.

            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //tablonun hangi tablo olduğunu anlaması için yanına connection yazılır.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //sqldataadapter veritabanı ile c# kodları arasında köprü görevi görür

            DataTable dataTable = new DataTable();//verilerin geçici belleğe alınmasını sağlayacak.
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)//datarow datatabledan gelen bir sınıf türüdür.
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
