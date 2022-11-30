// Перевод десятичного числа в двоичное

Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertToBin(int num)
{
    string str = string.Empty;
    while (num > 0)
    {
        str = num % 2 + str;
        num = num / 2;
    }
    return str;
}

string newNumberBin = ConvertToBin(number);
Console.WriteLine($"Преобразованное двоичное число равно {newNumberBin}");
