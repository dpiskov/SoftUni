double length = double.Parse(Console.ReadLine());
double width =double.Parse(Console.ReadLine());

double area = PrintArea(length, width);

Console.WriteLine(area);

static double PrintArea(double length, double width)
{
    return length * width;
}