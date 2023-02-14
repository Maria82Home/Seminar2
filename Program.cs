//Task1. Убирает из рандомного трехзначного числа второй символ.

/*int CutNumber(int num)
{ 
  int hundreds = num / 100;
  int units = num % 10;
  int result = hundreds * 10 + units;
  return result;
}

int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);
Console.Write($"New version of {randNumber} is {newNumber}");
*/

//Task2. Определяет кратно ли число a и b.

/*bool IsMultiplied(int num, int div1, int div2)
{
  if(num % div1 == 0 && num % div2 == 0)
    return true;
  else
    return false;
}

/*bool IsMultipliedBest(int num, int div1, int div2)
{
  return num % div1 == 0 && num % div2 == 0;
}


Console.Write("Input number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplied(number,divider1,divider2);
if(result)
  Console.WriteLine($"Your number {number} is divisible by {divider1} and {divider2}");
else
  Console.WriteLine($"Your number {number} is not divisible by {divider1} and {divider2}");
*/

//Task3. Написать программу, которая выводит случайное двухзначное число и показывает наибольшую цифру числа.
/*
int GetMaxNumber(int num)
{
  int dozens = num/10;
  int units = num % 10;
  if (dozens>=units)
    return dozens;
  else
    return units;
}

int randNumber = new Random().Next(10,100);
Console.WriteLine($"Random number is {randNumber}, maximum inut is {GetMaxNumber(randNumber)}");
*/

//Task4. Написать программу, которая запрашивает два числа и проверяет является ли одно квадратом другого.
/*
bool IsSquare(int num1, int num2)
{
  return num1 == num2*num2 | num2 == num1*num1;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(num1,num2));*/