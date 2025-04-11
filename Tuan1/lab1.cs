using System;

namespace Tuan1
{
    public class Lab1
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++) // Kiểm tra đến căn bậc hai
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 1: Chào hỏi với tên và tuổi.
        public static void Bai1()
        {
            Console.WriteLine("Bài 1: Nhập tên và tuổi.");
            Console.Write("Tên của bạn: ");
            string ten = Console.ReadLine() ?? "";
            Console.Write("Tuổi của bạn: ");
            if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi >= 0)
            {
                Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
            }
            else
            {
                Console.WriteLine("Tuổi phải là một số nguyên dương!");
            }
        }

        // Bài 2: Tính diện tích hình chữ nhật.
        public static void Bai2()
        {
            Console.WriteLine("Bài 2: Tính diện tích hình chữ nhật.");
            Console.Write("Nhập chiều dài: ");
            if (double.TryParse(Console.ReadLine(), out double dai))
            {
                Console.Write("Nhập chiều rộng: ");
                if (double.TryParse(Console.ReadLine(), out double rong) && dai > 0 && rong > 0)
                {
                    Console.WriteLine($"Diện tích hình chữ nhật là: {dai * rong}");
                }
                else
                {
                    Console.WriteLine("Chiều dài và chiều rộng phải là số dương!");
                }
            }
            else
            {
                Console.WriteLine("Chiều dài phải là một số!");
            }
        }

        // Bài 3: Chuyển đổi nhiệt độ từ độ C sang độ F.
        public static void Bai3()
        {
            Console.WriteLine("Bài 3: Chuyển đổi nhiệt độ C sang F.");
            Console.Write("Nhập nhiệt độ (°C): ");
            if (double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine($"Nhiệt độ (°F): {(c * 9 / 5) + 32}");
            }
            else
            {
                Console.WriteLine("Nhiệt độ phải là số!");
            }
        }

        // Bài 4: Kiểm tra số chẵn hay lẻ.
        public static void Bai4()
        {
            Console.WriteLine("Bài 4: Kiểm tra số chẵn hay lẻ.");
            Console.Write("Nhập số nguyên: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine(n % 2 == 0 ? $"{n} là số chẵn." : $"{n} là số lẻ.");
            }
            else
            {
                Console.WriteLine("Phải nhập số nguyên!");
            }
        }

        // Bài 5: Tính tổng và tích của hai số.
        public static void Bai5()
        {
            Console.WriteLine("Bài 5: Tính tổng và tích hai số.");
            Console.Write("Nhập số thứ nhất: ");
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Write("Nhập số thứ hai: ");
                if (int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine($"Tổng: {a + b}");
                    Console.WriteLine($"Tích: {a * b}");
                }
                else
                {
                    Console.WriteLine("Phải nhập số nguyên!");
                }
            }
        }

        // Bài 6: Kiểm tra số dương, âm hay không.
        public static void Bai6()
        {
            Console.WriteLine("Bài 6: Kiểm tra số dương, âm hay không.");
            Console.Write("Nhập một số: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num > 0) Console.WriteLine($"{num} là số dương.");
                else if (num < 0) Console.WriteLine($"{num} là số âm.");
                else Console.WriteLine($"{num} là số không.");
            }
            else
            {
                Console.WriteLine("Phải nhập số!");
            }
        }

        // Bài 7: Kiểm tra năm nhuận.
        public static void Bai7()
        {
            Console.WriteLine("Bài 7: Kiểm tra năm nhuận.");
            Console.Write("Nhập một năm: ");
            if (int.TryParse(Console.ReadLine(), out int nam))
            {
                Console.WriteLine((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0)
                    ? $"{nam} là năm nhuận."
                    : $"{nam} không phải là năm nhuận.");
            }
            else
            {
                Console.WriteLine("Phải nhập số nguyên!");
            }
        }

        // Bài 8: In bảng cửu chương.
        public static void Bai8()
        {
            Console.WriteLine("Bài 8: In bảng cửu chương.");
            Console.Write("Nhập một số nguyên dương: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine("Phải nhập số nguyên dương!");
            }
        }

        // Bài 9: Tính giai thừa.
        public static void Bai9()
        {
            Console.WriteLine("Bài 9: Tính giai thừa.");
            Console.Write("Nhập một số nguyên dương: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                long gt = 1;
                for (int i = 1; i <= n; i++)
                {
                    gt *= i;
                }
                Console.WriteLine($"Giai thừa của {n} là: {gt}");
            }
            else
            {
                Console.WriteLine("Phải nhập số nguyên dương!");
            }
        }

        // Bài 10: Kiểm tra số nguyên tố.
        public static void Bai10()
        {
            Console.WriteLine("Bài 10: Kiểm tra số nguyên tố.");
            Console.Write("Nhập một số nguyên: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine(KiemTraSoNguyenTo(n)
                    ? $"{n} là số nguyên tố."
                    : $"{n} không phải là số nguyên tố.");
            }
            else
            {
                Console.WriteLine("Phải nhập số nguyên dương!");
            }
        }
    }
}
