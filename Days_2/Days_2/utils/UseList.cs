using System;
namespace Days_2.utils
{
	public class UseList
	{

		public void Call()
		{

			// List
			List<string> list = new List<string>();

			// add item
			list.Add("Zehra");
			list.Add("Ayşe");
			list.Add("Mehmet");
            list.Add("Ali");
            list.Add("Veli");
            list.Add("Serkan");

			Console.WriteLine("Lütfen Kullanıcı Giriniz");
			string name1 = Console.ReadLine();
			list.Add(name1);


			// size
			int size = list.Count;
			Console.WriteLine($"Size: {size}");

			// get item
			string data = list[0];
			Console.WriteLine(data);

            Console.WriteLine("-----------------------");
			for(int i = 0; i< list.Count; i++)
			{
				Console.WriteLine(list[i]);
			}

            // remove item
            list.RemoveAt(0);
			list.Remove("Veli");

            Console.WriteLine("-----------------------");
			// loop
			foreach(string item in list)
			{
				Console.WriteLine(item);
			}


        }

	}
}

