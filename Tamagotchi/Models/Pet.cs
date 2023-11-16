using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string PetName { get; set; }
    public int Id { get; }
    public int PetFood { get; set; }
    public int PetRest { get; set; }
    public int PetAttention { get; set; }
    public string PetStatus { get; set; }
    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name)
    {
      PetName = name;
      PetFood = 100;
      PetRest = 100;
      PetAttention = 100;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void FeedPet(int Id)
    {
      _instances[Id-1].PetFood += 10;
    }

    public static void RestPet(int Id)
    {
      _instances[Id-1].PetRest += 10;
    }

    public static void AttentionPet(int Id)
    {
      _instances[Id-1].PetAttention += 10;
    }

    public static void TimePassage()
    {
      foreach (Pet pet in _instances)
      {
        pet.PetFood -= 1;
        pet.PetRest -= 1;
        pet.PetAttention -= 1;
      }
    }

    public static void PetDeathCheck()
    {
      foreach (Pet pet in _instances)
      {
        if (pet.PetFood <= 0 || pet.PetRest <= 0 || pet.PetAttention <= 0)
        {
          pet.PetStatus = $"Your {pet.PetName} has died.";
        }
        else if (pet.PetFood >= 0 || pet.PetRest >= 0 || pet.PetAttention >= 0)
        {
          pet.PetStatus = $"{pet.PetName} is alive and well.";
        }
      }
    }
  }
}