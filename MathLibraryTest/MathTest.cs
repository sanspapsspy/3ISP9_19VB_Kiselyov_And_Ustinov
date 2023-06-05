using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathLibraryBlin;


namespace MathLibraryTest
{
    [TestClass]
    public class MathTest
    {
        // ТРИГОНОМЕТРИЯ
        //SinugAngle
        [TestMethod]
        public void SinugAngleTesta20b10c5sinA4()
        {
            // arrange
            double a = 20;
            double b = 10;
            double c = 5;
            double SinA = 4;

            // act
            double res = Trigonometry.SinugAngle(a, b, c);

            // assert
            Assert.AreEqual(SinA, res);
        }
        [TestMethod]
        public void SinugAngleTesta25b10c5sinA5()
        {
            // arrange
            double a = 25;
            double b = 10;
            double c = 5;
            double SinA = 5;

            // act
            double res = Trigonometry.SinugAngle(a, b, c);

            // assert
            Assert.AreEqual(SinA, res);
        }
        [TestMethod]
        public void SinugAngleTesta30b10c5sinA6()
        {
            // arrange
            double a = 30;
            double b = 10;
            double c = 5;
            double SinA = 6;

            // act
            double res = Trigonometry.SinugAngle(a, b, c);

            // assert
            Assert.AreEqual(SinA, res);
        }
        //CosineOfAnAngle
        [TestMethod]
        public void CosineOfAnAnglea25b10c5CosA2()
        {
            // arrange
            double a = 25;
            double b = 10;
            double c = 5;
            double CosA = 2;

            // act
            double res = Trigonometry.CosineOfAnAngle(a, b, c);

            // assert
            Assert.AreEqual(CosA, res);
        }
        [TestMethod]
        public void CosineOfAnAnglea25b20c5CosA4()
        {
            // arrange
            double a = 25;
            double b = 20;
            double c = 5;
            double CosA = 4;

            // act
            double res = Trigonometry.CosineOfAnAngle(a, b, c);

            // assert
            Assert.AreEqual(CosA, res);
        }
        [TestMethod]
        public void CosineOfAnAnglea30b20c5CosA6()
        {
            // arrange
            double a = 25;
            double b = 30;
            double c = 5;
            double CosA = 6;

            // act
            double res = Trigonometry.CosineOfAnAngle(a, b, c);

            // assert
            Assert.AreEqual(CosA, res);
        }

        //AngleTangent
        [TestMethod]
        public void AngleTangent25b20c5CosA5()
        {
            // arrange
            double a = 25;
            double b = 30;
            double c = 5;
            double TngA = 5;

            // act
            double res = Trigonometry.AngleTangent(a, b, c);

            // assert
            Assert.AreEqual(TngA, res);
        }
        [TestMethod]
        public void AngleTangent20b20c5CosA4()
        {
            // arrange
            double a = 20;
            double b = 30;
            double c = 5;
            double TngA = 4;

            // act
            double res = Trigonometry.AngleTangent(a, b, c);

            // assert
            Assert.AreEqual(TngA, res);
        }
        [TestMethod]
        public void AngleTangent30b20c5CosA6()
        {
            // arrange
            double a = 30;
            double b = 30;
            double c = 5;
            double TngA = 6;

            // act
            double res = Trigonometry.AngleTangent(a, b, c);

            // assert
            Assert.AreEqual(TngA, res);
        }
        [TestMethod]
        //AngleCotangent
        public void AngleCotangent5b20c10CtgA6()
        {
            // arrange
            double a = 5;
            double b = 30;
            double c = 10;
            double CtgA = 2;

            // act
            double res = Trigonometry.AngleCotangent(a, b, c);

            // assert
            Assert.AreEqual(CtgA, res);
        }
        [TestMethod]
        public void AngleCotangent5b30c15CtgA3()
        {
            // arrange
            double a = 5;
            double b = 30;
            double c = 15;
            double CtgA = 3;

            // act
            double res = Trigonometry.AngleCotangent(a, b, c);

            // assert
            Assert.AreEqual(CtgA, res);
        }
        [TestMethod]
        public void AngleCotangenta5b20c20CtgA6()
        {
            // arrange
            double a = 5;
            double b = 30;
            double c = 20;
            double CtgA = 4;

            // act
            double res = Trigonometry.AngleCotangent(a, b, c);

            // assert
            Assert.AreEqual(CtgA, res);
        }
        //Arcsine
        [TestMethod]
        public void Arcsine0CtgA()
        {
            // arrange
            double a = 0;
            double ArsA = 0;

            // act
            double res = Trigonometry.Arcsine(a);

            // assert
            Assert.AreEqual(ArsA, res);
        }
        [TestMethod]
        public void Arcsine1CtgA()
        {
            // arrange
            double a = 0.75;
            double ArsA = 0.848062078981481;

            // act
            double res = Trigonometry.Arcsine(a);

            // assert
            Assert.AreEqual(ArsA, res);
        }
        [TestMethod]
        public void Arcsine0_7CtgA()
        {
            // arrange
            double a = 0.7;
            double ArsA = 0.775397496610753;

            // act
            double res = Trigonometry.Arcsine(a);

            // assert
            Assert.AreEqual(ArsA, res);
        }

        // ГЕОМЕТРИЯ
        [TestMethod]
        public void AreaOfTrianglea2h3S3()
        {
            // arrange
            double a = 2;
            double h = 3;
            double S = 3;

            // act
            double res = Geometry.AreaOfTriangle(a,h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfTriangleda6h5S15()
        {
            // arrange
            double a = 6;
            double h = 5;
            double S = 15;

            // act
            double res = Geometry.AreaOfTriangle(a,h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfTrianglea6h5S15()
        {
            // arrange
            double a = 6;
            double h = 5;
            double S = 15;

            // act
            double res = Geometry.AreaOfTriangle(a,h);

            // assert
            Assert.AreEqual(S, res);
        }

        //AreaOfRighrTriangle
        [TestMethod]
        public void AreaOfRighrTriangleq6h5S15()
        {
            // arrange
            double q = 6;
            double h = 5;
            double S = 15;

            // act
            double res = Geometry.AreaOfRighrTriangle(q, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfRighrTriangleq5h6S15()
        {
            // arrange
            double q = 5;
            double h = 6;
            double S = 15;

            // act
            double res = Geometry.AreaOfRighrTriangle(q, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfRighrTriangleq2h3S2()
        {
            // arrange
            double q = 2;
            double h = 3;
            double S = 3;

            // act
            double res = Geometry.AreaOfRighrTriangle(q, h);

            // assert
            Assert.AreEqual(S, res);
        }
        //AreaOfRectangle
        [TestMethod]
        public void AreaOfRectangleq2h3S6()
        {
            // arrange
            double q = 2;
            double h = 3;
            double S = 6;

            // act
            double res = Geometry.AreaOfRectangle(q, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfRectangleq3h3S9()
        {
            // arrange
            double q = 3;
            double h = 3;
            double S = 9;

            // act
            double res = Geometry.AreaOfRectangle(q, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfRectangleq9h9S81()
        {
            // arrange
            double q = 9; 
            double h = 9;
            double S = 81;

            // act
            double res = Geometry.AreaOfRectangle(q,h);

            // assert
            Assert.AreEqual(S, res);
        }
        //AreaOfCircle
        [TestMethod]
        public void AreaOfCircleq1S()
        {
            // arrange
            double q = 1;
            double S = 3.141592653589793;

            // act
            double res = Geometry.AreaOfCircle(q);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfCircleq0()
        {
            // arrange
            double q = 0;
            double S = 0;

            // act
            double res = Geometry.AreaOfCircle(q);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfCircleq2()
        {
            // arrange
            double q = 2;
            double S = 12.566370614359172;

            // act
            double res = Geometry.AreaOfCircle(q);

            // assert
            Assert.AreEqual(S, res);
        }
        
        //AreaOfTrapezoid
        [TestMethod]
        public void AreaOfTrapezoidw2a2h2S4()
        {
            // arrange
            double w = 2;
            double a = 2;
            double h = 2;
                double S = 4;

            // act
            double res = Geometry.AreaOfTrapezoid(w,a,h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfTrapezoidw2a3h3S7_5()
        {
            // arrange
            double w = 2;
            double a = 3;
            double h = 3;
            double S = 7.5;

            // act
            double res = Geometry.AreaOfTrapezoid(w, a, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void AreaOfTrapezoidq4a4h4S16()
        {
            // arrange
            double w = 4;
            double a = 4;
            double h = 4;
            double S = 16;

            // act
            double res = Geometry.AreaOfTrapezoid(w, a, h);

            // assert
            Assert.AreEqual(S, res);
        }


        //ALGEBRA
        //LinearEquation
        [TestMethod]
        public void LinearEquation()
        {
            // arrange
            double w = 4;
            double a = 4;
            double h = 4;
            double S = 0;

            // act
            double res = Algebra.LinearEquation(w, a, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void LinearEquationw()
        {
            // arrange
            double w = 6;
            double a = 5;
            double h = 2;
            double S = -18;

            // act
            double res = Algebra.LinearEquation(w, a, h);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void LinearEquationa()
        {
            // arrange
            double w = 5;
            double a = 2;
            double h = 7;
            double S = 25;

            // act
            double res = Algebra.LinearEquation(w, a, h);

            // assert
            Assert.AreEqual(S, res);
        }

        //RowSum
        [TestMethod]
        public void RowSumS13()
        {
            // arrange
            double[] arr = { 1, 3, 4, 5 };
            double S = 13;

            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowSumS55()
        {
            // arrange
            double[] arr = { 1, 3, 4, 5 ,9,10,2,6,7,8};
            double S = 55;

            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowSumwS17()
        {
            // arrange
            double[] arr = { 1, 3, 4,4,5 };
            double S = 17;
            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }

        //RowAgg
        [TestMethod]
        public void RowAggS()
        {
            // arrange
            double[] arr = { 1, 3, 4 };
            double S = 8;
            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowAggS22()
        {
            // arrange
            double[] arr = { 1, 3, 4 ,10,1,1,2};
            double S = 22;
            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowAggS8()
        {
            // arrange
            double[] arr = { 1, 3, 4 };
            double S = 8;
            // act
            double res = Algebra.RowSum(arr);

            // assert
            Assert.AreEqual(S, res);
        }

        //RowMax
        [TestMethod]
        public void RowMaxS4()
        {
            // arrange
            double[] arr = { 1, 3, 4 };
            double S = 4;
            // act
            double res = Algebra.RowMax(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowMaxS300()
        {
            // arrange
            double[] arr = { 1, 3, 4,200,300 };
            double S = 300;
            // act
            double res = Algebra.RowMax(arr);

            // assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void RowMaxS6()
        {
            // arrange
            double[] arr = { 1, 3, 4 ,5,4,6};
            double S = 6;
            // act
            double res = Algebra.RowMax(arr);

            // assert
            Assert.AreEqual(S, res);
        }


        //QuadraticEquation
        [TestMethod]
        public void QuadraticEquation()
        {
            // arrange
            double a = 4;
            double b = 5;
            double c = 6;
            double S1 = 2;
            double S2 = 2;
            // act
            string res = Algebra.QuadraticEquation(a,b,c);

            // assert
            Assert.AreEqual(S1, S2, res);
        }
        [TestMethod]
        public void QuadraticEquationw()
        {
            // arrange
            double a = 4;
            double b = 6;
            double c = 3;
            double S1 = 0;
            double S2 = 0;
            // act
            string res = Algebra.QuadraticEquation(a, b, c);

            // assert
            Assert.AreEqual(S1,S2, res);
        }
        [TestMethod]
        public void QuadraticEquatione()
        {
            // arrange
            double a = 2;
            double b = 6;
            double c = 3;
            double S1 = -0.320550528229663;
            double S2 = -0.320550528229663;
            // act
            string res = Algebra.QuadraticEquation(a, b, c);

            // assert
            Assert.AreEqual(S1, S2, res);
        }
    }
}
