﻿using System;
namespace lib1
{
    public class MathFunctions
    {
        /// <summary>
        /// Вычисляет сумму двух целых чисел.
        /// </summary>
        /// <param name="firstTerm">Первое целое число для сложения.</param>
        /// <param name="secondTerm">Второе целое число для сложения.</param>
        /// <returns>Сумма первого и второго числа.</returns>
        public static double Add(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }
        /// <summary>
        /// Вычисляет сумму двух чисел.
        /// </summary>
        /// <param name="firstTerm">Первое число для сложения.</param>
        /// <param name="secondTerm">Второе число для сложения.</param>
        /// <returns>Сумма первого и второго числа.</returns>
        public static double Add(double firstTerm, double secondTerm)
        {
            return firstTerm + secondTerm;
        }
        /// <summary>
        /// Вычисляет сумму двух чисел, заданных в виде строк.
        /// </summary>
        /// <param name="firstTerm">Первая строка, представляющая число.</param>
        /// <param name="secondTerm">Вторая строка, представляющая число.</param>
        /// <returns>Сумма двух чисел в виде числа с плавающей запятой.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если один из параметров не может быть преобразован в число.</exception>
        public static double Add(string firstTerm, string secondTerm)
        {
            if (double.TryParse(firstTerm, out double firstNumber) && double.TryParse(secondTerm, out double secondNumber))
            {
                double result = firstNumber + secondNumber;
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }
        /// <summary>
        /// Вычисляет разность между двумя целыми числами.
        /// </summary>
        /// <param name="firstTerm">Первое целое число, от которого вычитается второе.</param>
        /// <param name="secondTerm">Второе целое число, которое вычитается из первого.</param>
        /// <returns>Результат вычитания второго числа из первого.</returns>
        public static double Substract(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }
        /// <summary>
        /// Вычисляет разность между двумя числами.
        /// </summary>
        /// <param name="firstTerm">Первое число, от которого вычитается второе.</param>
        /// <param name="secondTerm">Второе число, которое вычитается из первого.</param>
        /// <returns>Результат вычитания второго числа из первого.</returns>
        public static double Substract(double firstTerm, double secondTerm)
        {
            return firstTerm - secondTerm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstTerm"></param>
        /// <param name="secondTerm"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Substract(string firstTerm, string secondTerm)
        {
            if (double.TryParse(firstTerm, out double firstNumber) && double.TryParse(secondTerm, out double secondNumber))
            {
                double result = firstNumber - secondNumber;
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }
        /// <summary>
        /// Умножает два целых числа.
        /// </summary>
        /// <param name="firstTerm">Первое целое число для умножения.</param>
        /// <param name="secondTerm">Второе целое число для умножения.</param>
        /// <returns>Результат умножения двух целых чисел.</returns>
        public static double Multiply(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }
        /// <summary>
        /// Умножает два числа.
        /// </summary>
        /// <param name="firstTerm">Первое число для умножения.</param>
        /// <param name="secondTerm">Второе число для умножения.</param>
        /// <returns>Результат умножения двух чисел.</returns>
        public static double Multiply(double firstTerm, double secondTerm)
        {
            return firstTerm * secondTerm;
        }
        /// <summary>
        /// Умножает два числа, представленные в виде строк.
        /// </summary>
        /// <param name="firstTerm">Первое число в виде строки.</param>
        /// <param name="secondTerm">Второе число в виде строки.</param>
        /// <returns>Результат умножения двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если хотя бы одно из входных значений не является допустимым числом.</exception>
        public static double Multiply(string firstTerm, string secondTerm)
        {
            if (double.TryParse(firstTerm, out double firstNumber) && double.TryParse(secondTerm, out double secondNumber))
            {
                double result = firstNumber * secondNumber;
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }
        /// <summary>
        /// Выполняет деление двух целых чисел.
        /// </summary>
        /// <param name="firstTerm">Первое число (делимое).</param>
        /// <param name="secondTerm">Второе число (делитель).</param>
        /// <returns>Результат деления первого числа на второе.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если делитель равен нулю.</exception>
        public static double Devide(int firstTerm, int secondTerm)
        {
            if(firstTerm == 0 || secondTerm == 0)
            {
                throw new ArgumentException("Нельзя делить на ноль");
            }
            else
            {
                return firstTerm / secondTerm;
            }  
        }
        /// <summary>
        /// Выполняет деление двух чисел.
        /// </summary>
        /// <param name="firstTerm">Первое число (делимое).</param>
        /// <param name="secondTerm">Второе число (делитель).</param>
        /// <returns>Результат деления первого числа на второе.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если делитель равен нулю.</exception>
        public static double Devide(double firstTerm, double secondTerm)
        {
            if (firstTerm == 0 || secondTerm == 0)
            {
                throw new ArgumentException("Нельзя делить на ноль");
            }
            else
            {
                return firstTerm / secondTerm;
            }
        }
        /// <summary>
        /// Выполняет деление двух чисел, представленных в виде строк.
        /// </summary>
        /// <param name="firstTerm">Первое число (делимое).</param>
        /// <param name="secondTerm">Второе число (делитель).</param>
        /// <returns>Результат деления первого числа на второе.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если входные данные некорректны или если делитель равен нулю.</exception>
        public static double Devide(string firstTerm, string secondTerm)
        {
            if (double.TryParse(firstTerm, out double firstNumber) && double.TryParse(secondTerm, out double secondNumber))
            {
                if(firstNumber == 0 || secondNumber == 0)
                {
                    throw new ArgumentException("Нельзя делить на ноль!");
                }
                else
                {
                    double result = firstNumber * secondNumber;
                    return result;
                }
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }
        /// <summary>
        /// Возвращает значение первого числа, возведенного в степень второго числа.
        /// </summary>
        /// <param name="term">Основание степени (число, которое нужно возвести в степень).</param>
        /// <param name="exponention">Степень (число, на которое нужно возвести основание).</param>
        /// <returns>Результат возведения в степень.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если основание равно нулю и степень отрицательная.</exception>
        public static double Power(int term, int exponention)
        {
            if (exponention == 0)
            {
                return 1;
            }
            if (exponention < 0)
            {
                if (term == 0)
                {
                    throw new ArgumentException("Base cannot be zero when exponent is negative.");
                }
                term = 1 / term;
                exponention = -exponention;
            }
            double result = 1;
            for (int i = 0; i < exponention; i++)
            {
                result *= term;
            }

            return result;
        }
        /// <summary>
        /// Возвращает значение первого числа, возведенного в степень второго числа.
        /// </summary>
        /// <param name="term">Основание степени (число, которое нужно возвести в степень).</param>
        /// <param name="exponention">Степень (число, на которое нужно возвести основание). Может быть отрицательным.</param>
        /// <returns>Результат возведения в степень.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если степень является бесконечностью или NaN.</exception>
        public static double Power(double term, double exponention)
        {
            if (double.IsInfinity(exponention) || double.IsNaN(exponention))
            {
                throw new ArgumentException("Exponent cannot be infinity or NaN.");
            }
            if (exponention < 0)
            {
                term = 1 / term;
                exponention = -exponention;
            }
            double result = 1;
            for (int i = 0; i < Math.Round(exponention); i++)
            {
                result *= term;
            }
            return result;
        }
        /// <summary>
        /// Возвращает значение первого числа, возведенного в степень второго числа.
        /// </summary>
        /// <param name="term">Основание степени (число, которое нужно возвести в степень).</param>
        /// <param name="exponention">Степень (число, на которое нужно возвести основание).</param>
        /// <returns>Результат возведения в степень.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если входные строки не могут быть преобразованы в числа.</exception>
        public static double Power(string term, string exponention)
        {
            if (double.TryParse(term, out double firstNumber) && double.TryParse(exponention, out double secondNumber))
            {
                double result = 1;
                for (int i = 0; i < secondNumber; i++)
                {
                    result *= firstNumber;
                }
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid Input");
            }
        }
        /// <summary>
        /// Вычисляет квадратный корень заданного числа с заданной точностью.
        /// </summary>
        /// <param name="number">Число, из которого необходимо извлечь квадратный корень.</param>
        /// <param name="tolerance">Допустимая погрешность для вычисления. По умолчанию 1e-10.</param>
        /// <returns>Квадратный корень из заданного числа.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если заданное число меньше нуля.</exception>
        public static double Sqrt(double number, double tolerance = 1e-10)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot compute the square root of a negative number.");
            }
            if (number == 0)
            {
                return 0;
            }

            double guess = number / 2.0;
            while (Math.Abs(guess * guess - number) > tolerance)
            {
                guess = (guess + number / guess) / 2.0;
            }
            return guess;
        }
        /// <summary>
        /// Склеивает два целых числа и возвращает их значение как число с плавающей запятой.
        /// </summary>
        /// <param name="firstTerm">Первый целый термин.</param>
        /// <param name="secondTerm">Второй целый термин.</param>
        /// <returns>Склеенное значение двух терминов в виде числа с плавающей запятой.</returns>
        public static double SuperSum(int firstTerm, int secondTerm)
        {
            string parsed_firstTerm = firstTerm.ToString();
            string parsed_secondTerm = secondTerm.ToString();
            double result = double.Parse(parsed_firstTerm + parsed_secondTerm);
            return result;
        }
        /// <summary>
        /// Склеивает два числа с плавающей запятой и возвращает их значение как число с плавающей запятой.
        /// </summary>
        /// <param name="firstTerm">Первый термин с плавающей запятой.</param>
        /// <param name="secondTerm">Второй термин с плавающей запятой.</param>
        /// <returns>Склеенное значение двух терминов в виде числа с плавающей запятой.</returns>
        public static double SuperSum(double firstTerm, double secondTerm)
        {
            string parsed_firstTerm = firstTerm.ToString();
            string parsed_secondTerm = secondTerm.ToString();
            double result = double.Parse(parsed_firstTerm + parsed_secondTerm);
            return result;
        }
        /// <summary>
        /// Склеивает два строковых значения и возвращает их значение как число с плавающей запятой.
        /// </summary>
        /// <param name="firstTerm">Первый строковый термин.</param>
        /// <param name="secondTerm">Второй строковый термин.</param>
        /// <returns>Склеенное значение двух терминов в виде числа с плавающей запятой.</returns>
        public static double SuperSum(string firstTerm, string secondTerm)
        {
            double result = double.Parse(firstTerm + secondTerm);
            return result;
        }
        public static double Calculator(string str) { return 0; }
    }
}