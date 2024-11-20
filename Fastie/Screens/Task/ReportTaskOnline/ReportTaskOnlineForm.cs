using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;

namespace Fastie.Screens.Task.ReportTaskOnline
{
    public partial class ReportTaskOnlineForm : Form
    {
        public ReportTaskOnlineForm()
        {
            InitializeComponent();
            handleImportDataGridView();
        }

        private Stream DownloadImage(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = client.DownloadData(imageUrl);
                    return new MemoryStream(imageBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}");
                return null; // Return null in case of an error
            }
        }

        private string relativePath(string subPath)
        {
            string fullPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..", "..", subPath);
            return fullPath;
        }

        private async void handleImportDataGridView()
        {
            var values = await handleDataSheet();
            if (values == null)
            {
                Console.WriteLine("No data available.");
                return;
            }

            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i][0]?.ToString());
                Console.WriteLine(values[i][1]?.ToString());
                Console.WriteLine(values[i][2]?.ToString());
                Console.WriteLine(values[i][3]?.ToString());
                Console.WriteLine(values[i][4]?.ToString());
                Console.WriteLine(values[i][5]?.ToString());
                Console.WriteLine(values[i][6]?.ToString());
            }
        }

        private async Task<IList<IList<Object>>> handleDataSheet()
        {
            // API Key của bạn
            string apiKey = "AIzaSyCHVUVNsmnAkuyVb6dStMTRd0nF9Q2uGdI";
            string spreadsheetId = "1d0GYgmQ2-GFwFIF40c5BkaHUMMl2AMe5RK-5CNn3uuo";  // Thay bằng Spreadsheet ID
            string range = "'Answer_1'!A2:G";  // Dải dữ liệu cần đọc

            // URL để truy cập dữ liệu từ Google Sheets
            string url = $"https://sheets.googleapis.com/v4/spreadsheets/{spreadsheetId}/values/{range}?key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    // Phân tích dữ liệu JSON trả về
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<GoogleSheetResponse>(json);

                    if (result != null && result.Values != null)
                    {
                        return result.Values;
                    }
                }
                else
                {
                    MessageBox.Show($"Lỗi khi truy cập Google Sheets: {response.ReasonPhrase}");
                }
            }

            return null;
        }

        public class GoogleSheetResponse
        {
            public IList<IList<object>> Values { get; set; }
        }

    }
}
