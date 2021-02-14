using System;
namespace Generics 
{
    public class Car 
    {
      string name;
      public Motor m = new Motor();
      public Car(string nm) 
      {
          name = nm;
      }
      public class Motor
      {
          public void Draw() 
          {
              Console.WriteLine("Motor run run run ....");
          }
          
      }
    }
 


}