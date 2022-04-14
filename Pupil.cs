// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil
  {
    public string Origin { get; protected set;}
    public string Title { get; protected set;}
    public Pupil(string title)
    {
      this.Title = title;
    }
    public Pupil(string title, string origin)
    {
       this.Title = title;
       this.Origin = origin;
    }
    public Storm CastWindStorm()
    {
      return new Storm("wind",false, this.Title);
    }
  }
  
}
