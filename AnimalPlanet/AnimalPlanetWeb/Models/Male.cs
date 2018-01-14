using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalPlanet.Models
{
    public class Male
    {
        public List<AnimalModel> Pets { get; set; }
    }
    public class MaleName
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}