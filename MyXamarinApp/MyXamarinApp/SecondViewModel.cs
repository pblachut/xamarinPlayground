using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Microsoft.Practices.Unity;

namespace MyXamarinApp
{
	public class SecondViewModel
	{
		public string Id { get; private set;}

		public ICommand Click { get; set; }

		private IUnityContainer _unityContainer;
		private INavigation _navigation;

		public SecondViewModel (
			IUnityContainer unityContainer,
			INavigation navigation)
		{
			Id = Guid.NewGuid ().ToString();

			_unityContainer = unityContainer;
			_navigation = navigation;

			Click = new Command (BackToMainPage);
		}

		private async void BackToMainPage()
		{
			var mainView = _unityContainer.Resolve<MainView> ();
			await _navigation.PushAsync (mainView);
		}
	}
}

