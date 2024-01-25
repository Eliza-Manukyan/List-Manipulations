using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
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
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> middleElements = FindMiddleElements(numbers);

            Console.WriteLine("Middle element(s): " + string.Join(", ", middleElements));
        }

        static List<int> FindMiddleElements(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty");
            }

            int middleIndex = numbers.Count / 2;

            if (numbers.Count % 2 == 0)
            {
                // If the list has an even number of elements, return the two middle elements
                return new List<int> { numbers[middleIndex - 1], numbers[middleIndex] };
            }
            else
            {
                // If the list has an odd number of elements, return the middle element
                return new List<int> { numbers[middleIndex] };
            }
        }
    }

}






