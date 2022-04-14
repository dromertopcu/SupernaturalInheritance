// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm
  {
    public string Essence { get; private set;}
    public bool IsStrong { get; private set;}
    public string Caster { get; private set;}

    public Storm(string essence, bool isStrong, string caster)
    {
      this.Essence = essence;
      this.IsStrong = isStrong;
      this.Caster = caster;
    }

    public string Announce()
    {
      string announce = $"{this.Caster} cast a {(this.IsStrong ? "strong" : "weak")} {this.Essence} storm!";
      return announce;
    }
  }

}
