using Fastie.Components.LayoutTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace Fastie.Screens.Task
{
    public partial class NearlyReportForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        private TaskForm taskForm;
        private string idCongViec;
        public NearlyReportForm(TaskForm taskForm, string idCongViec)
        {
            InitializeComponent();
            this.taskForm = taskForm;
            this.idCongViec = idCongViec;  
        }

        public void LoadDataTaskTable()
        {
            flowLayoutPanelReport.Controls.Clear();
            List<DanhSachBaoCao> danhSachBaoCao = taskBLL.LayDanhSachBaoCao(idCongViec);
            foreach (var baoCao in danhSachBaoCao)
            {
                LayoutDetailReportForm layoutDetailReportForm = new LayoutDetailReportForm()
                {
                    IdReport = this.idCongViec,
                    ReportContent = baoCao.NoiDung,
                    ReportDate = baoCao.NgayBaoCao.HasValue ? baoCao.NgayBaoCao.Value.ToString("dd/MM/yyyy") : "N/A",
                    FileName = baoCao.TenFile,
                    ImageName = baoCao.TenAnh,
                    FileUrl = baoCao.DuongDanFile,
                    ImageUrl = baoCao.DuongDanAnh
                };
                flowLayoutPanelReport.Controls.Add(layoutDetailReportForm);
            }
        }

        private void NearlyReportForm_Load(object sender, EventArgs e)
        {
            LoadDataTaskTable();
        }
    }
}
