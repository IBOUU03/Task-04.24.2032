using System.Collections.Generic;
using Task3.Models;

namespace Task3.DataAccess
{
    public class Data
    {
        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Title="Lorem Ipsum 11",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=2,Title="Lorem Ipsum 22",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=3,Title="Lorem Ipsum 33",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
        };

        //public static List<SerFeature> SerFeatures = new List<SerFeature>
        //{
        //    new SerFeature{Id=1,Title="Lorem Ipsum",Icon="bx bxl-dribbble",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
        //    new SerFeature{Id=2,Title="Sed ut perspiciatis",Icon="bx bxl-dribbble",Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
        //    new SerFeature{Id=3,Title="Magni Dolores",Icon="bx bxl-dribbble",Desc="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
        //    new SerFeature{Id=4,Title="Nemo Enim",Icon="bx bxl-dribbble",Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
        //    new SerFeature{Id=5,Title="Dele cardo",Icon="bx bxl-dribbble",Desc="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
        //    new SerFeature{Id=6,Title="Divera don",Icon="bx bxl-dribbble",Desc="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"},
        //};

    }
}
