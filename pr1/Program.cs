﻿using System;
using System.Linq;
using lib1;
public class Program
{
    const double pi = 3.14;
    const double radius = 5.0;

    public static int SignIn(int x)
    {
        if (x < 0)
        {
            return -1;
        }
        else if (x == 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    public static void Main()
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

        Random rand = new Random();
        int day_of_week = rand.Next(1, 7);
        string day_of_week_string = "";
        switch (day_of_week)
        {
            case 1:
                day_of_week_string = "Monday";
                break;
            case 2:
                day_of_week_string = "Tuesday";
                break;
            case 3:
                day_of_week_string = "Wednesday";
                break;
            case 4:
                day_of_week_string = "Thursday";
                break;
            case 5:
                day_of_week_string = "Friday";
                break;
            case 6:
                day_of_week_string = "Saturday";
                break;
            case 7:
                day_of_week_string = "Sunday";
                break;
            default:
                day_of_week_string = "Invalid Day";
                break;
        }
        Console.WriteLine($"Random date of week is {day_of_week_string}");

        string int_6 = Console.ReadLine();
        int parsed_int_6 = int.Parse(int_6);
        string int_7 = Console.ReadLine();
        int parsed_int_7 = int.Parse(int_7);
        int result = 1;
        for (int i = parsed_int_6; i <= parsed_int_7; i++)
        {
            result = result * i;
        }
        Console.WriteLine($"Result of umn with A and B is {result}");

        int rand_3grade = rand.Next(1, 100);
        int counter = 0;
        while (rand_3grade > 1)
        {
            if (rand_3grade / 3 == 1)
            {
                counter++;
                Console.WriteLine($"{rand_3grade} is {counter}-th grade of 3 value");
                rand_3grade = rand_3grade / 3;
            }
            if (rand_3grade % 3 == 0)
            {
                rand_3grade = rand_3grade / 3;
                counter++;
                continue;
            }
            else
            {
                Console.WriteLine($"{rand_3grade} is not the grade of 3!");
                break;
            }
        }

        Random rnd = new Random();
        int[] arr2 = new int[5];
        int result2 = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = rnd.Next(-10, 10);
            result2 += arr2[i];
            Console.WriteLine(arr2[i]);
        }
        Console.WriteLine("Сумма элементов массива: " + result2);

        int rand_int1 = rand.Next(-1, 1);
        int rand_int2 = rand.Next(-1, 1);
        Console.WriteLine($"Result: {SignIn(rand_int1) + SignIn(rand_int2)}");
        testLib(4, 5);
    }
    public List<string> wave(string str)
    {
        List<string> result_list = new List<string>();
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
            {
                char[] symbols = str.ToCharArray();
                symbols[i] = char.ToUpper(symbols[i]);
                result_list.Add(new string(symbols));
            }
        }
        return result_list;
    }

    public static string Rot13(string message)
    {
        string result = "";
        foreach (var s in message)
        {
            if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
                result += Convert.ToChar((s + 13)).ToString();
            else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
                result += Convert.ToChar((s - 13)).ToString();
            else result += s;
        }
        return result;
    }

    public static string Order(string words)
    {
        string[] words_arr = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var orderedWords = words_arr.OrderBy(word => word.FirstOrDefault(char.IsDigit)).ToArray();
        return string.Join(" ", orderedWords);
    }

    public static int Persistence(long n)
    {
        string str_n = n.ToString();
        int counter = 0;
        if (str_n.Length == 1)
        {
            return 0;
        }
        while (str_n.Length > 1)
        {
            counter++;
            int[] numbers = str_n.Select(c => (int)char.GetNumericValue(c)).ToArray();
            n = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                n *= numbers[i];
            }
            str_n = n.ToString();
        }
        return counter;
    }

    public static string FirstNonRepeatingLetter(string s)
    {
        foreach (char c in s)
        {
            if (s.Count(x => char.ToLower(x) == char.ToLower(c)) == 1)
            {
                return c.ToString();
            }
        }

        return "";
    }

    public static string Likes(string[] name)
    {
        if (name.Length == 0)
        {
            return "no one likes this";
        }
        else if (name.Length == 1)
        {
            string cur_name = new string(name[0]);
            return $"{cur_name} likes this";
        }
        else if (name.Length == 2)
        {
            string cur_name1 = new string(name[0]);
            string cur_name2 = new string(name[1]);
            return $"{cur_name1} and {cur_name2} like this";
        }
        else if (name.Length == 3)
        {
            string cur_name1 = new string(name[0]);
            string cur_name2 = new string(name[1]);
            string cur_name3 = new string(name[2]);
            return $"{cur_name1}, {cur_name2} and {cur_name3} like this";
        }
        else
        {
            string cur_name1 = new string(name[0]);
            string cur_name2 = new string(name[1]);
            return $"{cur_name1}, {cur_name2} and {name.Length - 2} others like this";
        }
    }

    public static string SpinWords(string str)
    {
        char[] separators = new char[] { ' ' };
        string[] words = str.Split(separators, StringSplitOptions.None);
        string result_str = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                char[] current_array = words[i].ToCharArray();
                Array.Reverse(current_array);
                string cur_res = new string(current_array);
                result_str += cur_res;
                if (i < words.Length - 1)
                {
                    result_str += ' ';
                }
            }
            else
            {
                result_str += words[i];
                if (i < words.Length - 1)
                {
                    result_str += ' ';
                }
            }
        }
        return result_str;
    }

    public static string ReverseWords(string str)
    {
        char[] separators = new char[] { ' ' };
        string[] words = str.Split(separators, StringSplitOptions.None);
        string result_str = "";
        for (int i = 0; i < words.Length; i++)
        {
            char[] current_array = words[i].ToCharArray();
            Array.Reverse(current_array);
            string current_res = new string(current_array);
            result_str += current_res;
            if (i < words.Length - 1)
            {
                result_str += " ";
            }
        }
        return result_str;
    }

    public static bool ValidatePin(string pin)
    {
        foreach (char c in pin)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        if (pin.Length != 6 && pin.Length != 4)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static int GetVowelCount(string str)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int vowelCount = 0;
        foreach (char c in str.ToLower())
        {
            if (Array.Exists(vowels, element => element == c))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }

    public static int DescendingOrder(int num)
    {
        char[] digits = num.ToString().ToCharArray();
        Array.Sort(digits);
        Array.Reverse(digits);
        return int.Parse(new string(digits));
    }

    public static void testLib(double temp1, double temp2)
    {
        Console.WriteLine($"Sum:{MathFunctions.Add(temp1, temp2)}");
        Console.WriteLine($"Sum:{MathFunctions.Substract(temp1, temp2)}");
        Console.WriteLine($"Sum:{MathFunctions.Multiply(temp1, temp2)}");
        Console.WriteLine($"Sum:{MathFunctions.Devide(temp1, temp2)}");
        Console.WriteLine($"Sum:{MathFunctions.Power(temp1, temp2)}");
        Console.WriteLine($"Sum:{MathFunctions.Sqrt(temp1, temp2)}");
    }
}