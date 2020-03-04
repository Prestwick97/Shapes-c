namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Face { get; set; }
    public Sphere(Circle radius)
    {
      Face = radius;
    }

    public double GetSurfaceArea()
    {
      double radius = Face.Radius;
      return 4 * 3.14 * radius * radius;
    }

    public double GetVolume()
    {
      double radius = Face.Radius;
      return (4.0 / 3) * 3.14 * radius * radius * radius;
    }
  }
}