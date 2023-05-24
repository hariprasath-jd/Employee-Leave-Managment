using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Employee_Leave_Managment
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        List<object[]> retrive;
        object[] info;
        string admin;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = db.LoginValidate(tbUserIn.Text, tbPasswdIn.Text);
            //MessageBox.Show(info[1] +" "+ info[2]+" "+ info[3]);
            try
            {
                if (info == null)
                {
                    MessageBox.Show("Password Incoreect 1", "Error!!");
                    
                }
                else if ((tbUserIn.Text.ToString() == (string)info[1]) && ((string)info[2] == tbPasswdIn.Text.ToString()))
                {
                    if (((string)info[3] == "A")||((string)info[3] == "S"))
                    {
                        Admin_Dashboard ad = new Admin_Dashboard();
                        ad.Show();
                        ad.WindowState = this.WindowState;
                        object[] sam = db.EditBasicInfo((int)info[0]);
                        if ((string)info[3] == "A")
                        {
                            admin = "Admin Dashboard";
                        }
                        if ((string)info[3] == "S")
                        {
                            admin = "Super Admin Dashboard";
                        }
                        ad.SetDetails(sam[1].ToString(), (int)info[0], info[3].ToString(),admin);
                        ad.SetCount(db.ToatalEmp(),db.CountPermission());
                        this.Hide();
                    }
                    else if ((string)info[3] == "E")
                    {
                        object[] sam = db.EditBasicInfo((int)info[0]);
                        Employee_DashBoard ad = new Employee_DashBoard(sam[1].ToString(), (int)info[0], sam[2].ToString(), sam[3].ToString());
                        ad.Show();
                        ad.WindowState = this.WindowState;
                        
                        //ad.SetEmpDetails(sam[1].ToString(), (int)info[0], sam[2].ToString(), sam[3].ToString());
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password Incoreect \n"+ex.Message, "Error!!");
            }
        }
    }
}
