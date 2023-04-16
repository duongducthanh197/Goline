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
using System.Runtime.InteropServices;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Views
{
    public partial class frmTimesheets : Form
    {
        TimesheetsController _timesheetsController = new TimesheetsController();
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

                try
                {
                    // Create a new instance of the Excel Application
                    Excel.Application excelApp = new Excel.Application();

                    // Hide the Excel Application window from the user
                    excelApp.Visible = false;

                    // Open the Excel workbook
                    Excel.Workbook workbook = excelApp.Workbooks.Open(dataFile);

                    //Open worksheet
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                    Excel.Range usedRange = worksheet.UsedRange;
                    int lastRow = usedRange.Rows.Count;
                    List<TimesheetsRawDataDTO> timesheetRawDataList = new List<TimesheetsRawDataDTO>();

                    //Loop excel file by row
                    for (int index = 1; index <= lastRow; index++)
                    {
                        try
                        {   //Get data in column 1 and column 3
                            String fullname = worksheet.Cells[index, 1].Value;
                            DateTime inOutTime = DateTime.Parse(worksheet.Cells[index, 3].Value);

                            //Create and assign data for timesheets raw data object
                            TimesheetsRawDataDTO timesheetRawData = new TimesheetsRawDataDTO();
                            timesheetRawData.Fullname = fullname;
                            timesheetRawData.In_Out_Time = inOutTime;

                            //Add timesheets raw data to list
                            timesheetRawDataList.Add(timesheetRawData);    

                        }
                        catch { }
                    }
                    //Insert data to database
                    _timesheetsRawDataController.InsertTimesheetsRawData(timesheetRawDataList);

                    // Save and close the Excel file
                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();

                    // Release the resources used by the workbook and Excel Application
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("Hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
