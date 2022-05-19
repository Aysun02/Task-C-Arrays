using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 3, 4, 7 };
            int[] array2 = { 3, 2 };

            Console.WriteLine(IsArrayContains(array1, array2));
        }
        static bool IsArrayContains(int[] array1, int[] array2)
        {
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if  (array2[j] == array1[i] ) 
                    {
                        counter++;
                        if (counter == array2.Length)
                        {
                            return true;
                        }
                    }

                }

            }
            return false;
          
        }
    }
}
