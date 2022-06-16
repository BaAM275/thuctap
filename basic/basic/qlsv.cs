using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    
    class qlsv
    {
        public List<sinhvien> ListSinhVien = null;

        public qlsv()
        {
            ListSinhVien = new List<sinhvien>();
        }


        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].ID;
                foreach (sinhvien sv in ListSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                }
                max++;
            }
            return max;
        }

        public void NhapSinhVien()
        {
            // Khởi tạo một sinh viên mới
            sinhvien sv = new sinhvien();
            sv.ID = GenerateID();
            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Sex = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());


            ListSinhVien.Add(sv);
        }

        internal void ShowSinhVien()
        {
            throw new NotImplementedException();
        }

        public void ShowSinhVien(List<sinhvien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                  "ID", "Name", "Sex", "Age");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (sinhvien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                      sv.ID, sv.Name, sv.Sex, sv.Age);
                }
            }
            Console.WriteLine();
        }

        public List<sinhvien> getListSinhVien()
        {
            return ListSinhVien;
        }
    }
    
}

