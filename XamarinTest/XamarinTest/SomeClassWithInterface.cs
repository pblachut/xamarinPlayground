using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using Microsoft.Practices.Unity;

namespace XamarinTest
{
	public interface ISomeClassWithInterface
	{
		void DoSomething();
	}

	public class SomeClassWithInterface : ISomeClassWithInterface
	{
		public SomeClassWithInterface ()
		{
		}

		public void DoSomething()
		{
		}
	}
}

