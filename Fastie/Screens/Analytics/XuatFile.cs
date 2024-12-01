using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.AnalyticsBLL;
using DTO.AnalyticsDTO;
using Fastie.Components.Toastify;
using Word = Microsoft.Office.Interop.Word;

namespace Fastie.Screens.Analytics
{
    public partial class XuatFile : Form
    {
        private string charPath;
        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();
        private string idBoPhan;
        private string idNhanSu;
        private string idTaiKhoan;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string hoTen;
        private string chucVu;
        private string boPhan;

        public XuatFile()
        {
            InitializeComponent();
        }

        public XuatFile(string idBoPhan, string ngayBatDau, string ngayKetThuc)
        {
            InitializeComponent();
            this.idBoPhan = idBoPhan;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public XuatFile(string idBoPhan, string idNhanSu, string idTaiKhoan, string ngayBatDau, string ngayKetThuc, string charPath, string hoTen, string chucVu, string boPhan)
        {
            InitializeComponent();
            this.idBoPhan = idBoPhan;
            this.idNhanSu = idNhanSu;
            this.idTaiKhoan = idTaiKhoan;  // Ensure this is assigned correctly
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;

            Console.WriteLine($"Constructor received idTaiKhoan: {idTaiKhoan}");
            this.charPath = charPath;
            this.hoTen = hoTen;
            this.chucVu = chucVu;
            this.boPhan = boPhan;
        }



        //public LayMaTaiKhoanTheoMaBoPhanVaMaNhanSu(string idBoPhan, string idNhanSu)
        //{

        //}
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        /*
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            showMessage("Đang xuất file, vui lòng chờ...", "success");

            string filePath = "D:\\Bao_cao.docx";

            // Tạo đối tượng Word Application
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            try
            {
                // Thiết lập font mặc định
                doc.Content.Font.Name = "Times New Roman";
                doc.Content.Font.Size = 13;

                // Header
                Word.HeaderFooter header = doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                header.Range.Text = "";
                if (ckbDocumentName.Checked) header.Range.Text += ("\n" + ckbDocumentName.Text);
                if (ckbDocumentNumber.Checked) header.Range.Text += ("\n" + ckbDocumentNumber.Text);
                if (ckbDocumentDate.Checked) header.Range.Text += ("\n" + ckbDocumentDate.Text);
                header.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                // Footer
                Word.HeaderFooter footer = doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                footer.Range.Text = "";
                if (ckbSoftwareVersion.Checked) footer.Range.Text += ("\n" + ckbSoftwareVersion.Text);
                footer.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                // Tiêu đề chính
                var title = doc.Content.Paragraphs.Add();
                title.Range.Text = "BÁO CÁO KẾT QUẢ CÔNG VIỆC";
                title.Range.Font.Size = 16;
                title.Range.Font.Bold = 1;
                title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                // Thông tin đối tượng
                Word.Paragraph para1 = doc.Content.Paragraphs.Add();
                para1.Range.Text = "Họ và tên: Đỗ Thị Kiều Thanh\n";
                para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para1.Range.InsertParagraphAfter();

                Word.Paragraph para2 = doc.Content.Paragraphs.Add();
                para2.Range.Text = "Chức vụ: Quản lý\n";
                para2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para2.Range.InsertParagraphAfter();

                Word.Paragraph para3 = doc.Content.Paragraphs.Add();
                para3.Range.Text = "Bộ phận: Kế toán\n";
                para3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para3.Range.InsertParagraphAfter();

                Word.Paragraph para4 = doc.Content.Paragraphs.Add();
                para4.Range.Text = $"Thời gian thống kê: {ngayBatDau} – {ngayKetThuc}\n";
                para4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para4.Range.InsertParagraphAfter();

                // Dữ liệu bảng thống kê tiến độ công việc
                List<ThongTinThongKe> data = analyticsBLL.LayBangThongKeTienDoCongViecTheoMaTaiKhoan(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Tạo bảng trong Word
                Word.Table table = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, data.Count + 1, 3);
                table.Borders.Enable = 1;
                table.AllowAutoFit = true;

                // Header của bảng
                table.Cell(1, 1).Range.Text = "ID Công Việc";
                table.Cell(1, 2).Range.Text = "Tên Công Việc";
                table.Cell(1, 3).Range.Text = "Tiến Độ Công Việc";

                // Định dạng header
                for (int col = 1; col <= 3; col++)
                {
                    table.Cell(1, col).Range.Font.Bold = 1;
                    table.Cell(1, col).Range.Font.Name = "Times New Roman";
                    table.Cell(1, col).Range.Font.Size = 12;
                    table.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                // Điền dữ liệu vào bảng
                for (int i = 0; i < data.Count; i++)
                {
                    table.Cell(i + 2, 1).Range.Text = data[i].IdCongViec;
                    table.Cell(i + 2, 2).Range.Text = data[i].TenCongViec;
                    table.Cell(i + 2, 3).Range.Text = data[i].TienDoCongViec;

                    for (int col = 1; col <= 3; col++)
                    {
                        table.Cell(i + 2, col).Range.Font.Name = "Times New Roman";
                        table.Cell(i + 2, col).Range.Font.Size = 12;
                        table.Cell(i + 2, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                }

                Word.Paragraph space = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu bảng thống kê số công việc hoàn thành đúng hạn và trễ hạn
                List<ThongTinThongKe> summaryData = analyticsBLL.LayThongKeSoCongViecHoanThanhDungHanTreHan(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Tạo bảng thống kê số công việc hoàn thành đúng hạn và trễ hạn
                Word.Table summaryTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                summaryTable.Borders.Enable = 1;
                summaryTable.AllowAutoFit = true;

                // Header của bảng
                summaryTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                summaryTable.Cell(1, 2).Range.Text = "Số Lượng";

                // Định dạng header
                for (int col = 1; col <= 2; col++)
                {
                    summaryTable.Cell(1, col).Range.Font.Bold = 1;
                    summaryTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    summaryTable.Cell(1, col).Range.Font.Size = 12;
                    summaryTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                if (summaryData.Count > 0)
                {
                    summaryTable.Cell(2, 1).Range.Text = "Hoàn thành đúng hạn";
                    summaryTable.Cell(2, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhDungHan.ToString();

                    summaryTable.Cell(3, 1).Range.Text = "Hoàn thành trễ hạn";
                    summaryTable.Cell(3, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhTreHan.ToString();
                }
                else
                {
                    summaryTable.Cell(2, 1).Range.Text = "Không có dữ liệu";
                    summaryTable.Cell(2, 2).Range.Text = "0";
                }
                Word.Paragraph space1 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();
                // Dữ liệu bảng thống kê nhận việc chủ động
                List<ThongTinThongKe> activeTaskData = analyticsBLL.LayThongKeSoLanNhanViecChuDongVaSoLanXinDieuChinhPhanCong(idTaiKhoan, ngayBatDau, ngayKetThuc);

                Word.Table activeTaskTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                activeTaskTable.Borders.Enable = 1;
                activeTaskTable.AllowAutoFit = true;

                // Header của bảng
                activeTaskTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                activeTaskTable.Cell(1, 2).Range.Text = "Số Lượng";

                for (int col = 1; col <= 2; col++)
                {
                    activeTaskTable.Cell(1, col).Range.Font.Bold = 1;
                    activeTaskTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    activeTaskTable.Cell(1, col).Range.Font.Size = 12;
                    activeTaskTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                // Điền dữ liệu vào bảng
                // Điền dữ liệu vào bảng
                if (activeTaskData.Count > 0)
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Số lần nhận việc chủ động";
                    activeTaskTable.Cell(2, 2).Range.Text = activeTaskData[0].SoLanNhanViecChuDong.ToString();

                    activeTaskTable.Cell(3, 1).Range.Text = "Số lần xin điều chỉnh phân công";
                    activeTaskTable.Cell(3, 2).Range.Text = activeTaskData[0].SoLanXinDieuChinhPhanCong.ToString();
                }
                else
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Không có dữ liệu";
                    activeTaskTable.Cell(2, 2).Range.Text = "0";
                }
                Word.Paragraph space2 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu tỷ lệ hoàn thành công việc
                ThongTinThongKe completionRateData = analyticsBLL.LayThongKeTiLeHoanThanhCongViec(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Chuyển đổi tỷ lệ
                int tiLeHoanThanh = (int)Math.Round(completionRateData.TiLeHoanThanhCongViec * 100, 0);

                // Bảng thống kê tỷ lệ hoàn thành công việc
                Word.Paragraph completionRateTitle = doc.Content.Paragraphs.Add();
                completionRateTitle.Range.Text = "Bảng thống kê tỷ lệ hoàn thành công việc:";
                completionRateTitle.Range.Font.Bold = 1;
                completionRateTitle.Range.Font.Size = 14;
                completionRateTitle.Range.InsertParagraphAfter();

                Word.Table completionRateTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                completionRateTable.Borders.Enable = 1;
                completionRateTable.AllowAutoFit = true;

                completionRateTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                completionRateTable.Cell(1, 2).Range.Text = "Tỷ Lệ (%)";

                for (int col = 1; col <= 2; col++)
                {
                    completionRateTable.Cell(1, col).Range.Font.Bold = 1;
                    completionRateTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    completionRateTable.Cell(1, col).Range.Font.Size = 12;
                    completionRateTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                completionRateTable.Cell(2, 1).Range.Text = "Tỷ lệ hoàn thành công việc";
                completionRateTable.Cell(2, 2).Range.Text = $"{tiLeHoanThanh} %";


                // Lưu file
                doc.SaveAs2(filePath);
                MessageBox.Show("Báo cáo đã được tạo thành công tại: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                doc.Close();
                wordApp.Quit();
            }
        }
        */
        /*
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            showMessage("Đang xuất file, vui lòng chờ...", "success");

            string filePath = "D:\\Bao_cao.docx";

            // Tạo đối tượng Word Application
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            try
            {
                // Thiết lập font mặc định
                doc.Content.Font.Name = "Times New Roman";
                doc.Content.Font.Size = 13;

                // Header
                Word.HeaderFooter header = doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                header.Range.Text = ""; // Reset header

                // Thêm nội dung Header dựa trên checkbox
                if (ckbDocumentName.Checked)
                {
                    header.Range.Text += "Tên tài liệu: Báo cáo kết quả công việc tháng 11.2024\n";
                }
                if (ckbDocumentNumber.Checked)
                {
                    header.Range.Text += "Số tài liệu: BC001_TK0000000003\n";
                }
                if (ckbDocumentDate.Checked)
                {
                    header.Range.Text += "Ngày: 26/11/2024\n";
                }
                if (ckbSoftwareVersion.Checked)
                {
                    header.Range.Text +=  "Fastie v0.1.4";
                }

                header.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                // Footer
                Word.HeaderFooter footer = doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                footer.Range.Text = ""; // Reset footer

                // Sử dụng StringBuilder để ghép nội dung Footer
                StringBuilder footerText = new StringBuilder();

           
                // Ghi nội dung ban đầu vào footer
                footer.Range.Text = footerText.ToString();

                // Thêm số trang nếu checkbox được chọn
                if (ckbLabelNumberOfPages.Checked)
                {
                    // Chèn trường đánh số trang
                    footer.Range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    footer.Range.Text += "Trang số: ";
                    footer.Range.Fields.Add(footer.Range, Word.WdFieldType.wdFieldPage);

                    footer.Range.Text += " / "; // Thêm dấu "/"

                    // Chèn trường tổng số trang
                    footer.Range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    footer.Range.Fields.Add(footer.Range, Word.WdFieldType.wdFieldNumPages);
                }

                // Căn trái cho Footer
                footer.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;



                // Tiêu đề chính
                var title = doc.Content.Paragraphs.Add();
                title.Range.Text = "BÁO CÁO KẾT QUẢ CÔNG VIỆC";
                title.Range.Font.Size = 16;
                title.Range.Font.Bold = 1;
                title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                // Thông tin đối tượng
                Word.Paragraph para1 = doc.Content.Paragraphs.Add();
                para1.Range.Text = "Họ và tên: Đỗ Thị Kiều Thanh\n";
                para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para1.Range.InsertParagraphAfter();

                Word.Paragraph para2 = doc.Content.Paragraphs.Add();
                para2.Range.Text = "Chức vụ: Quản lý\n";
                para2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para2.Range.InsertParagraphAfter();

                Word.Paragraph para3 = doc.Content.Paragraphs.Add();
                para3.Range.Text = "Bộ phận: Kế toán\n";
                para3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para3.Range.InsertParagraphAfter();

                Word.Paragraph para4 = doc.Content.Paragraphs.Add();
                para4.Range.Text = $"Thời gian thống kê: {ngayBatDau} – {ngayKetThuc}\n";
                para4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para4.Range.InsertParagraphAfter();

                // Dữ liệu bảng thống kê tiến độ công việc
                List<ThongTinThongKe> data = analyticsBLL.LayBangThongKeTienDoCongViecTheoMaTaiKhoan(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Tạo bảng trong Word
                Word.Table table = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, data.Count + 1, 3);
                table.Borders.Enable = 1;
                table.AllowAutoFit = true;

                // Header của bảng
                table.Cell(1, 1).Range.Text = "ID Công Việc";
                table.Cell(1, 2).Range.Text = "Tên Công Việc";
                table.Cell(1, 3).Range.Text = "Tiến Độ Công Việc";

                // Định dạng header
                for (int col = 1; col <= 3; col++)
                {
                    table.Cell(1, col).Range.Font.Bold = 1;
                    table.Cell(1, col).Range.Font.Name = "Times New Roman";
                    table.Cell(1, col).Range.Font.Size = 12;
                    table.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                // Điền dữ liệu vào bảng
                for (int i = 0; i < data.Count; i++)
                {
                    table.Cell(i + 2, 1).Range.Text = data[i].IdCongViec;
                    table.Cell(i + 2, 2).Range.Text = data[i].TenCongViec;
                    table.Cell(i + 2, 3).Range.Text = data[i].TienDoCongViec;

                    for (int col = 1; col <= 3; col++)
                    {
                        table.Cell(i + 2, col).Range.Font.Name = "Times New Roman";
                        table.Cell(i + 2, col).Range.Font.Size = 12;
                        table.Cell(i + 2, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                }

                Word.Paragraph space = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu bảng thống kê số công việc hoàn thành đúng hạn và trễ hạn
                List<ThongTinThongKe> summaryData = analyticsBLL.LayThongKeSoCongViecHoanThanhDungHanTreHan(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Tạo bảng thống kê số công việc hoàn thành đúng hạn và trễ hạn
                Word.Table summaryTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                summaryTable.Borders.Enable = 1;
                summaryTable.AllowAutoFit = true;

                // Header của bảng
                summaryTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                summaryTable.Cell(1, 2).Range.Text = "Số Lượng";

                // Định dạng header
                for (int col = 1; col <= 2; col++)
                {
                    summaryTable.Cell(1, col).Range.Font.Bold = 1;
                    summaryTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    summaryTable.Cell(1, col).Range.Font.Size = 12;
                    summaryTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                if (summaryData.Count > 0)
                {
                    summaryTable.Cell(2, 1).Range.Text = "Hoàn thành đúng hạn";
                    summaryTable.Cell(2, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhDungHan.ToString();

                    summaryTable.Cell(3, 1).Range.Text = "Hoàn thành trễ hạn";
                    summaryTable.Cell(3, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhTreHan.ToString();
                }
                else
                {
                    summaryTable.Cell(2, 1).Range.Text = "Không có dữ liệu";
                    summaryTable.Cell(2, 2).Range.Text = "0";
                }
                Word.Paragraph space1 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();
                // Dữ liệu bảng thống kê nhận việc chủ động
                List<ThongTinThongKe> activeTaskData = analyticsBLL.LayThongKeSoLanNhanViecChuDongVaSoLanXinDieuChinhPhanCong(idTaiKhoan, ngayBatDau, ngayKetThuc);

                Word.Table activeTaskTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                activeTaskTable.Borders.Enable = 1;
                activeTaskTable.AllowAutoFit = true;

                // Header của bảng
                activeTaskTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                activeTaskTable.Cell(1, 2).Range.Text = "Số Lượng";

                for (int col = 1; col <= 2; col++)
                {
                    activeTaskTable.Cell(1, col).Range.Font.Bold = 1;
                    activeTaskTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    activeTaskTable.Cell(1, col).Range.Font.Size = 12;
                    activeTaskTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                // Điền dữ liệu vào bảng
                // Điền dữ liệu vào bảng
                if (activeTaskData.Count > 0)
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Số lần nhận việc chủ động";
                    activeTaskTable.Cell(2, 2).Range.Text = activeTaskData[0].SoLanNhanViecChuDong.ToString();

                    activeTaskTable.Cell(3, 1).Range.Text = "Số lần xin điều chỉnh phân công";
                    activeTaskTable.Cell(3, 2).Range.Text = activeTaskData[0].SoLanXinDieuChinhPhanCong.ToString();
                }
                else
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Không có dữ liệu";
                    activeTaskTable.Cell(2, 2).Range.Text = "0";
                }
                Word.Paragraph space2 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu tỷ lệ hoàn thành công việc
                ThongTinThongKe completionRateData = analyticsBLL.LayThongKeTiLeHoanThanhCongViec(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Chuyển đổi tỷ lệ
                int tiLeHoanThanh = (int)Math.Round(completionRateData.TiLeHoanThanhCongViec * 100, 0);

                // Bảng thống kê tỷ lệ hoàn thành công việc
                Word.Paragraph completionRateTitle = doc.Content.Paragraphs.Add();
                completionRateTitle.Range.Text = "Bảng thống kê tỷ lệ hoàn thành công việc:";
                completionRateTitle.Range.Font.Bold = 1;
                completionRateTitle.Range.Font.Size = 14;
                completionRateTitle.Range.InsertParagraphAfter();

                Word.Table completionRateTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                completionRateTable.Borders.Enable = 1;
                completionRateTable.AllowAutoFit = true;

                completionRateTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                completionRateTable.Cell(1, 2).Range.Text = "Tỷ Lệ (%)";

                for (int col = 1; col <= 2; col++)
                {
                    completionRateTable.Cell(1, col).Range.Font.Bold = 1;
                    completionRateTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    completionRateTable.Cell(1, col).Range.Font.Size = 12;
                    completionRateTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                completionRateTable.Cell(2, 1).Range.Text = "Tỷ lệ hoàn thành công việc";
                completionRateTable.Cell(2, 2).Range.Text = $"{tiLeHoanThanh} %";


                // Lưu file
                doc.SaveAs2(filePath);
                MessageBox.Show("Báo cáo đã được tạo thành công tại: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                doc.Close();
                wordApp.Quit();
            }
        }
        */



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            showMessage("Đang xuất file, vui lòng chờ...", "success");

            string filePath = "D:\\Bao_cao.docx";
            string hoTenCleaned = hoTen.Contains(",") ? hoTen.Split(',')[1].Trim() : hoTen.Trim();
            string hoTenCleaned1 = hoTenCleaned.Replace("[", "").Replace("]", "").Split(',').Last().Trim();
            string chucVuCleaned = chucVu.Contains(",") ? chucVu.Split(',')[1].Trim() : chucVu.Trim();
            string chucVuCleaned1 = chucVuCleaned.Replace("[", "").Replace("]", "").Split(',').Last().Trim();
            string boPhanCleaned = boPhan.Contains(",") ? boPhan.Split(',')[1].Trim() : boPhan.Trim();
            string boPhanCleaned1 = boPhanCleaned.Replace("[", "").Replace("]", "").Split(',').Last().Trim();



            // Tạo đối tượng Word Application
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();

            try
            {
                // Thiết lập font mặc định
                doc.Content.Font.Name = "Times New Roman";
                doc.Content.Font.Size = 13;

                // Header
                Word.HeaderFooter header = doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                header.Range.Text = ""; // Reset header

                // Thêm nội dung Header dựa trên checkbox
                if (ckbDocumentName.Checked)
                {
                    header.Range.Text += "Tên tài liệu: Báo cáo kết quả công việc tháng 11.2024";
                }
                if (ckbDocumentNumber.Checked)
                {
                    header.Range.Text += "Số tài liệu: BC001_TK0000000003";
                }
                if (ckbDocumentDate.Checked)
                {
                    header.Range.Text += $"Ngày: {DateTime.Now.ToString("dd/MM/yyyy")}";
                }
                if (ckbSoftwareVersion.Checked)
                {
                    header.Range.Text += "Fastie v0.1.4";
                }
                header.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                // Footer
                Word.HeaderFooter footer = doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
                footer.Range.Text = ""; // Reset footer
                if (ckbLabelNumberOfPages.Checked)
                {
                    footer.Range.Text += "Trang số: ";
                    footer.Range.Fields.Add(footer.Range, Word.WdFieldType.wdFieldPage);
                }

                // Thêm thông tin mặc định
                var title1 = doc.Content.Paragraphs.Add();
                title1.Range.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
                title1.Range.Font.Size = 14;
                title1.Range.Font.Bold = 1;
                title1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title1.Range.InsertParagraphAfter();

                var title2 = doc.Content.Paragraphs.Add();
                title2.Range.Text = "Độc lập – Tự do – Hạnh phúc";
                title2.Range.Font.Size = 14;
                title2.Range.Font.Bold = 1;
                title2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title2.Range.InsertParagraphAfter();

                var date = doc.Content.Paragraphs.Add();
                date.Range.Text = $"Tp.Hồ Chí Minh, ngày {DateTime.Now.ToString("dd")} tháng {DateTime.Now.ToString("MM")} năm {DateTime.Now.ToString("yyyy")}";
                date.Range.Font.Size = 12;
                date.Range.Font.Bold = 0;
                date.Range.Font.Italic = 1;
                date.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight; // Căn phải
                date.Range.ParagraphFormat.SpaceAfter = 6; // Tạo khoảng cách sau ngày tháng
                date.Range.InsertParagraphAfter();


                // Thêm một đoạn văn mới để kiểm tra căn giữa
                var testParagraph = doc.Content.Paragraphs.Add();
                testParagraph.Range.Text = "BÁO CÁO KẾT QUẢ CÔNG VIỆC THÁNG 11/ NĂM 2024";
                testParagraph.Range.Font.Size = 16;
                testParagraph.Range.Font.Bold = 1;
                testParagraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                testParagraph.Range.ParagraphFormat.SpaceAfter = 10; // Tạo khoảng cách sau đoạn
                testParagraph.Range.InsertParagraphAfter();


                // Thêm thông tin cá nhân
                var info1 = doc.Content.Paragraphs.Add();
                info1.Range.Text = $"Họ và tên: {hoTenCleaned1}"; // Loại bỏ ID, chỉ lấy tên
                info1.Range.Font.Size = 13;
                info1.Range.Font.Bold = 0; // Không in đậm
                info1.Range.Font.Italic = 0; // Không in nghiêng
                info1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                info1.Range.InsertParagraphAfter();

                var info2 = doc.Content.Paragraphs.Add();
                info2.Range.Text = $"Chức vụ: {chucVuCleaned1}"; // Lấy phần chức vụ từ chuỗi (bỏ mã số)
                info2.Range.Font.Size = 13;
                info2.Range.Font.Bold = 0; // Không in đậm
                info2.Range.Font.Italic = 0; // Không in nghiêng
                info2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                info2.Range.InsertParagraphAfter();

                var info3 = doc.Content.Paragraphs.Add();
                info3.Range.Text = $"Bộ phận: {boPhanCleaned1}"; // Lấy phần bộ phận từ chuỗi (bỏ mã số)
                info3.Range.Font.Size = 13;
                info3.Range.Font.Bold = 0; // Không in đậm
                info3.Range.Font.Italic = 0; // Không in nghiêng
                info3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                info3.Range.InsertParagraphAfter();


                var info4 = doc.Content.Paragraphs.Add();
                info4.Range.Text = $"Thời gian thống kê: {ngayBatDau} – {ngayKetThuc}"; // Sử dụng thời gian truyền vào
                info4.Range.Font.Size = 13;
                info4.Range.Font.Bold = 0; // Không in đậm
                info4.Range.Font.Italic = 0; // Không in nghiêng
                info4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                info4.Range.InsertParagraphAfter();

                // Dữ liệu bảng thống kê tiến độ công việc
                List<ThongTinThongKe> data = analyticsBLL.LayBangThongKeTienDoCongViecTheoMaTaiKhoan(idTaiKhoan, ngayBatDau, ngayKetThuc);
                // Thêm tiêu đề cho bảng thống kê tiến độ công việc
                var progressTableTitle = doc.Content.Paragraphs.Add();
                progressTableTitle.Range.Text = "Bảng 1: Thống kê tiến độ công việc";
                progressTableTitle.Range.Font.Size = 13;
                progressTableTitle.Range.Font.Bold = 1;
                progressTableTitle.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                progressTableTitle.Range.InsertParagraphAfter();

                // Tạo bảng thống kê tiến độ công việc
                Word.Table table = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, data.Count + 1, 3);
                table.Borders.Enable = 1;
                table.AllowAutoFit = true;

                // Header của bảng
                table.Cell(1, 1).Range.Text = "STT";
                table.Cell(1, 2).Range.Text = "Tên Công Việc";
                table.Cell(1, 3).Range.Text = "Tiến Độ Công Việc";

                // Định dạng header
                for (int col = 1; col <= 3; col++)
                {
                    table.Cell(1, col).Range.Font.Bold = 0; // Không in đậm
                    table.Cell(1, col).Range.Font.Italic = 0; // Không in nghiêng
                    table.Cell(1, col).Range.Font.Name = "Times New Roman";
                    table.Cell(1, col).Range.Font.Size = 12;
                    table.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                // Điền dữ liệu vào bảng
                for (int i = 0; i < data.Count; i++)
                {
                    table.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                    table.Cell(i + 2, 2).Range.Text = data[i].TenCongViec.ToLower(); // In thường
                    table.Cell(i + 2, 3).Range.Text = data[i].TienDoCongViec.ToLower(); // In thường

                    for (int col = 1; col <= 3; col++)
                    {
                        table.Cell(i + 2, col).Range.Font.Bold = 0; // Không in đậm
                        table.Cell(i + 2, col).Range.Font.Italic = 0; // Không in nghiêng
                        table.Cell(i + 2, col).Range.Font.Name = "Times New Roman";
                        table.Cell(i + 2, col).Range.Font.Size = 12;
                        table.Cell(i + 2, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                }

                Word.Paragraph space = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu bảng thống kê số công việc hoàn thành đúng hạn và trễ hạn
                List<ThongTinThongKe> summaryData = analyticsBLL.LayThongKeSoCongViecHoanThanhDungHanTreHan(idTaiKhoan, ngayBatDau, ngayKetThuc);
                var completedTaskTableTitle = doc.Content.Paragraphs.Add();
                completedTaskTableTitle.Range.Text = "Bảng 2: Thống kê số công việc hoàn thành đúng hạn và trễ hạn"; // In thường
                completedTaskTableTitle.Range.Font.Size = 13;
                completedTaskTableTitle.Range.Font.Bold = 1; // Không in đậm
                completedTaskTableTitle.Range.Font.Italic = 0; // Không in nghiêng
                completedTaskTableTitle.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                completedTaskTableTitle.Range.InsertParagraphAfter();



                // Tạo bảng thống kê số công việc hoàn thành
                Word.Table summaryTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                summaryTable.Borders.Enable = 1;
                summaryTable.AllowAutoFit = true;

                // Header của bảng
                summaryTable.Cell(1, 1).Range.Text = "Loại Thống Kê";
                summaryTable.Cell(1, 2).Range.Text = "Số Lượng";

                // Định dạng header
                for (int col = 1; col <= 2; col++)
                {
                    summaryTable.Cell(1, col).Range.Font.Bold = 0; // Không in đậm
                    summaryTable.Cell(1, col).Range.Font.Italic = 0; // Không in nghiêng
                    summaryTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    summaryTable.Cell(1, col).Range.Font.Size = 12;
                    summaryTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                if (summaryData.Count > 0)
                {
                    summaryTable.Cell(2, 1).Range.Text = "Hoàn thành đúng hạn"; // In thường
                    summaryTable.Cell(2, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhDungHan.ToString();

                    summaryTable.Cell(3, 1).Range.Text = "Hoàn thành trễ hạn"; // In thường
                    summaryTable.Cell(3, 2).Range.Text = summaryData[0].SoLuongCongViecHoanThanhTreHan.ToString();
                }
                else
                {
                    summaryTable.Cell(2, 1).Range.Text = "Không có dữ liệu"; // In thường
                    summaryTable.Cell(2, 2).Range.Text = "0";
                }

                Word.Paragraph space1 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();
                // Dữ liệu bảng thống kê nhận việc chủ động
                List<ThongTinThongKe> activeTaskData = analyticsBLL.LayThongKeSoLanNhanViecChuDongVaSoLanXinDieuChinhPhanCong(idTaiKhoan, ngayBatDau, ngayKetThuc);
                var activeTaskTableTitle = doc.Content.Paragraphs.Add();
                activeTaskTableTitle.Range.Text = "Bảng 3: Thống kê nhận việc chủ động và xin điều chỉnh phân công"; // In thường
                activeTaskTableTitle.Range.Font.Size = 13;
                activeTaskTableTitle.Range.Font.Bold = 1; // Không in đậm
                activeTaskTableTitle.Range.Font.Italic = 0; // Không in nghiêng
                activeTaskTableTitle.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                activeTaskTableTitle.Range.InsertParagraphAfter();

                // Tạo bảng thống kê nhận việc chủ động
                Word.Table activeTaskTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 3, 2);
                activeTaskTable.Borders.Enable = 1;
                activeTaskTable.AllowAutoFit = true;

                // Header của bảng
                activeTaskTable.Cell(1, 1).Range.Text = "Loại thống kê"; // In thường
                activeTaskTable.Cell(1, 2).Range.Text = "Số lượng"; // In thường

                for (int col = 1; col <= 2; col++)
                {
                    activeTaskTable.Cell(1, col).Range.Font.Bold = 0; // Không in đậm
                    activeTaskTable.Cell(1, col).Range.Font.Italic = 0; // Không in nghiêng
                    activeTaskTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    activeTaskTable.Cell(1, col).Range.Font.Size = 12;
                    activeTaskTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }


                if (activeTaskData.Count > 0)
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Số lần nhận việc chủ động"; // In thường
                    activeTaskTable.Cell(2, 2).Range.Text = activeTaskData[0].SoLanNhanViecChuDong.ToString();

                    activeTaskTable.Cell(3, 1).Range.Text = "Số lần xin điều chỉnh phân công"; // In thường
                    activeTaskTable.Cell(3, 2).Range.Text = activeTaskData[0].SoLanXinDieuChinhPhanCong.ToString();
                }
                else
                {
                    activeTaskTable.Cell(2, 1).Range.Text = "Không có dữ liệu"; // In thường
                    activeTaskTable.Cell(2, 2).Range.Text = "0";
                }
                Word.Paragraph space2 = doc.Content.Paragraphs.Add();
                space.Range.Text = "\n";
                space.Range.InsertParagraphAfter();

                // Lấy dữ liệu tỷ lệ hoàn thành công việc
                ThongTinThongKe completionRateData = analyticsBLL.LayThongKeTiLeHoanThanhCongViec(idTaiKhoan, ngayBatDau, ngayKetThuc);

                // Chuyển đổi tỷ lệ
                int tiLeHoanThanh = (int)Math.Round(completionRateData.TiLeHoanThanhCongViec * 100, 0);

                // Thêm tiêu đề cho bảng thống kê tỷ lệ hoàn thành công việc
                var completionRateTableTitle = doc.Content.Paragraphs.Add();
                completionRateTableTitle.Range.Text = "Bảng 4: Thống kê tỷ lệ hoàn thành công việc"; // In thường
                completionRateTableTitle.Range.Font.Size = 13;
                completionRateTableTitle.Range.Font.Bold = 1; // Không in đậm
                completionRateTableTitle.Range.Font.Italic = 0; // Không in nghiêng
                completionRateTableTitle.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                completionRateTableTitle.Range.InsertParagraphAfter();




                Word.Table completionRateTable = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, 1, 2);
                completionRateTable.Borders.Enable = 1;
                completionRateTable.AllowAutoFit = true;

                completionRateTable.Cell(1, 1).Range.Text = "Loại thống kê"; // In thường
                completionRateTable.Cell(1, 2).Range.Text = "Tỷ lệ (%)"; // In thường

                for (int col = 1; col <= 2; col++)
                {
                    completionRateTable.Cell(1, col).Range.Font.Bold = 0; // Không in đậm
                    completionRateTable.Cell(1, col).Range.Font.Italic = 0; // Không in nghiêng
                    completionRateTable.Cell(1, col).Range.Font.Name = "Times New Roman";
                    completionRateTable.Cell(1, col).Range.Font.Size = 12;
                    completionRateTable.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }


                completionRateTable.Cell(2, 1).Range.Text = "Tỷ lệ hoàn thành công việc";
                completionRateTable.Cell(2, 2).Range.Text = $"{tiLeHoanThanh} %";


                // Lưu file
                doc.SaveAs2(filePath);
                MessageBox.Show("Báo cáo đã được tạo thành công tại: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                doc.Close();
                wordApp.Quit();
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
