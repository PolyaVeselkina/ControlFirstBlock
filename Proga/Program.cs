// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void PrintArray (string [] array1)
{
    for (int i = 0; i < array1.Length; i ++)
        Console.Write (array1[i] + "  ");
    Console.WriteLine();
}


string [] CreateNewArray (string [] array2)
{
    string [] newArray1 = new string [array2.Length];
    int newI = 0;

    for (int i = 0; i < array2.Length; i ++)
    {
        if (array2[i].Length <= 3)
        {
            newArray1[newI] = array2[i];
            newI ++;
        }
    }
    return newArray1;
}


string [] array = {"Привет!", ":-)", "28", "Ла-ла", "^-^", "&"};
PrintArray (array);

string [] newArray = CreateNewArray(array);
PrintArray (newArray);
