using System;

namespace EX8_OOP
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
                    Console.WriteLine("a. Hiển thị bảng mã ASCII");
                    Console.WriteLine("b. Hiển thị bảng mã UTF-8 của trang mã 65001");
                    Console.WriteLine("c. Phát tiếng beep khi nhấn phím space");
                    Console.WriteLine("d. Đếm số lần xuất hiện của mỗi kí tự trong chuỗi");
                    Console.Write("Chọn một tùy chọn (a-d): ");

                    char option = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (option)
                    {
                        case 'a':
                            // Hiển thị bảng mã ASCII
                            DisplayASCIITable();
                            validOption = true;
                            break;
                        case 'b':
                            // Hiển thị bảng mã UTF-8 của trang mã 65001
                            DisplayUTF8Table();
                            validOption = true;
                            break;
                        case 'c':
                            // Phát tiếng beep khi nhấn phím space
                            BeepOnSpace();
                            validOption = true;
                            break;
                        case 'd':
                            // Đếm số lần xuất hiện của mỗi kí tự trong chuỗi
                            CountCharacterOccurrences();
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

        // a. Hiển thị bảng mã ASCII
        static void DisplayASCIITable()
        {
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine($"ASCII {i}: {(char)i}");
            }
        }

        // b. Hiển thị bảng mã UTF-8 của trang mã 65001
        static void DisplayUTF8Table()
        {
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine($"UTF-8 {i}: {(char)i}");
            }
        }

        // c. Phát tiếng beep khi nhấn phím space
        static void BeepOnSpace()
        {
            Console.WriteLine("Nhấn phím space để phát tiếng beep");
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Beep();
                }
            }
        }

        // d. Đếm số lần xuất hiện của mỗi kí tự trong chuỗi
        static void CountCharacterOccurrences()
        {
            Console.Write("Nhập chuỗi kí tự: ");
            string input = Console.ReadLine();

            var charCount = new int[128];

            foreach (char c in input)
            {
                charCount[c]++;
            }

            for (int i = 0; i < 128; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine($"Kí tự {(char)i} xuất hiện {charCount[i]} lần.");
                }
            }
        }
    }
}
