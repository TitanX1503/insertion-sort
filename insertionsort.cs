using System;

namespace InsertionSort
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);    
            }
        }

        static void InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                //i -> Índice actual en la "caja"
                int x = nums[i];

                //x -> Valor actual en la "caja"

                int j = i - 1;
                //j -> Índice que estamos comparando con el de la caja
                //nums[j] -> Valor que estamos comparando con el de la caja

                //Condiciones del while
                //1. No pasarnos del límite inferior de índices permitidos en array
                //   (llegar hasta el inicio)
                //2. Detener la comparación de números hacia la izquierda en el momento
                //   en que nos encontráramos un valor que no fuera mayor al de la "caja"
                while (j >= 0 && nums[j] > x)
                {
                    //"Recorrer a la derecha"
                    nums[j + 1] = nums[j];
                    j = j - 1;
                }
                //En este momento, j está a la izquierda del "espacio vacío"
                //j + 1 es el índice del espacio vacío
                nums[j + 1] = x;
            }
        }

        static void Main(string[] args)
        {
            int[] nums = new int[]{8, 9, 7, 6, 10, 4, 11, 9, 7};

            System.Console.WriteLine("Antes de ordenar:");
            PrintArray(nums);
            InsertionSort(nums);
            System.Console.WriteLine("Después de ordenar:");
            PrintArray(nums);

        }
    }
}