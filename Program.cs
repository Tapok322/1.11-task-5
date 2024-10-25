using System.Threading.Tasks;

Console.WriteLine("Введите координаты пушки по Ox: ");
int x0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты пушки по Oy: ");
int y0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальную скорость снаряда: ");
int V0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угол вылета снаряда из пушки в градусах: ");
int a = Convert.ToInt32(Console.ReadLine());

double Vx0 = V0 * Math.Cos(a * Math.PI/180);
double Vy0 = V0 * Math.Sin(a * Math.PI/180);
int t = 1;
const double g = 9.81;
double xt = x0;
double yt = y0;
xt = x0 + Vx0 * t;
yt = y0 + Vy0 * t - g * Math.Pow(t, 2) / 2;
StreamWriter sw = new StreamWriter("C:\\Users\\prdb\\source\\repos\\Task_5\\Task_5.txt");
List<double> list_y = new List<double>();

list_y.Add(yt);

Console.WriteLine("x");
sw.WriteLine("x");
Console.WriteLine($"{xt:F3}");
sw.WriteLine($"{xt:F3}");
Console.WriteLine("y");
sw.WriteLine("y");
Console.WriteLine($"{yt:F3}");
sw.WriteLine($"{yt:F3}");

while (yt > 0)
{
    xt = x0 + Vx0 * t;
    yt = y0 + Vy0 * t - (g * Math.Pow(t, 2)) / 2;
    if (yt > 0)
    {
        t += 1;

        list_y.Add(yt);
        Console.WriteLine("x");
        sw.WriteLine("x");
        Console.WriteLine($"{xt:F3}");
        sw.WriteLine($"{xt:F3}");
        Console.WriteLine("y");
        sw.WriteLine("y");
        Console.WriteLine($"{yt:F3}");
        sw.WriteLine($"{yt:F3}");
    }

}

double[] y_array = list_y.ToArray();

Console.WriteLine($"Координата x траектории полета снаряда: {xt:F3}.");
sw.WriteLine($"Координата x траектории полета снаряда: {xt:F3}.");
Console.WriteLine($"Координата y траектории полета снаряда: {yt:F3}.");
sw.WriteLine($"Координата y траектории полета снаряда: {yt:F3}.");
Console.WriteLine($"Координаты наивысшей точки траектории: {y_array.Max():F3}.");
sw.WriteLine($"Координаты наивысшей точки траектории: {y_array.Max():F3}.");
sw.Close();
