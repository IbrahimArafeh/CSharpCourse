using System;
using System.Collections.Generic;
using System.IO;

namespace Session2
{
    internal class Program
    {
        // method for reading number from a file
        static List<double> ReadNumberFromFile(string filename)
        {
            List<double> numbers = new List<double>();

            using (StreamReader times = File.OpenText(filename))
            {
                while (!times.EndOfStream)
                {
                    string line = times.ReadLine();
                    double lapEndTime = double.Parse(line);
                    numbers.Add(lapEndTime);
                }
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            List<double> nourInfo = ReadNumberFromFile("SampleText.txt");

            foreach(var item in nourInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            List<double> nourInfo1 = ReadNumberFromFile("SampleNour.txt");

            foreach (var item in nourInfo1)
            {
                Console.WriteLine(item);
            }

            //string[] lines = File.ReadAllLines("SampleText.txt");

            //double currentLapStartTime = 0; //0
            //double fastestLapTime = 0; //78.2
            //int lapNumber = 0; //0  1
            //int fastestLapNumber = 0; //0

            //foreach (var item in lines)
            //{
            //    double lapEndtime = double.Parse(item); // 78.2  157.2 
            //    double lapTime = lapEndtime - currentLapStartTime; //78.2  79

            //    if (fastestLapTime == 0 || lapTime < fastestLapTime)
            //    {
            //        fastestLapTime = lapTime; //78.2
            //        fastestLapNumber = lapNumber; //0
            //    }

            //    currentLapStartTime = lapEndtime; //78.2   157.2 
            //    lapNumber += 1; //1  2

            //}

            //Console.WriteLine("Fastest Lap Time is : " + fastestLapTime);
            //Console.WriteLine("Fastest Lap Number is  : " + fastestLapNumber);


            //for (int i =0; i<lines.Length; i++)
            //{
            //    double lapEndtime = double.Parse(lines[i]); // 78.2  157.2 

            //    double lapTime = lapEndtime - currentLapStartTime; //78.2  79

            //    if (fastestLapTime == 0 || lapTime < fastestLapTime)
            //    {
            //        fastestLapTime = lapTime; //78.2
            //        fastestLapNumber = lapNumber; //0
            //    }

            //    currentLapStartTime = lapEndtime; //78.2   157.2 
            //    lapNumber += 1; //1  2

            //}


            //Console.WriteLine("Fastest Lap Time is : " + fastestLapTime);
            //Console.WriteLine("Fastest Lap Number is  : " + fastestLapNumber);




            //using (StreamReader times = File.OpenText("SampleText.txt"))
            //{
            //    while(!times.EndOfStream)
            //    {
            //        string line = times.ReadLine();
            //        double lapEndTime = double.Parse(line);
            //        Console.WriteLine(lapEndTime);
            //    }
            //}

            //using (StreamReader times = File.OpenText("SampleText.txt"))
            //{
            //    while (!times.EndOfStream)
            //    {
            //        string line = times.ReadLine();
            //        if(line == "STOP!")
            //        {
            //            break;
            //        }
            //        double lapEndTime = double.Parse(line);
            //        Console.WriteLine(lapEndTime);
            //    }
            //}



        }
    }
}
