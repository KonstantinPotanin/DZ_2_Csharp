//Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TwoNumber(int num)
{
    int des = num / 10;
        
    int result = des % 10;
    return result;
}

Console.WriteLine("Введиде трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNum = TwoNumber(number);

Console.WriteLine($"Ввели число {number}, получили новое число {newNum}");
*/

//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Введиде число: ");
int num = Convert.ToInt32(Console.ReadLine()); //конвертируем строку в число
if (num >= 100)
{
    string str = num.ToString(); //конвертируем число в строку и выводим третий символ (второй индекс)
    char threechar = str[2];
    Console.WriteLine ("Третья цифра введёного числа: " + threechar);
}
else
{
    Console.WriteLine("Третьей цифра нет!");
}
*/

//Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void DaysWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("Этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DaysWeek (dayNumber);
*/