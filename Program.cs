// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Print(string[] array) //метод печати массива в консоль
{
    int check = array.Length;
    for (int i = 0; i < check; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введитете любые 10 строк через Enter");
string[] inputArr = new string[10]; // задаю исходный массив, решив что пусть он будет из 10 строк 
for (int i = 0; i < inputArr.Length; i++) // ввод строк в массив с клавиатуры из консоли
{
    inputArr[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Массив из строк, введеных вами:");

Print(inputArr);
int count = 0;
for (int i = 0; i < inputArr.Length; i++) //подсчет количества строк, удовл.условию задачи
{
    if (inputArr[i].Length <= 3) count++;
}
if (count == 0)
{
    Console.WriteLine("В заданном массиве нет строк, длина которых меньше либо равна 3.");
}
else
{
    string[] outputArr = new string[count]; //задаю итоговый массив
    for (int i = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= 3)
        {
            outputArr[outputArr.Length - count] = inputArr[i]; //добавление строк из исходного массива в итоговый, удовл.усл.задачи
            count--;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам ");

    Print(outputArr);
}