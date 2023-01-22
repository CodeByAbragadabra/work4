internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            sum = (number % 10) + sum;
            number /= 10;
        }

        Console.WriteLine($"Удвоенная сумма цифр числа = {sum * 2}");
    }
}