using System;
using System.Collections.Generic;
using System.Globalization;

namespace Task3
{

    class program
    {
        static void Main(string[] args)
        {

            double totalAmtpaid = 0.0;
            const double price = 0.10;
            double bottles = 0.0;
            int weekly = 0;
            string question = "Y";
            double totalbottles = 0.0;
            int day = 0;
            DateTime dob = new DateTime(2002, 10, 22);




            do
            {

                do
                {
                    // Program throws an exception when I run it. Please fix this. 
                    Console.WriteLine("Please enter no of bottles receivied today:");
                    bottles = double.Parse(Console.ReadLine());
                    day = day + 1;
                    Console.WriteLine("This is day " + day);


                    //DateTime emptyDateTime = new DateTime();
                    Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);

                    weekly++;
                    totalbottles = totalbottles + bottles;
                    Console.WriteLine("total no of bottles collected " + totalbottles);




                } while (weekly < 7);
                {


                    totalAmtpaid = totalbottles * price;// this shows total bottles collect through week into price show amt paid for week 
                    Console.WriteLine("The total amt paid is:" + totalAmtpaid);
                    Console.ReadLine();
                }

                Console.WriteLine("Would you like to continue? (Y/N)");
                question = Console.ReadLine();
            } while (question == "Y");




        }

    }
}









    //TODO: Make sure you are formatting correctly







