
using ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassA classAObject = new(5);
        Console.WriteLine(classAObject);
        Console.WriteLine(classAObject.CLassAIntProperty * Math.PI / 2);
    }
}