// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {1, 6, 8, 4, 7};
int size = array.Length;

void ShowArray ( int[] array, int size)
{
    if (size == 0)
    {
        Console.Write(array[size]);
        return;
    }
    Console.Write(array[size]);
    ShowArray(array, size - 1);
}

ShowArray(array, size - 1);

