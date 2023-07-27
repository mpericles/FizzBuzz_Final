using System;

namespace FizzBuzz_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(new int[] { 3, 5, 10, 15, 2 });
        }

        //Write a public method that accepts a number
        //To make a method the following 5 items
        //1. access modifier
        //2. return Type
        //3. Method Name
        //4. Parameters
        //5. Scope 
        public static void FizzBuzz(int[] arraynumbers)
        {
            
            for (int i = 0; i < arraynumbers.Length; i++)
            { 
            //when the number is divisible by both, return the word fizzbuzz
            if (arraynumbers[i] % 3 == 0 && arraynumbers[i] % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
                Console.WriteLine($"This is the value of the integer that returned fizzbuzz: {arraynumbers[i]}");
                Console.WriteLine();
            }
            //when the number is divisible by 5 return the word buzz
            else if (arraynumbers[i] % 5 == 0)
            {
                Console.WriteLine("fizz");
                Console.WriteLine($"This is the value of the integer that returned fizz: {arraynumbers[i]}");
                Console.WriteLine();
            }
            //when the number is divisible by 3 return the word fizz
            else if (arraynumbers[i] % 3 == 0)
            {
                Console.WriteLine("buzz");
                Console.WriteLine($"This is the value of the integer that returned buzz: {arraynumbers[i]}");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine($"This is the value of the integer that is the exception: {arraynumbers[i]}");
                Console.WriteLine();
            }
        }
        }
    }
}