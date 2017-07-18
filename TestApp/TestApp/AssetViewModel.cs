﻿using System;
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
                        name = "Pondview2",
                        id = "1"
                    },
                    new Asset
                    {
                        name = "Oakbank Thornbank Pond",
                        id = "2"
                    },
                    new Asset
                    {
                        name = "Lakeview Estates Ltd",
                        id = "5"
                    },
                    new Asset
                    {
                        name = "Trullwrook Investments - Pond A",
                        id = "8"
                    },
                    new Asset
                    {
                        name = "Concord Storm Drainage - Pond B",
                        id = "9"
                    },
                    new Asset
                    {
                        name = "Pond 10",
                        id = "10"
                    },
                    new Asset
                    {
                        name = "Sugarbrush Developments Ph 1",
                        id = "11"
                    },
                    new Asset
                    {
                        name = "Sugarbrush Developments Ph 1",
                        id = "12"
                    },
                    new Asset
                    {
                        name = "Pond 1 - Woodland Acres",
                        id = "14"
                    },
                    new Asset
                    {
                        name = "Thornhill/Vaughan Community",
                        id = "15"
                    },
                    new Asset
                    {
                        name = "Keele/407",
                        id = "16"
                    },
                    new Asset
                    {
                        name = "Pond 17",
                        id = "17"
                    },
                    new Asset
                    {
                        name = "Langstaff Eco-Park",
                        id = "20"
                    },
                    new Asset
                    {
                        name = "Concord Storm Drainage - Pond A",
                        id = "21"
                    },
                    new Asset
                    {
                        name = "Pond 22 - Aldridge Estates",
                        id = "22"
                    },
                    new Asset
                    {
                        name = "Maple Neighbourhood 2 Pond",
                        id = "23"
                    },
                    new Asset
                    {
                        name = "Fieldgate Pond",
                        id = "24"
                    },
                    new Asset
                    {
                        name = "Maplewood Villages Ltd",
                        id = "31"
                    },
                    new Asset
                    {
                        name = "Keele-Steeles-Jane Imdus. Area",
                        id = "32"
                    },
                    new Asset
                    {
                        name = "CNR Industrial Subdivision",
                        id = "36"
                    }

                };

            }else if (assetType.Equals("Structure"))
            {
                assets = new ObservableCollection<Asset>
                {
                    new Asset
                    {
                        name = "Culvert",
                        id = "2-10"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "2-12"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "10-10"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "10-11"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "10-12"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-13"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-2"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "10-20"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-3"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-4"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-5"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-7"
                    },
                    new Asset
                    {
                        name = "Bridge",
                        id = "10-8"
                    },
                    new Asset
                    {
                        name = "Culvert",
                        id = "11-4"
                    }


                };

            }else if (assetType.Equals("LID"))
            {
                assets = new ObservableCollection<Asset>
                {
                    new Asset
                    {
                        name = "Site 1",
                        id = "1"
                    },
                    new Asset
                    {
                        name = "Site 2",
                        id = "2"
                    },
                    new Asset
                    {
                        name = "Site 3",
                        id = "3"
                    },
                    new Asset
                    {
                        name = "Site 4",
                        id = "4"
                    },
                    new Asset
                    {
                        name = "Site 5",
                        id = "5"
                    },
                    new Asset
                    {
                        name = "Site 6",
                        id = "6"
                    }
                };
            }

            for (int x = 0; x < assets.Count; x++)
            {
                assets[x].nameID = assets[x].combine(assets[x].id, assets[x].name);
            }
        }
    }
}
