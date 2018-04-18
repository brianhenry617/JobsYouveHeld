using System.Collections.Generic;
using System;

namespace JobsYouveHeld.Models
{
  public class Jobs
  /* Creating Jobs Class, which we will create instances from */
  {
    private string _location; /*Create Private string called _location*/
    private string _start;
    private string _end;
    private static List<Jobs> _instances = new List<Jobs> {}; /*Create private list called _instances, which will be empty for now*/


    public Jobs (string location, string start, string end)
    {
      _location = location;
      _start = start;
      _end = end;
    }

    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }

    public string GetStart()
    {
      return _start;
    }
    public void SetStart(string newStart)
    {
      _start = newStart;
    }

    public string GetEnd()
    {
      return _end;
    }
    public void SetEnd(string newEnd)
    {
      _end = newEnd;
    }
    public static List<Jobs> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
