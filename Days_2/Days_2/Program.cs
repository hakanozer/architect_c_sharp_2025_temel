using Days_2.models;
using Days_2.users;
using Days_2.utils;

namespace Days_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            Product p1 = new Product();
            p1.title = "TV";
            p1.detail = "TV Detail";
            p1.price = 30000;
            p1.category = "Elektronik";

            // product add
            productManager.ProductAdd(p1);

            // kullanıcıddan veri alımı
            Console.WriteLine("Lütfen adınızı giriniz!");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen yaşınızı giriniz!");
            string stAge = Console.ReadLine();

            User user = new User();
            user.UserControl(name, stAge);

            // List
            string[] users = { "Zehra", "Ayşe", "Mehmet", "Ahmet" };
            Action<int> action = new Action<int>();
            UseList useList = new UseList();
            useList.Call();

        }
    }
}