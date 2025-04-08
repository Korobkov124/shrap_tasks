using System;
class Program
{
    const double pi = 3.14;
    const double radius = 5.0;
    static void Main()
    {
        string Mark = "Toyota";
        string Model = "Mark 2";
        double Engine_capacity = 2.5;
        bool is_crached = false;
        Console.WriteLine($"Mark:{Mark}\nModel:{Model}\nEngine capacity:{Engine_capacity}\nIs it crashed? {is_crached}");

        Console.WriteLine($"Area of the circle is {pi * (radius * radius)}");

        string name = Console.ReadLine();
        string age = Console.ReadLine();
        string color = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Your age is {age}. Your favourite color is {color}");
    }
}