using System;

namespace Task3
{
    class Program
    {


        static void Main(string[] args)
        {
           //TODO: For longer variable names make sure to use camelcase. example totalAmtPaid
           //TODO: Please comment out each piece of logic so I can see the program flow
            double totalamtpaid = 0.0;
            const double price = 0.10;
            double bottles = 0.0;
            double runingtotal = 0.0;
            int weekly = 0;
            double weeklytotal = 0.0;
            do
            {

                Console.WriteLine("Please enter no of bottles receivied today:");
                bottles = double.Parse(Console.ReadLine());
                weekly++;

                
                   

            } while (weekly<7);
            {

                runingtotal += bottles;
                weeklytotal = bottles * 7;
                Console.WriteLine("The total of bottle is per week is:" + weeklytotal);
                Console.ReadLine();
                totalamtpaid = weeklytotal  * price;
                Console.WriteLine("The total amt paid is:" + totalamtpaid);
                Console.ReadLine();
            }
            
                
                



               

        }
    }


    //TODO: Make sure you are formatting correctly
        }



    



