namespace Nada_s_Task
{
    static class Nader_sParty
    {


        public static float PresentList(float budget, float bagVolume, int people,
            int Npresents, float[] presentVolume, float[] presentPrice)
        {


            float MaximumSpending = 0;
            float totalPrice;
            float totalVolume;
            int PresentsByPeople = Npresents / people;
            int TotalPresents = PresentsByPeople;
            PresentsSort(presentPrice, presentVolume);

            for (int i = 0; i < presentPrice.Length - TotalPresents; i++)
            {
                totalPrice = 0;
                totalVolume = 0;

                for (int j = 0; j < TotalPresents; j++)
                {
                    totalPrice += presentPrice[i + j];
                    totalVolume += presentVolume[i + j];
                }

                Console.WriteLine(totalPrice);

                if (totalPrice <= budget && totalPrice > MaximumSpending && totalVolume <= bagVolume)
                {
                    MaximumSpending = totalPrice;
                }

            }

            return MaximumSpending;
        }


        public static void PresentsSort(float[] presentPrice, float[] presentVolume)
        {

            for (int i = 0; i < presentPrice.Length; i++)
            {
                for (int j = i; j < presentPrice.Length; j++)
                {
                    if (presentPrice[i] < presentPrice[j])
                    {
                        float TempPrice = presentPrice[i];
                        presentPrice[i] = presentPrice[j];
                        presentPrice[j] = TempPrice;

                        float tempVolume = presentVolume[i];
                        presentVolume[i] = presentVolume[j];
                        presentVolume[j] = tempVolume;

                    }
                }
            }


            //foreach (var item in presentPrice)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████");


            //foreach (var item in presentVolume)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();
        }

    }


}
