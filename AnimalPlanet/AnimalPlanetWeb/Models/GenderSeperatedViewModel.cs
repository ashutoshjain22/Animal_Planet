using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalPlanet.Models
{
    public class GenderSeperatedViewModel
    {
        public List<MaleName> Male { get; set; }
        public List<FemaleName> Female { get; set; }
    }
}