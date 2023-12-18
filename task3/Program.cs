// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Задаем массив
int[] FillArray(int[] arr)
{
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(1, 100);
}
return arr;
}
void PrintArray(int[] arr)
{
foreach (int item in arr) System.Console.Write(item + " ");
System.Console.WriteLine();
}
// Выводим элементы массива в обратном порядке с помощью рекурсии
void PrintMassiv(int[] arr, int i)
{
if (i >= 0)
    Console.Write(arr[i] + " ");
    PrintMassiv(arr, i-1);
}
System.Console.WriteLine("Введите количество элементов");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
array = FillArray(array);
System.Console.WriteLine("Сформированный массив");
PrintArray(array);
Console.WriteLine();
System.Console.WriteLine("Перевернутый массив");
PrintMassiv(array, (array.Length-1));
