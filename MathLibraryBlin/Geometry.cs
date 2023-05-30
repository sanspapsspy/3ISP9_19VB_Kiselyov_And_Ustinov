using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryBlin
{
    public class Geometry
    {
        // Площадь треугольника
        public static double AreaOfTriangle(double a, double h)
        {
            double S = 0.5 * a * h;
            return S;
        }

        // Площадь прямоугольного треугольника
        public static double AreaOfRighrTriangle(double q, double h)
        {
            double S = q * h / 2;
            return S;
        }

        // Площадь прямоугольника
        public static double AreaOfRectangle(double q, double h)
        {
            double S = q * h;
            return S;
        }

        // Площадь круга
        public static double AreaOfCircle(double r)
        {
            double S = r * r * Math.PI;
            return S;
        }

        // Площадь трапеции
        public static double AreaOfTrapezoid(double w , double a ,double h)
        {
            double S = 0.5 * (w + a) * h;
            return S;
        }
    } 
}
