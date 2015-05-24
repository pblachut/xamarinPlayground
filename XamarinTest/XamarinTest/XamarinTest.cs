
using System;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace XamarinTest
{
	public class App : Application
	{
		public App ()
		{
			var mainPage = new NavigationPage ();

			MainPage = mainPage;

			var container = new UnityContainer();


			container.RegisterType<ISomeClassWithInterface, SomeClassWithInterface> ();
			container.RegisterInstance<IUnityContainer> (container);
			container.RegisterInstance<INavigation> (App.Current.MainPage.Navigation);

			var view = container.Resolve<MainPage> ();
			container.RegisterInstance<MainPage> (typeof(MainPage).ToString(), view, new ContainerControlledLifetimeManager());

			var nextNaviPage = container.Resolve<NextVaviPage> ();
			container.RegisterInstance<NextVaviPage> (typeof(NextVaviPage).ToString(), nextNaviPage, new ContainerControlledLifetimeManager());


			MainPage.Navigation.PushAsync (view);
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

