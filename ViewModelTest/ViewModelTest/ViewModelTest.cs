using System;
using XLabs.Forms.Mvvm;
using Xamarin.Forms;

namespace ViewModelTest
{
	public class App : Application
	{
		public App ()
		{
			RegisterViews();
			MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainView>());
		}

		private void RegisterViews()
		{
			ViewFactory.Register<MainView, MainViewModel>();
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

