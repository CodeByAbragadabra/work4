internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int mult = 1;

        while (number > 0)
        {
            mult = number % 10 * mult;
            number /= 10;
        }

        Console.WriteLine($"Произведение цифр числа = {mult}");
    }
}