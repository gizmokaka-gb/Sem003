Console.WriteLine("Введите координату X1: ");

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");


int A = x2 - x1;
int B = y2 - y1;


double length = Math.Sqrt(A * A + B * B );
Console.WriteLine($"Длинна отрезка {length}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}