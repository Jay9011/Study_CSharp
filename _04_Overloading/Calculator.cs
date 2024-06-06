namespace _04_Function;

internal static class Calculator
{
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static int Divide(int a, int b, out int remainder)
    {
        remainder = a % b;
        return a / b;
    }

    public static int Divide(int a, int b, int c)   // C#에서는 `out` 키워드 또한 메서드 시그니처에 포함됨
    {
        return a / b;
    }
    // public static int Divide(int b, int a)   // 매개변수의 이름은 메서드의 시그니처에 포함되지 않음
    // {
    //     return b / a;
    // }
}