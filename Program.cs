using System;

namespace PetyaandStrings
{
    class Program
    {
        static void Main()
        {

                string str1 = Console.ReadLine();

                string str2 = Console.ReadLine();

                string  a= str1.ToLower();

                string b = str2.ToLower();

                if (a ==b)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] < b[i])
                        {
                            Console.WriteLine("-1");
                            break;
                        }
                        if (a[i] >b[i])
                        {
                            Console.WriteLine("1");
                            break;
                        }
                    }
                }

            }
        }
    }
    

