using System;
using Tuan1;
public class Lab1
{
    static bool snt(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    //Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn [tuổi] tuổi!".
    public static void bai1()
    {
        System.Console.WriteLine("Bai1: Nhap ten va tuoi cua ban.");
        Console.WriteLine("Nhap ten cua ban: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Nhap tuoi cua ban: ");
        try
        {
            int age = int.Parse(Console.ReadLine() ?? "0");
            if (age < 0)
            {
                throw new CheckAmDuongException("Tuoi phai la mot so nguyen duong!");
            }
            Console.WriteLine($"Xin chao {name}, ban {age} tuoi!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Tuoi phai la mot so nguyen!");
        }
        catch (CheckAmDuongException)
        {
            Console.WriteLine("Tuoi phai la mot so nguyen duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
    public static void bai2()
    {
        try
        {
            System.Console.WriteLine("Bai2: Tinh dien tich hinh chu nhat.");
            Console.WriteLine("Nhap chieu dai: ");
            double chieuDai = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Nhap chieu rong: ");
            double chieuRong = double.Parse(Console.ReadLine() ?? "0");
            if (chieuDai < 0 || chieuRong < 0)
            {
                throw new CheckAmDuongException("Chieu dai va chieu rong phai la so duong!");
            }
            double dienTich = chieuDai * chieuRong;
            Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Chieu dai va chieu rong phai la so!");
        }
        catch (CheckAmDuongException)
        {
            Console.WriteLine("Chieu dai va chieu rong phai la so duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F. Công thức: F = (C * 9/5) + 32
    public static void bai3()
    {
        try
        {
            System.Console.WriteLine("Bai3: Chuyen doi nhiet do C sang F.");
            Console.WriteLine("Nhap nhiet do C: ");
            double nhietDoC = double.Parse(Console.ReadLine() ?? "0");
            double nhietDoF = (nhietDoC * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do F la: {nhietDoF}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Nhiet do phai la so!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
    public static void bai4()
    {
        try
        {
            System.Console.WriteLine("Bai4: Kiem tra so chan hay le.");
            Console.WriteLine("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} la so chan.");
            }
            else
            {
                Console.WriteLine($"{n} la so le.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím
    public static void bai5()
    {
        try
        {
            System.Console.WriteLine("Bai5: Tinh tong va tich hai so.");
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            int tong = a + b;
            int tich = a * b;
            Console.WriteLine($"Tong cua {a} va {b} la: {tong}.");
            Console.WriteLine($"Tich cua {a} va {b} la: {tich}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
    public static void bai6()
    {
        try
        {
            System.Console.WriteLine("Bai6: Kiem tra so duong, am hay khong.");
            Console.WriteLine("Nhap mot so: ");
            double n = double.Parse(Console.ReadLine() ?? "0");
            if (n > 0)
            {
                Console.WriteLine($"{n} la so duong.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} la so am.");
            }
            else
            {
                Console.WriteLine($"{n} la so khong.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không. (Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
    public static void bai7()
    {
        try
        {
            System.Console.WriteLine("Bai7: Kiem tra nam nhuan.");
            Console.WriteLine("Nhap mot nam: ");
            int nam = int.Parse(Console.ReadLine() ?? "0");
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} la nam nhuan.");
            }
            else
            {
                Console.WriteLine($"{nam} khong phai la nam nhuan.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 8: Viết chương trình nhập vào một số nguyên dương n và in ra bảng cửu chương từ 1 đến 10.
    public static void bai8()
    {
        try
        {
            System.Console.WriteLine("Bai 8: In ra bang cuu chuong.");
            Console.WriteLine("Nhap mot so nguyen duong: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n <= 0)
            {
                throw new CheckAmDuongException("Phai nhap so nguyen duong!");
            }
            Console.WriteLine($"Bang cuu chuong cua {n}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (CheckAmDuongException)
        {
            Console.WriteLine("Phai nhap so nguyen duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    //Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
    public static void bai9()
    {
        try
        {
            System.Console.WriteLine("Bai 9: Tinh giai thua.");
            Console.WriteLine("Nhap mot so nguyen duong: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n < 0)
            {
                throw new CheckAmDuongException("Phai nhap so nguyen duong!");
            }
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine($"Giai thua cua {n} la: {giaiThua}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (CheckAmDuongException)
        {
            Console.WriteLine("Phai nhap so nguyen duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
    // Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
    public static void bai10()
    {
        try
        {
            System.Console.WriteLine("Bai 10: Kiem tra so nguyen to.");
            Console.WriteLine("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n < 0)
            {
                throw new CheckAmDuongException("Phai nhap so nguyen duong!");
            }
            if (snt(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Phai nhap so nguyen!");
        }
        catch (CheckAmDuongException)
        {
            Console.WriteLine("Phai nhap so nguyen duong!");
        }
        catch (Exception)
        {
            Console.WriteLine("Da xay ra loi.");
        }
    }
}