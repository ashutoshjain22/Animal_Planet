using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Persistance
{
    public class Owner
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //public string pets { get; set; }
        public List<Animal> Pets { get; set; }
    }

    public class Animal
    {
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }
        public string Type { get; set; }


    }
}
