// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine ("Ведите число:");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = 1;
int count = 1;

while (ostatok > 0) //  Подсчет разрядности входящего числа
{
   ostatok = number/Step (count);
   count ++; 
}

int Step (int stepenchisla) // Возведение в степень
{
    int stepen = 1;
    int i = 1;
    while (i <= stepenchisla)
      {
        stepen = stepen * 10;
        i++;
      }
        return stepen;

}
count = count - 1; //  разрядность числа 

if (count > 2) 
 {
  int digit3 = number / Step ((count - 3)) % 10; 
  Console.WriteLine (digit3);
 }

else
{
  Console.WriteLine ("Третьей цифры нет");  
}
