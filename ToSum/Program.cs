using System.Collections;

namespace ToSum
{
    internal class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2)
            {
                return new int[]  { 0, 1 };
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return new int[2];

            //Hashtable ht = new Hashtable();
            //Hashtable ht2 = new Hashtable();
            //int[] ints = new int[2];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    ht.Add(i, nums[i]);
            //    ht2.Add(i, nums[i]);
            //}

            //bool isValue = true;
            //int complement = 0;
            //int com = 0;
            //int key = 0;
            //int value = 0;
            //foreach (DictionaryEntry num in ht)
            //{
            //    if (num.Value != null)
            //    {
            //        complement = target - (int)num.Value;
            //        key = (int)num.Key;
            //        value = (int)num.Value;
            //    }


            //    ht2.Remove(num.Key);

            //    bool tets = ht.ContainsKey(complement);

            //    if (ht2.ContainsValue(complement))
            //    {
            //        if (isValue)
            //        {
            //            ints[1] = (int)num.Key;
            //            isValue = false;
            //            com = complement;
            //        }

            //        if (num.Value != null)
            //        {
            //            if (ints[1] != (int)num.Key && (int)num.Value == com)
            //            {
            //                ints[0] = (int)num.Key;
            //            }
            //        }
            //    }
            //    ht2.Add(key, value);
        //}

        //    return ints;
        }

        public void DisplayArray(int[] nums)
        {
            foreach (int x in nums)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            program.DisplayArray(program.TwoSum(nums, target));

            int[] nums1 = { 3, 2, 4 };
            target = 6;

            program.DisplayArray(program.TwoSum(nums1, target));

            int[] nums2 = { 3, 3 };
            target = 6;

            program.DisplayArray(program.TwoSum(nums2, target));

            int[] nums3 = { 2, 4, 11, 3 };
            target = 6;

            program.DisplayArray(program.TwoSum(nums3, target));
        }
    }
}