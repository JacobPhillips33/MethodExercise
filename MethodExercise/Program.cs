using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is my favorite color too! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}s are so cool are they? What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Wow, that is crazy! You might not believe it, but I was wearing a {color} shirt when I " +
                $"met a {animal} named {name} at a concert by {band}... What are the odds?");
        }
    }
}
