using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllKindQuestions
{
    class FizzBuzz
    {
        public static void FizzBuzz35()
        {
            bool flag = true;
            int counter = 1;
            while (flag)
            {
                if (counter % 3 == 0)
                {
                    if (counter % 5 == 0)
                    {
                        Console.WriteLine("FIZZ BUZZ");
                        counter++;
                        continue;
                    }
                    Console.WriteLine("FIZZ");
                }
                else if (counter % 5 == 0)
                {
                    if (counter % 3 == 0)
                    {
                        Console.WriteLine("FIZZ BUZZ");
                        counter++;
                        continue;
                    }
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(counter);
                }
                Console.ReadLine();
                counter++;

            }
        }
}
