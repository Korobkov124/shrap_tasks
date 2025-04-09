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

        int int_literal = 42;
        double double_literal = 4.2;
        char char_literal = 'a';
        string string_literal = "string";
        bool bool_literal = false;
        Console.WriteLine($"int literal:{int_literal}, data type:{int_literal.GetType()}\ndouble literal:{double_literal}, data type:{double_literal.GetType()}\n" +
            $"char literal:{char_literal}, data type:{char_literal.GetType()}\nsrting literal:{string_literal}, data type:{string_literal.GetType()}\n" +
            $"bool literal:{bool_literal}, data type:{bool_literal.GetType()}");

        string string_7 = Console.ReadLine();
        double double_1 = double.Parse(string_7.Substring(0, 1));
        double double_2 = double.Parse(string_7.Substring(1, 1));
        Console.WriteLine($"Sum:{double_1 + double_2}\nUmn:{double_1 * double_2}");

        string int_1 = Console.ReadLine();
        string int_2 = Console.ReadLine();
        int A = int.Parse(int_1);
        int B = int.Parse(int_2);
        if (A > 2 && B <= 3)
        {
            Console.WriteLine("it is true");
        }
        else
        {
            Console.WriteLine("it is false");
        }


        string int_3 = Console.ReadLine();
        int parsed_int_3 = int.Parse(int_3);
        string int_4 = Console.ReadLine();
        int parsed_int_4 = int.Parse(int_4);
        string int_5 = Console.ReadLine();
        int parsed_int_5 = int.Parse(int_5);
        int[] arr = { parsed_int_3, parsed_int_4, parsed_int_5 };
        Console.WriteLine($"Maximum of this array is: {arr.Max()}");
    }
}