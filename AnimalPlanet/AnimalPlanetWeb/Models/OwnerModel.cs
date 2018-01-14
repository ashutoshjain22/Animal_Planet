using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalPlanet.Models
{
    public class OwnerModel
    {
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public List<AnimalModel> Pets { get; set; }


    }

    public class AnimalModel
    {
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }


    }
}