using System;

namespace VariablesInputConversionFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastName;
            double gpa;

            Console.WriteLine("please enter your first name >>");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();
            Console.WriteLine("please enter your GPA >>");
                string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; // idk why but we wabt to bump up everyones GPA by .5

            string output = "Hello " + firstname + " " + "! " +
                    " we boosted your gpa to " + gpa.ToString("N3");

            Console.WriteLine(output);
        }
    }
}
