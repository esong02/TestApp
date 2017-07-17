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
                    title = "Facility 1"
                },
                new Asset
                {
                    title = "Facility 2"
                },
                new Asset
                {
                    title = "Facility 3"
                }
            };

            

        }
    }
}
