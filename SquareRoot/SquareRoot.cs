using System;


namespace SquareRoot
{
    class SquareRoot
    {
        static double NumberParse(string input)
        {
            double result;
            result = double.Parse(input);
            return result;
        }
        static double GetRoot(double input)
        {
            double result;
            result = Math.Sqrt(input);
            if (result.ToString() == "NaN")
            {
                throw new Exception ("resultNaN");
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                double number = NumberParse(input);
                double result = GetRoot(number);
                Console.WriteLine("{0:F3}", result);
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
