using System;

namespace IsCircularSentence
{
    class Program
    {
        public bool FindCircularSentence(string sentence)
        {
            string[] splittedSentence = sentence.Split(' ');

            if (splittedSentence[0][0] != splittedSentence[splittedSentence.Length - 1][splittedSentence[splittedSentence.Length - 1].Length - 1])
                return false;

            for (int i = 0; i < splittedSentence.Length - 1; i++)
            {
                if (splittedSentence[i][splittedSentence[i].Length - 1] != splittedSentence[i + 1][0])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            string sentence = "Leetcode is cool";
            string sentence1 = "eetcode";
            string sentence2 = "leetcode exercises sound delightful";

            Console.WriteLine(program.FindCircularSentence(sentence));
            Console.WriteLine(program.FindCircularSentence(sentence1));
            Console.WriteLine(program.FindCircularSentence(sentence2));
            Console.ReadKey();
        }
    }
}
