using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 42;
            Console.WriteLine(age);
            Console.WriteLine("Arithmetic Operators ");
            int result;
            int x =20, y =30;
            result = x + y;
            Console.WriteLine("Arithmetic Operators " + result);
            result = x - y;
            Console.WriteLine("Subtraction Operators " + result);
            result = x * y;
            Console.WriteLine("Multiplication Operators " + result);
            result = x / y;
            Console.WriteLine("Devision Operators " + result);
            result = x % y;
            Console.WriteLine("Modulo Operators " + result);
            //Postfix or Prefix

            Console.WriteLine("postfix: ");
                int i = 7;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.WriteLine("Prefix:");
            double a = 2.5;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            //String
            string sub;
            sub = "Md Arafat";
            Console.WriteLine("Name: "+sub);
            string Na;
            Na = "Arafat Rahman";
            Console.WriteLine($"Name: {Na}" );
            //var
            var rae = 7.5;
            Console.WriteLine(rae);
            var name = "MD Arafat Rahman";
            Console.WriteLine(name);
            Console.Read();
        }
    }
}
