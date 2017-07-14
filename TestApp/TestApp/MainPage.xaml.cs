using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    
	public partial class MainPage : ContentPage
	{
        

		public MainPage()
		{
			InitializeComponent();

            

            //syncDB.Clicked += MenuClickHandler;
           // settings.Clicked += MenuClickHandler;
            //myTasks.Clicked += MenuClickHandler;
            //find.Clicked += MenuClickHandler;


        }
       
        void MenuClickHandler(object sender, EventArgs args)
        {
            /*
           Button menuBtn = sender as Button;

           if (menuBtn == syncDB)
           {
               sampleLabel.Text = "Sync DB";
           }else if (menuBtn == myTasks)
           {
               sampleLabel.Text = "My Tasks";
           }else if (menuBtn == find)
           {
               sampleLabel.Text = "Find";
           }else if (menuBtn == settings)
           {
               sampleLabel.Text = "Settings";
           }
           else
           {
               sampleLabel.Text = "Unknown";
           }

           */
        }

        private void TapSyncDB(object sender, EventArgs e)
        {
            sampleLabel.Text = "Sync DB";
        }

        private void TapMyTasks(object sender, EventArgs e)
        {
            sampleLabel.Text = "My Tasks";
        }

        private void TapFind(object sender, EventArgs e)
        {
            sampleLabel.Text = "Find";
        }

        private void TapSettings(object sender, EventArgs e)
        {
            sampleLabel.Text = "Settings";
        }

        private void TapFacilityTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.Yellow;
        }

        private void TapStructureTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.GreenYellow;
        }

        private void TapLIDTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.DeepSkyBlue;
        }

        /*
        void OnLoginClicked(object sender, EventArgs args)
        {

            if (username.Text.Equals("Civica",StringComparison.OrdinalIgnoreCase))
            {
                if (password.Text.Equals("pass",StringComparison.OrdinalIgnoreCase))
                {
                    loginButton.Text = "Logged In!";
                }
                else
                {
                    loginButton.Text = "Wrong Password";
                }
            }
            else
            {
                loginButton.Text = "Wrong Username";
            }


        }
        */
    }
}
