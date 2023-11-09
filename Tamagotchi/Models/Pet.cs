using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string PetName { get; set; }
    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name)
    {
      PetName = name;
      _instances.Add(this);
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }
  }
}