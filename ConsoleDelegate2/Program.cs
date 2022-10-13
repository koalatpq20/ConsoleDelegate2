using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Nhập hình bạn muốn tạo: \n 1. Chữ nhật \n 2.Vuông \n 3.Tam giác");
            int type = Convert.ToInt16(Console.ReadLine());

            Shape shape = new Shape();

            switch (type)
            {
                case 1:
                    Console.WriteLine("Nhập chiều dài: ");
                    shape.Length1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Nhập chiều rộng: ");
                    shape.Length2 = Convert.ToDouble(Console.ReadLine());

                    //Chèn code xử lý chu vi, diện tích
                    shape.ChuVi = TinhChuViChuNhat;
                    shape.DienTich = TinhDienTichChuNhat;

                    break;

                case 2:
                    Console.WriteLine("Nhập cạnh: ");
                    shape.Length1 = Convert.ToDouble(Console.ReadLine());

                    //Chèn code xử lý chu vi, diện tích
                    shape.ChuVi = TinhChuViHinhVuong;
                    shape.DienTich = TinhDienTichHinhVuong;

                    break;
                    
                case 3:
                    Console.WriteLine("Nhập cạnh 1: ");
                    shape.Length1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhập cạnh 2: ");
                    shape.Length2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhập cạnh 3: ");
                    shape.Length3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhập chiều cao: ");
                    shape.Height = Convert.ToDouble(Console.ReadLine());

                    //Chèn code xử lý chu vi, diện tích
                    shape.ChuVi = TinhChuViTamGiac;
                    shape.DienTich = TinhDienTichHinhVuong;

                    break;
            }

            shape.DisplayInfo(); //gọi phương thức tính chu vi, dien tich
            Console.ReadLine();
        }

        private static double TinhChuViTamGiac(double length1, double length2, double length3)
        {
            return length1 + length2 + length3;
        }

        private static double TinhChuViChuNhat(double length1, double length2, double length3)
        {
            return length1 * 2 + length2 * 2;
        }

        private static double TinhChuViHinhVuong(double length1, double length2, double length3)
        {
            return length1 * 4;
        }

        private static double TinhDienTichTamGiac(double length1, double length2, double height)
        {
            return length1 * height / 2;
        }

        private static double TinhDienTichChuNhat(double length1, double length2, double height)
        {
            return length1 * length2;
        }

        private static double TinhDienTichHinhVuong(double length1, double length2, double height)
        {
            return length1 * length1;
        }
    }
}
