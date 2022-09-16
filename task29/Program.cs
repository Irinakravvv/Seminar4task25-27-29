// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.


Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 число");
int num4 = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Введите 5 число");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 6 число");
int num6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 7 число");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 8 число");
int num8 = Convert.ToInt32(Console.ReadLine());

int[] array = {num1, num2, num3, num4, num5, num6, num7, num8};

Console.WriteLine($"[{string.Join(", ", array)}]");

