Console.WriteLine("Эта программа подсчитает значение функии F(x) = x^3 + ctg(x)");

Console.Write("Введите начало отрезка, на котором расчитывать функцию: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите конец отрезка, на котором расчитывать функцию: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите шаг: ");
double h = Convert.ToDouble(Console.ReadLine());

double x = a;
double f;

while (x <= h)
{
    f = Math.Pow(x, 3) - Math.Tan(x);

    Console.Write(x + " ");
    Console.Write(f + "\n");

    x = x + h;
}
