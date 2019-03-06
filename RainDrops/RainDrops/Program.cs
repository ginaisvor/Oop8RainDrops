using System;

namespace RainDrops
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number you want me to transform: ");
            string input = Console.ReadLine();
            int number = 1;
            if (int.TryParse(input, out number))
            {
                number = int.Parse(input);
                string converted = PlingPlangPlong(number);
                Console.WriteLine(converted);
            }
            else
            {
                Console.WriteLine("Invalid input. It must be a number.We'll play like this untill you enter a valid number.");
                do
                {
                    input = Console.ReadLine();
                }
                while (!int.TryParse(input, out number));
                number = int.Parse(input);
                string converted = PlingPlangPlong(number);
                Console.WriteLine(converted);
            }
        }

        public static string PlingPlangPlong(int number)
        {
            string rez = "";
            if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                rez = number.ToString();
            }
            if (number % 3 == 0)
            {
                rez += "Pling";
            }
            if (number % 5 == 0)
            {
                rez += "Plang";
            }
            if (number % 7 == 0)
            {
                rez += "Plong";
            }
            return rez;
        }
    }
}
