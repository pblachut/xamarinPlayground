using System;
using XLabs.Forms.Mvvm;

namespace ViewModelTest
{
	public class MainViewModel : ViewModel
	{
		private string _message;

		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}

		public MainViewModel ()
		{
			Message = "Hello Xamarin Forms Labs MVVM Basics!!";
		}
	}
}

