using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int[] inputNumbers;

            inputNumbers = GetNumberArray();
            try
            {
                AreSorted(inputNumbers);
                PrintArray(inputNumbers);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static void PrintArray(int[] inputNumbers)
        {
            Console.Write("1 < ");
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.Write("{0} < ", inputNumbers[i]);
            }
            if (inputNumbers[inputNumbers.Length-1] != 100)
            {
                Console.Write("100");
            }

        }

        private static void AreSorted(int[] inputNumbers)
        {
            for (int i = 0; i < inputNumbers.Length - 2; i++)
            {
                if (!(inputNumbers[i] < inputNumbers[i + 1]))
                {
                    throw new Exception("inputs are not sorted correctly");
                }
                if (inputNumbers[i] <= 1 || inputNumbers[i] >= 100)
                {
                    throw new IndexOutOfRangeException("input out of range");
                }
            }

        }
        private static int[] GetNumberArray()
        {
            int[] input = new int[10];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}
