using System;

namespace RomanToInt
{
    class Program
    {
        public int RomanNumberToInt(string s)
        {
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //I
                if (s.Length >= 2 && i != s.Length - 1 && s[i] == 'I' && s[i + 1] == 'V')
                {
                    sum += 4;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (s.Length >= 2 && i != s.Length - 1 &&  s[i] == 'I' && s[i + 1] == 'X')
                {
                    sum += 9;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (s[i] == 'I')
                {
                    for (int j = i; j < s.Length && s[j] == 'I'; j++)
                    {
                        counter++;
                    }

                    sum += counter;
                    i += (counter - 1);

                    if (i == s.Length - 1)
                        break;

                    counter = 0;
                }

                //V
                if (i != 0 && s[i] == 'V' && s[i - 1] != 'I')
                    sum += 5;
                else if (i == 0 && s[i] == 'V')
                    sum += 5;

                //X
                if (s.Length >= 2 && i != s.Length - 1 && s[i] == 'X' && s[i + 1] == 'L')
                {
                    sum += 40;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (s.Length >= 2 && i != s.Length - 1 && s[i] == 'X' && s[i + 1] == 'C')
                {
                    sum += 90;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (i != 0 && s[i] == 'X' && s[i - 1] != 'I')
                {
                    for (int j = i; j < s.Length && s[j] == 'X'; j++)
                    {
                        counter++;
                    }

                    sum += (counter * 10);
                    i += (counter - 1);

                    if (i == s.Length - 1)
                        break;

                    counter = 0;
                }
                else if (i == 0 && s[i] == 'X')
                {
                    for (int j = i; j < s.Length && s[j] == 'X'; j++)
                    {
                        counter++;
                    }

                    sum += (counter * 10);
                    i += (counter - 1);

                    if (i == s.Length - 1)
                        break;

                    counter = 0;
                }

                //L
                if (i != 0 && s[i] == 'L' && s[i - 1] != 'X')
                    sum += 50;
                else if (i == 0 && s[i] == 'L')
                    sum += 50;


                //C
                if (s.Length >= 2 && i != s.Length - 1 && s[i] == 'C' && s[i + 1] == 'D')
                {
                    sum += 400;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (s.Length >= 2 && i != s.Length - 1 && s[i] == 'C' && s[i + 1] == 'M')
                {
                    sum += 900;
                    i++;

                    if (i == s.Length - 1)
                        break;
                }
                else if (i != 0 && s[i] == 'C' && s[i - 1] != 'X')
                {
                    for (int j = i; j < s.Length && s[j] == 'C'; j++)
                    {
                        counter++;
                    }

                    sum += (counter * 100);
                    i += (counter - 1);

                    if (i == s.Length - 1)
                        break;

                    counter = 0;
                }
                else if (i == 0 && s[i] == 'C')
                {
                    for (int j = i; j < s.Length && s[j] == 'C'; j++)
                    {
                        counter++;
                    }

                    sum += (counter * 100);
                    i += (counter - 1);

                    if (i == s.Length - 1)
                        break;

                    counter = 0;
                }

                //D
                if (i != 0 && s[i] == 'D' && s[i - 1] != 'C')
                    sum += 500;
                else if (i == 0 && s[i] == 'D')
                    sum += 500;

                //M
                if (i != 0 && s[i] == 'M' && s[i - 1] != 'C')
                    sum += 1000;
                else if (i == 0 && s[i] == 'M')
                    sum += 1000;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "III";
            string s1 = "LVIII";
            string s2 = "MCMXCIV";
            string s3 = "IX";
            string s4 = "DCXXI";
            string s5 = "MMMCC";

            //Console.WriteLine(program.RomanNumberToInt(s));
            //Console.WriteLine(program.RomanNumberToInt(s1));
            //Console.WriteLine(program.RomanNumberToInt(s2));
            //Console.WriteLine(program.RomanNumberToInt(s3));
            //Console.WriteLine(program.RomanNumberToInt(s4));
            Console.WriteLine(program.RomanNumberToInt(s5));
            Console.ReadKey();
        }
    }
}
