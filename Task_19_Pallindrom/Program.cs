string message = "Введите 5 значное число:";
int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 9999 && resultNumber < 100000)
        {
        break;
        }
        else
        {
            Console.WriteLine("ВВели не число или не коректное число. Повторите ввод.");
        }
    }
    return resultNumber;
}

int forWorkMethod = GetNumber(message);

int WorkMethod(int forWorkMethod)
{
    if (forWorkMethod / 10000 == forWorkMethod % 10 && forWorkMethod/1000%10 == forWorkMethod/10%10)
    {
        Console.WriteLine("Это палиндром");
    }
    else 
    {
        Console.WriteLine("Это не палиндром");
    }
    return forWorkMethod;
}
int Checkout = WorkMethod(forWorkMethod);



