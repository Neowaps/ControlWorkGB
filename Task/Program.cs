System.Console.Write("Введите количество строк: ");
int countArr = Convert.ToInt32(Console.ReadLine());
string[] array = new string[countArr];
void FillArray()
{
    for (int i = 0; i < countArr; i++)
    {
        System.Console.Write($"Введите {i + 1}'ю строку: ");
        array[i] = Console.ReadLine();
    }
}
