using System;
public class Answer {
static void CheckDivisibility(int firstNumber, int secondNumber)
{
    Console.Write("Введите целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int result=num1%num2
        if (result==0)
        {
            Console.WriteLine("делится");
        }
    else
    {
        Console.WriteLine("не делится");
    }
}
static public void Main(string[] args) {
int firstNumber, secondNumber;
if (args.Length >= 2) {
firstNumber = int.Parse(args[0]);
secondNumber = int.Parse(args[1]);
} else {
firstNumber = 10;
secondNumber = 2;
}
CheckDivisibility(firstNumber, secondNumber);
}
}
