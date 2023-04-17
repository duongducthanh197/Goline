using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timesheets_System.Controllers;
using Excel = Microsoft.Office.Interop.Excel;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Views
{
    public partial class frmTimesheets : Form
    {
        Point mouseOffset;
        UserController _userController = new UserController();
        TimesheetsController _timesheetsController = new TimesheetsController();
        TimesheetsDetailsController _timesheetsDetailsController = new TimesheetsDetailsController();
        TimesheetsRawDataController _timesheetsRawDataController = new TimesheetsRawDataController();

        public frmTimesheets()
        {
            InitializeComponent();
        }


        private void frmTimesheets_Load(object sender, EventArgs e)
        {
            frmInit();
        }

        private void frmInit()
        {
            //Load value for Year combobox(from DB)
            cbb_Year.DataSource = _timesheetsController.GetYears();
            if (cbb_Year.Items.Count > 0) cbb_Year.Text = DateTime.Now.Year.ToString();
            cbb_Month.Text = DateTime.Now.Month.ToString();

            //Load timesheets from DB to datagridview
            LoadTimesheets();

        }


        private void btn_Show_Click(object sender, EventArgs e)
        {
            //Load timesheets from DB to datagridview
            LoadTimesheets();
            if (dgv_Timesheets.RowCount == 0) MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void LoadTimesheets()
        {
            //Check input YEAR and MONTH are not empty
            if (cbb_Year.Text != string.Empty && cbb_Month.Text != string.Empty)
            {
                //Assign datasource for datagridview
                dgv_Timesheets.AutoGenerateColumns = false;
                dgv_Timesheets.DataSource = _timesheetsController.GetTimesheetsList(int.Parse(cbb_Year.Text), int.Parse(cbb_Month.Text));
            }
        }


        private void btn_Upload_Click(object sender, EventArgs e)
        {
            //Select data file
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = false;
            openDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Check file format
                string dataFile = openDialog.FileName;
                string a = Path.GetExtension(dataFile);
                if (Path.GetExtension(dataFile) != ".xlsx" && Path.GetExtension(dataFile) != ".xls")
                {
                    MessageBox.Show("Vui lòng chọn file có định dạng *.xlsx hoặc *.xls", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new instance of the Excel Application
                Excel.Application excelApp = new Excel.Application();

                // Hide the Excel Application window from the user
                excelApp.Visible = false;

                // Open the Excel workbook
                Excel.Workbook workbook = excelApp.Workbooks.Open(dataFile);

                try
                {
                    //Open worksheet
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                    Excel.Range usedRange = worksheet.UsedRange;
                    int lastRow = usedRange.Rows.Count;

                    List<TimesheetsRawDataDTO> timesheetRawDataList = new List<TimesheetsRawDataDTO>();

                    //Loop excel file by row
                    for (int index = 1; index <= lastRow; index++)
                    {
                        try
                        {
                            TimesheetsRawDataDTO timesheetRawData = new TimesheetsRawDataDTO();
                            //Get data in column 1 and column 3
                            String fullname = worksheet.Cells[index, 1].Value;
                            DateTime inOutTime = DateTime.Parse(worksheet.Cells[index, 3].Value);

                            //Assign data for timesheets raw data object
                            timesheetRawData.Fullname = fullname.Trim();
                            timesheetRawData.In_Out_Time = inOutTime;

                            //Add timesheets raw data to list
                            timesheetRawDataList.Add(timesheetRawData);

                        }catch { }
                    }

                    //Insert data to database
                    _timesheetsRawDataController.InsertTimesheetsRawData(timesheetRawDataList);

                    // Save and close the Excel file
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    // Save and close the Excel file
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    //Convert raw data(timesheets_raw_data_tb) to details data(timesheets_details_tb)
                    //
                    //   FULLNAME |               INOUTTIME                                                   FULLNAME  |            DATE      |               CHECKIN           |                   CHECKOUT     |   WORKINGHOURS 
                    //Hoàng Văn A |  2022 - 12 - 26 09:45:27               =>                       Hoàng Văn A |   2022 - 12 - 26 |  2022 - 12 - 26 09:45:27  |  2022 - 12 - 26 13:09:03   |               5.4
                    //Hoàng Văn A |  2022 - 12 - 26 11:26:42                                           Hoàng Văn A |   2022 - 12 - 27 |  2022 - 12 - 27 07:43:39  |  2022 - 12 - 27 14:08:01   |               6.4
                    //Hoàng Văn A |  2022 - 12 - 26 12:05:30
                    //Hoàng Văn A |  2022 - 12 - 26 13:09:03
                    //Hoàng Văn A |  2022 - 12 - 27 07:43:39                                 
                    //Hoàng Văn A |  2022 - 12 - 27 08:05:50
                    //Hoàng Văn A |  2022 - 12 - 27 12:19:18
                    //Hoàng Văn A |  2022 - 12 - 27 11:33:50
                    //Hoàng Văn A |  2022 - 12 - 27 14:08:01
                    _timesheetsRawDataController.ConvertRawDataToDetailsData();

                    List<TimesheetsRawDataDTO> rawDataList = new List<TimesheetsRawDataDTO>();
                    rawDataList = _timesheetsRawDataController.GetRawDataList();

                    foreach (TimesheetsRawDataDTO _timesheetsRawDataDTO in rawDataList)
                    {
                        UserDTO _userDTO = _userController.GetUserByFullname(_timesheetsRawDataDTO.Fullname);

                        //Check fullname from raw data exist in user_tb
                        //Exist         => continue
                        //Not exist  => Unnesscessary data
                        if (_userDTO != null)
                        {
                            //Create timesheets object to search
                            TimesheetsDTO _timesheetsDTO = new TimesheetsDTO();
                            _timesheetsDTO.Fullname = _userDTO.Fullname;
                            _timesheetsDTO.Year = _timesheetsRawDataDTO.In_Out_Time.Year;
                            _timesheetsDTO.Month = _timesheetsRawDataDTO.In_Out_Time.Month;

                            if (_timesheetsController.TimesheetsExist(_timesheetsDTO) == false)
                            {
                                _timesheetsDTO.Username = _userDTO.Username;

                                //Insert new row to timekeeping_tb EX: 1, Nguyễn Văn A, 2023, 02
                                _timesheetsController.InsertNewTimesheets(_timesheetsDTO);
                            }

                            TimesheetsDetailsDTO _timesheetsDetailsDTO = new TimesheetsDetailsDTO();
                            _timesheetsDetailsDTO.Fullname = _userDTO.Fullname;
                            _timesheetsDetailsDTO.Date = _timesheetsRawDataDTO.In_Out_Time;
                            _timesheetsDetailsDTO = _timesheetsDetailsController.GetDetailsByFullnameAndDate(_timesheetsRawDataDTO);

                            if (_timesheetsDetailsDTO != null)
                            {
                                _timesheetsController.UpdateTimesheetsByDay(_timesheetsDetailsDTO);
                            }
                        }
                    }

                    //Truncate raw data after filtering and insert to timesheets_details_tb
                    _timesheetsRawDataController.TruncateRawData();

                    //Reload data source for combobox year
                    frmInit();

                    MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void pn_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }

        }
    }
}
