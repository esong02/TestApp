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

        public AssetViewModel(string assetType)
        {
            if (assetType.Equals("Facility")) { 
                assets = new ObservableCollection<Asset>
                {
                    new Asset
                    {
                        name = "Facility 1"
                    },
                    new Asset
                    {
                        name = "Facility 2"
                    },
                    new Asset
                    {
                        name = "Facility 3"
                    }
                };

            }else if (assetType.Equals("Structure"))
            {
                assets = new ObservableCollection<Asset>
                {
                    new Asset
                    {
                        name = "Structure 1"
                    },
                    new Asset
                    {
                        name = "Structure 2"
                    },
                    new Asset
                    {
                        name = "Structure 3"
                    }
                };
            }else if (assetType.Equals("LID"))
            {
                assets = new ObservableCollection<Asset>
                {
                    new Asset
                    {
                        name = "Site 1"
                    },
                    new Asset
                    {
                        name = "Site 2"
                    },
                    new Asset
                    {
                        name = "Site 3"
                    }
                };
            }


        }
    }
}
