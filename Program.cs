﻿﻿using System;

namespace dotnet_FindMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + "\t");
            }

            int min = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    index = j - 1;
                }
            }
            Console.WriteLine("The Smaller property value in the list is " + min + " ,at position " + index);
        }
    }
}