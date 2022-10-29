using System;

namespace FlowChart
{
    class Zadanie2
    {
        static void Main()
        {
            //input data to array
            int[] input = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse);

            for (; ; )
            {
                if (input[0] > 0 && input[1] > 0)
                {
                    input[0] = input[0] - 1;
                    input[1] = input[1] - 1;
                    Console.Write("C");
                }

                if (input[0] <= 0 || input[1] <= 0)
                    break;
            }

            if (input[0] > 0) //CHECK X
            { //YES
                if (input[1] > 0) //CHECK Y
                { //YES
                    input[0] = input[0] - 1;
                    input[1] = input[1] - 1;
                    Console.Write("C");
                }
                else
                { //NO
                    Console.Write("D");
                    if (input[2] > 0) //CHECK Z
                    { //YES
                        ;
                    }
                    else
                    { //NO
                        Console.Write("G");
                    }
                }
            }
            else
            { //NO
                Console.Write("E");
                Console.Write("G");
            }
            Console.WriteLine();
        }
    }
}