using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using System.Text;

namespace TestApp
{
    public class AssetViewModel
    {
        public ObservableCollection<Asset> assets { get; set; }

        public AssetViewModel()
        {

            assets = new ObservableCollection<Asset>
            {
                new Asset
                {
                    tabColor = "Yellow",
                    Title = "Facility 1"
                },
                new Asset
                {
                    tabColor = "Green",
                    Title = "Facility 2"
                },
                new Asset
                {
                    tabColor = "Blue",
                    Title = "Facility 3"
                }
            };

            

        }
    }
}
