// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Dot(Lines dir)
{
    double x = (dir.b2 - dir.b1)/(dir.k1 - dir.k2);
    double y = dir.k1 * x + dir.b1;
    Console.WriteLine($"Точка пересечения прямых y = {dir.k1}x + {dir.b1} и y = {dir.k2}x + {dir.b2} является точка ({x} ; {y})");    
}
Lines direct = new Lines();

direct.b1 = GetNumber("Введите значение для b1: ");
direct.k1 = GetNumber("Введите значение для k1: ");
direct.b2 = GetNumber("Введите значение для b2: ");
direct.k2 = GetNumber("Введите значение для k2: ");

Dot(direct);


class Lines
{
    public double b1 {get; set;}
    public double k1 {get; set;}
    public double b2 {get; set;}
    public double k2 {get; set;}
}
