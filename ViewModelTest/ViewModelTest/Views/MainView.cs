using System;

using Xamarin.Forms;

namespace ViewModelTest
{
	public class MainView : ContentPage
	{
		public MainView ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


