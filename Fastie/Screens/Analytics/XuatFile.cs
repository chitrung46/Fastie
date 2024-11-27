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
        private AnalyticsBLL analyticsBLL = new AnalyticsBLL();
        private string idBoPhan;
        private string idNhanSu;
        private string idTaiKhoan;
        private string ngayBatDau;
        private string ngayKetThuc;

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

        public XuatFile(string idBoPhan, string idNhanSu, string ngayBatDau, string ngayKetThuc)
        {
            InitializeComponent();
            this.idBoPhan = idBoPhan;
            this.idNhanSu = idNhanSu;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            showMessage("Xuất file thành công", "success");
            this.Close();
            //string filePath = "D:\\Bao_cao.docx";

            //// Tạo đối tượng Word Application
            //Word.Application wordApp = new Word.Application();
            //Word.Document doc = wordApp.Documents.Add();

            //try
            //{
            //    doc.Content.Font.Name = "Times New Roman";
            //    doc.Content.Font.Size = 13; 
            //    doc.Content.Font.Bold = 0;  
            //    doc.Content.Font.Italic = 0; 

            //    // Header
            //    Word.HeaderFooter header = doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
            //    header.Range.Text = "";

            //    if (ckbDocumentName.Checked)                       
            //        header.Range.Text += ("\n" + ckbDocumentName.Text);
            //    if (ckbDocumentNumber.Checked)
            //        header.Range.Text += ("\n" + ckbDocumentNumber.Text);
            //    if (ckbDocumentDate.Checked)
            //        header.Range.Text += ("\n" + ckbDocumentDate.Text);

            //    header.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            //    // Footer
            //    Word.HeaderFooter footer = doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];
            //    footer.Range.Text = "";

            //    if (ckbSoftwareVersion.Checked)
            //        footer.Range.Text += ("\n" + ckbSoftwareVersion.Text);
            //    //if (ckbLabelNumberOfPages.Checked)
            //    //    footer.Range.Text += ("\n" + ckbLabelNumberOfPages.Text);
            //    footer.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            //    // Tiêu đề chính
            //    var title = doc.Content.Paragraphs.Add();
            //    title.Range.Text = "BÁO CÁO KẾT QUẢ CÔNG VIỆC";
            //    title.Range.Font.Size = 16;
            //    title.Range.Font.Bold = 1;
            //    title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //    title.Range.InsertParagraphAfter();

            //    // Thông tin đối tượng được thống kê báo cáo
            //    Word.Paragraph para1 = doc.Content.Paragraphs.Add();
            //    para1.Range.Text = "Họ và tên: Đỗ Thị Kiều Thanh\n";
            //    para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            //    para1.Range.InsertParagraphAfter();

            //    Word.Paragraph para2 = doc.Content.Paragraphs.Add();
            //    para2.Range.Text = "Chức vụ: Quản lý\n";
            //    para2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            //    para2.Range.InsertParagraphAfter();

            //    Word.Paragraph para3 = doc.Content.Paragraphs.Add();
            //    para3.Range.Text = "Bộ phận: Kế toán\n";
            //    para3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            //    para3.Range.InsertParagraphAfter();

            //    Word.Paragraph para4 = doc.Content.Paragraphs.Add();
            //    para4.Range.Text = "Thời gian thống kê: 01/11/2024 – 30/11/2024\n";
            //    para4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            //    para4.Range.InsertParagraphAfter();

            //    XuatBangThongKeTrangThaiCongViecTheoMaTaiKhoan(doc, idTaiKhoan, ngayBatDau, ngayKetThuc);

            //    // Lưu file
            //    doc.SaveAs2(filePath);
            //    MessageBox.Show("Báo cáo đã được tạo thành công tại: " + filePath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            //}
            //finally
            //{
            //    doc.Close();
            //    wordApp.Quit();
            //}
        }

        private void XuatBangThongKeTrangThaiCongViecTheoMaTaiKhoan(Word.Document doc, string idTaiKhoan, string ngayBatDau, string ngayKetThuc)
        {
            List<ThongTinThongKe> bangThongKe = analyticsBLL.LayBangThongKeTienDoCongViecTheoMaTaiKhoan(idTaiKhoan, ngayBatDau, ngayKetThuc);

            Word.Paragraph para1 = doc.Content.Paragraphs.Add();
            para1.Range.Text = "Thời gian thống kê: 01/11/2024 – 30/11/2024\n";
            para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            para1.Range.InsertParagraphAfter();

            Word.Table table = doc.Tables.Add(doc.Content.Paragraphs.Add().Range, bangThongKe.Count + 1, 3);
            table.Borders.Enable = 1; 
            table.AllowAutoFit = true;

            table.Cell(1, 1).Range.Text = "ID Công Việc";
            table.Cell(1, 2).Range.Text = "Tên Công Việc";
            table.Cell(1, 3).Range.Text = "Tiến Độ Công Việc";

            for (int col = 1; col <= 3; col++)
            {
                table.Cell(1, col).Range.Font.Bold = 1;
                table.Cell(1, col).Range.Font.Name = "Times New Roman";
                table.Cell(1, col).Range.Font.Size = 12;
                table.Cell(1, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter; 
            }

            for (int i = 0; i < bangThongKe.Count; i++)
            {
                table.Cell(i + 2, 1).Range.Text = bangThongKe[i].IdCongViec;
                table.Cell(i + 2, 2).Range.Text = bangThongKe[i].TenCongViec;
                table.Cell(i + 2, 3).Range.Text = bangThongKe[i].TienDoCongViec;

                for (int col = 1; col <= 3; col++)
                {
                    table.Cell(i + 2, col).Range.Font.Name = "Times New Roman";
                    table.Cell(i + 2, col).Range.Font.Size = 12;
                    table.Cell(i + 2, col).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft; 
                }
            }
        }
    }
}
