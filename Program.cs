﻿Console.WriteLine("Задайте количество элементов в первом массиве:");
int lengthOfFirstArray = int.Parse(Console.ReadLine());

string[] arrayFirst = new string[lengthOfFirstArray];

for (int i = 0; i < arrayFirst.Length; i++)
{
    Console.WriteLine("Задайте элемент первого массива в виде слова, символа или числа:");
    string userString = Console.ReadLine();
    arrayFirst[i] = userString;
}
