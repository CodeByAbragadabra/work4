internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int temp_number = number;

            bool stop = false;

            while (temp_number > 0)
            {
                int character = temp_number % 10;

                if (character == 1)
                {
                    Console.WriteLine($"Число c единицей = {number}");
                    stop = true;
                    break;
                }
                else
                {
                    temp_number = temp_number / 10;
                }

            }

            if (stop)
            {
                break;
            }

            if (number == 0)
            {
                break;
            }

        }
    }
}