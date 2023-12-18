// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());
void GetNumbers (int numM, int numN)
{
    if (numM <= numN)
    {
        Console.Write(numM + " ");
        GetNumbers(numM +1, numN);
    }
}
GetNumbers (numberM, numberN);
