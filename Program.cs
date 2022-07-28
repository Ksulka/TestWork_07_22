// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Print(string[] array)
{
    int check = array.Length;
    for (int i = 0; i < check; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введитете любые 10 строк через Enter");
string[] inputArr = new string[10];
for (int i = 0; i < inputArr.Length; i++)
{
    inputArr[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Массив из строк, введеных вами:");

Print(inputArr);
int count = 0;
for (int i = 0; i < inputArr.Length; i++)
{
    if (inputArr[i].Length <= 3) count++;
}
if (count == 0)
{
    Console.WriteLine("В заданном массиве нет строк, длина которых меньше либо равна 3.");
}
else
{
    string[] outputArr = new string[count];
    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= 3)
        {
            outputArr[outputArr.Length - count] = inputArr[i];
            count--;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам ");

    Print(outputArr);
}