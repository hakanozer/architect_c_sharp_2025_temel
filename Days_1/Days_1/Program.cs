namespace Days_1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Ali";
            string surname = "Bilmem";

            string stAge = "30";
            int age = 30;

            long num = 2342342342342342342;
            int sum = age + 5;

            bool status = false;

            double num1 = 10.5;

            Console.WriteLine(name + " " + surname);

            // atama operatörleri
            int numa = 10;
            numa += 5; // numa = numa + 5;
            numa -= 1;
            Console.WriteLine(numa);

            int i = 0;
            i++;
            Console.WriteLine(i);

            // mantıksal operatörler
            // == sol taraf ile sağ tarafın eşit olması
            int x = 10;
            int y = 20;

            status = x == y;
            Console.WriteLine(status);

            // != sol taraf ile sağ tarafın eşit olmaması
            status = x != y;
            Console.WriteLine(status);

            // > sol taraf sağ taraftan büyük mü
            status = x > y;
            Console.WriteLine(status);

            // < sol taraf sağ taraftan küçük mü
            status = x < y;
            Console.WriteLine(status);

            // >= sol taraf sağ taraftan büyük veya eşit mi
            status = x >= y;
            Console.WriteLine(status);

            // <= sol taraf sağ taraftan küçük veya eşit mi
            status = x <= y;
            Console.WriteLine(status);

            // logic operatörler
            // &&, ||
            // && -> sol taraftaki koşul ile sağ taraftaki koşul sağlanıyor

            status = x > 9 && y < 21;
            Console.WriteLine($"&& -> {status}");

            status = x > y || y > 10;
            Console.WriteLine($"|| -> {status}");

            // if -> karar kontrol yapısı
            /*
             if ( koşul ) {
                // yapılacak işlemler
             }else {
                // olumsuz işlemleri
             }
             */
            int w = 10;
            int e = 11;
            if (w > e)
            {
                Console.WriteLine("w > e");
            } else
            {
                Console.WriteLine("w < e");
            }

            string username = "ali01";
            string password = "12345";
            if (username == "ali01" && password == "12345")
            {
                Console.WriteLine("Login Success");
            } else
            {
                Console.WriteLine("Login Fail");
            }

            // else - if
            string firstname = "ali";
            string lastname = "bilmem";
            string email = "ali@mail.com";

            if (firstname == "" || lastname == "" || email == "")
            {
                Console.WriteLine("Lütfen tüm alanları doldurunuz!");
            } else
            {
                Console.WriteLine("Form gönderiliyor...");
            }

            if (firstname == "")
            {
                Console.WriteLine("Lütfen adınızı giriniz!");
            } else if (lastname == "")
            {
                Console.WriteLine("Lütfen soyadınızı giriniz!");
            } else if (email == "")
            {
                Console.WriteLine("Lütfen email giriniz!");
            } else
            {
                Console.WriteLine("Form Gönderildi");
            }

            // swicth
            string day = "pazar";
            switch (day)
            {
                case "pazartesi":
                    // yapılacak işlemler
                    Console.WriteLine("Mesai bitim 16:00");
                    break;
                case "sali":
                    Console.WriteLine("Mesai bitim 16:15");
                    break;
                case "carsamba":
                    Console.WriteLine("Mesai bitim 15:45");
                    break;
                default:
                    Console.WriteLine("Hatalı Gün!");
                    break;
            }

            // diziler
            // bir değişken içinde birden fazla değeri tutmak için
            object[] arrObj = { 100, "Ali", true, 10.6 };
            int[] numbers = { };
            string[] names = {"Ali", "Veli", "Zehra", "Ayşe", "Mehmet", "Ahmet", "Zafer"};
            // index - 0 dan başlar
            // dizi içindeki elemanların sıralanma biçimidir.
            string item = names[5];
            Console.WriteLine(item);

            object objItem = arrObj[0];
            if ( objItem is int )
            {
                int aInt = (int)objItem;
                Console.WriteLine(aInt + 50);
            }

            // size -> dizi içindeki eleman sayısını verir
            int size = names.Length;
            int index = 3;
            Console.WriteLine(size);
            if (size > index)
            {
                Console.WriteLine(names[index]);
            }

            // loop
            for(int count = 0; count<10; count++)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("======================");

            for(int count = 2; count < size; count++)
            {
                Console.WriteLine( names[count] );
            }

            Console.WriteLine("----------------------");
            foreach(string data in names )
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("======================");
            // Nesne üretimi
            // CustomerService -> sınıf adı
            // customer -> nesne
            // new -> sınıfı bellek seviyesinde hazırlayan ve nesneyi üreten
            // CustomerService() -> kurucu method
            CustomerService customer = new CustomerService();
            // nesneden sonra (.) ile özellik listesi alınır
            customer.number = 30;
            Console.WriteLine(customer.number);

            CustomerService actionCustomer = new CustomerService();
            Console.WriteLine(actionCustomer.number);

            bool loginStatus = customer.login("ali01", "12345");
            Console.WriteLine($"Login Status : {loginStatus}");

            loginStatus = customer.login("ahmet0", "12345");
            Console.WriteLine($"Login Status : {loginStatus}");

            customer.security(100);
            customer.security(133);
            customer.security(455);

            string[] newNames = customer.addStringArrayItem(names);
            foreach(string itm in newNames)
            {
                Console.WriteLine(itm);
            }

            // static
            // sınıf adı ile erişime uygun nesnelerdir.
            // kullan yada kullanma bellekte yer kaplamaya devam eder.
            Console.WriteLine(CustomerService.name);
            CustomerService.name = "Serkan Bilsin";
            Console.WriteLine(CustomerService.name);

            int sum1 = CustomerService.sum(34, 789);
            Console.WriteLine($"Sum1 : {sum1}");

            int sum2 = CustomerService.sum(67, 677);
            Console.WriteLine($"Sum2 : {sum2}");

        }
    }

}