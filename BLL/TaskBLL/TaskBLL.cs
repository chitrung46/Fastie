using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.TaskDTO;
using DAL.TaskDAL;

namespace BLL.TaskBLL
{
    public class TaskBLL
    {
        public List<TaskType>LayDanhSachLoaiCongViec ()
        {
            return TaskDAL.LayDanhSachLoaiCongViec();
        }

        public bool ThemCongViecGiaoViec (TaskInfo task)
        {
            return TaskDAL.ThemCongViecGiaoViec(task);
        }

        public string TaoCongViecId (string idLoaiCongViec, string idBoPhan)
        {
            return TaskDAL.TaoCongViecId(idLoaiCongViec, idBoPhan);
        }
        public string TaoLichSuId()
        {
            return TaskDAL.TaoLichSuId();
        }

        public string LayIdLoaiCongViecTuTen(string tenLoaiCongViec)
        {
            return TaskDAL.LayIdLoaiCongViecTuTen(tenLoaiCongViec);
        }

        public bool LuuBoPhanNhanViec(string idBoPhanNhanViec, string idCongViec)
        {
            return TaskDAL.LuuBoPhanNhanViec(idBoPhanNhanViec, idCongViec);
        }

        public bool LuuTaiKhoanNhanViec(string idTaiKhoanNhanViec, string idCongViec)
        {
            return TaskDAL.LuuTaiKhoanNhanViec(idTaiKhoanNhanViec, idCongViec);
        }
    }
}
