using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class TaskBLL
    {
        TaskAccess taskAccess = new TaskAccess();

        public void capNhatTrangThaiCongViec(string CongviecID, string newStatus)
        {
            try
            {
                taskAccess.capNhatTrangThaiCongViec(CongviecID, newStatus);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái công việc ID: {CongviecID}.", ex);
            }
        }

        public List<TaskInfo> layCongViecTheoID(string idTaiKhoan)
        {
            try
            {
                return taskAccess.layCongViecTheoID(idTaiKhoan);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc cho tài khoản ID: {idTaiKhoan}.", ex);
            }
        }

        public void giaoViecChoTaiKhoan(string accountId, string taskId)
        {
            try
            {
                taskAccess.giaoViecChoTaiKhoan(accountId, taskId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi gán công việc ID: {taskId} cho tài khoản ID: {accountId}.", ex);
            }
        }

        public List<TaskInfo> nhanCongViecChuaDuocGiaoTuTaiKhoan(string accountId)
        {
            try
            {
                return taskAccess.nhanCongViecChuaDuocGiaoTuTaiKhoan(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc chưa gán cho tài khoản ID: {accountId}.", ex);
            }
        }

        public List<TaskInfo> nhanNhiemVuDuocGiaoTuTaiKhoan(string accountId)
        {
            try
            {
                return taskAccess.nhanNhiemVuDuocGiaoTuTaiKhoan(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc đã gán cho tài khoản ID: {accountId}.", ex);
            }
        }
    }

}