using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string PetName { get; set; }
    public int Id { get; }
    public int PetFood { get; }
    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name)
    {
      PetName = name;
      PetFood = 100;
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
  }
}