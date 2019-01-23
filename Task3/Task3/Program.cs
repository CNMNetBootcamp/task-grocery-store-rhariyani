using System;

namespace Task3
{
    class Program
    {


        static void Main(string[] args)
        {
           
            double totalAmtpaid = 0.0;
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

                runingtotal += bottles; // storing userinput value bottles to runingtotal

                weeklytotal = bottles * 7;// weeklytotal shows total no of bottles into 7 to show 7days total of bottle collection
                Console.WriteLine("The total of bottle is per week is:" + weeklytotal);
                Console.ReadLine();

                totalAmtpaid = weeklytotal  * price;// this shows total bottles collect through week into price show amt paid for week 
                Console.WriteLine("The total amt paid is:" + totalAmtpaid);
                Console.ReadLine();
            }
            
                
                



               

        }
    }



        }



    



