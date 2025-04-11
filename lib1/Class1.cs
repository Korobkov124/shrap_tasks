namespace lib1
{
    public class MathFunctions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstTerm"></param>
        /// <param name="secondTerm"></param>
        /// <returns></returns>
        public double Add(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstTerm"></param>
        /// <param name="secondTerm"></param>
        /// <returns></returns>
        public double Add(double firstTerm, double secondTerm)
        {
            return firstTerm + secondTerm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstTerm"></param>
        /// <param name="secondTerm"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double Add(string firstTerm, string secondTerm)
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
        /// 
        /// </summary>
        /// <param name="firstTerm"></param>
        /// <param name="secondTerm"></param>
        /// <returns></returns>
        public double Substract(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }
        /// <summary>
        /// Вычисляет разность между двумя числами.
        /// </summary>
        /// <param name="firstTerm">Первое число, от которого вычитается второе.</param>
        /// <param name="secondTerm">Второе число, которое вычитается из первого.</param>
        /// <returns>Результат вычитания второго числа из первого.</returns>
        public double Substract(double firstTerm, double secondTerm)
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
        public double Substract(string firstTerm, string secondTerm)
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
        public double Multiply(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }
        /// <summary>
        /// Умножает два числа.
        /// </summary>
        /// <param name="firstTerm">Первое число для умножения.</param>
        /// <param name="secondTerm">Второе число для умножения.</param>
        /// <returns>Результат умножения двух чисел.</returns>
        public double Multiply(double firstTerm, double secondTerm)
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
        public double Multiply(string firstTerm, string secondTerm)
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
        public double Devide(int firstTerm, int secondTerm)
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
        public double Devide(double firstTerm, double secondTerm)
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
        public double Divide(string firstTerm, string secondTerm)
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
        public double Power(int term, int exponention)
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
        public double Power(double term, double exponention)
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
        public double Power(string term, string exponention)
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
        public double Sqrt(double number, double tolerance = 1e-10)
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
    }
}