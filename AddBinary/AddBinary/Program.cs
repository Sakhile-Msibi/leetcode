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
            StringBuilder ans = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            int curr = 0;
            int sum = 0;

            for (int i = a.Length - 1, j = b.Length -1; i >= 0 || j >= 0; i--, j--)
            {
                sum = curr;

                if (i >= 0)
                    sum += a[i] - 48;

                if (j >= 0)
                    sum += b[j] - 48;

                ans.Append(sum % 2);
                curr = sum / 2;
            }

            if (curr != 0)
                ans.Append(curr);

            
            for (int i = ans.Length - 1; i >= 0; i--)
            {
                sb.Append(ans[i]);
            }

            return sb.ToString();

            //BigInteger intA = Convert.ToInt32(a, 2);
            //BigInteger intB = Convert.ToInt32(b, 2);

            //return Convert.ToString((byte)(intA + intB), 2);


            //BigInteger intA = int.Parse(a);
            //BigInteger intB = int.Parse(b);
            //BigInteger rem = 0;
            //List<BigInteger> sum = new List<BigInteger>();
            //StringBuilder ans = new StringBuilder();

            //if (a == "0" && b == "0")
            //    return "0";

            //while (intA != 0 || intB != 0)
            //{
            //    sum.Add((intA % 10 + intB % 10 + rem) % 2);

            //    rem = (intA % 10 + intB % 10 + rem) / 2;

            //    intA /= 10;
            //    intB /= 10;
            //}

            //if (rem != 0)
            //    sum.Add(rem);

            //for (int j = sum.Count - 1; j >= 0; j--)
            //{
            //    ans.Append(sum[j]);
            //}

            //return ans.ToString();
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
