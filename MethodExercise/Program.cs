using System;

namespace MethodExercise
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args)
        {
            //-------------------Exercise 1-------------------------------------------
            //Console.WriteLine("Hello! What is your name?");
            //var name = Console.ReadLine();

            //Console.WriteLine($"Hi, {name}. What is your favorite color?");
            //var color = Console.ReadLine();

            //Console.WriteLine($"{color} is my favorite color too! What is your favorite animal?");
            //var animal = Console.ReadLine();

            //Console.WriteLine($"{animal}s are so cool are they? What is your favorite band?");
            //var band = Console.ReadLine();

            //Console.WriteLine($"Wow, that is crazy! You might not believe it, but I was wearing a {color} shirt when I " +
            //    $"met a {animal} named {name} at a concert by {band}... What are the odds?");

            //-------------------Exercise 2-------------------------------------------

            var methodAdd = Add(6, 2);
            Console.WriteLine(methodAdd);

            var methodSubtract = Subtract(6, 2);
            Console.WriteLine(methodSubtract);

            var methodMultiply = Multiply(6, 2);
            Console.WriteLine(methodMultiply);

            var methodDivide = Divide(6, 2);
            Console.WriteLine(methodDivide);

            var methodModulus = Modulus(23, 6);
            Console.WriteLine(methodModulus);
        }
    }
}
