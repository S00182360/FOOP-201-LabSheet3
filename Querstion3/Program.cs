using System;

namespace Querstion3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double sideLength = 0;
            DemoSquares[] SquareArray = new DemoSquares[10];
            //double area = 0;

            for (int i = 0; i < SquareArray.Length; i++)
            {
                sideLength = i + 1;
                SquareArray[i] = new DemoSquares(sideLength);
                //SquareArray[i].Area = sideLength;
                Console.WriteLine("The area of a square with length {0}M is {1}m^2", SquareArray[i].Length, SquareArray[i].Area);
            }
            //SquareArray[0].Area = sideLength;



        }
    }

    public class DemoSquares
    {
        public DemoSquares(double length)
        {
            Length = length;
        }

        public double Length { get; }

        private double _area;
        public double Area
        {
            get {
                _area = Length*Length;
                return _area; }
            set { _area = value; }

        }

        //private double AreaCalc(double length)
        //{
        //    Area = length * length;
        //    return Area;
        //}

        //private double _perimiter;
        //public double Perimiter
        //{
            //get { return _perimiter; }
            //set { _perimiter = value * 4; }
        //}



    }
}
