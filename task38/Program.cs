// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.



Console.Clear();
int[] array = new int[4];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($" {array[i]} ");
}
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.Write($"] Разность максимального и минимального элементов массива: {max - min}");