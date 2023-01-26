string message = "Введите число, до которого хотите посмотреть таблицу кубов:";
int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber))
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

int number = GetNumber(message);

for (int i = 1; i <= number; i++)
{
    Console.Write(i*i*i + ","); 
}
