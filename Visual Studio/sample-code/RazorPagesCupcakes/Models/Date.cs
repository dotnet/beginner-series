using System.Drawing.Printing;

namespace RazorPagesCupcakes.Models
{
    public class Date
    {
        public void PrintDays()
        {
            string longMessage = """
               This is a long message.
               It has several lines.
                   Some are indented
                           more than others.
               Some should start at the first column.
               Some have "quoted text" in them.
             """;
            Console.WriteLine(GetDay(1));
            Console.WriteLine(longMessage);
        }

        static string GetDay(int dayNum)
        {
            string dayName = dayNum switch // Convert to switch expression
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednsday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saterday",
                7 => "Sunday",
                _ => "Invalid day number",
            };
            return dayName;
        }
    }
}