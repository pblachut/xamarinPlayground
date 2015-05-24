using System;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace MyXamarinApp
{
	public class App : Application
	{
		public App ()
		{
			var container = new UnityContainer ();

			container.RegisterInstance<IUnityContainer> (container);

			MainPage = GetMainPageWithoutIoC ();
		}

		private ContentPage GetMainPageWithoutIoC()
		{
			var viewModel = new MainViewModel ();
			var view = new MainView (viewModel);
			return view;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

