using System;

namespace Session3
{
    class Plan
    {

        // Constructor
        public Plan(string _identifier)
        {
            _identifier = identifier;
        }

        public string identifier
        {
            get;
            set;
        }

        public double SpeedInMilesPerHour
        {
            get;
            set;
        }

        double KilometersPerMile = 1.609;
        // convert from Mile to Kilo meters
        public double SpeedInKeloMetersPerHour
        {
            get
            {
                return SpeedInMilesPerHour * KilometersPerMile;
            }
            set
            {
                SpeedInMilesPerHour = value / KilometersPerMile;
            }
        }

        public const int approche = 0;
        public const int leaving = 1;

        public int Directive { get; set; }

        public enum NType
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plan.NType a = Plan.NType.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Plan.NType)0;
            Console.WriteLine(b);  // output: Summer

            var c = (Plan.NType)4;
            Console.WriteLine(c);  // output: 4

            Plan boing320 = new Plan("Boing320"); /// Object From class


            Plan AirBus430 = new Plan("AirBus430");


            boing320.identifier ="Boing 320"; // add attribute value to class attributes
            AirBus430.identifier = "AirBus430"; // add attribute value to class attributes

            boing320.SpeedInMilesPerHour = 320.2;
            AirBus430.SpeedInKeloMetersPerHour = 200;



        //Console.WriteLine("The Plan Name is: {0}, with Speed in Miles: {1} and Speed in Kilo Meters: {2} ",
        //    boing320.identifier, boing320.SpeedInMilesPerHour,
        //    boing320.SpeedInKeloMetersPerHour);

            //Console.WriteLine("The Plan Name is: {0}, with Speed in Miles: {1} and Speed in Kilo Meters: {2} ",
            //    AirBus430.identifier, AirBus430.SpeedInMilesPerHour,
            //    AirBus430.SpeedInKeloMetersPerHour);

        }
    }
}
