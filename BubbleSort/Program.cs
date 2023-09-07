namespace BubbleSort
{
     class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 3, 6, 9, 4, 1, 2, 7, 5, 8 };

            int tempSpot = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }


            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                for (int j = 0; j < numbers.Length - 1; j++) 
                {
                    if (numbers[j] > numbers[j + 1]) 
                    { 
                        tempSpot = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = tempSpot;
                    }
                }
            }
            Console.WriteLine("Sorted: ");
            foreach (int p in numbers)
                Console.WriteLine(p + " ");
            Console.ReadLine();
        }
    }
}