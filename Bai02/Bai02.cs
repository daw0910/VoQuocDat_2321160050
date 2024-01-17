using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double rong;
        private double dai;
        public ChuNhat(double rong, double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public double tinhDienTich()
        {
            return dai * rong;
        }
        public void Xuat()
        {
            Console.WriteLine("Dai: {0}\t Rong: {1}\t Chu vi: {2}\t Dien tich: {3}", dai, rong, tinhChuVi(), tinhDienTich());

        }
    }
    class Vuong : ChuNhat
    {
        private double canh;
        public Vuong(double canh) : base(canh, canh)
        {
        }
        public double tinhChuVi()
        {
            return (canh + canh) * 2;
        }
        public double tinhDienTich()
        {
            return canh * canh;
        }
        public void Xuat()
        {
            Console.WriteLine("Canh: {0}\t Chu vi: {1}\t Dien tich: {2}", canh, tinhChuVi(), tinhDienTich());
        }
    }
    class Bai02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh Chu vi va Dien Tich Hinh Vuong & Chu Nhat");
            ChuNhat cn = new ChuNhat(500, 700);
            ChuNhat vu = new Vuong(500);
            cn.Xuat();
            vu.Xuat();
            Console.ReadLine();
        }
    }
}
