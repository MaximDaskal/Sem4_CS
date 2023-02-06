
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow не использовать
double power_of (int a, int b)
{
    int c = b; // Запоминаем первоначальное значение b(это нужно для случая если b < 0)
    long res = 1;
    if(b<0) 
    {
        b = b*(-1);
    }

    for(int i =0; i<b; i++)
    {
        res=res*a;
    }
    if(c>=0) return res;
    else return Math.Round((1/(Convert.ToDouble(res))), 3);
}

Console.Write("Input base of degree: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input exponent: ");
int numB = Convert.ToInt32(Console.ReadLine());

double res = power_of (numA, numB);
Console.WriteLine($"{numA}^{numB} = {res}");


/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void sum_of_digits(int varA)
{
    Console.Write($"Сумма цифр числа {varA} -> ");
    if(varA<0) varA = varA*(-1);
    int res = 0;
    
    while(varA>0)
    {
        res = res + varA % 10;
        varA = varA / 10;
    }
    Console.Write($"{res}");    
}


Console.Write("Input your number: ");
int numA = Convert.ToInt32(Console.ReadLine());
sum_of_digits(numA);
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из произвольного колчества элементов и выводит их на экран.
void fill_array(int [] arryVar)// Заполняем массив значениями
{
    for(int i =0; i<arryVar.Length; i++)
    {
        Console.Write($"Array's Index = {i}. Input value: ");
        arryVar[i]= Convert.ToInt32(Console.ReadLine());
    }
    //return arryVar;
}

void printArray(int [] arryVar)// Выводим массив на экран
{
    Console.Write("Your Array is : [");
    for(int i =0; i<arryVar.Length; i++)
    {
        Console.Write($"{arryVar[i]}, ");
    }
     Console.Write("\b\b]");
}


Console.Write("Input array's size: ");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA>0)
{
    int [] myArray = new int[numA];
    fill_array(myArray);
    printArray(myArray);
}
else 
Console.WriteLine("Impossible number");
*/

