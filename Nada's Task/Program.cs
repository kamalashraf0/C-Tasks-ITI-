namespace Nada_s_Task
{
    class Program
    {

        static void Main(string[] args)
        {

            float budget = 183.23f;
            float bagVolume = 64.11f;
            int people = 7;
            int Npresents = 12;

            float[] presentVolume = { 4.53f, 9.11f, 4.53f, 6.00f, 1.04f, 0.87f, 2.57f, 19.45f, 65.59f, 14.14f, 16.66f, 13.53f };
            float[] presentPrice = { 12.23f, 45.03f, 12.23f, 32.93f, 6.99f, 0.46f, 7.34f, 65.98f, 152.13f, 7.23f, 10.00f, 25.25f };

            Console.WriteLine($"Maximum Amount of Money Spending  = ({Nader_sParty.PresentList(budget, bagVolume, people, Npresents, presentVolume, presentPrice)})");

            //Cal(presentPrice);


            //Nader_sParty.PresentsSort(presentPrice, presentVolume);

            Console.ReadKey();
        }


        public static void Cal(float[] arr)
        {
            float res;
            float max = 0;

            for (int i = 0; i <= arr.Length - 7; i++)
            {
                res = 0;
                for (int j = 0; j < 7; j++)
                {
                    res += arr[i + j];


                }

                if (res <= 183 && res > max)
                {

                    max = res;


                }
            }
            Console.WriteLine(max);
        }




    }

}
