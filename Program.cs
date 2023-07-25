namespace FizzBuzz_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(15));
        }

        //Write a public method that accepts a number
        //To make a method the following 5 items
        //1. access modifier
        //2. return Type
        //3. Method Name
        //4. Parameters
        //5. Scope 
        public static string FizzBuzz(int i)    
        {
            // Once I moved the code to Visual Community from Visual Code found 8 errors
            // the errors had to do with missing semicolans; repeat %; my parameter declared as number and me using
            // the interger I in my if else if statement
            // The other issue I was fighting with the compiler about was th fact that i did a if, else if and else statement
            // and it gave me an erro for the semicolon for the else but it seems I just needed to return.. learning
            // so it did not run kinda as it gave me a message about trusting the ASP.net certificate. Took a chance and said yes
            // Need to talk to someone about this one 

            //when the number is divisible by both, return the word fizzbuzz
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "fizzbuzz";
            }
            //when the number is divisible by 5 return the word buzz
            else if (i % 5 == 0)
            {
                return "fizz";
            }
            //when the number is divisible by 3 return the word fizz
            //else (i % 3 == 0)
            {
                return "buzz";
            }
        }
    }
}