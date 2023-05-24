using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Leave_Managment
{
    public partial class Employee_DashBoard : Form
    {
        string name = "";
        int id;
        List<object[]> retrive;
        object[] data;
        DataBase db = new DataBase();

        public Employee_DashBoard(string name, int id, string dept, string desig)
        {
            InitializeComponent();
            lbTopName.Text = lbNamePD.Text = name;
            this.name = name;
            lbEmpDept.Text = dept;
            lbDesigPD.Text = desig;
            lbIdPD.Text = tbEmpId.Text = id.ToString();
            this.id = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you Sure!!!", "Conformation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Form lp = new Form1();
                lp.Show();
                lp.WindowState = this.WindowState;
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            object[] vali = db.LoginValidate(tbEmpUserID.Text,tbOldPassword.Text);
            if ((tbEmpUserID.Text == (string)vali[1]) && (tbOldPassword.Text == (string)vali[2]))
            {
                if (tbNewPasswd.Text == tbRPasswd.Text)
                {
                    db.UpdateLoginInfo((int)vali[0],tbEmpUserID.Text,tbNewPasswd.Text);
                    MessageBox.Show("Id Updated","Done!!");
                }
                else
                {
                    MessageBox.Show("Password Didn't Match","Error!!");
                }
            }
            else
            {
                MessageBox.Show("Old Password Didn't Match","Confirm Password");
            }
        }

        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            string Leave_type;
            if (cbEmpType.SelectedIndex != -1)
            {
                if ((tbEmpReason != null) || (tbEmpReason.Text != ""))
                {
                    if (cbEmpType.SelectedIndex == 0)
                        Leave_type = "Sick";
                    else
                        Leave_type = "Permission";
                    db.InsertLeave(id, name, (DateTime)dtpFrom_Date.Value, (DateTime)dtpTo_Date.Value, Leave_type, tbEmpReason.Text, "E");
                    MessageBox.Show("Leave Applied", "Done!!");
                }
                else
                    MessageBox.Show("Please mention the reason Correctly!!");
            }
            else
                MessageBox.Show("Check The Leave Type Correctly!!");
        }

        private void Employee_DashBoard_Load(object sender, EventArgs e)
        {
            retrive = db.LoadSpecificLeave(id);
            foreach (object[] i in retrive)
            {
                dgvEmpLeaveReport.Rows.Add(i);
            }
            try
            {
                data = db.ShowSalaryResult(id);
                int days = db.GetLeaveDays(id);
                if (data != null)
                {
                    //MessageBox.Show((string)data[1].ToString() + " " + (string)data[2].ToString());
                    //MessageBox.Show(days.ToString());
                    lbLeaveCount.Text = days.ToString();
                    lbCTCPackage.Text = (string)data[1].ToString();
                    int workingday = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    double perdaysalary = Convert.ToDouble(data[2]) / workingday;

                    lbThisMonthDispatch.Text = (Convert.ToDouble(data[2]) - (perdaysalary * days)).ToString("N2");
                }
                else
                {
                    lbLeaveCount.Text = "NA";
                    lbCTCPackage.Text = "NA";
                    lbThisMonthDispatch.Text = "NA";
                }
            }
            catch (Exception ex)
            {
                lbLeaveCount.Text = "NA";
                lbCTCPackage.Text = "NA";
                lbThisMonthDispatch.Text = "NA";
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
