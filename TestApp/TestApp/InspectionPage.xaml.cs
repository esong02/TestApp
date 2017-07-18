using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InspectionPage : ContentPage
	{
		public InspectionPage()
		{
			InitializeComponent();
            var navPage = App.Current.MainPage as NavigationPage;
            navPage.BarBackgroundColor = Color.GreenYellow;
            navPage.BarTextColor = Color.Black;
            

            
		}
	}
}