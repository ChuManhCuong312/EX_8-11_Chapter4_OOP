using System;

namespace EX10_OOP
{
    struct Student
    {
        public string Name;
        public double Score;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool validInput = false;
            int n = 0;

            while (!validInput)
            {
                try
                {
                    Console.Write("Nhập số lượng sinh viên: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new ArgumentException("Số lượng sinh viên phải lớn hơn 0.");
                    }
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Console.WriteLine("Vui lòng thử lại.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Console.WriteLine("Vui lòng thử lại.");
                }
            }

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.Write($"Nhập thông tin sinh viên {i + 1}:\nTên: ");
                    string name = Console.ReadLine();

                    // Kiểm tra tên không chứa số hoặc kí tự đặc biệt
                    if (!IsNameValid(name))
                    {
                        throw new ArgumentException("Tên sinh viên không hợp lệ.");
                    }

                    students[i].Name = name;

                    Console.Write("Điểm: ");
                    double score = double.Parse(Console.ReadLine());

                    // Kiểm tra điểm nằm trong khoảng từ 0 đến 10
                    if (score < 0 || score > 10)
                    {
                        throw new ArgumentException("Điểm sinh viên phải nằm trong khoảng từ 0 đến 10.");
                    }

                    students[i].Score = score;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Điểm phải là một số.");
                    i--; // Nhập lại thông tin cho sinh viên này
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Console.WriteLine("Vui lòng thử lại.");
                    i--; // Nhập lại thông tin cho sinh viên này
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Console.WriteLine("Vui lòng thử lại.");
                    i--; // Nhập lại thông tin cho sinh viên này
                }
            }

            Console.WriteLine("\nThông tin của từng sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine($"Tên: {student.Name}, Điểm: {student.Score}");
            }

            double totalScore = 0;
            foreach (var student in students)
            {
                totalScore += student.Score;
            }

            double averageScore = totalScore / n;
            Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore}");
        }

        static bool IsNameValid(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
