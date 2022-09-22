using Barcode_Test.ViewModels;
using Barcode_Test.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Barcode_Test
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
			Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));
		}
	}
}
