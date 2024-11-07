using DAL;
using DAL.TaskDAL;
using DTO;
using DTO.TaskDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class TaskBLL
    {
        
        TaskDAL taskDAL = new TaskDAL();

        public void capNhatTrangThaiCongViec(string CongviecID, string newStatus)
        {
            try
            {
                taskDAL.capNhatTrangThaiCongViec(CongviecID, newStatus);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái công việc ID: {CongviecID}.", ex);
            }
        }

        public List<TaskInfo> layCongViecTheoID(string accountId)
        {
            try
            {
                return taskDAL.layCongViecTheoID(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc cho tài khoản ID: {accountId}.", ex);
            }
        }

        public void giaoViecChoTaiKhoan(string accountId, string taskId)
        {
            try
            {
                taskDAL.giaoViecChoTaiKhoan(accountId, taskId);
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
                return taskDAL.nhanCongViecChuaDuocGiaoTuTaiKhoan(accountId);
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
                return taskDAL.nhanNhiemVuDuocGiaoTuTaiKhoan(accountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc đã gán cho tài khoản ID: {accountId}.", ex);
            }
        }

        public List<TaskType> LayDanhSachLoaiCongViec()
        {
            return taskDAL.LayDanhSachLoaiCongViec();
        }

        public bool ThemCongViecGiaoViec(TaskInfo task)
        {
            return taskDAL.ThemCongViecGiaoViec(task);
        }

        public string TaoCongViecId(string idLoaiCongViec, string idBoPhan)
        {
            return taskDAL.TaoCongViecId(idLoaiCongViec, idBoPhan);
        }
        public string TaoLichSuId()
        {
            return taskDAL.TaoLichSuId();
        }

        public string LayIdLoaiCongViecTuTen(string tenLoaiCongViec)
        {
            return taskDAL.LayIdLoaiCongViecTuTen(tenLoaiCongViec);
        }

        public bool LuuBoPhanNhanViec(string idBoPhanNhanViec, string idCongViec)
        {
            return taskDAL.LuuBoPhanNhanViec(idBoPhanNhanViec, idCongViec);
        }

        public bool LuuTaiKhoanNhanViec(string idTaiKhoanNhanViec, string idCongViec)
        {
            return taskDAL.LuuTaiKhoanNhanViec(idTaiKhoanNhanViec, idCongViec);
        }

        public TaskInfo GetTaskDetailsById(string taskId)
        {
            return taskDAL.layCongViecTheoID(taskId).FirstOrDefault();
        }

    }

}