using System;

namespace TestFlight
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Flight flight1 = new Flight();
            Flight flight2 = new Flight();

            flight1.AirlineName = "British Ariways";
            flight1.FlightNumber = 604;
            flight1.Row = 5;
            flight1.Seat = 'D';

            flight2.AirlineName = "EasyJet";
            flight2.FlightNumber = 704;
            flight2.Row = 1;
            flight2.Seat = 'A';

            Console.WriteLine("Flight 1:");
            Console.WriteLine("Flight {0} number {1}", flight1.AirlineName, flight1.FlightNumber);
            Console.WriteLine("Your seat is {0}{1}", flight1.Row, flight1.Seat);

            Console.WriteLine("Flight 2:");
            Console.WriteLine("Flight {0} number {1}", flight2.AirlineName, flight2.FlightNumber);
            Console.WriteLine("Your seat is {0}{1}", flight2.Row, flight2.Seat);
        }
    }

    public class Flight
    {
        private string _airlineName;
        public string AirlineName
        {
            get { return _airlineName; }
            set { _airlineName = value; }
        }

        private int _flightNumber;
        public int FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; }
        }

        private int _row;
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        private char _seat;
        public char Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
    }
}
