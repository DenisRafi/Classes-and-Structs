/*
C# Classes and Structs

- A class or struct defines the template for an object.
- A class represents a reference type 
- A struct represents a value type
- Reference and value imply memory strategies

Example, CustomClass in the ProgrammingGuide namespace has three members:
an instance constructor, a property named Number, and a method named Multiply. 
The Main method in the Program class creates an instance (object) of CustomClass,
and the object’s method and property are accessed by using dot notation.
  
By Denis Rafi
 */
using System;
namespace ProgrammingGuide
{
    public class CustomClass
    {
        public int Number { get; set; }
        public int Multiply(int num)
        {
            return num * Number;
        }
        public CustomClass()
        {
            Number = 0;
        }
    }
    class Program
    {
        static void Main()
        {
            CustomClass custClass = new CustomClass();
            custClass.Number = 18;
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}.");
        }
    }
}
//output: The result is 72.
