using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DividePlayers
{
    class Program
    {
        public long CanDividePlayers(int[] skill)
        {
            if (skill.Length == 2)
            {
                return (skill[0] * skill[1]);
            }
            else
            {
                Array.Sort(skill);
                skill = skill.Reverse().ToArray();
                IList<List<int>> list = new List<List<int>>();
                List<int> child = new List<int>();
                List<int> child3 = new List<int>();
                int chemistry = -1;
                int len = skill.Length / 2;

                for (int i = 0; i < skill.Length; i++)
                {
                    for (int j = i + 1; j < skill.Length; j++)
                    {
                        if (skill[i] + skill[j] == skill[0] + skill[skill.Length - 1])
                        {
                            child.Add(skill[i]);
                            child.Add(skill[j]);

                            if (!child3.Contains(i))
                            {
                                list.Add(child);
                                child3.Add(i);
                            }
                                
                            child = new List<int>();
                        }
                    }
                }

                List<int> child1 = new List<int>();
                List<int> child2 = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    child1.Add(list[i][0] * list[i][1]);

                    if (!child2.Contains(list[i][0]))
                        child2.Add(list[i][0]);

                    if (!child2.Contains(list[i][1]))
                        child2.Add(list[i][1]);
                }

                skill = skill.Distinct().ToArray();
                if (child2.Count == skill.Length && child1.Count >= len)
                {
                    for (int k = 0; k < len; k++)
                    {
                        chemistry += child1[k];
                    }
                    chemistry++;
                }

                return chemistry;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] skill = { 3, 2, 5, 1, 3, 4 };
            int[] skill1 = { 3, 4 };
            int[] skill2 = { 1, 1, 2, 3 };
            int[] skill3 = { 2, 2, 2, 2 };
            int[] skill4 = { 5,1,1,2,1,4 };
            int[] skill5 = { 1,4,4,1 };

            Console.WriteLine(program.CanDividePlayers(skill));
            Console.WriteLine(program.CanDividePlayers(skill1));
            Console.WriteLine(program.CanDividePlayers(skill2));
            Console.WriteLine(program.CanDividePlayers(skill3));
            Console.WriteLine(program.CanDividePlayers(skill4));
            Console.WriteLine(program.CanDividePlayers(skill5));
            Console.ReadKey();
        }
    }
}
