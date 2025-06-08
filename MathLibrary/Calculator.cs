namespace MathLibrary;


public static class Calculator
{

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("لا يمكن القسمة على صفر");
        return a / b;
    }

    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }

   
}