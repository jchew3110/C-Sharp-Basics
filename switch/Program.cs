using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Input a number between 0 and 6: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(GetDay(num));
            Console.ReadLine();

        }
        static string GetDay(int dayNum) {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
