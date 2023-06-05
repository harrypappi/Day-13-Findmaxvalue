using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test cases for integers
        int maxInt1 = FindMax(10, 5, 3);    
        int maxInt2 = FindMax(2, 8, 6);     
        int maxInt3 = FindMax(4, 7, 9);     

        Console.WriteLine($"Max Int 1: {maxInt1}");
        Console.WriteLine($"Max Int 2: {maxInt2}");
        Console.WriteLine($"Max Int 3: {maxInt3}");

        // Test cases for floats
        float maxFloat1 = FindMax(1.5f, 2.3f, 1.9f);    
        float maxFloat2 = FindMax(0.8f, 0.5f, 0.9f);    
        float maxFloat3 = FindMax(10.2f, 9.7f, 8.6f);   

        Console.WriteLine($"Max Float 1: {maxFloat1}");
        Console.WriteLine($"Max Float 2: {maxFloat2}");
        Console.WriteLine($"Max Float 3: {maxFloat3}");

        // Test cases for strings 
        string maxString1 = FindMax("Apple", "Grapes", "Banana");   
        string maxString2 = FindMax("Dog", "Cat", "Elephant");      
        string maxString3 = FindMax("Red", "Green", "Blue");         
        Console.WriteLine($"Max String 1: {maxString1}");
        Console.WriteLine($"Max String 2: {maxString2}");
        Console.WriteLine($"Max String 3: {maxString3}");
    }

    public static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
    {
        T max = a;

        if (b.CompareTo(max) > 0)
            max = b;

        if (c.CompareTo(max) > 0)
            max = c;

        return max;
    }
}
