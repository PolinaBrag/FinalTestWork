Console.WriteLine("Задайте количество элементов в первом массиве:");
int lengthOfFirstArray = int.Parse(Console.ReadLine());

string[] arrayFirst = new string[lengthOfFirstArray];

for (int i = 0; i < arrayFirst.Length; i++)
{
    Console.WriteLine("Задайте элемент первого массива в виде слова, символа или числа:");
    string userString = Console.ReadLine();
    arrayFirst[i] = userString;
}

string[] arraySecond = new string[arrayFirst.Length];
int maxLengthOfString = 3;

for (int i = 0; i < arrayFirst.Length; i++)
{
    if (arrayFirst[i].Length <= maxLengthOfString)
    {
        arraySecond[i] = arrayFirst[i];
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] != null)
            {
                Console.Write($" \"{array[i]}\" ");
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
    }
    Console.Write("]");
}

PrintArray(arrayFirst);
Console.Write(" => ");
PrintArray(arraySecond);

