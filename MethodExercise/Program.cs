using System;

namespace MethodExercise
{
    internal class Program
    {
        public static int Add(params int[] methodAdd)
        {
            int totalAdd = 0;

            foreach(int Add in methodAdd)
            {
                totalAdd += Add;
            }

            return totalAdd;
        }
        public static int Subtract(params int[] methodSubtract)
        {
            int totalSubtract = 0;

            foreach(int Subtract in methodSubtract)
            {
                totalSubtract -= Subtract;
            }

            return totalSubtract;
        }
        public static int Multiply(params int[] methodMultiply)
        {
            int totalMultiply = 1;

            foreach(int Multiply in methodMultiply)
            {
                totalMultiply *= Multiply;
            }

            return totalMultiply;
        }
        public static double Divide(params double[] methodDivide)
        {
            double totalDivide = 1000;

            foreach(double Divide in methodDivide)
            {
                totalDivide /= Divide;
            }

            return totalDivide;
        }
        public static int Modulus(params int[] methodModulus)
        {
            int totalModulus = 23;

            foreach(int Modulus in methodModulus)
            {
                totalModulus %= Modulus;
            }

            return totalModulus;
        }
        static void Main(string[] args)
        {
            ////-------------------Exercise 1-------------------------------------------
            Console.WriteLine("Hello! What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite color too! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}s are so cool aren't they? What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Wow, that is crazy! You might not believe it, but I was wearing a {color} shirt when I " +
                $"met a {animal} named {name} at a concert by {band}... What are the odds?");

            //-------------------Exercise 2-------------------------------------------

            var methodAdd = Add(6, 2, 21, 42);
            Console.WriteLine(methodAdd);

            var methodSubtract = Subtract(6, 2, 12, 33);
            Console.WriteLine(methodSubtract);

            var methodMultiply = Multiply(6, 2, 39, 12, 42, 102);
            Console.WriteLine(methodMultiply);

            var methodDivide = Divide(6, 2);
            Console.WriteLine(methodDivide);

            var methodModulus = Modulus(6, 3);
            Console.WriteLine(methodModulus);
                      
        }
    }
}
