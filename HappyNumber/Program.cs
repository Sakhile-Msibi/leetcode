namespace HappyNumber
{
    internal class Program
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
                
            do
            { 

                double sum = 0;
                string num = n.ToString();
                char[] chars = num.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    sum += Math.Pow((chars[i] - 48), 2);
                }

                if (set.Contains((int)sum))
                {
                    return false;
                }
                set.Add((int)sum);

                if ((int)sum == 1)
                {
                    return true;
                }

                n = (int)sum;
            } while (true);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int n = 1;
            int n1 = 2;

            Console.WriteLine(program.IsHappy(n));
            Console.WriteLine(program.IsHappy(n1));
        }
    }
}