﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Microsoft.Practices.Unity;

namespace MyXamarinApp
{
	public class MainViewModel
	{
		public string Id { get; private set;}


		public ICommand Click { get; set; }

		private IUnityContainer _unityContainer;
		private INavigation _navigation;

		public MainViewModel (
			IUnityContainer unityContainer,
			INavigation navigation)
		{
			Id = Guid.NewGuid ().ToString();

			_unityContainer = unityContainer;
			_navigation = navigation;

			Click = new Command (GoToSecondView);
		}

		private async void GoToSecondView()
		{
			var secondView = _unityContainer.Resolve<SecondView> ();
			await _navigation.PushAsync (secondView);
		}
	}
}

