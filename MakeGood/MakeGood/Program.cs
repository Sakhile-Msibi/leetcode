using System;

namespace MakeGood
{
    class Program
    {
        public string makeGood(string s)
        {
            if (s.Length == 1)
                return s;


            char[] sChars = s.ToCharArray();
            string str = "";

            for (int i = 0; i < sChars.Length - 1; i++)
            {
                if (sChars[i] == sChars[i + 1] - 32)
                {
                    sChars[i] = ' ';
                    sChars[i + 1] = ' ';

                    str = "";
                    for (int j = 0; j < sChars.Length; j++)
                    {
                        if (sChars[j] != ' ')
                            str += sChars[j];
                    }

                    sChars = str.ToCharArray();

                    if (i != 0)
                        i -= 2;
                    else
                        i--;
                }

                if (i >= 0)
                {
                    if (sChars[i] - 32 == sChars[i + 1])
                    {
                        sChars[i] = ' ';
                        sChars[i + 1] = ' ';

                        str = "";
                        for (int j = 0; j < sChars.Length; j++)
                        {
                            if (sChars[j] != ' ')
                                str += sChars[j];
                        }

                        sChars = str.ToCharArray();

                        if (i != 0)
                            i -= 2;
                        else
                            i--;
                    }
                }
            }

            str = "";
            for (int i = 0; i < sChars.Length; i++)
            {
                if (sChars[i] != ' ')
                    str += sChars[i];
            }

            return str;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            
            string s = "leEeetCcode";
            string s1 = "abBAcC";
            string s2 = "s";
            string s3 = "Pp";
            string s4 = "RLlr";

            Console.WriteLine(program.makeGood(s4));
            Console.WriteLine(program.makeGood(s3));
            Console.WriteLine(program.makeGood(s1));
        }
    }
}
