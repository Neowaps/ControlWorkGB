System.Console.Write("Введите количество строк: ");
int countArr = Convert.ToInt32(Console.ReadLine());
int limit = 3;
string[] array = new string[countArr];
void FillArray()
{
    for (int i = 0; i < countArr; i++)
    {
        System.Console.Write($"Введите {i + 1}'ю строку: ");
        array[i] = Console.ReadLine();
    }
}

void FormArray(string[] arrayForm)
{
    for (int i = 0; i < countArr; i++)
    {
        if (array.Length <= limit)
        {
            int count = 0;
            arrayForm[count] = array[i];
            count++;
        }
    }
}