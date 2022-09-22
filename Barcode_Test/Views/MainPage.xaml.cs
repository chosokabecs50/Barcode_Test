using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barcode_Test.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private async void Button1_Clicked(object sender, EventArgs e)
		{
			//Ask for permission first
			bool allowed = false;
			allowed = await BarcodeScanner.Mobile.XamarinForms.Methods.AskForRequiredPermission();
			if (allowed)
				await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
			else await Shell.Current.DisplayAlert("Alert", "You have to provide Camera permission", "Ok");

		}
	}
}