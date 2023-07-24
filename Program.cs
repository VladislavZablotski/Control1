string[] array = new string[7];
int counter = 0;
for (int i=0; i<array.Length; i++)
{
    Console.WriteLine($"Введите строку {i+1}");
    array[i] = Console.ReadLine();
    if (array[i].Length<=3)
    {
        counter++;
    }
}
string[] array_sorted = new string[counter];
int j = 0;
int k = 0;
while (j<10)
{
    if (array[j].Length<=3)
    {
        array_sorted[k] = array[j];
        k++;
    }
    j++;
}
Console.WriteLine();
Console.WriteLine($"Исходный массив: {String.Join(",", array)}");
Console.WriteLine($"Отобранный массив: {String.Join(",", array_sorted)}");
