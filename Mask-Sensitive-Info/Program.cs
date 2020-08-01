using System;

namespace Mask_Sensitive_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret and I will hide it for you.");

            var userInput = Console.ReadLine();

            var maskedSecret = new String('X', userInput.Length - 4) + userInput.Substring(userInput.Length - 4);

            Console.WriteLine(maskedSecret);

            Console.ReadKey();
        }
    }
}
