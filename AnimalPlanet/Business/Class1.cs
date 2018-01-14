using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalPlanet.Models;

namespace Business
{
    public class Class1
    {
        #region "BUSINESS LOGIC"

        private GenderSeperatedViewModel GetGenderSeparatedOwnerCatList(List<OwnerModel> ownerViewModel)
        {
            //Separate male and female owners
            var maleOwner = ownerViewModel.Where(x => x.Gender == Constants.Male).Select(p => new Male() { Pets = p.Pets }).ToList();
            var femaleOwner = ownerViewModel.Where(x => x.Gender == Constants.Female).Select(p => new Female() { Pets = p.Pets }).ToList();


            var itemsMale = from list in maleOwner
                            from item in list.Pets
                            select item;

            //Merge all male owner's cats
            List<MaleName> maleNameList = (from item in itemsMale
                                           select new MaleName
                                           {
                                               Name = item.AnimalName
                                           }
                                         ).OrderBy(x => x.Name).ToList();

            var itemsFemale = from list in femaleOwner
                              from item in list.Pets
                              select item;

            //Merge all female owner's cats
            List<FemaleName> femaleNameList = (from item in itemsFemale
                                               select new FemaleName
                                               {
                                                   Name = item.AnimalName
                                               }
                             ).OrderBy(x => x.Name).ToList();

            //Prepare and return result view model consisting both Male and Female view models
            GenderSeperatedViewModel genderSeperatedVM = new GenderSeperatedViewModel { Male = maleNameList, Female = femaleNameList };

            return genderSeperatedVM;
        }


        #endregion
    }
}
