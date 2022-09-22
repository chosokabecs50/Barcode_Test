using BarcodeScanner.Mobile.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Barcode_Test.ViewModels
{
	public class NewViewModel : ContentPage
	{
		private ICommand _onDetectCommand { get; set; }
		public ICommand OnDetectCommand
		{
			get { return _onDetectCommand; }
			set
			{
				_onDetectCommand = value;
				OnPropertyChanged();
			}
		}

		private bool _isScanning = true;
		public bool IsScanning
		{
			get
			{
				return _isScanning;
			}
			set
			{
				if (!Equals(_isScanning, value))
				{
					_isScanning = value;
					OnPropertyChanged();
				}
			}
		}
		public NewViewModel()
		{
			Title = "About";
			OnDetectCommand = new Command<OnDetectedEventArg>(ExecuteOnDetectedCommand);

		}

		public void ExecuteOnDetectedCommand(OnDetectedEventArg arg)
		{
			List<BarcodeScanner.Mobile.Core.BarcodeResult> obj = arg.BarcodeResults;

			string result = obj[0].DisplayValue;

			Device.BeginInvokeOnMainThread(async () =>
			{
				IsScanning = true;
				if (IsScanning)
				{
					await Shell.Current.DisplayAlert("TEST", result, "OK");
				}
			});
		}
	}
}
