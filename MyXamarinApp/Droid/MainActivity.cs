using System;
using Xamarin.Forms;
using Microsoft.Practices.Unity;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MyXamarinApp.Droid
{
	[Activity (Label = "MyXamarinApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var container = new UnityContainer ();

			container.RegisterInstance<IUnityContainer> (container);

			Activator.

			LoadApplication (new App ());
		}
	}
}

