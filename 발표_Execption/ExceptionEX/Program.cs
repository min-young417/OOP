using System;

namespace ExceptionEX
{
    class Program
    {
        static void Main(string[] args)
        {
            //try~catch 예제
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                int index = 10;  // 유효하지 않은 인덱스
                
                //throw 예제
                if (index < 0 || index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException("유효하지 않은 인덱스입니다.");
                }

                int value = numbers[index];  // 예외 발생

                Console.WriteLine("값: " + value);  // 실행되지 않음
            }
            //when 예제
            catch (IndexOutOfRangeException ex) when (ex.Message == "유효하지 않은 인덱스입니다.")
            {
                Console.WriteLine("예외가 발생했습니다: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("다른 종류의 예외가 발생했습니다: " + ex.Message);
            }
            //finally 예제
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }
    }
}
