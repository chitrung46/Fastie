using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.DepartmentBLL;
using DTO;
using Fastie.Components.Toastify;
using GUI.TruniControls;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
namespace Fastie.Screens.Task
{
    public partial class DetailAssignFastingTaskForm : Form
    {

        TaskBLL taskBLL = new TaskBLL();
        private string idTaiKhoan;
        private string idBoPhanKhiDangNhap;
        DepartmentBLL departmentBLL = new DepartmentBLL();
        DataTable table = new DataTable();
        DataTable excelData = new DataTable();
        private string excelFilePath;
        private string excelFileName;
        public DetailAssignFastingTaskForm(string idTaiKhoan, string idBoPhan)
        {
            InitializeComponent();
            this.idTaiKhoan = idTaiKhoan;
            this.idBoPhanKhiDangNhap = idBoPhan;
        }

        private void DetailAssignFastingTaskForm_Load(object sender, EventArgs e)
        {
            dgvAssignTaskFast.Rows.Add("Tên công việc");
            dgvAssignTaskFast.Rows.Add("Tên loại công việc");
            dgvAssignTaskFast.Rows.Add("Mô tả công việc");
            dgvAssignTaskFast.Rows.Add("Thời hạn hoàn thành");
            this.AcceptButton = btnUpdate;
            
        }
        private int ExcelColumnLetterToNumber(string columnLetter)
        {
            int sum = 0;
            foreach (char c in columnLetter)
            {
                sum *= 26;
                sum += (c - 'A' + 1);
            }
            return sum;
        }

        private void SelectExcelFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xlsm;*.xls"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFilePath = openFileDialog.FileName;
                excelFileName = Path.GetFileName(excelFilePath);

                MessageBox.Show($"File '{excelFileName}' selected successfully!", "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void ProcessExcelData()
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                showMessage("Vui lòng chọn File", "error");
                return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.First();
                int rowCount = worksheet.Dimension.Rows;
                int startRow = int.TryParse(customTextBox1.Text, out int parsedRow) && parsedRow > 1 ? parsedRow : 2;

                // Clear previous data
                excelData.Clear();

                // Get user-input columns for each data type
                string taskNameColumn = dgvAssignTaskFast.Rows[0].Cells["Column"].Value?.ToString();
                string taskTypeColumn = dgvAssignTaskFast.Rows[1].Cells["Column"].Value?.ToString();
                string taskDescriptionColumn = dgvAssignTaskFast.Rows[2].Cells["Column"].Value?.ToString();
                string completionDeadlineColumn = dgvAssignTaskFast.Rows[3].Cells["Column"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(taskNameColumn) ||
                    string.IsNullOrWhiteSpace(taskTypeColumn) ||
                    string.IsNullOrWhiteSpace(taskDescriptionColumn) ||
                    string.IsNullOrWhiteSpace(completionDeadlineColumn))
                {
                    showMessage("Vui lòng điền đủ thôn tin", "error");
                    return;
                }

                List<string> errorMessages = new List<string>();

                for (int i = startRow; i <= rowCount; i++)
                {
                    
                    string taskName = worksheet.Cells[i, ExcelColumnLetterToNumber(taskNameColumn)].Text;
                    string taskType = worksheet.Cells[i, ExcelColumnLetterToNumber(taskTypeColumn)].Text;
                    string taskDescription = worksheet.Cells[i, ExcelColumnLetterToNumber(taskDescriptionColumn)].Text;
                    string completionDeadlineText = worksheet.Cells[i, ExcelColumnLetterToNumber(completionDeadlineColumn)].Text;

                    DateTime completionDeadline = DateTime.TryParseExact(completionDeadlineText,
                                                                        "dd/MM/yyyy HH:mm",
                                                                        CultureInfo.InvariantCulture,
                                                                        DateTimeStyles.None,
                                                                        out var parsedDate) ? parsedDate : DateTime.Now;

                    var task = new TaskInfo
                    {
                        Ten = taskName,
                        MoTa = taskDescription,
                        ThoiGianGiaoViec = DateTime.Now,
                        ThoiHanHoanThanh = completionDeadline,
                        IdTaiKhoanGiaoViec = this.idTaiKhoan,
                        IdLoaiCongViec = taskBLL.LayIdLoaiCongViecTuTen(taskType),
                        IdBoPhanGiaoViec = this.idBoPhanKhiDangNhap,
                        Id = taskBLL.TaoCongViecId(taskBLL.LayIdLoaiCongViecTuTen(taskType), this.idBoPhanKhiDangNhap),
                        GhiChu = "",
                        IdTienDoCongViec = "TD001",
                        IdLichSuMacDinh = taskBLL.TaoLichSuId()
                    };

                    bool result = taskBLL.ThemCongViecGiaoViec(task);
                    showMessage("Thêm các công việc thành công !", "success");
                    //if (!result)
                    //{
                    //    errorMessages.Add($"Failed to add task '{taskName}' at row {i}.");
                    //}
                                     
                }

                //if (errorMessages.Any())
                //{
                //    showMessage(string.Join(Environment.NewLine, errorMessages), "error");
                //}
                //else
                //{
                //    showMessage("Thêm các công việc thành công !", "success");
                //}
            }
        }


        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            SelectExcelFile();
            lblFileName.Text = excelFileName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProcessExcelData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
