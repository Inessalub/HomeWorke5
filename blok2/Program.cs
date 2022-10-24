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
Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("В какую степень возвести число?: ");
int stp = int.Parse(Console.ReadLine() ?? "0");
int stepen = Stepen(stp, number);
Console.WriteLine($"Число {number} в степени {stp} равно {stepen}");

// 2. Функцию, которая вычисляет факториал числа n

void Factorial(int x)
{
    int factorial = 1;
    for (int i = 1; i <= x; i++)
        factorial *= i;
    Console.WriteLine(factorial);
}
Console.WriteLine("Введите число искомого факториала: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа {x} равен ");
Factorial(x);

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
Random rand = new Random();
int n = rand.Next(0, 1000);
Console.WriteLine($"Сумма чисел в числе {n}");
SumNumeral(n); 

// 4. Функцию, которая проверяет является ли заданное число n полиндромом
bool Polindrome(string number)
{
    for (int i = 0; i < number.Length / 2; i++)

        if (number[i] != number[number.Length - i - 1])
            return false;
    return true;
}
Console.Write("Введите число и узнаем, является ли оно полиндромом ");
int number = int.Parse(Console.ReadLine() ?? "0");
string num = number.ToString();
bool polindrom = Polindrome(num);
Console.WriteLine(polindrom);

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

bool Number(int n)
{
    for (int i = 2; i < n; i++)

        if (n % i == 0) return false;

    return true;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Число простое? ");
bool num = Number(n);
Console.WriteLine(num);

// 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool ChetNumber(int number)
{
    bool n = false;
    if (number % 2 == 0) n = true;
    if (n == true) Console.WriteLine();
    else Console.WriteLine();
    return n;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Число четное? ");
bool chetnumber = ChetNumber(number);
Console.WriteLine(chetnumber);