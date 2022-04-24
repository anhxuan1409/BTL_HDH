using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // thêm thư viện dll để sử dụng shutdown.exe

namespace setTime
{
    public partial class Form1 : Form
    {
        public static decimal h = 0;   // khai báo biến chứa giờ
        public static decimal m = 0;   // khai báo biến chứa phút
        public static decimal s = 0;   // khai báo biến chứa giây
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            h = numericUpDown1.Value;    // gán h giá trị của giờ
            m = numericUpDown3.Value;    // gán m giá trị của phút
            s = numericUpDown2.Value;    // gán s giá trị của giây
            Form2 f2 = new Form2();
            f2.ShowDialog();

            decimal a = h * 3600 + m * 60 + s; // quy đổi giờ phút giây thành giây
            System.Diagnostics.Process.Start(@"C:\Windows\System32\shutdown.exe", "-s -t " + a.ToString()); // gọi đến file shutdown.exe để thực hiện tắt máy, a.ToString để quy đổi các biến nhận được qua string
        }
    }
}
