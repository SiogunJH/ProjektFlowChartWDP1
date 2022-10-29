using System;

namespace FlowChart
{
    class Zadanie1
    {
        static void Init()
        {
            //input data to array
            int[] input = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse);

        CheckX:

            if (input[0] > 0) //CHECK X
            { //YES
                if (input[1] > 0) //CHECK Y
                { //YES
                    input[0] = input[0] - 1;
                    input[1] = input[1] - 1;
                    Console.Write("C");
                    goto CheckX;
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