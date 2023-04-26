// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Укажите количество вводимых чисел");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите число");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(String.Join(", ",arr));

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество положительных чисел: "+count);