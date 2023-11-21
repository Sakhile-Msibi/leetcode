using System.Collections;

namespace IntersectionOfTwoArraysII
{
    internal class Program
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Dictionary<int, int> map2 = new Dictionary<int, int>();
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!map.ContainsKey(nums1[i]))
                {
                    map.Add(nums1[i], 1);
                }
                else
                {
                    int value = 0;
                    bool val = map.TryGetValue(nums1[i], out value);

                    map.Remove(nums1[i]);
                    map.Add(nums1[i], ++value);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (!map2.ContainsKey(nums2[i]))
                {
                    map2.Add(nums2[i], 1);
                }
                else
                {
                    int value = 0;
                    bool val = map2.TryGetValue(nums2[i], out value);

                    map2.Remove(nums2[i]);
                    map2.Add(nums2[i], ++value);
                }
            }

            if (map.Count <= map2.Count)
            {
                foreach (KeyValuePair<int, int> pair in map)
                {
                    if (map2.ContainsKey(pair.Key))
                    {
                        int value = 0;
                        bool val = map2.TryGetValue(pair.Key, out value);
                         

                        if (pair.Value <= value)
                        {
                            for (int i = 0; i < pair.Value; i++)
                            {
                                arrayList.Add(pair.Key);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < value; i++)
                            {
                                arrayList.Add(pair.Key);
                            }
                        }
                        
                    }
                }
            }
            else
            {
                foreach (KeyValuePair <int, int> pair in map2)
                {
                    if (map.ContainsKey(pair.Key))
                    {
                        int value = 0;
                        bool val = map.TryGetValue(pair.Key, out value);

                        if (pair.Value <= value)
                        {
                            for (int i = 0; i < pair.Value; i++)
                            {
                                arrayList.Add(pair.Key);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < value; i++)
                            {
                                arrayList.Add(pair.Key);
                            }
                        }
                    }
                }
            }

            return (int[])arrayList.ToArray(typeof(int));
        }

        public void DisplayArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            program.DisplayArray(program.Intersect(nums1, nums2));

            int[] nums3 = { 4, 9, 5 };
            int[] nums4 = { 9, 4, 9, 8, 4 };

            program.DisplayArray(program.Intersect(nums3, nums4));

            int[] nums5 = { 1, 2 };
            int[] nums6 = { 1, 1 };

            program.DisplayArray(program.Intersect(nums5, nums6));

            int[] nums7 = { 1, 2, 2, 1 };
            int[] nums8 = { 1, 2 };

            program.DisplayArray(program.Intersect(nums7, nums8));

            Console.ReadKey();
        }
    }
}