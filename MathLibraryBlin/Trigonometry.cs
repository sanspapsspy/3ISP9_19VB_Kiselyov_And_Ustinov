using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryBlin
{
    public class Trigonometry
    {
        // Синус угла
        public static double SinugAngle(double a, double b, double c)
        {
            double SinA = a / c;
            return SinA;
        }

        // Косинус угла
        public static double CosineOfAnAngle(double a, double b, double c)
        {
            double CosA = b / c;
            return CosA;
        }

        // Тангенс угла
        public static double AngleTangent(double a, double b, double c)
        {
            double TngA = a / c;
            return TngA;
        }


        // Котангенс угла
        public static double AngleCotangent(double a, double b, double c)
        {
            double CtgA = c / a;
            return CtgA;
        }

        // Арксинус угла
        public static double Arcsine(double a)
        {
            double ArsA = Math.Asin(a);
            return ArsA;
        }
    }
}
