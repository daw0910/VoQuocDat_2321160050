using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    public class SinhVien
    {
        private string _hoTen;
        private double _diemToan;
        private double _diemVan;
        private double _diemNgoaiNgu;
        private int _khoiHoc;
        private double _diemTB;
        private string _hocLuc;
        private string _xepLoai;
        public SinhVien()
        {

        }
        public SinhVien(string HoTen)
        {
            this.HoTen =HoTen;
        }
        public SinhVien(string hoTen, double diemToan, double diemVan, double diemNgoaiNgu, int khoiHoc, int diemTB, string hocLuc, string xepLoai)
        {
            this._hoTen = hoTen;
            this._diemToan = diemToan;
            this._diemVan = diemVan;
            this._diemNgoaiNgu = diemNgoaiNgu;
            this._khoiHoc = khoiHoc;
            this._diemTB = diemTB;
            this._hocLuc = hocLuc;
            this._xepLoai = xepLoai;
        }
        public string HoTen
        {
            set { this._hoTen = value; }
            get { return _hoTen; }
        } 
        public double DiemToan
        {
            set { this._diemToan = value; }
            get { return _diemToan; }
        }
        public double DiemVan
        {
            set { this._diemVan = value; }
            get { return _diemVan; }
        }
        public double DiemNgoaiNgu
        {
            set { this._diemNgoaiNgu = value; }
            get { return _diemNgoaiNgu; }
        }
        public int KhoiHoc
        {
            set { this._khoiHoc = value; }
            get { return _khoiHoc; }
        }
        public double DiemTB
        {
            set { this._diemTB = value; }
            get { return _diemTB; }
        }
        public string HocLuc
        {
            set { this._hocLuc = value; }
            get { return _hocLuc; }
        }
        public string XepLoai
        {
            set { this._xepLoai = value; }
            get { return _xepLoai; }
        }
        public double TinhDiemTrungBinh()
        {
            double  DiemTB = (DiemToan + DiemVan + DiemNgoaiNgu) / 3;
            DiemTB = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
            return DiemTB;
        }
        public string TinhXepLoai()
        {
            if (DiemTB > 5 )
            {
                HocLuc = "DuocLenLop";
            }
            else
            {
                HocLuc = "LuuBan";
            }
            return XepLoai;
        }
        public void  InThongTin()
        {
            Console.WriteLine("Ho ten sinh vien: {0}", HoTen);
            Console.WriteLine("Diem trung binh: {0}", DiemTB);
            Console.WriteLine("Tinh xep loai: {0}", XepLoai);
        }
    }
    class Bai01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            Console.Write("Nhập Họ Tên: ");
            sv.HoTen = Console.ReadLine();
            Console.Write("Nhập Điểm Toán: ");
            sv.DiemToan =double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Văn:");
            sv.DiemVan = double.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Ngoại Ngữ: ");
            sv.DiemNgoaiNgu = double.Parse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
