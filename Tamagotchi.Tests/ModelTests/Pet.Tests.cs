using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {
    [TestMethod]
    public void PetConstructor_CreateInstanceOfPet_Pet()
    {
      Pet newTamagotchi = new Pet("M");
      Assert.AreEqual(typeof(Pet), newTamagotchi.GetType());
    }

    [TestMethod]
    public void GetPetName_ReturnPetName_String()
    {
      string name = "M";
      Pet newTamagotchi = new Pet(name);
      string result = newTamagotchi.PetName;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetPetName_SetPetName_String()
    {
      string name = "Zeeb";
      Pet newTamagotchi = new Pet(name);
      string updatedName = "Dimbo";
      newTamagotchi.PetName = updatedName;
      string result = newTamagotchi.PetName;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_PetList()
    {
      List<Pet> newList = new List<Pet> { };
      List<Pet> result = Pet.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
    // [TestMethod]
    // public void GetAll_ReturnPets_PetList
  }
}