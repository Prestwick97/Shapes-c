namespace Shapes.Models
{
  public class Circle
  {
    public double Radius { get; set; }

    public Circle (double radius)
    {
      Radius = radius;
    }

    public double GetDiameter(double radius)
    {
      return radius * 2;
    }
    public double GetCircumference(double radius)
    {
      return radius * 2 * 3.14;
    }
    public double GetArea(double radius)
    {
      return 3.14 * radius * radius;
    }
  }
}