using System.ComponentModel.Design;

namespace _01.DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                Console.WriteLine(days[dayOfWeek-1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
