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
                        ants.RemoveAt(curentAnt);
                        Console.WriteLine(ants[curentAnt].Item1 + " " + ants[curentAnt].Item2);
                    }

                    // Remove an ant if it reaches the end position
                    if (ants[curentAnt].Item1 == n && ants[curentAnt].Item2 == 'R')
                    {
                        ants.RemoveAt(curentAnt);
                        Console.WriteLine(ants[curentAnt].Item1 + " " + ants[curentAnt].Item2);
                    }

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
                                }
                                else
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'R');
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
                                }
                                else
                                {
                                    ants[i] = Tuple.Create(ants[i].Item1, 'R');
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(time);
                return (int)time;






                //List<List<int, char>> ants = new List<List<int, char>>();
                //IDictionary<char, int> ants = new Dictionary<char, int>();
                //double max = 0;

                //for (int j = 0; j < left.Length; j++)
                //{
                //    //cart.add(left[i], 'L');
                //    ants.Add(Tuple.Create((double)left[j], 0.0, 'L'));

                //}

                //for (int j = 0; j < right.Length; j++)
                //{
                //    //cart.add(right[i], 'R');
                //    ants.Add(Tuple.Create((double)right[j], 0.0, 'R'));
                //    //Console.WriteLine(i);
                //}
                ////ants.Sort();
                //foreach (var ant in ants)
                //{
                //    Console.WriteLine(ant.Item1 + " " + ant.Item2 + " " + ant.Item3);
                //}
                ////Console.WriteLine(ants.Count);



                ////Left to right

                //double term1 = 0;
                //double term2 = 0;
                ////int i = 0;
                //for (int i = 0; i < ants.Count; i++)
                ////while (ants.Count != 0)
                //{
                //    Console.WriteLine("i = " + i);
                //    //Console.WriteLine("ants.Count = " + ants.Count);
                //    Console.WriteLine(ants[i].Item3);
                //    Console.WriteLine(ants[i].Item1);
                //    Console.WriteLine(ants[i].Item2);
                //    //if ( i < ants.Count)
                //    //{
                //        if (ants[i].Item1 == 0 && ants[i].Item3 == 'L')
                //        {
                //            Console.WriteLine("Hello4444");
                //            ants.RemoveAt(i);
                //        }

                //        if (ants[i].Item1 == n && ants[i].Item3 == 'R')
                //        {
                //            ants.RemoveAt(i);
                //        }

                //        //Console.WriteLine("ants.Count1 = " + ants.Count);
                //        if (ants[i].Item3 == 'R' && (i + 1) < ants.Count)
                //        {
                //            //Console.WriteLine("Hello");
                //            if ((ants[i].Item1 + 1) == ants[i + 1].Item1 && ants[i + 1].Item3 == 'R')
                //            {
                //                term1 += ants[i].Item2 + 1.0;
                //                ants[i] = Tuple.Create(ants[i].Item1 + 1, term1, 'R');
                //                Console.WriteLine($"ants[{i}].Item2 " + ants[i].Item2);
                //                Console.WriteLine($"ants[{i}].Item1 " + ants[i].Item1);
                //                //ants[i].Item1 += 1;
                //            }
                //            else if ((ants[i].Item1 + 1) == ants[i + 1].Item1 && ants[i + 1].Item3 == 'L')
                //            {
                //                term1 += ants[i].Item2 + 0.5;
                //                ants[i] = Tuple.Create(ants[i].Item1 + 0.5, term1, 'L');
                //                Console.WriteLine($"ants[{i}].Item2 " + ants[i].Item2);
                //                Console.WriteLine($"ants[{i}].Item1 " + ants[i].Item1);
                //                //ants[i].Item2 += 0.5;
                //                //ants[i].Item1 += 0.5;
                //                //ants[i].Item3 = 'L';
                //            }
                //        }
                //        else if (ants[i].Item3 == 'L' && (i - 1) >= 0)
                //        {
                //            //Console.WriteLine("Hello");
                //           //Console.WriteLine(ants[i - 1].Item3);
                //           // Console.WriteLine(ants[i - 1].Item1);
                //           // Console.WriteLine(ants[i].Item1 - 1);
                //            if ((ants[i].Item1 - 1) == ants[i - 1].Item1 && ants[i - 1].Item3 == 'L')
                //            {
                //                term2 += ants[i].Item2 + 1.0;
                //                ants[i] = Tuple.Create(ants[i].Item1 + 1, term2, 'L');
                //                Console.WriteLine($"ants[{i}].Item2 " + ants[i].Item2);
                //                Console.WriteLine($"ants[{i}].Item1 " + ants[i].Item1);
                //                //ants[i].Item1 += 1;
                //            }
                //            else if ((ants[i].Item1 - 0.5) == ants[i - 1].Item1 && ants[i - 1].Item3 == 'L')
                //            {
                //                //Console.WriteLine(ants[i - 1].Item1);
                //                term2 += ants[i].Item2 + 0.5;
                //                ants[i] = Tuple.Create(ants[i - 1].Item1 + 0.5, term2, 'R');
                //                Console.WriteLine($"ants[{i}].Item2 " + ants[i].Item2);
                //                Console.WriteLine($"ants[{i}].Item1 " + ants[i].Item1);
                //                //ants[i].Item1 += 0.5;
                //                //ants[i].Item3 = 'R';
                //            }
                //        }

                //        Console.WriteLine("HelloLast");
                //        if (ants[i].Item2 > max)
                //        {
                //            max = ants[i].Item2;
                //        }
                //        Console.WriteLine("ants.Count = " + ants.Count);
                //    //}
                //    //i++;
                //}


                //return (int)max;
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            int n = 4;
            int[] left = { 4, 3 }/*{ 4, 7, 15 }*/;
            int[] right = { 0, 1 }/*{ 9, 3, 13, 10 }*/; 

            Console.WriteLine(program.GetLMoment(n, left, right));
        }
    }
}
