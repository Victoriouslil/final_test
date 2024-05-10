// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] EnteringOfArray()
{
    Console.WriteLine("Введите количество строк массива: ");
    int count = int.Parse(Console.ReadLine());

    string[] newArray = new string[count];

    Console.WriteLine($"Введите {count} строк:");
    for (int i = 0; i < count; i++)
    {
        newArray[i] = Console.ReadLine();
    }

    return newArray;
}

string[] CreateArrayWithLessThanThreeSymbols(string[] newArray)
{
    int count = 0;
    foreach (string item in newArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];

    int i = 0;

    foreach (string item in newArray)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}
