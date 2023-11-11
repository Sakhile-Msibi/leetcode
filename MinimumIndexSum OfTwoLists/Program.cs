namespace MinimumIndexSum_OfTwoLists
{
    internal class Program
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> strings1 = new Dictionary<string, int>();
            Dictionary<string, int> strings2 = new Dictionary<string, int>();
            int indexSum = int.MaxValue;
            List<string> strings = new List<string>();

            for (int i = 0; i < list1.Length; i++)
            {
                if (!strings1.ContainsKey(list1[i]))
                {
                    strings1.Add(list1[i], i);
                }
                else
                {
                    strings2.Add(list1[i], i);
                }
            }

            for (int i = 0; i < list2.Length; i++)
            {
                if (!strings1.ContainsKey(list2[i]))
                {
                    strings1.Add(list2[i], i);
                }
                else
                {
                    strings2.Add(list2[i], i);
                }
            }

            if (list1.Length > list2.Length)
            {
                for (int i = 0; i < list2.Length; i++)
                {
                    int s1Value = -1;
                    int s2Value = -1;
                    bool s1Boolean;
                    bool s2Boolean;

                    if (strings2.ContainsKey(list2[i]))
                    {
                        s1Boolean = strings1.TryGetValue(list2[i], out s1Value);
                        s2Boolean = strings2.TryGetValue(list2[i],out s2Value);

                        if (indexSum > s1Value + s2Value)
                        {
                            strings.Clear();
                            strings.Add(list2[i]);
                        }
                        else if (indexSum == s1Value + s2Value)
                        {
                            strings.Add(list2[i]);
                        }
                        indexSum = s1Value + s2Value;
                    }
                }
            }
            else
            {
                for (int i = 0; i < list1.Length; i++)
                {
                    int s1Value = -1;
                    int s2Value = -1;
                    bool s1Boolean;
                    bool s2Boolean;

                    if (strings2.ContainsKey(list1[i]))
                    {
                        s1Boolean = strings1.TryGetValue(list1[i], out s1Value);
                        s2Boolean = strings2.TryGetValue(list1[i], out s2Value);

                        if (indexSum > s1Value + s2Value)
                        {
                            strings.Clear();
                            strings.Add(list1[i]);
                        }
                        else if (indexSum == s1Value + s2Value)
                        {
                            strings.Add(list1[i]);
                        }
                        indexSum = s1Value + s2Value;
                    }
                }
            }

            return strings.ToArray();
        }

        public void DisplayArray(string[] strings)
        {
            foreach (string s in strings)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };

            program.DisplayArray(program.FindRestaurant(list1, list2));

            string[] list3 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list4 = { "KFC", "Shogun", "Burger King" };

            program.DisplayArray(program.FindRestaurant(list3, list4));

            string[] list5 = { "happy", "sad", "good" };
            string[] list6 = { "sad","happy","good" };

            program.DisplayArray(program.FindRestaurant(list5, list6));
        }
    }
}