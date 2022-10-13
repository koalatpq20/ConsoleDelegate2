using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate2
{
    public class Shape
    {
        public delegate double ChuViDelegate(double length1, double length2, double length3);
        public delegate double DienTichDelegate(double length1, double length2, double height);

        public ChuViDelegate ChuVi { get; set; }
        public DienTichDelegate DienTich { get; set; }

        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Length3 { get; set; }
        public double Height { get; set; }
        public string ShapeType { get; set; }

        //Phương thức xuất thông tin của hình gồm các bước chính:
        // 1. Tính chu vi
        // 2. Tính diện tích
        // 3. Xuất thông tin
        // Các bước thực hiện này không thay đổi cho mọi hình, chỉ khác nhau cách tính chu vi, tính diện tích tùy theo hình sẽ được tạo trong thực tế
        // Nên code tính toán chu vi, diện tích sẽ được chèn động qua delegate
        public void DisplayInfo()
        {
            double ketQuaChuVi = ChuVi(Length1, Length2, Length3);
            double ketQuaDienTich = DienTich(Length1, Length2, Height);

            Console.WriteLine($"Hình {ShapeType} - Chu vi {ketQuaChuVi} - Dien tich {ketQuaDienTich}");
        }
    }
}
