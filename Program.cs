using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;
      storms[stormsIndex] = new Storm("wind",false, "Zul 'rajas");
      stormsIndex++;

      Pupil firstPupil = new Pupil("Mezil-kree");
      storms[stormsIndex] = firstPupil.CastWindStorm();
      stormsIndex++;

      Mage firstMage = new Mage("Gul'dan");
      storms[stormsIndex] = firstMage.CastRainStorm();
      stormsIndex++;
      
      storms[stormsIndex] = firstMage.CastWindStorm();
      stormsIndex++;

      Archmage firstArchmage = new Archmage("Nielas Aran");
     storms[stormsIndex] = firstArchmage.CastRainStorm();
     stormsIndex++;
     storms[stormsIndex] = firstArchmage.CastLightningStorm();
     stormsIndex++;
     foreach(var item in storms)
     {
       if(item != null)
        Console.WriteLine(item.Announce());
     }
     

    }
  }
}