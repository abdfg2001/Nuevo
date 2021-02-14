using System;
namespace App
{
  public interface IShape
  {
      void Draw();
  }
  class Circulo : IShape {
    public void Draw() {
      Console.WriteLine("Circle Draw");
    }
  }
  class Rectangulo : IShape {
    public void Draw() {
      Console.WriteLine("Rectangle Draw");
    }
  }

  public class Persona
   {
     public void SayHi()
     {
        Console.WriteLine("Hola dice una persona");
     }
   }
}
