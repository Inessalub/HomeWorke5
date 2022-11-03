
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}
// Поиск минимума
int MinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}
// Поиск максимума
int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];

    return max;
}
// Поиск суммы элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];

    return sum;
}
// Поиск произведения элементов массива
int MultArray(int[] array)
{
    int mult = 1;
    for (int i = 0; i < array.Length; i++)
        mult *= array[i];
    return mult;
}
//Поиск индекса заданного элемента в массиве, если такого элемента в массиве 
//нет то возвращать -1
int IndexElement(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == N)
        {
            return i;
        }
    return -1;
}
// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть,
//false – нет.
bool ElementArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number) return true;
    return false;
}
// Среднее арифметическое элеметов массива
double Avg(int[] array)
{
    return SumArray(array) / array.Length;
}

// Подсчёт количества отрицательных элементов массива
int NegativeElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) count++;
    return count;
}
// Подсчёт количества положительных элементов в массиве
int PositiveElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}
// Подсчёт количества вхождений элемента в массив
int Count(int[] array, int ara)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == ara) count++;
    return count;
}
// Подсчёт количества чётных элементов в массив
int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

// Подсчёт количества нечётных элементов в массиве
int UnevenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) count++;
    return count;
}
// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[i - 1]) return false;
    return true;
}

// II. Реализовать следующие функции:
// 1. Функцию, которая вычисляет число a в степени 

int Stepen(int stp, int number)
{
    int count = 0;
    int newnumber = 1;
    for (int i = 0; i < stp; i++)
        if (count < stp) newnumber *= number;
    count++;
    return newnumber;
}
// 2. Функцию, которая вычисляет факториал числа n

int Factorial(int x)
{
    int factorial = 1;
    for (int i = 1; i <= x; i++)
        factorial *= i;
    return factorial;
}

// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n

void SumNumeral(int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
        if (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
    Console.WriteLine(sum);
}


// 4. Функцию, которая проверяет является ли заданное число n полиндромом
bool Polindrome(string num)
{
    bool res = true;
    for (int i = 0; i < num.Length / 2; i++)

        if (num[i] != num[num.Length - i - 1])
            res = false;
    return res;
}

// 5. Функцию, складывающую два целых числа
void SumNumbers(int a, int b)
{
    int number = 0;
    if (a % 1 == 0 && b % 1 == 0) number = a + b;
    Console.WriteLine(number);
}
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел {a} и {b} равна: ");
SumNumbers(a, b);

// 6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false

bool Number(int com)
{
    int i = 2;
        if (com % i == 0) return true;

    return false;
}

// 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool EvenyNumber(int axa)
{
    if (axa % 2 == 0) return true;
    return false;
}


//III. Вызвать и проверить работу всех вышеуказанных фукнций

Console.WriteLine("Размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[] array = new int[size];


FillArray(array, 0, 100);
Console.WriteLine("Массив:  ");
Console.Write(array);


PrintArray(array);
Console.WriteLine();
Console.WriteLine();


int minvalue = MinValue(array);
Console.WriteLine($"Минимальное значение: {MinValue(array)}");
Console.WriteLine();


int maxvalue = MaxValue(array);
Console.WriteLine($"Максимальное значение: {MaxValue(array)}");
Console.WriteLine();


Console.WriteLine($"Сумма элементов массива: {SumArray(array)}");
Console.WriteLine();


Console.WriteLine($"Произведение элементов массива: {MultArray(array)}");
Console.WriteLine();


Console.WriteLine("Введите искомый элемент  массива:  ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.WriteLine($"Заданный элемент массива соответсвует индексу {IndexElement(array, N)}");
Console.WriteLine();


Console.WriteLine("Проверим, есть ли число в массиве? Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{ElementArray(array, value)}");
Console.WriteLine();


Console.WriteLine($"Среднее арифметическое элеметов массива: {Avg(array)}");
Console.WriteLine();


Console.WriteLine($"Кол-во отрицательных элементов в массиве: {NegativeElement(array)}");
Console.WriteLine();

Console.WriteLine($"Кол-во положительных элементов в массиве: {PositiveElement(array)}");
Console.WriteLine();



Console.WriteLine("Введите число: ");
int ara = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Заданное число встречается в массиве {Count(array, ara)} раз");
Console.WriteLine();


Console.WriteLine($"Кол-во четных элементов в массиве {EvenNumber(array)}");
Console.WriteLine();

Console.WriteLine($"Кол-во нечетных элементов в массиве {UnevenNumber(array)}");
Console.WriteLine();

Console.WriteLine("является ли массив отсортированным по возрастанию ");
Console.WriteLine($"({SortArray(array)})");

Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("В какую степень возвести число?: ");
int stp = int.Parse(Console.ReadLine() ?? "0");
int stepen = Stepen(stp, number);
Console.WriteLine($"Число {number} в степени {stp} равно {stepen}");

Console.WriteLine("Введите число искомого факториала: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int factorial = Factorial(x);
Console.WriteLine($"Факториал числа {x} равен " + factorial);

Random rand = new Random();
int n = rand.Next(0, 1000);
Console.WriteLine($"Сумма чисел в числе {n}");
SumNumeral(n);


Console.Write("Введите число и узнаем, является ли оно полиндромом ");
int numberz = int.Parse(Console.ReadLine() ?? "0");
string num = numberz.ToString();
bool polindrom = Polindrome(num);
Console.WriteLine(polindrom);

Console.WriteLine("Введите число: ");
int com = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Число простое? ");
bool numbera = Number(n);
Console.WriteLine(numbera);

Console.WriteLine("Введите число: ");
int axa = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число четное?  {EvenyNumber(axa)}");