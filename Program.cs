using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов n");
            int n = int.Parse(Console.ReadLine());
            FillArray(n);
            
        }

        public static int CountArray(int[][][] ms)
        {
            int length = ms.Length;
            int[] diagonalElements = new int[length * length];

            int index = 0;
            for (int i = 0 ; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    diagonalElements[index] = ms[i][j][j];
                    index++;
                }                 
                  
            }                       
            Array.Sort(diagonalElements);
            int secondLargest = diagonalElements[diagonalElements.Length - 2];
            Console.WriteLine("Второе по величине значение элементов диагоналей куба = " + secondLargest);
            return secondLargest;
            
        }


        public static void FillArray(int n)
        {
            //заполнение таблицы для теста
            Random r = new Random();

            int[][][] arr = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n][];

                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = new int[n];
                }
            }
                      
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        arr[i][j][k] = r.Next(-10,10);
                    }
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
            
                for (int j = 0; j < arr[i].Length; j++)
                {
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        Console.Write(arr[i][j][k].ToString() + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            CountArray(arr);
        }
    }
}
