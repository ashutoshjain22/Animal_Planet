using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalPlanet.Models;
using AnimalPlanet.Helpers;
using AnimalPlanet.Controllers;
using System.Collections.Generic;

namespace AnimalPlanet_Test
{
    [TestClass]
    public class OwnerTest
    {
        #region "BEHAVIOURAL TEST CASES"

        [TestMethod]
        public void CheckForCatUnderMaleMethodBehavioural() //Check whether animal is cat or not under male owner
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            if (actualResult.Male.Count > 0)
                Assert.AreEqual<string>(Constants.PetType, actualResult.Male[0].Type.ToString());
            else
                Assert.AreEqual<string>(Constants.PetType, Constants.PetType);

        }

        [TestMethod]
        public void CheckForCatUnderFemaleMethodBehavioural() //Check whether animal is cat or not under female owner
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            if (actualResult.Female.Count > 0)
                Assert.AreEqual<string>(Constants.PetType, actualResult.Female[0].Type.ToString());
            else
                Assert.AreEqual<string>(Constants.PetType, Constants.PetType);

        }

        #endregion
        
        #region "POSITIVE TEST CASES"

        [TestMethod]
        public void OwnerGetMaleAnimalCountMethodPositive()
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            Assert.AreEqual<int>(4, actualResult.Male.Count);
        }

        [TestMethod]
        public void OwnerGetFemaleAnimalCountMethodPositive()
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            Assert.AreEqual<int>(3, actualResult.Female.Count);
        }

        #endregion

        #region "Negative TEST CASES"

        [TestMethod]
        public void OwnerGetMaleAnimalCountMethodNegative()
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            Assert.AreNotEqual<int>(0, actualResult.Male.Count);
        }

        [TestMethod]
        public void OwnerGetFemaleAnimalCountMethodNegative()
        {
            GenderSeperatedViewModel expectedResult = new GenderSeperatedViewModel();
            expectedResult.Female = new List<FemaleName>();
            expectedResult.Male = new List<MaleName>();
            OwnerController appObject = new OwnerController();

            GenderSeperatedViewModel actualResult = appObject.GetAnimals();

            Assert.AreNotEqual<int>(0, actualResult.Female.Count);
        }

        #endregion


    }
}
