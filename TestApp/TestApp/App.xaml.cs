using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            /*
            var navPage = new NavigationPage(new MainPage());
            navPage.BindingContext = new { BarColor = Color.Transparent };
            navPage.SetBinding(NavigationPage.BarBackgroundColorProperty, new Binding("BarColor"));

            this.MainPage = navPage;
            */

            MainPage = new NavigationPage(new MainPage());
            /*
            {
                BarBackgroundColor = Color.Transparent,
                BarTextColor = Color.Black
            };
            */
            //MainPage.BarBackgroundColor = Color.White;
            //MainPage.BarTextColor = Color.Black;
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
