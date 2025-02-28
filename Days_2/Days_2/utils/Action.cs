using System;
namespace Days_2
{
	public class Action<T>
	{
		T[] arr = {};

		public T call1(T t)
		{
			return t;
		}

		public T index(int index)
		{
			return arr[index];
		}

	}
}

