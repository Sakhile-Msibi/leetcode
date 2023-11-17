using System.Collections;

namespace ValidParentheses
{
    internal class Program
    {
        public bool IsValid(string s)
        {
            if (s.Length == 1 || s.Length % 2 != 0)
            {
                return false;
            }

            

                char[] chars = new char[s.Length];
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] == ')' || s[0] == ']' || s[0] == '}')
                {
                    return false;
                }
                if (s[s.Length - 1] == '(' || s[s.Length - 1] == '[' || s[s.Length - 1] == '{')
                {
                    return false;
                }

                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    chars[counter++] = s[i];
                    continue;
                }
                
                if (s[i] == ')' && chars[counter - 1] != '(')
                {
                    return false;
                }
                
                if (s[i] == ']' && chars[counter - 1] != '[')
                {
                    return false;
                }

                if (s[i] == '}' && chars[counter - 1] != '{')
                {
                    return false;
                }

                s = s.Remove(i, 1);
                s = s.Remove(i - 1, 1);
                chars[counter - 1] = '\0';
                i -= 2;
                counter--;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != '\0')
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string s = "()";
            Console.WriteLine(program.IsValid(s));

            string s1 = "()[]{}";
            Console.WriteLine(program.IsValid(s1));

            string s2 = "(]";
            Console.WriteLine(program.IsValid(s2));

            string s3 = "({[]()})";
            Console.WriteLine(program.IsValid(s3));

            string s4 = "((";
            Console.WriteLine(program.IsValid(s4));

            string s5 = "){";
            Console.WriteLine(program.IsValid(s5));

            string s6 = "()))";
            Console.WriteLine(program.IsValid(s6));

            Console.ReadKey();
        }
    }
}