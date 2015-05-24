using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Microsoft.Practices.Unity;

namespace XamarinTest
{
	public class ViewModel : INotifyPropertyChanged
	{


		public ICommand ClickCommand { get; set; }

		private ISomeClassWithInterface _someClassWithInterface;
		private IUnityContainer _unityContainer;
		private INavigation _navigation;

		public ViewModel(
			ISomeClassWithInterface someClassWithInterface,
			IUnityContainer unityContainer,
			INavigation navigation)
		{
			_someClassWithInterface = someClassWithInterface;
			_unityContainer = unityContainer;
			_navigation = navigation;

			ClickCommand = new Command (Navigate);
		}


		private async void Navigate()
		{
			var nextPageView = _unityContainer.Resolve<NextVaviPage> ();
			await _navigation.PushAsync (nextPageView);
		}

		double hue, saturation, luminosity;
		Color color;

		public event PropertyChangedEventHandler PropertyChanged;

		public double Hue
		{
			set
			{
				if (hue != value)
				{
					hue = value;
					OnPropertyChanged("Hue");
					SetNewColor();
				}
			}
			get
			{
				return hue;
			}
		}

		public double Saturation
		{
			set
			{
				if (saturation != value)
				{
					saturation = value;
					OnPropertyChanged("Saturation");
					SetNewColor();
				}
			}
			get
			{
				return saturation;
			}
		}

		public double Luminosity
		{
			set
			{
				if (luminosity != value)
				{
					luminosity = value;
					OnPropertyChanged("Luminosity");
					SetNewColor();
				}
			}
			get
			{
				return luminosity;
			}
		}

		public Color Color
		{
			set
			{
				if (color != value)
				{
					color = value;
					OnPropertyChanged("Color");

					this.Hue = value.Hue;
					this.Saturation = value.Saturation;
					this.Luminosity = value.Luminosity;
				}
			}
			get
			{
				return color;
			}
		}

		void SetNewColor()
		{
			this.Color = Color.FromHsla(this.Hue,
				this.Saturation,
				this.Luminosity);
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

