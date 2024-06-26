﻿namespace _04_Function
{
    internal class Program
    {
        static void OverloadingTest()
        {
            int num1 = 10, num2 = 3;

            int result = Calculator.Divide(num1, num2);

            Console.WriteLine($"{num1} / {num2} = {result}");   // 10 / 3 = 3

            int remainder;
            result = Calculator.Divide(num1, num2, out remainder);

            Console.WriteLine($"{num1} / {num2} = {result} ({remainder})"); // 10 / 3 = 3 (1)
        }

        static void OptionalParamTest()
        {
            OptionalParam.PrintMessage("안녕하세요."); // 안녕하세요.

            OptionalParam.PrintMessage("반갑습니다.", 3);
            /*  반갑습니다.
             *  반갑습니다.
             *  반갑습니다.
             */

            // 명명된 인수와 함께 사용
            OptionalParam.PrintDetails("홍길동", address: "한국");   // Name: 홍길동, Age: 0, Address: 한국
        }

        static void Main(string[] args)
        {
            OptionalParamTest();
        }
    }
}
