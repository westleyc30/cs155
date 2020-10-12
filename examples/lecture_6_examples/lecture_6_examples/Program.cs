using System;

namespace lecture_6_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions
            // Dealing with errors
            // Try block
            // Catch Handler
            /*
            // without try catch
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr[6]);


            // with try catch
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[6]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
                       */

            int[] arr = { 1, 3, 0, 62, 11, 190 };
            try
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
