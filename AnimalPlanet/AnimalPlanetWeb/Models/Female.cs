using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalPlanet.Models
{
    public class Female
    {
        public List<AnimalModel> Pets { get; set; }
    }
    public class FemaleName
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}