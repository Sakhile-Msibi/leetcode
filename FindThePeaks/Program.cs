namespace FindThePeaks
{
    internal class Program
    {
        public IList<int> FindPeaks(int[] mountain)
        {
            if (mountain.Length == 3 && (mountain[1] == mountain[0] || mountain[1] == mountain[2]))
            {
                return new List<int>();
            }

            IList<int> list = new List<int>();

            for (int i = 1; i < mountain.Length - 1; i++)
            {
                if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                {
                    list.Add(i);
                }
            }

            return list;
        }

        void DisplayList(IList<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] mountain = { 2, 4, 4 };

            program.DisplayList(program.FindPeaks(mountain));

            int[] mountain1 = { 1, 4, 3, 8, 5 };

            program.DisplayList(program.FindPeaks(mountain1));

            Console.ReadKey();
        }
    }
}