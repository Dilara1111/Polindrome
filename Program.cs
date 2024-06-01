using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Palindrome with for loop

                Console.Write("Enter any Number: ");
                string b = Console.ReadLine();
                int len = b.Length;
                bool isPalindrome = true;
                for (int i = 0; i < len / 2; i++)
                {
                    if (b[i] != b[len - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome ? "The number is palindrome" : "The number isn`t palindrome");

                // Palindrome with while loop

                Console.Write("Enter any number:");
                int num = int.Parse(Console.ReadLine());
                int remainder, temp, reversNumber = 0;
                temp = num;
                while (num > 0)
                {
                    remainder = num % 10; // ededin qaliginin tapilmasi prosesi
                    reversNumber = (reversNumber * 10) + remainder; // eks ededin tapilmasi
                    num = num / 10; // novbeti iterasiya ucun ededi kicildirik                    
                }
                if (temp == reversNumber) Console.WriteLine(reversNumber + " The number is Palindrome");
                else Console.WriteLine(reversNumber + "The number isnt Palindrome");

                // Word is Palindrome?
                Console.WriteLine("Enter any word:");
                string str = Console.ReadLine();
                int lenght = str.Length;
                bool isPalindrome2 = true;
                for (int i = 0; i < lenght / 2; i++)
                {
                    if (str[i] != str[lenght - 1 - i])
                    {
                        isPalindrome2 = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome2 ? "The word is palindrome" : "The word isn`t palindrome");
               

            }
        }
    }
}
