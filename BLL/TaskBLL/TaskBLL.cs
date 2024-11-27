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

        public List<TaskInfo> nhanCongViecChuaDuocGiaoTuTaiKhoan(string idBoPhan, string accountId)
        {
            try
            {
                return taskDAL.nhanCongViecChuaDuocGiaoTuTaiKhoan(idBoPhan, accountId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc chờ nhận cho bộ phận ID: {idBoPhan} và tài khoản ID: {accountId}.", ex);
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

        public List<TaskInfo> LayDanhSachCongViecDaGiao(string idNguoiDung)
        {
            try
            {
                return taskDAL.LayDanhSachCongViecDaGiao(idNguoiDung);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách công việc do người dùng ID: {idNguoiDung} giao.", ex);
            }
        }
        public bool ThemCongViecChuDong(string idCongViec, int soLuongNhanSuChuDong)
        {
            try
            {
                return taskDAL.ThemCongViecChuDong(idCongViec, soLuongNhanSuChuDong);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm công việc chủ động: " + ex.Message);
            }
        }
        public TaskInfo LayChiTietCongViecTheoIdCongViec(string IdTask)
        {
            try
            {
                return taskDAL.LayChiTietCongViecTheoIdCongViec(IdTask);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết công việc với ID: {IdTask}.", ex);
            }
        }

        public int LaySoLuongNhanSuChuDongTheoIdCongViec(string idCongViec)
        {
            try
            {
                return taskDAL.LaySoLuongNhanSuChuDongTheoIdCongViec(idCongViec);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết công việc với ID: {idCongViec}.", ex);
            }
        }
        public TaskInfo LayChiTietCongViec(string idTask)
        {
            try
            {
                return taskDAL.LayChiTietCongViec(idTask);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết công việc với ID: {idTask}.", ex);
            }
        }
        public List<TaskInfo> LayLichSuCongViec(string idNguoiDung)
        {
            try
            {
                return taskDAL.LayLichSuCongViec(idNguoiDung);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử công việc cho tài khoản ID: {idNguoiDung}.", ex);
            }
        }
        public string BaoCaoDangTienHanhCongViec(string idCongViec, string idTaiKhoanKhoiTao, string ghiChu)
        {
            try
            {
                return taskDAL.BaoCaoDangTienHanhCongViec(idCongViec, idTaiKhoanKhoiTao, ghiChu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi báo cáo đang tiến hành: " + ex.Message);
            }
        }
        public string BaoCaoHoanThanhCongViec(string idCongViec, string idTaiKhoanKhoiTao, string ghiChu)
        {
            try
            {
                return taskDAL.BaoCaoHoanThanhCongViec(idCongViec, idTaiKhoanKhoiTao, ghiChu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi báo cáo hoàn thành: " + ex.Message);
            }
        }
        public string BaoCaoDangTienHanhCongViecOnline(string idCongViec, string idTaiKhoanKhoiTao, string thoiGianBaoCao, string ghiChu)
        {
            try
            {
                return taskDAL.BaoCaoDangTienHanhCongViecOnline(idCongViec, idTaiKhoanKhoiTao, thoiGianBaoCao, ghiChu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi báo cáo đang tiến hành Online: " + ex.Message);
            }
        }
        public string BaoCaoHoanThanhCongViecOnline(string idCongViec, string idTaiKhoanKhoiTao, string thoiGianBaoCao, string ghiChu)
        {
            try
            {
                return taskDAL.BaoCaoHoanThanhCongViecOnline(idCongViec, idTaiKhoanKhoiTao, thoiGianBaoCao, ghiChu);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi báo cáo hoàn thành Online: " + ex.Message);
            }
        }
        public bool ThemTaiLieu (BaoCao baoCao)
        {
            try
            {
                return taskDAL.ThemTaiLieu(baoCao);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài liệu: " + ex.Message);
            }
        }
        public bool ThemHinhAnh(BaoCao baoCao)
        {
            try
            {
                return taskDAL.ThemHinhAnh(baoCao);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hình ảnh: " + ex.Message);
            }
        }
        public List<DanhSachBaoCao> LayDanhSachBaoCao(string idCongViec)
        {
            try
            {
                return taskDAL.LayDanhSachBaoCao(idCongViec);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách báo cáo: {idCongViec} giao.", ex);
            }
        }


        //Nhận việc online
        
        public bool NhanCongViecOnline(string idTaiKhoanNhanViec, string idCongViec, string loaiNhanViec)
        {
            try
            {
                return taskDAL.NhanCongViecOnline(idTaiKhoanNhanViec, idCongViec, loaiNhanViec);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi nhận công việc online: " + ex.Message);
            }
        }
        public void TaoLichSuNhanViec(string idCongViec, string idTaiKhoanNhan)
        {
            try
            {
                taskDAL.TaoLichSuNhanViec(idCongViec, idTaiKhoanNhan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo lịch sử nhận việc: " + ex.Message);
            }
        }

        public bool TaoDonXinDieuChinhPhanCong(string idCongViec, string idTaiKhoanNhanViec, string liDo)
        {
            try
            {
                return taskDAL.TaoDonXinDieuChinhPhanCong(idCongViec, idTaiKhoanNhanViec, liDo);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo đơn xin điều chỉnh phân công: " + ex.Message);
            }
        }

        public List<TaskInfo> HienThiDanhSachDieuChinhPhanCong(string idTaiKhoanGiaoViec)
        {
            try
            {
                return taskDAL.HienThiDanhSachDieuChinhPhanCong(idTaiKhoanGiaoViec);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị đơn xin điều chỉnh phân công: " + ex.Message);
            }
        }

        public bool XacNhanDieuChinhPhanCong(string idCongViec, string idTaiKhoanKhoiTao)
        {
            try
            {
                return taskDAL.XacNhanDieuChinhPhanCong(idCongViec, idTaiKhoanKhoiTao);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xác nhận điều chỉnh phân công: " + ex.Message);
            }
        }

        public bool TuChoiDieuChinhPhanCong(string idCongViec, string idTaiKhoanKhoiTao)
        {
            try
            {
                return taskDAL.TuChoiDieuChinhPhanCong(idCongViec, idTaiKhoanKhoiTao);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi từ chối điều chỉnh phân công: " + ex.Message);
            }
        }


        public bool DuyetHoanThanhCongViec(string idCongViec)
        {
            try
            {
                return taskDAL.DuyetHoanThanhCongViec(idCongViec);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi duyệt: " + ex.Message);
            }
        }
        public bool GiaoViec(string loaiGiaoViec, ThongTinGiaoViec ThongTinCongViec)
        {
            return taskDAL.GiaoViec( loaiGiaoViec,  ThongTinCongViec);
            
        }
        public DateTime? ThoiHanHoanThanhCongViecGoc(string idCongViecGoc)
        {
            try
            {
                return taskDAL.ThoiHanHoanThanhCongViecGoc(idCongViecGoc);
            }
            catch
            {
                return null;
            }
        }
        public bool KiemTraCongViecChuDong(string idTask)
        {
            try
            {
                return taskDAL.KiemTraCongViecChuDong(idTask);
            }
            catch
            {
                return false;
            }
        }
        public bool KiemTraCongViecPhatSinh(string idTask, out string idCongViecGoc)
        {
            idCongViecGoc = taskDAL.KiemTraCongViecPhatSinh(idTask);
            return idCongViecGoc != null;


        }
        public bool XoaCongViec(string idTask)
        {
            try
            {
                return taskDAL.XoaCongViec(idTask);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa công việc: " + ex.Message);
            }
        }
        public bool XoaCongViecPhatSinh(string idTask)
        {
            try
            {
                return taskDAL.XoaCongViecPhatSinh(idTask);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa công việc phát sinh: " + ex.Message);
            }
        }

        public bool CapNhatCongViec(string idCongViec, string loaiGiaoViec, ThongTinGiaoViec ThongTinCongViec)
        {
            return taskDAL.CapNhatCongViec(idCongViec, loaiGiaoViec, ThongTinCongViec);

        }

        public void TaoCongViecTuYKien(string tenCongViec, string tenBoPhan, string thoiGianGhiNhan, string moTa, string thoiHanHoanThanh)
        {
            try
            {
                taskDAL.TaoCongViecTuYKien(tenCongViec, tenBoPhan, thoiGianGhiNhan, moTa, thoiHanHoanThanh);
            } catch(Exception ex)
            {
                throw new Exception("Lỗi khi tạo công việc từ ý kiến: " + ex.Message);
            }
        }
    }

}