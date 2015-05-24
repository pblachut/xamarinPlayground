using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Microsoft.Practices.Unity;

namespace XamarinTest
{
	public class NextVaviPageViewModel
	{
		private INavigation _navigation;
		private IUnityContainer _unityContainer;

		public ICommand ClickCommand { get; set; }

		public NextVaviPageViewModel (
			INavigation navigation,
			IUnityContainer unityContainer)
		{
			_navigation = navigation;
			_unityContainer = unityContainer;

			ClickCommand = new Command (NavigateBack);
		}

		private async void NavigateBack()
		{
			var mainPage = _unityContainer.Resolve<MainPage> ();

			await _navigation.PushAsync (mainPage);
		}
			
	}
}

