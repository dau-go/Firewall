using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsExample
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
            if(FirewallForm.Lang==0)
            {
                ShowTiengViet();
            }
            else
            {
                ShowEnglish();
            }
        }
        public void ShowTiengViet()
        {
            label1.Text = "Xem và tạo quy tắc tường lửa do người dùng tạo";
            label2.Text = "Xem và thay đổi các quy tắc tường lửa Windows mặc định";
            label3.Text = "Xem và tạo quy tắc để chặn tường lửa của trang web";
            label4.Text = "Tạo các quy tắc tường lửa để cho phép hoặc chặn các kết nối đến các chương trình được chỉ định cho các cổng. Bạn cũng có thể cho phép kết nối chỉ khi nó được xác thực hoặc nếu nó là từ một người dùng, nhóm hoặc máy tính được ủy quyền. Theo mặc định, các kết nối đến bị chặn trừ khi chúng khớp với các quy tắc cho phép chúng và các kết nối gửi đi được cho phép trừ khi chúng khớp với các quy tắc chặn chúng.";
            label5.Text = "Đây là các quy tắc mặc định của các chương trình hệ thống Windows. Ở đây, tôi khuyến cáo người dùng không thay đổi quá nhiều quy tắc, điều này ảnh hưởng đến hoạt động của chương trình hệ thống.";
            label7.Text = "Tạo quy tắc tường lửa để cho phép hoặc chặn liên kết đến các trang web được chỉ định tại thời điểm được chỉ định. Giúp bạn quản lý quyền truy cập web của mình trong một khung thời gian.";
            linkLabel1.Text = "";
            linkLabel2.Text = "";
            linkLabel3.Text = "";
            linkLabel4.Text = "";
            linkLabel5.Text = "";
        }
        public void ShowEnglish()
        {
            label1.Text = "View and create user-created firewall rules";
            label2.Text = "View and change the default Windows firewall rules";
            label3.Text = "View and create rules to block the site's firewall";
            label4.Text = "Create firewall rules to allow or block connections to designated programs for ports. You can also allow a connection only if it is authenticated or if it is from a user, group, or authorized computer. By default, incoming connections are blocked unless they match rules that allow them and outgoing connections to be allowed unless they match the rules that block them.";
            label5.Text = "These are the default rules of windows system programs. Here, I recommend that users do not change too many rules, this affects the operation of the system program.";
            label7.Text = "Create firewall rules to allow or block links to designated sites at designated times. Helps you manage your web access in a time frame.";
            linkLabel1.Text = "";
            linkLabel2.Text = "";
            linkLabel3.Text = "";
            linkLabel4.Text = "";
            linkLabel5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
