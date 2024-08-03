using System.Diagnostics;

namespace Tasks_Day_7
{
    class Program
    {
        static void Main(string[] args)
        {


            #region ArrayOfIntegers


            //int[] arr = new int[6];


            //Console.WriteLine("Enter The Elements of the Array : ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("[");
            //foreach (var item in arr)
            //{
            //    Console.Write($" {item} ");
            //}
            //Console.WriteLine("]");

            //int maxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($" Longest Distance = {maxDistance - 1}");
            #endregion


            #region Reverse 



            //string sentecnce = "this is a test";

            //string[] split = sentecnce.Split(' ');



            //for (int i = split.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{split[i]} ");
            //}






            #endregion


            #region Count's of 1s

            CountV1(99);
            CountV2(99);
            CountV3(99);


            #endregion

            Console.ReadKey();
        }

        public static void CountV1(int range)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int count = 0;
            for (int i = 0; i <= range; i++)
            {
                int number = i;
                while (number > 0)
                {
                    int digit = number % 10;

                    if (digit == 1)
                    {

                        count++;
                    }
                    number /= 10;
                }
            }

            Console.WriteLine($"Count's of 1 = {count}");
            sw.Stop();
            Console.WriteLine(sw);
        }

        public static void CountV2(int range)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int count = 0;
            for (int i = 1; i <= range; i++)
            {
                string numberStr = i.ToString();


                foreach (char digitChar in numberStr)
                {
                    if (digitChar == '1')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Count's of 1 = {count}");
            sw.Stop();
            Console.WriteLine(sw);
        }

        public static void CountV3(int range)
        {

            string rangeStr = range.ToString();
            int strLength = rangeStr.Length;


            double totalOnes = strLength * Math.Pow(10, strLength - 1);

            Console.WriteLine($"Count's of 1 = {totalOnes}");
        }


    }
}
