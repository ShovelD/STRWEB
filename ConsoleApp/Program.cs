
using ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassA classAObject = new(5);
        Console.WriteLine(classAObject);
        Console.WriteLine(classAObject.CLassAIntProperty * 24);
        Console.WriteLine(classAObject.CLassAIntProperty * Math.PI / 2);
        Function(classAObject);
    }
    private static void Function(ClassA classA) 
    {

        Console.WriteLine("New Feature");
        Console.WriteLine($"classA base value:{classA.CLassAIntProperty}" +
            $"ClasssA modified value{classA.CLassAIntProperty * 0.3}");

    }
}
