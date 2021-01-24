using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using DataTable = System.Data.DataTable;

namespace QuanLyDaiLy
{
    public partial class BaoCaoDoanhSo : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList doanhSo;
        private DataTable tb=new DataTable();
        int id = -1;
        public BaoCaoDoanhSo()
        {
            InitializeComponent();
            tb.Columns.Add("ID", typeof(int));
            tb.Columns.Add("Đại lý", typeof(string));
            tb.Columns.Add("Số phiếu xuất", typeof(int));
            tb.Columns.Add("Tổng giá trị", typeof(float));
            tb.Columns.Add("tỷ lệ", typeof(string));
            Load();
        }

        private void Load()
        {
            //doanhSo= BUS_BaoCaoDoanhSo.GetDoanhSo(1);

            int[] dsThang= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cbThang.DataSource = dsThang;
            gvDoanhSo.DataSource = tb;
            gvDoanhSo.Columns["Id"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Clear();
         
            if (cbThang.SelectedIndex!=-1){
                int thang = int.Parse(cbThang.SelectedItem.ToString());
                doanhSo = BUS_BaoCaoDoanhSo.GetDoanhSo(thang);
                foreach (DTO_DoanhSo dso in doanhSo)
                {
                    string tendl = BUS_DaiLy.GetTenById(dso.IdDaiLy);
                    tb.Rows.Add(dso.IdDaiLy, tendl, dso.SoPhieuXuat, dso.TongDoanhSo, dso.TiLe+"%");
                }
                gvDoanhSo.DataSource = tb;

            }
            
        }

        private void cbThang_SelectedValueChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(cbThang.SelectedItem);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string saveExcelFile = @"D:\baocaodoanhso.xlsx";

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý 
                Range row1_TieuDe_BaoCaoDoanhSo = ws.get_Range("A1", "E1");
                row1_TieuDe_BaoCaoDoanhSo.Merge();
                row1_TieuDe_BaoCaoDoanhSo.Font.Size = fontSizeTieuDe;
                row1_TieuDe_BaoCaoDoanhSo.Font.Name = fontName;
                row1_TieuDe_BaoCaoDoanhSo.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_BaoCaoDoanhSo.Value2 = "Báo Cáo Doanh Số";

                //Tạo Ô Số Thứ Tự (STT)
                Range row23_STT = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_STT.Merge();
                row23_STT.Font.Size = fontSizeTenTruong;
                row23_STT.Font.Name = fontName;
                row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_STT.Value2 = "STT";

                //Tạo Ô ID Đại Lý:
                Range row23_MaSP = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_MaSP.Merge();
                row23_MaSP.Font.Size = fontSizeTenTruong;
                row23_MaSP.Font.Name = fontName;
                row23_MaSP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MaSP.Value2 = "ID Đại Lý";
                row23_MaSP.ColumnWidth = 20;

                //Tạo Ô Tháng:
                Range row23_Thang = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_Thang.Merge();
                row23_Thang.Font.Size = fontSizeTenTruong;
                row23_Thang.Font.Name = fontName;
                row23_Thang.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_Thang.ColumnWidth = 20;
                row23_Thang.Value2 = "Tháng";

                //Tạo Ô Tổng Doanh Số :
                Range row2_TongDoanhSo = ws.get_Range("D2", "D3");
                row2_TongDoanhSo.Merge();
                row2_TongDoanhSo.Font.Size = fontSizeTenTruong;
                row2_TongDoanhSo.Font.Name = fontName;
                row2_TongDoanhSo.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2_TongDoanhSo.Value2 = "Tổng Doanh số";

                //Tạo Ô Số Phiêu Xuất:
                Range row3_SoPhieuXuat = ws.get_Range("E2", "E3");
                row3_SoPhieuXuat.Font.Size = fontSizeTenTruong;
                row3_SoPhieuXuat.Font.Name = fontName;
                row3_SoPhieuXuat.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3_SoPhieuXuat.Value2 = "Số Phiếu Xuất";
                row3_SoPhieuXuat.ColumnWidth = 20;

                Range row4_TyLe = ws.get_Range("F2", "F3");
                row4_TyLe.Font.Size = fontSizeTenTruong;
                row4_TyLe.Font.Name = fontName;
                row4_TyLe.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row4_TyLe.Value2 = "Tỷ Lệ";
                row4_TyLe.ColumnWidth = 20;

                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "E3");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);


                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                DataTable tb = new DataTable();
                foreach (DTO_DoanhSo dso in doanhSo)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, dso.IdDaiLy, dso.Thang, dso.TongDoanhSo, dso.SoPhieuXuat, dso.TiLe };
                    Range rowData = ws.get_Range("A" + row, "E" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "E" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
    
    }
}
