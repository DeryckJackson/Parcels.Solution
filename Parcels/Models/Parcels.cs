using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcels
  {
    private int _width;
    private int _height;
    private int _depth;
    private static List<Parcels> _instances = new List<Parcels>();

    public Parcels(int width, int height, int depth)
    {
      _width = width;
      _height = height;
      _depth = depth;

      _instances.Add(this);
    }

    public List<Parcels> GetAll()
    {
      return _instances.GetAll();
    }

    public int Volume()
    {
      return _width * _height * _depth; 
    }

    public int CostToShip()
    {
      return Volume() / 3;
    }
  }
}