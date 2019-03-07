using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {1, 5, 0, 34, 3, 9 };
            
            Array.Sort(numbers);

            var index = BinarySearchRecursive(numbers, 0, numbers.Length -1, 34);
            System.Console.WriteLine(index);

            // var index2 = BinarySearching(numbers, 3);
            // System.Console.WriteLine(index2);

            Console.ReadKey();
        }

            private static int LinearSearch(int[] array, int x)
            {
            
            for (int i = 0; i < array.Length; i++)
            {                            
                if(array[i] == x)
                {
                    return i;
                }
                
            }
            
            return -1;
        }


        private static int BinarySearching(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;

            while(left <= right)
            {
                var middle = (left + right) / 2;

                if(array[middle] == item)
                return middle;

                if(item < array[middle])
                right = middle - 1;

                else

                left = middle + 1;
            }

            return -1;
        }

        // private static int BinarySearchRecursive(int[] array, int item)
        // {
        //     return BinarySearchRecursive(array, 0, array.Length - 1, item);
        // }



        private static int BinarySearchRecursive(int[] array, int left, int right, int item)
        {
            if(right >= left)
            {
               var middle = (left + right) / 2;


                if(array[middle] == item)
                return middle;


                if(array[middle] > item)
                    return BinarySearchRecursive(array, left, middle - 1, item);


                
                    return BinarySearchRecursive(array, middle + 1, right, item);
            }
            return - 1;
        }

    }
}

