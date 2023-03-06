// 2. Растояние между точками в 2Д пространстве

double dis(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
}
Console.WriteLine(dis(3, 6, 2, 1));