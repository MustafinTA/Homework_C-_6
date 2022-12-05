// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целые числа: ");

int[] array = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', '.', ',' },
StringSplitOptions.RemoveEmptyEntries), int.Parse);

System.Console.WriteLine(GetCount(array));

int GetCount(int[] arr)
{
int count = 0;
foreach (var item in array)
{
    if (item > 0) count++;
}
return count;
}
