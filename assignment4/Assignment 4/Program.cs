using System.Threading;
using System;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //1 - Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.//


            //Console.Write("Enter x1= ");
            //double x1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y1= ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2= ");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y2= ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3= ");
            //double x3 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y3= ");
            //double y3 = double.Parse(Console.ReadLine());


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}


            #endregion
            #region 2
            //2 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            //- If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //  - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //        - If the worker takes more than 5 hours, they are required to leave the company.
            //          To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.


            //Console.WriteLine("Enter the time taken to complete the task (in hours):");
            //double time = double.Parse(Console.ReadLine());

            //if (time >= 2 && time < 3)
            //{
            //    Console.WriteLine("Worker is highly efficient.");
            //}
            //else if (time >= 3 && time < 4)
            //{
            //    Console.WriteLine("Worker should increase their speed.");
            //}
            //else if (time >= 4 && time < 5)
            //{
            //    Console.WriteLine("Worker should be provided with training to enhance their speed.");
            //}
            //else if (time >= 5)
            //{
            //    Console.WriteLine("Worker should leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid time input.");

            //}



            #endregion
            #region 3

            //3 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.WriteLine("Enter the size of the identity matrix x ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine ("1 ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("0 ");
            //        }
            //    }
            //    Console.WriteLine();


            #endregion
            #region 4
            //20 - Write a program in C# Sharp to find the sum of all elements of the array.

            //    Console.WriteLine("Enter the number of elements in the array:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    int sum = 0;

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //        sum += array[i];
            //    }

            //    Console.WriteLine("The sum of all elements in the array is: " + sum);

            #endregion
            #region 5
            //21 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //Console.WriteLine("Enter the number of elements in each array:")
            //int n = int.Parse(Console.ReadLine()); 
            //int[] array1 = new int[n];
            //int[] array2 = new int[n];
            //int[] mergedArray = new int[2 * n];








            #endregion
            #region 6
            //22 - Write a program in C# Sharp to count the frequency of each element of an array.





            //Console.WriteLine("Enter the number of elements in the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //            array[j] = int.MinValue; 
            //        }
            //    }
            //    if (array[i] != int.MinValue)
            //    {
            //        Console.WriteLine($"{array[i]}: {count}");
            //    }



            #endregion
            #region 7
            //23 - Write a program in C# Sharp to find maximum and minimum element in an array



            //Console.WriteLine("Enter the number of elements in the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}

            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");


            #endregion

            #region 8
            //24 - Write a program in C# Sharp to find the second largest element in an array.


            //Console.WriteLine("Enter the number of elements in the array:");
            //int x = int.Parse(Console.ReadLine());

            //int[] array = new int[x];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < x; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < x; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        secondMax = max;
            //        max = array[i];
            //    }
            //    else if (array[i] > secondMax && array[i] != max)
            //    {
            //        secondMax = array[i];
            //    }
            //}

            //Console.WriteLine($"The second largest element is: {secondMax}");






            #endregion

            #region 9
            //            25 -.Consider an Array of Integer values with size N, having values as
            ///                    / in this Example

            //7      0    0   0   0   5   6   7   5   0   7   5   3

            //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).

            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.




            #endregion
            #region 10


            //            26 - Given a list of space separated words, reverse the order of the words.

            //            Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word Output: Word
            //Note : 
            //Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement



            //Console.WriteLine("Enter a space-separated list of words:");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine("Reversed order of words:");
            //Console.WriteLine(string.Join(" ", words));


            #endregion


            #region 11
            //27 - Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            #endregion
            #region 12

            //28 - Write a Program to Print One Dimensional Array in Reverse Order



            //Console.WriteLine("Enter the number of elements in the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Array in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region function
            #region 1

            //1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.


            //    int a = 5;
            //    Console.WriteLine("Before method call: " + a);
            //    IncreaseValue(ref a);
            //    Console.WriteLine("After method call: " + a);
           

            //static void IncreaseValue(ref int x)
            //{
            //    x += 10;
            //    Console.WriteLine("Inside method: " + x);
        

             #endregion
             #region 2













            #endregion















                  #endregion

        }





















































    }






















}
















































































































       


    






































































