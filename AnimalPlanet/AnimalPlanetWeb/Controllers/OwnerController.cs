using AnimalPlanet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Interfaces.Services;
using Services.Persistance;
using Services.Models;
using Services.Services;
using AnimalPlanet.Helpers;

namespace AnimalPlanet.Controllers
{
    public class OwnerController : ApiController
    {
        #region "Data Members"

        private OwnerService _ownerService;
        private Business _business;

        #endregion

        #region "CONSTRUCTOR"
        public OwnerController()
        {

        }

        #endregion

        #region "ACTION METHODS"

        [Route("api/Owner/GetAnimals")]
        [HttpPost]
        public GenderSeperatedViewModel GetAnimals()
        {
            GenderSeperatedViewModel animalViewModel = new GenderSeperatedViewModel();
            try
            {
                _ownerService = new OwnerService();
                _business = new Business();

                var list = _ownerService.GetAllOwnerList(); // Call service that pulls out all owner data along with their animals and prepare a owner list
                List<OwnerModel> ownerViewModel = GetAllOwnerAnimalsViewModel(list); //Convert result into owner model
                animalViewModel = _business.GetGenderSeparatedOwnerCatList(ownerViewModel); //Get result view model consisting both models 1. Male, 2. Female
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return animalViewModel;
        }


        #endregion

        #region "PRIVATE FUNCTIONS"

        private List<OwnerModel> GetAllOwnerAnimalsViewModel(IEnumerable<Owner> list)
        {
            //Filter list with Cat and sort resut in descending by gender
            List<OwnerModel> ownerViewModel = (from t1 in list
                                               select new OwnerModel
                                               {
                                                   Name = t1.Name,
                                                   Gender = t1.Gender,
                                                   Age = t1.Age,

                                                   Pets = (t1.Pets != null) ? (from t2 in t1.Pets   // Null condition check, it may be ;ossible that owner does not have any pets
                                                                               select new AnimalModel
                                                                               {
                                                                                   AnimalName = t2.Name,
                                                                                   AnimalType = t2.Type
                                                                               }).Where(x => x.AnimalType == Constants.PetType).OrderBy(x => x.AnimalName).ToList() : null
                                               }).Where(x => x.Pets != null).OrderByDescending(x => x.Gender).ToList();

            //Where(x => x.Pets != null)    "If there is no pet"
            return ownerViewModel;
        }

        #endregion
        
    }
}
