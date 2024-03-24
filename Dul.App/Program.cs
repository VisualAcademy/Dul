using System;

namespace Dul.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1] Creator 호출 테스트
            Console.WriteLine(Dul.Creator.GetName());

            //[2] Math 호출 테스트
            Console.WriteLine(Dul.Math.Abs(-1234));

            //[3] StringLibrary 호출 테스트
            Console.WriteLine("안녕하세요.".CutStringUnicode(6));

            //[1] Creator 호출 테스트
            Console.WriteLine(Creator.GetName());

            //[2] Math 호출 테스트
            Console.WriteLine(Dul.Math.Abs(-1234)); // System.Math와 Dul.Math 충돌 방지

            //[3] StringLibrary 호출 테스트
            Console.WriteLine("안녕하세요.".CutStringUnicode(6));

            //[4] DateTimeUtility 호출 테스트
            Console.WriteLine(DateTimeUtility.ShowTimeOrDate(DateTime.Now));
        }
    }
}
