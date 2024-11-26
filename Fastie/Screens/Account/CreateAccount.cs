using BLL.DecentralizationBLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fastie.Components.Toastify;
using BLL.DepartmentBLL;
using Fastie.Components.LayoutPersonnel;
using System.ComponentModel.DataAnnotations;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
namespace Fastie
{
    public partial class CreateAccount : Form
    {
        DecentralizationBLL decentralizationBLL = new DecentralizationBLL();
        AccountBLL accountBLL = new AccountBLL();
        private string stateCurrentList;
        private bool isLoaded = false;
        private string selectedDepartmentId;
        private string selectedPositionId;
        private LayoutPersonnelForm layoutPersonnelForm;
        public CreateAccount(LayoutPersonnelForm layoutPersonnelForm)
        {
            InitializeComponent();
            this.layoutPersonnelForm = layoutPersonnelForm;
        }
        private void loadDataPositionList()
        {
            List<PositionInfo> positionInfos = decentralizationBLL.getPositionList();

            if (positionInfos != null)
            {
                cbPosition.Items.Clear();
                

                foreach (PositionInfo position in positionInfos)
                {
                    cbPosition.Items.Add(new KeyValuePair<string, string>(position.IdChucVu, position.TenChucVu));
                }

                cbPosition.DisplayMember = "Value";
                cbPosition.ValueMember = "Key";

                cbPosition.SelectedIndex = 0;
            }
        }

        private void loadDataDepartmentList()
        {
            List<DepartmentInfo> departmentInfos = decentralizationBLL.getDepartmentList();

            if (departmentInfos != null)
            {
                cbDepartment.Items.Clear();
                

                foreach (DepartmentInfo department in departmentInfos)
                {
                    cbDepartment.Items.Add(new KeyValuePair<string, string>(department.IdBoPhan, department.TenBoPhan));
                }

                cbDepartment.DisplayMember = "Value";
                cbDepartment.ValueMember = "Key";

                cbDepartment.SelectedIndex = 0;
            }
        }
        private void showMessage(string message, string type)
        {
            LayoutToastify layoutToastify = new LayoutToastify();
            layoutToastify.SetMessage(message, type);
            layoutToastify.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            isLoaded = false;
            loadDataDepartmentList();
            loadDataPositionList();
            isLoaded = true;
            this.AcceptButton = btnAdd;
        }

        private void cbDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbDepartment.SelectedItem).Key;
                this.selectedDepartmentId = selectedId;                
            }
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                var selectedId = ((KeyValuePair<string, string>)cbPosition.SelectedItem).Key;
                this.selectedPositionId = selectedId;                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                showMessage("Vui lòng nhập tên đăng nhập", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (!IsValidEmail(txtUsername.Text))
            {
                showMessage("Tên đăng nhập không hợp lệ", "error");
                btnAdd.Enabled = true;

                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                showMessage("Vui lòng nhập mật khẩu", "error");
                btnAdd.Enabled = true;

                return;
            }
            if (txtPassword.Text.Length < 6)
            {
                showMessage("Mật khẩu phải có ít nhất 6 ký tự", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (selectedDepartmentId == null)
            {
                showMessage("Vui lòng chọn bộ phận", "error");
                btnAdd.Enabled = true;
                return;
            }
            if (selectedPositionId == null)
            {
                showMessage("Vui lòng chọn chức vụ", "error");
                btnAdd.Enabled = true;
                return;
            }
            
            Account taoTaiKhoanMoi = new Account
            {
                TenDangNhap = txtUsername.Text,
                MatKhau = txtPassword.Text,
                IdNhanSu = layoutPersonnelForm.IdPersonnel,
                IdChucVu = this.selectedPositionId,
                IdBoPhan = this.selectedDepartmentId
            };
                                    
            int result = accountBLL.ThemTaiKhoan(taoTaiKhoanMoi);
            try
            {
                if (result == -1)
                {
                    showMessage("Tên đăng nhập đã tồn tại!", "error");
                    btnAdd.Enabled = true;
                    return;
                }
                else if (result == 0)
                {
                    sendEmail();
                    showMessage("Thêm tài khoản mới thành công!", "success");
                    this.Close();
                }
                else
                {
                    showMessage("Vui lòng thử lại sao!", "error");
                    this.Close();
                }
            } catch (Exception ex)
            {
                showMessage("Đã xảy ra lỗi không mong muốn!", "error");
                this.Close();
            }
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Mẫu kiểm tra định dạng email
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool sendEmail()
        {
            try
            {
                // Thông tin email gửi
                string fromEmail = "fastie.n02@gmail.com";
                string fromPassword = "rtpl hzno ottm erol"; // Mật khẩu ứng dụng của email gửi

                // Lấy thông tin người nhận từ TextBox hoặc biến đầu vào
                string name = layoutPersonnelForm.Name;
                string email = layoutPersonnelForm.Email;
                string userName = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim(); // Nếu bạn có trường tên người dùng


                // Nội dung email xác nhận tạo tài khoản thành công
                string content = $@"
Kính gửi {name},

Chúc mừng bạn đã tạo tài khoản thành công tại Fastie! Chúng tôi rất vui mừng chào đón bạn trở thành một phần của cộng đồng Fastie.

Dưới đây là thông tin tài khoản của bạn:
- Tên tài khoản: {userName}
- Email đăng ký: {email}
- Mật khẩu: {password}  
- Ngày tạo tài khoản: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}

Chúng tôi khuyến nghị bạn đổi mật khẩu ngay sau khi đăng nhập để bảo đảm an toàn tài khoản. Bạn có thể đăng nhập vào tài khoản của mình bất cứ lúc nào để trải nghiệm các dịch vụ tuyệt vời của chúng tôi.

Nếu có bất kỳ câu hỏi hoặc cần hỗ trợ, xin vui lòng liên hệ với chúng tôi qua email này hoặc gọi đến số 0939999666.

Một lần nữa, cảm ơn bạn đã tin tưởng và lựa chọn Fastie. Chúng tôi hy vọng bạn sẽ có những trải nghiệm tuyệt vời!

Chân thành cảm ơn,

Trân trọng,  
Fastie  
Đội ngũ hỗ trợ khách hàng
";

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage();
                mail.To.Add(email); // Email người nhận
                mail.From = new MailAddress(fromEmail); // Email người gửi
                mail.Subject = "Xác nhận yêu cầu hỗ trợ của bạn - [Đội ngũ Firon]"; // Tiêu đề email
                mail.Body = content; // Nội dung email

                // Thiết lập cấu hình SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromEmail, fromPassword)
                };

                // Gửi email
                smtp.Send(mail);

                // Trả về true nếu gửi thành công
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể log thêm thông tin lỗi vào đây
                showMessage(ex.Message, "error");
                return false;
            }


        }
    }
}
