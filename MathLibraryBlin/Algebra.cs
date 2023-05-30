using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryBlin
{
    public class Algebra
    {
        // Корни квадратного уравнения
        public static string QuadraticEquation(double a, double b, double c)
        {
            if (a != 0)
            {
                double Disc = b*b - 4 * a * c;
                if (Disc < 0)
                {
                    string noCoren = "Нет корней";
                    return noCoren;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(Disc)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(Disc)) / (2 * a);
                    string res = "x1 = " + x1.ToString() + " x2 = " + x2.ToString();
                    return res;
                }
            }
            else
            {
                string noRes = "Это не квадратное уравнение";
                return noRes;
            }
        }

        // Корень линейного уравнения
        public static double LinearEquation(double a, double b, double c)
        {
            double x = c - b;
            x *= a;
            return x;
        }

        // Сумма массива
        public static double RowSum(double[] arr)
        {
            double resArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                resArr = resArr + arr[i];
            }
            return resArr;
        }

        // Среднее значение ряда
        public static double RowAgg(double[] arr)
        {
            double resArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                resArr = resArr + arr[i];
            }
            resArr = resArr / arr.Length;
            return resArr;
        }

        // Максимальное значение ряда
        public static double RowMax(double[] arr)
        {
            double res = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (res < arr[i])
                {
                    res = arr[i];
                }
            }
            return res;
        }
    }
}
