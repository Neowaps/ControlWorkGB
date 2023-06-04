System.Console.Write("Введите количество строк: ");
int countArr = Convert.ToInt32(Console.ReadLine());
int limit = 3;

void FillArray(string[] arrayFill)
{
    for (int i = 0; i < arrayFill.Length; i++)
    {
        System.Console.Write($"Введите {i + 1}'ю строку: ");
        arrayFill[i] = Console.ReadLine();
    }
}

string[] FormArray(string[] arrayIncome)
{
    string[] arrayForm = new string[arrayIncome.Length];
    int count = 0;
    for (int i = 0; i < arrayIncome.Length; i++)
    {
        if (arrayIncome[i].Length <= limit)
        {
            arrayForm[count] = arrayIncome[i];
            count++;
        }
    }
    return arrayForm;
}

void PrintArray(string[] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        System.Console.Write(arrayPrint[i] + " ");
    }
}

string[] array = new string[countArr];
FillArray(array);
System.Console.Write("Вы ввели массив:");
PrintArray(array);
System.Console.WriteLine();
string[] newArray = new string[countArr];
newArray = FormArray(array);
System.Console.Write("Сформированный массив: ");
PrintArray(newArray);
