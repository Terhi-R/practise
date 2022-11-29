using System;

namespace snallWeeks_lab_firstDotNetApp
{
    class Program
    {

        private static string greet(string namePassedIn)
        {
            return
            "Welcome to SALT, " + namePassedIn;
        }
        private static string courseDays(string startPassedIn)
        {

            DateTime date = DateTime.Now;
            var month = date.Month;
            var year = date.Year;
            var day = date.Day;

            var daysInMonth = System.DateTime.DaysInMonth(year, month);
            var daysNextMonth = System.DateTime.DaysInMonth(year, (month + 1));

            var thisMonth = daysInMonth - day;
            var JanMonth = "";

            if (int.Parse(startPassedIn.Substring(0, 1)) == 0)
            {
                JanMonth += startPassedIn.Substring(1, 1);
            }
            else
            {
                JanMonth += startPassedIn.Substring(0, 2);
            };

            var daysLeft = thisMonth + daysNextMonth + (int.Parse(JanMonth));

            return
            "Today it is " + daysLeft + " days left until the course starts";
        }

        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("When does the course start? ");
            var start = Console.ReadLine();

            var greeting = greet(name);
            var courseStart = courseDays(start);

            Console.WriteLine(greeting);
            Console.WriteLine(courseStart);

        }
    }
}
