using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllKindQuestions
{
    public class ListAnalyzer
    {
        public int FindBiggestNumber(List<int> numbers)
        {
            int biggestSoFar = numbers[0];

            foreach (int number in numbers)
            {
                if (number > biggestSoFar)
                {
                    biggestSoFar = number;
                }
            }

            return biggestSoFar;
        }
    }
}
