internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Вводите чисолки и тыкайте 0 если хотите закончить тыкать: ");
        int temp_num = int.MinValue;
        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                break;
            }
            else
            {
                if (num > temp_num)
                {
                    temp_num = num;
                }
                else
                {
                    Console.WriteLine($"Максимальное число = {temp_num}");
                    break;
                }
            }
        }
    }
}