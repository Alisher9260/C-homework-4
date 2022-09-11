// задача 25 написать программу которая принимает на вход числа а выдает
// и возводит число в нутуральноую степень B
/*int FindStep(int numberA,int NumberB)
{

     int st = numberA;
    for (int current  = 1; current < NumberB;current++)
    {
        st= st*numberA;
    }
    return st;
}
Console.Write ("введите число 1 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("введите число 2 ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ($" число {a} в степени {b} равно {FindStep(a,b)}");*/

// задача 27 написать программу которая принимает на вход числа а выдает
// cумму цифр в числе
/* int FindSum(int number)
{
    int size = 0;

    while (number> 0)
       {
        size= size + number % 10;
        number = number/10;
       }
    return size;
}
Console.Write ("input positive integer number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ($"number of digits of number {a} is  {FindSum(a)}");*/

// задача 29  написать программу которая задает массив
// из 8 элементов и выводит их на экран

/*int[] CreateArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    for (int i =0; i < size;i++) 
        newArray[i] = new Random().Next (minValue, maxValue);

        return newArray; 
}

void Showarray( int[] array)
{
     for (int i = 0; i < array.Length;i++)
     Console.Write (array [i] + " " );

     Console.WriteLine();
}
Showarray(CreateArray(5,0,19));*/