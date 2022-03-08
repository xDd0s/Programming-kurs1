using System;

namespace Лаб_7
{
    class Program
    {
        static int Rec(int a)
        {
            if (a == 1) return 1;
            return Rec(a - 1) + a;
        }
        static int MinMassiva(int[] arr)
        {
            int pol = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] >= 0)
                {
                    pol = arr[i];
                    break;
                }
            }
            if (pol == -1)
            {
                Console.WriteLine("Net Polozhitelnix");
                return 1;
            }
            else
                return MinMassivaRab(arr, arr.Length, pol, 0);
        }
        static int MinMassivaRab(int[] arr, int arraySize, int min, int i)
        {
            if (i < arraySize)
            {
                if (arr[i] < min && arr[i] >= 0)
                    min = arr[i];
                i++;
                return MinMassivaRab(arr, arraySize, min, i);                
            }
            else 
                return min;
        }
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] m = new int[10];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = R.Next(-256,256);
                Console.Write(m[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine(MinMassiva(m));

            Console.WriteLine(Rec(3));
        }
    }
}
