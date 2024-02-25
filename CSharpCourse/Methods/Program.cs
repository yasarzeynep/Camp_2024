

public class Program
{
    private static void Main(string[] args)
    {//Add();
     //Add();
     //Add();
     //var result = Add2(10);
     //Console.WriteLine(result);

        //int number1 ;
        //int number2 =100;
        //var result2 = Add3(out number1, number2);
        //Console.WriteLine(result2);
        //Console.WriteLine(number1);
        //Console.ReadLine();

        //Console.WriteLine(Multiply(2, 4));
        //Console.WriteLine(Multiply(2, 4, 3));

        Console.WriteLine(Add4( 2, 3, 6, 8, 7));
        Console.ReadLine();

    }
    static void Add()
    {
        Console.WriteLine("Add! ");
    }
    static int Add2(int number1, int number2 = 40)
    {
        var result = number1 + number2;
        return result;
    }

    #region ref- out
    //out methodun içinde bir kere set edlmesi gerekiyor
    static int Add3(out int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;

    }
    #endregion

    #region method onerloading
    //out methodun içinde bir kere set edlmesi gerekiyor
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
    #endregion

    #region params keyword
    //parantez içinde params son paramaetre olarak tanımlanmalı
    public static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }
    #endregion
}

