// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] initial = { "dust", "cat", "error", "dog", "8936", "$$", "may" };
int count = 0;
for (int i = 0; i < initial.Length; i++)
{
    if (initial[i].Length <= 3)
    {
        count++;
    }
}
string[] final = new string[count];
int j = 0;
for (int i = 0; i < 7; i++)
{
    if (initial[i].Length <= 3)
    {
        final[j] = initial[i];
        j++;
    }
}
    for (int i = 0; i < final.Length; i++)
    {
        System.Console.Write($"{final[i]} ");
    }
