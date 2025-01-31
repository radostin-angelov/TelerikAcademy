﻿/*
    We are given the following sequence:

    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
    ...
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/

namespace Print50MembersOfSequencs
{
    using System;
    using System.Collections.Generic;

    class Print50MembersOfSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = n;
            int count = 0;
            Queue<int> loopParams = new Queue<int>();
            Console.Write(currentNumber);

            while (count < 50)
            {
                int first = currentNumber + 1;
                loopParams.Enqueue(first);

                int second = 2 * currentNumber + 1;
                loopParams.Enqueue(second);

                int third = currentNumber + 2;
                loopParams.Enqueue(third);

                Console.Write(", {0}, {1}, {2}", first, second, third);
                currentNumber = loopParams.Dequeue();
                count++;
            }

            Console.WriteLine();
            
        }
    }
}
