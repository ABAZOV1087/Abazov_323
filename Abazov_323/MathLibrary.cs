using System;

namespace Abazov_323
{
    public class Core
    {
        public static BankDBEntities Context = new BankDBEntities();
    }


    public class MathLibrary
    {

        /// <param name="x">Значение X.</param>
        /// <param name="y">Значение Y.</param>
        /// <param name="z">Значение Z.</param>
        /// <returns>Результат вычисления.</returns>
        public double CalculateComplexExpression(double x, double y, double z)
        {
            // ЗАМЕНЕНО НА ArgumentOutOfRangeException, чтобы тесты не падали
            if (Math.Abs(x - 2) < 0.000001) throw new ArgumentOutOfRangeException("x", "Division by zero in sqrt");
            if (Math.Atan(z) == 0) throw new ArgumentOutOfRangeException("z", "Division by zero in atan");

            double part1 = (Math.Exp(x) + 1) / Math.Sqrt(Math.Abs(x - 2));
            double part2 = (2 * Math.Abs(x + y) * Math.Pow(x + 1, -1)) / Math.Atan(z);
            return part1 * part2;
        }

        /// <summary>
        /// Вычисляет значение с условием выбора функции (Page2).
        /// </summary>
        /// <param name="x">Аргумент x.</param>
        /// <param name="y">Аргумент y.</param>
        /// <param name="mode">Режим: 1 - sinh, 2 - sqr, остальное - exp.</param>
        /// <returns>Результат d.</returns>
        public double CalculateConditional(double x, double y, int mode)
        {
            double fx;
            if (mode == 1) fx = Math.Sinh(x);
            else if (mode == 2) fx = Math.Pow(x, 2);
            else fx = Math.Exp(x);

            if (x > y) return Math.Pow(fx - y, 3) + Math.Atan(fx);
            else if (y > x) return Math.Pow(y - fx, 3) + Math.Atan(fx);
            else return Math.Pow(y + fx, 3) + 0.5;
        }

        /// <summary>
        /// Вычисляет значение функции для табулирования (Page3).
        /// </summary>
        /// <param name="x">Аргумент x.</param>
        /// <param name="b">Параметр b.</param>
        /// <returns>Значение y.</returns>
        public double CalculateTabulation(double x, double b)
        {
            if (x < 0) throw new ArgumentOutOfRangeException("x", "x must be >= 0 for Pow(x, 2.5)");
            return (Math.Pow(x, 2.5) - b) * Math.Log(x * x + 12.7);
        }
    }

    public class BankDBEntities { }
}