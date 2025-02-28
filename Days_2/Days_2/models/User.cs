using System;
namespace Days_2
{
	public struct User
	{
		public string name;
		public string surname;
		public string email;
		public string password;
		public bool status;

        public override string ToString()
        {
			string item = $"{name} {surname} {email} {password} {status}";
			return item;
        }

    }
}

