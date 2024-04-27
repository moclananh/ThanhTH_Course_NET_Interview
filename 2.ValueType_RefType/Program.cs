class Program
{
    static void Main(string[] args)
    {
        // Value type example
        int value1 = 5;
        int value2 = value1; // value2 gets a copy of the value of value1
        value2 = 10; // changing value2 does not affect value1
        Console.WriteLine("Value type example:");
        Console.WriteLine($"value1: {value1}"); // Output: 5
        Console.WriteLine($"value2: {value2}"); // Output: 10

        Console.WriteLine();

        // Reference type example
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1; // array2 points to the same array as array1
        array2[0] = 10; // changing array2 affects array1
        Console.WriteLine("Reference type example:");
        Console.WriteLine($"array1[0]: {array1[0]}"); // Output: 10
        Console.WriteLine($"array2[0]: {array2[0]}"); // Output: 10
    }
}