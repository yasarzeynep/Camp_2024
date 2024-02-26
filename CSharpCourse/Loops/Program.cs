
//ForLoop();
//WhileLoop();
//DoWhileLoop();ForeachLoop();

if(IsPrimeNumber(7))
    Console.WriteLine("This is a prime Number");
else
    Console.WriteLine("This is not a prime Number");

#region for-loop
static void FoorLoop()
{
    for (int i = 0; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
}
#endregion

#region while-loop
static void WhileLoop()
{
    int number = 100;

    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;

    }
}
#endregion
#region do-while-loop
static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;

    } while (number >= 0);
    Console.ReadLine();
}
#endregion
#region foreach-loop
static void ForeachLoop()
{
    string[] students = new string[3] { "Engin", "Derin", "Salih" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}
#endregion

 static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}