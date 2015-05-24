using System;

namespace MyXamarinApp
{
	public class MainViewModel
	{
		public string Id { get; private set;}

		public MainViewModel ()
		{
			Id = Guid.NewGuid ().ToString();
		}
	}
}

