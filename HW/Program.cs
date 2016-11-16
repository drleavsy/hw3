using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int count = 0;
            int minim = 0;
            int maxim = 0;

            Console.WriteLine("Please write the array size: ");
            while ( !(int.TryParse(Console.ReadLine(), out size)) )
            {
               Console.WriteLine("Please enter proper array size again: ");
            }

            int[] arrayA = InitArray(size);

            Console.WriteLine("Please enter array's elements one-by-one: ");
            fillArray(arrayA, size);
            minMaxtArr(arrayA, size, ref minim, ref maxim);

        
            Console.WriteLine("The minimum number is: " + minim);
            Console.WriteLine("The maximum number is: " + maxim);
            Console.Read();
        }

        static int[] InitArray(int sizeArr)
        {
            int[] array = new int[sizeArr];
            return array;
        }
        static void fillArray(int[] arrayIn, int sizeIn)
        {
            string input;
            int i = 0;
            int elem = 0;
            
            while(i < sizeIn)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out elem))
                {
                    arrayIn[i] = elem;
                    i++;
                }
                else
                {
                    Console.WriteLine("Enter the proper array element #" , i++ , " again: ");
                }
            }
        }
        static void minMaxtArr(int[] arrayInA, int sizeA, ref int minNum, ref int maxNum)
        {
            minNum = arrayInA[0];
            maxNum = arrayInA[0];
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeA; j++)
                {
                    if (arrayInA[i] < arrayInA[j])
                    {
                        if (maxNum < arrayInA[j])
                        {
                            maxNum = arrayInA[j];
                        }
                        else if(minNum > arrayInA[j])
                        {
                            minNum = arrayInA[j];
                        }
                    }
                    else
                    {
                        if (minNum > arrayInA[j])
                        {
                            minNum = arrayInA[j];
                        }
                    }
                }
            }
        }
    }
}
