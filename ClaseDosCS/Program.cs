using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2, 3 };

            Arrays sumarArreglo = new Arrays();

            int[] result = sumarArreglo.sumArray(array1, array2);

            Console.WriteLine("La suma de los arreglos es: \n");

            sumarArreglo.viewArray(result);

            int edad = 15;

            string validation = (edad > 18) ?  "eres mayor" : "eres menor";


        }
    }

    class Arrays
    {
        public int[] sumArray(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }

        public void viewArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    
}