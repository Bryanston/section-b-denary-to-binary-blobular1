// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        string mod = "";
        while (num > 0)
        {
            mod = (num % 2) + mod;
            num /= 2;
        }
        Console.WriteLine(mod);
    }
}
