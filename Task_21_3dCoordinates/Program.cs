int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber !=0)
        {
        break;
        }
        else
        {
            Console.WriteLine("ВВели не коректное число или не число. Повторите ввод.");
        }
    }
    return resultNumber;
}

double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return result;
}

int ax = GetNumber("Введите координату x1");
int bx = GetNumber("Введите координату y1");
int az = GetNumber("Введите координату z1");

int ay = GetNumber("Введите координату x2");
int by = GetNumber("Введите координату y2");
int bz = GetNumber("Введите координату z2");

double distance = GetDistance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между ({ax},{ay},{az}) и ({bx},{by},{bz}) is {distance}");