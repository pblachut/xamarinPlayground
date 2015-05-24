using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyXamarinApp
{
	public partial class MainView : ContentPage
	{
		public MainView (MainViewModel viewModel)
		{
			InitializeComponent ();

			this.BindingContext = viewModel;
		}
	}
}

