// Программа, которая из имеющегося массива строк формирует массив строк в 3 и менее элемента

void NewArray (string [] arr)
{
    for (int x = 0; x < arr.Length; x++)
    {
        Console.Write(arr[x]+"  ");
    }
}

string [] FillArray (string [] arr)
{
    string [] newarray = new string [arr.Length];
    int variable = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarray[variable] = arr[i];
            variable++;
        }
    }
    return newarray;
}

Console.Write("Длинна массива: ");
int number = Convert.ToInt32(Console.ReadLine());
string [] array = new string [number];
for (int i = 0; i < number; i++)
{
   Console.Write($"ведите {i+1} элемент массива:  ");
   array[i] = Console.ReadLine();
   }

Console.WriteLine("Массив слов в 3 и менее элемента :");
NewArray(FillArray(array));