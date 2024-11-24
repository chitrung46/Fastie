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

        /*
        public List<AnalyticsDTO> GetAllPositions()
        {
            AnalyticsDAL analyticsDAL = new AnalyticsDAL();
            return analyticsDAL.GetAllPositions();
        }
        */
        public List<AnalyticsDTO> ThongKeTrangThaiCongViec(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            var data = analyticsDAL.ThongKeTrangThaiCongViec(accountId, departmentId, positionId, personnelId, startDate, endDate);

            foreach (var item in data)
            {
                Console.WriteLine($"BLL Result - TrangThai: {item.TenChucVu}, SoLuong: {item.IdChucVu}");
            }

            return data;
        }
        public List<AnalyticsDTO> ThongKeHoanThanh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            return analyticsDAL.ThongKeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);
        }
        public List<AnalyticsDTO> ThongKeNhanViecChuDongVaDieuChinh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            AnalyticsDAL analyticsDAL = new AnalyticsDAL();
            return analyticsDAL.ThongKeNhanViecChuDongVaDieuChinh(accountId, departmentId, positionId, personnelId, startDate, endDate);
        }

        public List<AnalyticsDTO> ThongKeTyLeHoanThanh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            List<AnalyticsDTO> data = analyticsDAL.ThongKeTyLeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);
            Console.WriteLine($"BLL Data Count: {data.Count}");
            foreach (var item in data)
            {
                Console.WriteLine($"Hoàn thành: {item.SoLuongHoanThanh}, Chưa hoàn thành: {item.SoLuongChuaHoanThanh}, Tỷ lệ: {item.TyLeHoanThanh}, Tổng số: {item.TongSoCongViec}");
            }
            return data;
        }

        public string LayChuVuID(string accountId)
        {
            return analyticsDAL.LayChuVuID(accountId);
        }
        public List<AnalyticsDTO> LayTaCaBoPhan()
        {
            try
            {
                return analyticsDAL.LayTaCaBoPhan();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AnalyticsBLL.GetAllDepartments: {ex.Message}");
                throw;
            }
        }

        public List<AnalyticsDTO> ThongKeTyLeHoanThanhTatCaBoPhan(string accountId, DateTime startDate, DateTime endDate)
        {
            return analyticsDAL.LayThongKeTyLeHoanThanhTatCaBoPhan(accountId, startDate, endDate);
        }


    }
}
