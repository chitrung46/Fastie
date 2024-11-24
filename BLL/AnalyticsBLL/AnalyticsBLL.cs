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
            AnalyticsDAL analyticsDAL = new AnalyticsDAL();
            return analyticsDAL.ThongKeNhanViecChuDongVaDieuChinh(accountId, departmentId, positionId, personnelId, startDate, endDate);
        }

        public List<AnalyticsDTO> ThongKeTyLeHoanThanh(string accountId, string departmentId, string positionId, string personnelId, DateTime startDate, DateTime endDate)
        {
            List<AnalyticsDTO> data = analyticsDAL.ThongKeTyLeHoanThanh(accountId, departmentId, positionId, personnelId, startDate, endDate);
            return data;
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


    }
}
