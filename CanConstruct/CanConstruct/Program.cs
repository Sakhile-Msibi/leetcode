using System;

namespace CanConstruct
{
    class Program
    {
        public bool canConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            if (magazine.Contains(ransomNote))
                return true;

            int counter = 0;
            char[] ransomNoteChars = ransomNote.ToCharArray();
            char[] magazineChars = magazine.ToCharArray();

            for (int i = 0; i < ransomNoteChars.Length; i++)
            {
                for (int j = 0; j < magazineChars.Length; j++)
                {
                    if (ransomNoteChars[i] == magazineChars[j])
                    {
                        magazineChars[j] = '0';
                        counter++;
                        break;
                    }
                }
            }

            if (counter == ransomNoteChars.Length)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string randsomeNote = "ba";
            string magazine = "abca";

            Console.WriteLine(program.canConstruct(randsomeNote, magazine));
        }
    }
}
