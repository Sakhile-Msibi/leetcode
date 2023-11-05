using System;
using System.Collections.Generic;

namespace GetLastMoment
{
    class Program
    {
        public int GetLMoment(int n, int[] left, int[] right)
        {
            if (left.Length == 0 && right.Length == 0)
                return 0;

            Array.Sort(left);
            Array.Sort(right);

            if (left.Length == 0)
            {
                return n - right[0];
            }
            else if (right.Length == 0)
            {
                return left[left.Length - 1];
            }
            else if (left.Length == 1 && right.Length == 1)
            {
                return (left[left.Length - 1] > right[right.Length - 1]) ? left[left.Length - 1] : right[right.Length - 1];
            }
            else
            {
                List<Tuple<double, char>> ants = new List<Tuple<double, char>>();
                double time = 0;

                // Add ants into a list
                for (int i = 0; i < left.Length; i++)
                {
                    ants.Add(Tuple.Create((double)left[i], 'L'));
                }

                for (int i = 0; i < right.Length; i++)
                {
                    ants.Add(Tuple.Create((double)right[i], 'R'));
                }

                ants.Sort();
                int curentAnt = 0;
                bool fractionTime = false;
                // While there are still ants on the plank (list), they should continue walking.
                // Ants can move to the left or to the right.
                // Ants can move in 0.5 unit / second or 1 unit / second
                while (ants.Count != 0)
                {
                    // Remove an ant if it reaches the start position
                    if (ants[curentAnt].Item1 == 0 && ants[curentAnt].Item2 == 'L')
                    {
                        Console.WriteLine("R -> L");
                        Console.WriteLine("Before " + ants[curentAnt].Item1 + " " + ants[curentAnt].Item2);
                        ants.RemoveAt(curentAnt);
                        //Console.WriteLine("Current: " + ants[curentAnt].Item1 + " " + ants[curentAnt].Item2);
                        //foreach (var ant in ants)
                        //{
                        //    Console.WriteLine(ant.Item1 + " " + ant.Item2);
                        //}
                        Console.WriteLine("Ants Number = " + ants.Count);
                    }

                    if (ants.Count == 0 /*|| ants[curentAnt].Item1 > n*/)
                        break;

                    // Remove an ant if it reaches the end position
                    if (ants[ants.Count - 1].Item1 == n && ants[ants.Count - 1].Item2 == 'R')
                    {
                        Console.WriteLine("L -> R");
                        Console.WriteLine("Before " + ants[ants.Count - 1].Item1 + " " + ants[ants.Count - 1].Item2);
                        ants.RemoveAt(ants.Count - 1);
                        //Console.WriteLine("Current: " + ants[ants.Count - 2].Item1 + " " + ants[ants.Count - 2].Item2);
                        //foreach (var ant in ants)
                        //{
                        //    Console.WriteLine(ant.Item1 + " " + ant.Item2);
                        //}
                        Console.WriteLine("Ants Number = " + ants.Count);
                    }

                    if (ants.Count == 0 /*|| ants[curentAnt].Item1 > n*/)
                        break;

                    foreach (var ant in ants)
                    {
                        Console.WriteLine(ant.Item1 + " " + ant.Item2);
                    }
                    Console.WriteLine("T = " + time);
                    Console.WriteLine("-------------End-------------");
                    // Determine if we will move at 0.5 unit / second or 1 unit / second
                    if (!fractionTime)
                    {
                        for (int i = 0; i < ants.Count - 1; i++)
                        {
                            if ((ants[i].Item1 == ants[i + 1].Item1) || ((ants[i].Item1 + 1) == ants[i + 1].Item1))
                            {
                                if (ants[i].Item2 == 'R' && ants[i + 1].Item2 == 'L')
                                {
                                    fractionTime = true;
                                    break;
                                }
                            }
                        }
                    }

                    // Ant moving at 0.5 unit/second
                    if (fractionTime)
                    {
                        time += 0.5;

                        for (int i = 0; i < ants.Count; i++)
                        {
                            if (ants[i].Item2 == 'R')
                            {
                                ants[i] = Tuple.Create(ants[i].Item1 + 0.5, 'R');
                            }
                            else
                            {
                                ants[i] = Tuple.Create(ants[i].Item1 - 0.5, 'L');
                            }
                        }
                        
                        for (int i = 0; i < ants.Count - 1; i++)
                        {
                            if (ants[i].Item1 == ants[i + 1].Item1)
                            {
                                if (ants[i].Item2 == 'R')
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'L');
                                    ants[i + 1] = Tuple.Create(ants[i + 1].Item1, 'R');
                                }
                                else
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'R');
                                    ants[i + 1] = Tuple.Create(ants[i + 1].Item1, 'L');
                                }
                            }
                        }

                        if ((int)ants[curentAnt].Item1 == ants[curentAnt].Item1)
                        {
                            fractionTime = false;
                        }
                    }
                    else
                    {
                        time += 1;

                        for (int i = 0; i < ants.Count; i++)
                        {
                            if (ants[i].Item2 == 'R')
                            {
                                ants[i] = Tuple.Create(ants[i].Item1 + 1, 'R');
                            }
                            else
                            {
                                ants[i] = Tuple.Create(ants[i].Item1 - 1, 'L');
                            }
                        }

                        for (int i = 0; i < ants.Count - 1; i++)
                        {
                            if (ants[i].Item1 == ants[i + 1].Item1)
                            {
                                if (ants[i].Item2 == 'R')
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'L');
                                    ants[i + 1] = Tuple.Create(ants[i + 1].Item1, 'R');
                                }
                                else
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'R');
                                    ants[i + 1] = Tuple.Create(ants[i + 1].Item1, 'L');
                                }
                            }
                        }
                    }
                }
                return (int)time;
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            //int n = 20;
            //int[] left = /*{ 4, 3 }*/{ 4, 7, 15 };
            //int[] right = /*{ 0, 1 }*/{ 9, 3, 13, 10 };

            int n = 11;
            int[] left = { 1, 4, 5, 10, 9 };
            int[] right = { 2, 7, 6, 3 };

            Console.WriteLine("Time = " + program.GetLMoment(n, left, right));
        }
    }
}
