//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] InputArray (int number)
{
    int [] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int newNumber = Convert.ToInt32(Console.ReadLine());
        array[i] = newNumber;
    }
    return array;
} 

int Result(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

int numberM = GetInfo("Введите колличество чисел, которые хотите проверить: ");
int [] array = InputArray(numberM);
int result = Result(array);

Console.WriteLine($"[{string.Join(", ", array)}] - > {result}");


