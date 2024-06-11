using System;

namespace EX9_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool validOption = false;
            while (!validOption)
            {
                try
                {
                    Console.WriteLine("a. Đảo ngược chuỗi");
                    Console.WriteLine("b. Đếm số lượng từ trong chuỗi");
                    Console.Write("Chọn một tùy chọn: ");

                    char option = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (option)
                    {
                        case 'a':
                            // Đảo ngược chuỗi
                            ReverseString();
                            validOption = true;
                            break;
                        case 'b':
                            // Đếm số lượng từ trong chuỗi
                            CountWords();
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Tùy chọn không hợp lệ.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Console.WriteLine("Vui lòng thử lại.");
                }
            }
        }

        // a. Đảo ngược chuỗi
        static void ReverseString()
        {
            try
            {
                Console.Write("Nhập chuỗi kí tự: ");
                string input = Console.ReadLine();

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);

                string reversedString = new string(charArray);
                Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                Console.WriteLine("Vui lòng thử lại.");
            }
        }

        // b. Đếm số lượng từ trong chuỗi
        static void CountWords()
        {
            try
            {
                Console.Write("Nhập chuỗi kí tự: ");
                string input = Console.ReadLine();

                string[] words = System.Text.RegularExpressions.Regex.Split(input, @"\W+");
                int wordCount = words.Length;

                Console.WriteLine($"Số lượng từ trong chuỗi: {wordCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                Console.WriteLine("Vui lòng thử lại.");
            }
        }
    }
}
