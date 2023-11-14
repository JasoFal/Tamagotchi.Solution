using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {

    public void Dispose()
    {
      Pet.ClearAll();
    }

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
    
    [TestMethod]
    public void GetAll_ReturnPets_PetList()
    {
      string pet01 = "Dimbo";
      string pet02 = "Zeeb";
      Pet newTamagotchi01 = new Pet(pet01);
      Pet newTamagotchi02 = new Pet(pet02);
      List<Pet> newPetList = new List<Pet> { newTamagotchi01, newTamagotchi02 };
      List<Pet> result =  Pet.GetAll();
      CollectionAssert.AreEqual(newPetList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string petName = "Zeeb";
      Pet newTamagotchi = new Pet(petName);
      int result = newTamagotchi.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnCorrectPet_Pet()
    {
      string pet01 = "Zeeb";
      string pet02 = "Dimbo";
      Pet newTamagotchi01 = new Pet(pet01);
      Pet newTamagotchi02 = new Pet(pet02);
      Pet result = Pet.Find(2);
      Assert.AreEqual(newTamagotchi02, result);
    }
  }
}