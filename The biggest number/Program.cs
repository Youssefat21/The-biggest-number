using System;

namespace The_biggest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number of your numbers : ");  // Take the size of array
            int size;                                                 
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];                        //Array decleration

            for (int i = 0; i < size; i++)                    //Take elements of array
            {
                Console.WriteLine("Enter value " +( i + 1) + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int index=0; 
            for (int i = 0; i < size; i++)             //The biggest element and its place in array
            {
                if (arr[0] < arr[i])
                {

                    arr[0] = arr[i];             // If arr[i] > arr[0] --> put the arr[i] value in arr[0] , else return to loop (continue;)

                    index = i;
                }
            }
                                                   // Display the results
            Console.WriteLine("------------------------------");
            Console.WriteLine("The biggest number is : " + arr[0]);
            Console.WriteLine("Its place in array is : "+index);
        }
    }
}
