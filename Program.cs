using System;
using System.Collections.Generic;
using App;
using Generics;
namespace C_Sharp
{
    class Program
    {
        abstract class Shape {
            public abstract void Draw();
        }
        class Circle : Shape {
            public override void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                Console.WriteLine("Rectangle Draw");
            }
        }

        class Person{
            public int age;
            public string name;
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }
        }

        static void Swap<T>(ref T a, ref T b) 
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Func(int x) {
            Console.WriteLine(x*2);
        }

        static int Suma(int x , int y) {
            return(x + y);
        }
       
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.age = 12;
            p1.name = "Juan";
            p1.SayHi();
            Persona p2 = new Persona();
            p2.SayHi();
            Console.WriteLine("Hello World!");
            Shape c = new Circle();
            c.Draw();
            IShape a = new Rectangulo();
            a.Draw();
            int x = 10;
            int y = 15;
            Swap<int>(ref x,ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno",1);
            d.Add("One",1);
            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
            {
                Console.WriteLine(s + ": " + d[s]);
            }
            Car z = new Car("Inicio");
            z.m.Draw();
            Func(20);
            Console.WriteLine(Suma(2,6));
             Func(Suma(2,6));
        }
    }
}
