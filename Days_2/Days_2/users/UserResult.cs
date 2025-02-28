using System;
using Days_2.models;

namespace Days_2
{
	public class UserResult
	{
		List<User> users = new List<User>();

		public UserResult()
		{
			Result();
		}

		private void Result()
		{
			users.Clear();
			for(int i = 0; i < 10; i++)
			{
                User u1 = new User();
                u1.name = "User - "+i;
                u1.surname = "Surame - "+i;
                u1.email = "user@mail.com-"+i;
                u1.password = "12345";
                u1.status = true;
                users.Add(u1);
            }
		}

		public void Add(User user)
		{
			users.Add(user);
		}

		public void Report()
		{
			foreach(User item in users)
			{
				Console.WriteLine($"{item}");
			}
		}

	}
}

