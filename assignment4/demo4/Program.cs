using System.Text;

namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  string vs string builder
            //string name01;

            //name01 = new string("nabil");

            //string name02 = "mohamed";
            //name02 = name01;
            //name01 = "ahmed";
            //Console.WriteLine($" name 01 is {name01}");
            //Console.WriteLine($" name 02 is {name02}");
            //string is an imutable type cannot ghange it is value


            //string message = "hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message += "route";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //////////////////////////////////////////
            //StringBuilder sb = new StringBuilder();
            //sb.Append("hello");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append("ROUTE");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());

            #endregion
            #region array
            #region one d array
            //int[] numbers;
            //numbers = new int[3];
            //Console.WriteLine(numbers[0]);
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //Console.WriteLine(numbers[0]);
            //int[] numbers2 = new int[3] {1,2,3};
            //int[] numbers3 = new int[] {1,2};
            //int[] numbers4 =  {1,2,3,4,5};
            //Console.WriteLine($"size of array = {numbers4.Length},number of dimenion = {numbers4.Rank}");
            //Console.WriteLine(numbers2[0]);
            //for (int i = 0; i < numbers4.Length; i++)
            //{
            //    Console.WriteLine(numbers4[i]);
            //}
            #endregion
            #region two d array
            //int[,] marks = new int[3, 5] { { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 } };
            ////Console.WriteLine($" size of array ={marks.Length},dimention = {marks.Rank}");
            //int[,] marks = new int[2, 4];
            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{

            //    Console.WriteLine($"enter marks of students num {i + 1}");
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($" sub num {j + 1}");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //     for (int i = 0;i < marks.GetLength(0);i++ )
            //{
            //    Console.WriteLine($"grades of students num {i + 1}");
            //    for(int j = 0;j < marks.GetLength(1);j++)
            //    {
            //        Console.WriteLine($"sub num {j+1} = {marks[i,j]}");
            //        marks[i,j] = int.Parse(Console.ReadLine());
            //    }

            //}



            #endregion
            #region judeg array
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] {1,2,3,4,5,6};
            //numbers[1] = new int[] { 4, 5 };
            //numbers[2] = new int[] { 6 };

            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //   for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(numbers{ [i][j]);
            //    }
            //}  
            #endregion
            #region  session 05
            #region array methods
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arr01 = { 1,2,3,4,5,6,7,8,9 };
            //int[] arr02 = new int[] { 5 };
            #region class number methods [static methods]
            //Array.Copy(arr01, arr02, 2);
            //foreach (int num in arr02)
            //{
            //    Console.WriteLine(num);
            //}
            //Array.Clear(nums);
            //Array.ConstrainedCopy(arr01 ,1 ,arr02, 1, 2);
            //int [] arr03 =  (int[]) Array.CreateInstance(typeof(int), 10);
            /// int[ , ,] arr04 = (int[, ,]) Array.CreateInstance(typeof(int), 2,4,3);



            #endregion
            #region object member methods
            //arr01.CopyTo(arr02, 1);
            //foreach (int num in arr02)
            //{
            //    Console.WriteLine(num);
            //}
            //arr01.SetValue(100, 1);
            //Console.WriteLine(arr01[1]);

            #endregion


            #endregion

            #endregion
            #region function
            #endregion




            #endregion



        }

    }



}