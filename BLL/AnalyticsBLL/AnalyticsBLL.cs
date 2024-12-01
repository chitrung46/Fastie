using DAL.AnalyticsDAL;
using DTO;
using DTO.AnalyticsDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AnalyticsBLL
{
    public class AnalyticsBLL
    {
        AnalyticsDAL analyticsDAL = new AnalyticsDAL();

        public List<AnalyticsDTO> LayBoPhanDuaTrenIDTaiKhoan(string accountId)
        {
            return analyticsDAL.LayBoPhanDuaTrenIDTaiKhoan(accountId);
        }

        public List<AnalyticsDTO> LayChucVuDuaTrenBoPhan(string departmentId)
        {
            return analyticsDAL.LayChucVuDuaTrenBoPhan(departmentId);
        }

        public List<AnalyticsDTO> LayNhanSuDuaTrenChucVuVaBoPhan(string departmentId, string positionId)
        {
            return analyticsDAL.LayNhanSuDuaTrenChucVuVaBoPhan(departmentId, positionId);
        }
        public List<AnalyticsDTO> ThongKeTrangThaiCongViec(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            var data = analyticsDAL.ThongKeTrangThaiCongViec(accountId, departmentId, positionId, personnelId, startDate, endDate);

            return data;
        }
        public List<AnalyticsDTO> ThongKeHoanThanh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            return analyticsDAL.ThongKeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);
        }
        public List<AnalyticsDTO> ThongKeNhanViecChuDongVaDieuChinh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"BLL Parameters - AccountId: {accountId}, DepartmentId: {departmentId}, PositionId: {positionId}, PersonnelId: {personnelId}, StartDate: {startDate}, EndDate: {endDate}");

            AnalyticsDAL analyticsDAL = new AnalyticsDAL();
            var data = analyticsDAL.ThongKeNhanViecChuDongVaDieuChinh(accountId, departmentId, positionId, personnelId, startDate, endDate);

            Console.WriteLine($"BLL Data Count: {data.Count}");
            return data;
        }

        public decimal ThongKeTyLeHoanThanh(string idTaiKhoan, string idBoPhan, string idChucVu, string idNhanSu, DateTime tuNgay, DateTime denNgay)
        {
            AnalyticsDAL analyticsDAL = new AnalyticsDAL();
            return analyticsDAL.ThongKeTyLeHoanThanh(idTaiKhoan, idBoPhan, idChucVu, idNhanSu, tuNgay, denNgay);
        }

        public string LayChuVuID(string accountId)
        {
            return analyticsDAL.LayChuVuID(accountId);
        }
        public List<AnalyticsDTO> LayTaCaBoPhan()
        {
            return analyticsDAL.LayTaCaBoPhan();
        }

        public List<AnalyticsDTO> ThongKeTyLeHoanThanhTatCaBoPhan(string accountId, DateTime startDate, DateTime endDate)
        {
            return analyticsDAL.LayThongKeTyLeHoanThanhTatCaBoPhan(accountId, startDate, endDate);
        }
        //Trung

        public List<ThongTinThongKe> LayBangThongKeTienDoCongViecTheoMaTaiKhoan(string idTaiKhoan, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                return analyticsDAL.LayBangThongKeTienDoCongViecTheoMaTaiKhoan(idTaiKhoan, ngayBatDau, ngayKetThuc);
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện lấy danh sách thống kê tiến độ công việc theo mã tài khoản: " + ex.Message);
            }
        }
        public List<ThongTinThongKe> LayThongKeSoCongViecHoanThanhDungHanTreHan(string idTaiKhoan, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                List<ThongTinThongKe> data = analyticsDAL.LayThongKeSoCongViecHoanThanhDungHanTreHan(idTaiKhoan, ngayBatDau, ngayKetThuc);
                foreach (var item in data)
                {
                    Console.WriteLine($"BLL - SoDungHan: {item.SoLuongCongViecHoanThanhDungHan}, SoTreHan: {item.SoLuongCongViecHoanThanhTreHan}");
                }
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện lấy danh sách thống kê số công việc hoàn thành đúng hạn trễ hạn: " + ex.Message);
            }
        }
        public List<ThongTinThongKe> LayThongKeSoLanNhanViecChuDongVaSoLanXinDieuChinhPhanCong(string idTaiKhoan, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                List<ThongTinThongKe> data = analyticsDAL.LayThongKeSoLanNhanViecChuDongVaSoLanXinDieuChinhPhanCong(idTaiKhoan, ngayBatDau, ngayKetThuc);
                foreach (var item in data)
                {
                    Console.WriteLine($"BLL - SoLanNhanViecChuDong: {item.SoLanNhanViecChuDong}, SoLanXinDieuChinhPhanCong: {item.SoLanXinDieuChinhPhanCong}");

                }
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực hiện lấy danh sách thống kê số công việc hoàn thành đúng hạn trễ hạn: " + ex.Message);
            }
        }
        public ThongTinThongKe LayThongKeTiLeHoanThanhCongViec(string idTaiKhoan, string ngayBatDau, string ngayKetThuc)
        {
            if (string.IsNullOrEmpty(idTaiKhoan))
            {
                throw new ArgumentException("ID tài khoản không được để trống!");
            }
            try
            {
                // Gọi DAL để lấy dữ liệu
                ThongTinThongKe tiLeHoanThanh = analyticsDAL.LayThongKeTiLeHoanThanhCongViec(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Kiểm tra kết quả trả về từ DAL
                if (tiLeHoanThanh == null)
                {
                    Console.WriteLine("BLL - Không có dữ liệu từ DAL.");
                    return new ThongTinThongKe
                    {
                        TiLeHoanThanhCongViec = 0 // Giá trị mặc định
                    };
                }

                // Log kết quả để kiểm tra
                Console.WriteLine($"BLL - Tỷ lệ hoàn thành công việc: {tiLeHoanThanh.TiLeHoanThanhCongViec}%");
                return tiLeHoanThanh;
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết
                Console.WriteLine($"BLL - Đã xảy ra lỗi: {ex.Message}");
                throw new Exception("Lỗi khi lấy tỷ lệ hoàn thành công việc: " + ex.Message);
            }
        }
        public string GetTaiKhoanId(string idNhanSu)
        {
            return analyticsDAL.GetTaiKhoanId(idNhanSu);
        }

    }
}
