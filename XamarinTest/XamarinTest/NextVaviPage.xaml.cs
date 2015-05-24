using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTest
{
	public partial class NextVaviPage : ContentPage
	{
		public NextVaviPage (NextVaviPageViewModel viewModel)
		{
			InitializeComponent ();

			BindingContext = viewModel;
		}
	}
}

