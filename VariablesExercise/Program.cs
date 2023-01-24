

using System;
using System.Security.Cryptography.X509Certificates;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        string myString = "I made a string";
        int x = 10;
        char myChar = 'a';
        bool isTasty = true;
        double bigNum = 126.01;
        decimal thisNum = 2.13m;

        Console.WriteLine($"This is an interpolated string {myString} followed by this interpolated number {x}, then the character {myChar}, then the boolean {isTasty}, then the double {bigNum} and finally the decimal {thisNum}");
        }
       
    }
}

