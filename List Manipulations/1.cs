using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulations
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 5, 8, 15, 3 };

            int maxNumber = FindLargestNumber(numbers);

            Console.WriteLine("The largest number is: " + maxNumber);
        }

        static int FindLargestNumber(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty");
            }

            int maxNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }
    }
}


    

