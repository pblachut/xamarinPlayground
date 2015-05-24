using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyXamarinApp
{
	public partial class SecondView : ContentPage
	{
		public SecondView (SecondViewModel viewModel)
		{
			InitializeComponent ();

			BindingContext = viewModel;
		}
	}
}

