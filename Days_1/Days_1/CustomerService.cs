using System;
namespace Days_1
{
	public class CustomerService
	{

		public static string name = "Erkan Bilsin";
		public int number = 40;

		public bool login(string username, string password)
		{
			if (username.Equals("ali01") && password.Equals("12345"))
			{
				security(100);
				return true;
			}
			return false;
		}


		public void security( int cid )
		{
			Console.WriteLine("Login Cid: " + cid);
		}


		// dizi içindeki değerlerin değişimi
		public string[] addStringArrayItem(string[] arr)
		{
			for(int i = 0; i<arr.Length; i++)
			{
				string item = "-"+arr[i];
				arr[i] = item;
			}
			return arr;
		}

		// static sum method
		public static int sum(int num1, int num2)
		{
			CustomerService customer = new CustomerService();
			customer.security(100);
			int sm = num1 + num2;
			return sm;
		}


	}
}

