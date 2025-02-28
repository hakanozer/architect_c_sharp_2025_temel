using System;
namespace Days_2.users
{
	public class User
	{
		public void UserControl(string name, string stAge)
		{			
			// try - catch
			try
			{
                // hata olma olasılığı olan kodlar
                int age = Convert.ToInt32(stAge);
				if(age > 0)
				{
					Console.WriteLine($"{name} durum: {UserAgeControl(age)}");
				}else
				{
					Console.WriteLine("Lütfen pozitif değer giriniz!"); ;
				}
            }
            catch(Exception ex)
			{
				// hata olduğunda çalışacak kodlar
				Console.WriteLine("Lütfen tam sayı giriniz!");
			}
		}


		private string UserAgeControl(int age)
		{
			string status = "";
			if (age > 0 && age < 18 )
			{
				status = "Ergen";
			}else if ( age >= 18 && age < 25 )
			{
				status = "Olgun";
			}else if ( age >= 26 && age < 40 )
			{
                status = "Geç";
            }
            else if ( age >= 41 && age < 60 )
			{
                status = "Orta Yaş";
            }
			return status;
		}

	}
}

