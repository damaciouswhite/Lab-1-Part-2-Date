using System;

namespace Lab1Part2_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Difference Between Dates");//This is the title of the code

            Console.WriteLine("Please Enter a Date (e.g. 10/22/1987)");//Asking the user to enter an date




            DateTime inputtedDate1 = DateTime.Parse(Console.ReadLine());//Allowing the user to input a date

            Console.WriteLine("Please Enter another Date (e.g. 10/22/1987)");//Asking the user to enter another date
            DateTime inputtedDate2 = DateTime.Parse(Console.ReadLine());//Allowing the user to enter another date


            TimeSpan ts = inputtedDate2 - inputtedDate1;//Subtracting the difference between the two dates

            int differenceInDays = ts.Days; //Getting the answer in days 
         
            int differenceInHours = ts.Hours;//Getting the answer in hours 

            int differenceInMinutes = ts.Minutes;//Getting the answer in minutes

            Console.WriteLine("days" + differenceInDays);//Writing out the answer in days from the above formula

            Console.WriteLine("hours" + differenceInHours);//Writing out the answer in hours from the above formula

            Console.WriteLine("minutes" + differenceInMinutes);//Wring out the answer in minutes from the above formula

        }
    }
}
