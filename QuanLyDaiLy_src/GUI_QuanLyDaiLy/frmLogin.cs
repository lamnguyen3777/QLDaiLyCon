using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        DTO_NhanVienQuanLy nhanVien;
        DTO_ThongTinTaiKhoan taiKhoan;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string user = txtuserName.Text.ToString();
            string pass = txtPassWord.Text.ToString();
            Console.WriteLine(user + " " + pass);
            int login = BUS_QuanLyTaiKhoan.KiemTraLogin(user, pass);
            if (login == 0)
            {
                taiKhoan = BUS_QuanLyTaiKhoan.GetTaiKhoan(user,pass);
                nhanVien = BUS_NhanVien.GetNhanVien(taiKhoan.Cmnd);
                frmLogin f1 = new frmLogin();
                f1.Close();
                frmTrangChuQuanLy f = new frmTrangChuQuanLy(taiKhoan,nhanVien);
                f.Show();
                
            }
            else if (login == 1)
            {
                MessageBox.Show("Tên user không chính xác","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (login == 2)
            {
                MessageBox.Show("Mật khẩu không chính xác","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tài khoản đã bị block bởi admin");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void simpleButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                string user = txtuserName.Text.ToString();
                string pass = txtPassWord.Text.ToString();
                Console.WriteLine(user + " " + pass);
                int login = BUS_QuanLyTaiKhoan.KiemTraLogin(user, pass);
                if (login == 0)
                {
                    taiKhoan = BUS_QuanLyTaiKhoan.GetTaiKhoan(user, pass);
                    nhanVien = BUS_NhanVien.GetNhanVien(taiKhoan.Cmnd);
                    this.Hide();
                    frmTrangChuQuanLy f = new frmTrangChuQuanLy(taiKhoan, nhanVien);
                    f.Show();

                }
                else if (login == 1)
                {
                    MessageBox.Show("Tên user không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (login == 2)
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã bị block bởi admin");
                }
            }    
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Upper(object sender, KeyPressEventArgs e)
        {

        }

        //private void simpleButton2_Click(object sender, EventArgs e)
        //{
        //    DangKyTaiKhoancs dangKyTaiKhoancs = new DangKyTaiKhoancs();
        //    dangKyTaiKhoancs.Show();
        //    this.Hide();
        //}
    }
}