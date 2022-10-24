
void FillArray(int[] array, int min, int max)   
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}

int MinValue (int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}

int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];

    return max;
}

void SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    Console.WriteLine(sum);
}

void MultiplicationArray(int[] array)
{
    int mult = 1;
    for (int i = 0; i < array.Length; i++)
        mult *= array[i];
    Console.WriteLine(mulriplication);
}

int IndexElement(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == N)
        {
            return i;
        }
    return -1;
}

bool ElementArray(int[] array, int value)
{
    bool x = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value) x = true;
    if (x == true) Console.WriteLine("Нашли число в массиве");
    else Console.WriteLine("Не нашли число в массиве");
    return x;
}

void MeanArray(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum = (sum + array[i]);
    Console.WriteLine(sum / array.Length);
}

int NegativeElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) count++;
    return count;
}

int Count(int[] array, int a)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == a) count++;
    return count;
}

void ChetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine(count);
}

int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

void NechetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) count++;
    Console.WriteLine(count);
}

bool SortArray(int[] array)
{
    bool sort = true;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[i - 1]) sort = false;
    if (sort == false) Console.WriteLine();
    else Console.WriteLine();
    return sort;
}

Console.WriteLine("Размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(); 
int[] array = new int[size];


FillArray(array, 0, 10);
Console.WriteLine("Массив:   ");


PrintArray(array);
Console.WriteLine();
Console.WriteLine();


int minvalue = MinValue(array);
Console.WriteLine("Минимальное значение: " + minvalue);
Console.WriteLine();


int maxvalue = MaxValue(array);
Console.WriteLine("Максимальное значение: " + maxvalue);
Console.WriteLine();


Console.WriteLine("Сумма элементов массива:");
SumArray(array);
Console.WriteLine();


Console.WriteLine("Произведение элементов массива:");
MultiplicationArray(array);
Console.WriteLine();


Console.WriteLine("Введите искомый элемент  массива:  (ищем индекс)");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int result = IndexElement(array, N);
Console.WriteLine($"Заданный элемент массива соответсвует индексу {result}");
Console.WriteLine();


Console.WriteLine("Проверим, есть ли число в массиве? Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
bool elementArray = ElementArray(array, value);
Console.WriteLine(elementArray);
Console.WriteLine();


Console.WriteLine("Среднее арифметическое элеметов массива:");
MeanArray(array);
Console.WriteLine();


int NegElements = NegativeElements(array);
Console.WriteLine("Кол-во отрицательных элементов в массиве: " + NegElements);
Console.WriteLine();


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int count = Count(array, a);
Console.WriteLine($"Заданное число встречается в массиве {count} раз.");
Console.WriteLine();


Console.WriteLine("Кол-во четных элементов в массиве:");
ChetElement(array);
Console.WriteLine();


int PosElements = PositiveElements(array);
Console.WriteLine("Кол-во положительных элементов в массиве: " + PosElements);
Console.WriteLine();


Console.WriteLine("Кол-во нечетных элементов в массиве:");
NechetElement(array);
Console.WriteLine();

Console.WriteLine("является ли массив отсортированным по возрастанию? ");
bool sortArray = SortArray(array);
Console.WriteLine(sortArray);
Console.WriteLine();

