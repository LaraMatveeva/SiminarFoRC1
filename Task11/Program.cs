// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int number1, int number2)
{
     return number1 % number2 == 0;
}

int MultiplicitySecond (int number1, int number2)
{ 
    return number1 % number2;
}

// bool result = Multiplicity(num1, num2);
// Console.WriteLine(result ? "Первое число кратно второму" : $"Некратно, остаток = {num1 % num2}" );

int result2 = MultiplicitySecond(num1, num2);
Console.WriteLine(result2 == 0 ? "Первое число кратно второму" : $"Некратно, остаток = {result2}" );