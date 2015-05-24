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

			MainPage = GetMainPageWithIoC (container);
		}

		private ContentPage GetMainPageWithoutIoC()
		{
			var viewModel = new MainViewModel ();
			var view = new MainView (viewModel);
			return view;
		}

		private ContentPage GetMainPageWithIoC(IUnityContainer container)
		{
			return container.Resolve<MainView> ();
		}

		private void RegisterViewModels(IUnityContainer container)
		{
			container.RegisterType<MainViewModel, MainViewModel> (new ContainerControlledLifetimeManager ());
		}

		private void RegisterViews(IUnityContainer container)
		{
			container.RegisterType<MainView, MainView> (new ContainerControlledLifetimeManager ());
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

