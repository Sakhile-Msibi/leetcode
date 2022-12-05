using System;

namespace ConvertTemperature
{
    class Program
    {
        public double[] TemperatureConvertion(double Celsius)
        {
            double[] ans = { Celsius + 273.15, Celsius * 1.80 + 32.00 };

            return ans;
        }

        public void PrintArray(double[] ans)
        {
            foreach (double val in ans)
                Console.Write(val + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            double Celsius = 36.50;
            double Celsius1 = 122.11;

            program.PrintArray(program.TemperatureConvertion(Celsius));
            program.PrintArray(program.TemperatureConvertion(Celsius1));
            Console.ReadKey();
        }
    }
}
