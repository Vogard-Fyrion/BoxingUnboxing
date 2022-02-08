using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> variables = new List<object>();
            {
                variables.Add(7);
                variables.Add(28);
                variables.Add(-1);
                variables.Add(true);
                variables.Add("chair");
            }
            int sum = 0;
            foreach(var indx in variables)
            {
                if(indx is int)
                {
                    Console.WriteLine(indx);
                    sum += (int)indx;
                }
                else
                {
                    Console.WriteLine(indx);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
