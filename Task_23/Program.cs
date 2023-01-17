// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Метод получения кубов чисел

void GetCubes(int[] number)
{
    int length = number.Length;

    for (int i = 1; i < length; i++)
    {
        number[i] = i * i * i;
    }
}

// Метод печати массива на экран

void PrintArray(int[] coll)
{
    int result = coll.Length;

    for (int i = 1; i < result; i++)
    {
        Console.Write(coll[i] + " ");
    }
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

int[] arr = new int[number + 1];
GetCubes(arr);
PrintArray(arr);