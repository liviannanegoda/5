//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine($"Введите длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine());
int startArray = GetArray(ElementNumbers,-200, 200);

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {startArray}");

int GetArray(int ElementNumbers, int minValue, int maxValue)
{
    int[] res = new int[ElementNumbers];
    int sumElements = 0;
    Console.Write("Получившийся массив: ");
    
    

    for (int i = 0; i < ElementNumbers; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write(res[i] + " ");
        {
            if (i % 2 != 1)
            {
                sumElements = sumElements + res[i];
            }
        }

    }
    return sumElements;
}





