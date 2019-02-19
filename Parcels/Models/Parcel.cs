using System;
using System.Collections.Generic;

namespace Parcels.Models {

  public class Parcel
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;
    private int _volume;
    private int _price;
    //private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (int length, int width, int height, int weight)
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
      //_instances.Add(this);
    }
    // public static List<Parcel> GetAll()
    // {
    //   return _instances;
    // }
    public int GetLength()
    {
      return _length;
    }
    public int GetWidth()
    {
      return _width;
    }
    public int GetHeight()
    {
      return _height;
    }
    public int GetWeight()
    {
      return _weight;
    }

    public int GetVolume()
    {
      _volume = _length * _width * _height;
      return _volume;
    }

    public int CostToShip()
    {
      _price = _weight * 1;
      return _price;
    }


  }
}
