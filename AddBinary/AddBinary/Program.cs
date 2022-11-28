using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AddBinary
{
    class Program
    {
        public string BinaryAddition(string a, string b)
        {
            //BigInteger intA = Convert.ToInt32(a, 2);
            //BigInteger intB = Convert.ToInt32(b, 2);

            //return Convert.ToString((byte)(intA + intB), 2);


            BigInteger intA = int.Parse(a);
            BigInteger intB = int.Parse(b);
            BigInteger rem = 0;
            List<BigInteger> sum = new List<BigInteger>();
            StringBuilder ans = new StringBuilder();

            if (a == "0" && b == "0")
                return "0";

            while (intA != 0 || intB != 0)
            {
                sum.Add((intA % 10 + intB % 10 + rem) % 2);

                rem = (intA % 10 + intB % 10 + rem) / 2;

                intA /= 10;
                intB /= 10;
            }

            if (rem != 0)
                sum.Add(rem);

            for (int j = sum.Count - 1; j >= 0; j--)
            {
                ans.Append(sum[j]);
            }

            return ans.ToString();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string a = "1110001";
            string b = "110100100";

            Console.WriteLine(program.BinaryAddition(a, b));
            Console.ReadKey();
        }
    }
}
