using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

using Xamarin.Forms;

namespace XamarinTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage (ViewModel viewmodel)
		{
			InitializeComponent ();

			BindingContext = viewmodel;
		}
	}
}

