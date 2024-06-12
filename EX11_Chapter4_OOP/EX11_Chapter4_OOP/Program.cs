using System;
using System.IO;

namespace EX11_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.Write("Nhập tên file (bao gồm đường dẫn nếu cần): ");
            string fileName = Console.ReadLine();

            Console.Write("Nhập nội dung muốn ghi vào file: ");
            string content = Console.ReadLine();

            WriteToFile(fileName, content);

            Console.WriteLine("Nội dung đã được ghi vào file.");

            Console.WriteLine("\nĐọc nội dung từ file:");
            string readContent = ReadFromFile(fileName);
            Console.WriteLine(readContent);
        }

        static void WriteToFile(string fileName, string content)
        {
            try
            {
                File.WriteAllText(fileName, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
            }
        }

        static string ReadFromFile(string fileName)
        {
            try
            {
                return File.ReadAllText(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
