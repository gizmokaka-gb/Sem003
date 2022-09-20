// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int number = int.Parse(num);

void Palindrome(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else
        Console.WriteLine($"Число {num} не является палиндромом.");
}
if (num.Length == 5)
{
    Palindrome(num);
}
else Console.WriteLine($"Вы ввели не пятизначное число");
