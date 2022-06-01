using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SinhVienOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien(1, "Vo Nguyen Tran Quoc", (float)8.5, (float)9.5);
            Console.WriteLine("\n{0} {1} {2} {3} {4}", "MaSV", "HoTen", "DiemLT", "DiemTH", "DiemTB");
            sv1.hienthiSV();
        }
    }
    
}
