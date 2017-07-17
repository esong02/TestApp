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
            
            facilityTab.BackgroundColor = Color.FromHex("ffce00");
            structureTab.BackgroundColor = Color.FromHex("#c4fd22");
            lidTab.BackgroundColor = Color.FromHex("#00baf0");

            tabfiller.BackgroundColor = Color.FromHex("ffce00");


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


        //Tabs
        private void TapFacilityTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.FromHex("ffce00");
            AssetList = new ListView();
            AssetList.ItemsSource = new String[]
            {
                "Facility 1",
                "Facility 2",
                "Facility 3"
            };
        }

        private void TapStructureTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.FromHex("#c4fd22");
            /*AssetList.ItemsSource = new String[]
            {
                "Structure 1",
                "Structure 2",
                "Structure 3"
            };*/
        }

        private void TapLIDTab(object sender, EventArgs e)
        {
            tabfiller.BackgroundColor = Color.FromHex("#00baf0");
            /*AssetList.ItemsSource = new String[]
            {
                "Site 1",
                "Site 2",
                "Site 3"
            };*/
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
