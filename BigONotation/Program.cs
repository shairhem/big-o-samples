using System;

namespace BigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testFunctions = new TestFunctions();
            var people = new string[] { "shairhem", "alain", "rey", "pat", "alain", "rey", "pat" };
            var index = testFunctions.FindIndex(people, "pat");
            var index2 = testFunctions.FindPattern("easyeasy", "shairhem");
            var result1 = testFunctions.IsPalindrome("ambulance");
            var result2 = testFunctions.IsPalindrome("anna");
            var result3 = testFunctions.IsPalindrome("neveroddoreven");
            var result4 = testFunctions.BinarySearchIterative(new int[] { 10,3,5,1 }, 5);
        }
    }
}
