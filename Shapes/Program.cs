using System;
using Shapes.Models;

namespace Shapes
{
  public class Program
  {
    public static void Main()
    {
      try 
      {
        CallRectangle();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }


    }

    public static void CallRectangle()
    {
      Console.WriteLine("Enter a lengt number of Rectangle.");
      int length = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a witdth number of Rectangle.");
      int witdth = int.Parse(Console.ReadLine());
      Rectangle newRectangle = new Rectangle(length, witdth);
      Console.WriteLine("Area of this Rectangle is " + newRectangle.GetArea());
      if ( newRectangle.IsSquare() == true)
      {
        Console.WriteLine("This Rectangle is Square!");
      }
      else
      {
        Console.WriteLine("This Rectangle is Not Square!");
      }
    }
  }
}