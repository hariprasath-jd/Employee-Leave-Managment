using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;

namespace Employee_Leave_Managment
{
    public partial class Admin_Dashboard : Form
    {
        string name;
        int id;
        int Leave_id;
        string attri;
        string Self_attri;
        DataBase db = new DataBase();
        List<object[]> retrive;
        public string lb;
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        public void SetDetails(string name, int id, string Self_attri, string adminlb)
        {
            lbAdminNameTopPanel.Text = name;
            this.name = name;
            tbAdminIdSubmit.Text = id.ToString();
            this.id = id;
            this.Self_attri = Self_attri;
            lbAdminDash.Text = adminlb;
        }
        public void SetCount(string Empcount, string ReqCount)
        {
            lbTotalEmployees.Text = Empcount;
            lbTotalRequest.Text = ReqCount;
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

        private void btnShow_Click(object sender, EventArgs e)
        {

            if ((cbDeptSort.SelectedIndex == 0) && (cbDesigSort.SelectedIndex == 0))
            {
                dgvShowEmployeeDetails.Rows.Clear();
                retrive = db.LoadDetails();
                foreach (object[] i in retrive)
                {
                    dgvShowEmployeeDetails.Rows.Add(i);
                }
                retrive = new List<object[]>();
            }
            else if ((cbDeptSort.SelectedIndex != 0) && (cbDesigSort.SelectedIndex != 0))
            {
                dgvShowEmployeeDetails.Rows.Clear();
                retrive = db.SortedDetails(cbDeptSort.SelectedItem.ToString(), cbDesigSort.SelectedItem.ToString());
                foreach (object[] i in retrive)
                {
                    dgvShowEmployeeDetails.Rows.Add(i);
                }
                retrive = new List<object[]>();
            }
            else if ((cbDeptSort.SelectedIndex == 0) && (cbDesigSort.SelectedIndex != 0))
            {
                dgvShowEmployeeDetails.Rows.Clear();
                retrive = db.SortedDesigDetails(cbDesigSort.SelectedItem.ToString());
                foreach (object[] i in retrive)
                {
                    dgvShowEmployeeDetails.Rows.Add(i);
                }
                retrive = new List<object[]>();
            }
            else if ((cbDeptSort.SelectedIndex != 0) && (cbDesigSort.SelectedIndex == 0))
            {
                dgvShowEmployeeDetails.Rows.Clear();
                retrive = db.SortedDeptDetails(cbDeptSort.SelectedItem.ToString());
                foreach (object[] i in retrive)
                {
                    dgvShowEmployeeDetails.Rows.Add(i);
                }
                retrive = new List<object[]>();
            }
            else
                dgvShowEmployeeDetails.Rows.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool result;
            string gender;
            double salary;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (cbSalaryPackage.SelectedIndex == 0)
                salary = 120000;
            else if (cbSalaryPackage.SelectedIndex == 1)
                salary = 240000;
            else if (cbSalaryPackage.SelectedIndex == 2)
                salary = 350000;
            else if (cbSalaryPackage.SelectedIndex == 3)
                salary = 500000;
            else if (cbSalaryPackage.SelectedIndex == 4)
                salary = 800000;
            else if (cbSalaryPackage.SelectedIndex == 5)
                salary = 1000000;
            else if (cbSalaryPackage.SelectedIndex == 6)
                salary = 1200000;
            else if (cbSalaryPackage.SelectedIndex == 7)
                salary = 1500000;
            else
                salary = 2000000;

            DateTime agenow = dtpGetD_O_B.Value;
            DateTime agelimit = DateTime.Now.AddDays(6570);
            double diff = agenow.CompareTo(agelimit);

            string name = tbGetFirstName.Text + " " + tbGetaLastName.Text;


            if (name != "")
            {
                result = true;
                if (cbGetDepartment.SelectedIndex != -1)
                {
                    result = true;
                    if (cbGetDesignation.SelectedIndex != -1)
                    {
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select designation", "Error"); result = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select department", "Error"); result = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the name correctly!", "check details"); result = false;
            }



            if (gender != null)
            {
                result = true;
                if ((tbGetEmail.Text != null) || (tbGetEmail.Text != ""))
                {
                    result = true;
                    if ((tbGetMobile.Text != null) || (tbGetMobile.Text != ""))
                    {
                        result = true;
                        if ((tbmlGetAddress.Text != null) || (tbmlGetAddress.Text != ""))
                        {
                            result = true;
                            //if (diff < 6570)
                            //{
                            //    result = true;
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Check the age \n age must be above 18", "Check age"); result = false;
                            //}
                        }
                        else
                        {
                            MessageBox.Show("Please enter the address!"); result = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the mobile number"); result = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the email"); result = false;
                }
            }
            else
            {
                MessageBox.Show("Please select the gender"); result = false;
            }


            if ((tbGetUGDegree.Text != null) || (tbGetUGDegree.Text != ""))
            {
                result = true;
                if ((tbGetPGDegree.Text != null) || (tbGetUGDegree.Text != ""))
                {
                    result = true;
                    if ((tbGetPh_D.Text != null) || (tbGetPh_D.Text != ""))
                    {
                        result = true;
                        if ((int.Parse(tbGet10Mark.Text) > 0) || ((int.Parse(tbGet10Mark.Text) <= 500)))
                        {
                            result = true;
                            if ((int.Parse(tbGetPlus2Mark.Text) > 0) || ((int.Parse(tbGetPlus2Mark.Text) <= 1200)))
                            {
                                result = true;
                                if ((tbgetExtraCertificate.Text != null) || (tbgetExtraCertificate.Text != ""))
                                {
                                    result = true;
                                }
                                else
                                {
                                    MessageBox.Show("Extra Certificate is empty \n if no cerificate then type 'nil' in the text box"); result = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter the correct mark for 12 Grade !"); result = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct mark for 10 Grade !"); result = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ph.d Degree is empty \n if no degree in ph.d then type 'nil' in the text box"); result = false;
                    }
                }
                else
                {
                    MessageBox.Show("PG Degree is empty \n if no degree in PG degree then type 'nil' in the text box"); result = false;
                }
            }
            else
            {
                MessageBox.Show("You are missing your UG Degree"); result = false;
            }

            if (cbSalaryPackage.SelectedIndex != -1)
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Please select salary");
                result = false;
            }

            if ((tbGetUser.Text != "") || (tbGetUser.Text != null))
            {
                result = true;
                if (tbGetPasswd.Text.Length <= 8)
                {
                    result = true;
                    if (tbGetPasswd.Text == tbReGetPasswd.Text)
                    {
                        result = true;

                        MessageBox.Show("Employee Added", "Success!!");
                    }
                    else
                    {
                        MessageBox.Show("Password Didn't match", "Error!!!"); result = false;
                    }
                }
                else
                {
                    MessageBox.Show("Password must have more than 8 character's"); result = false;
                }
            }
            else
            {
                MessageBox.Show("User was empty"); result = false;
            }


            if (result == true)
            {

                db.BasicData(name, cbGetDepartment.SelectedItem.ToString(), cbGetDesignation.SelectedItem.ToString());
                object[] temp = db.GetId(name);
                db.PersonalInfo((int)temp[0], gender, tbGetEmail.Text, tbGetMobile.Text, tbmlGetAddress.Text, dtpGetD_O_B.Value);
                db.EducationalInfo((int)temp[0], tbGetUGDegree.Text, tbGetPGDegree.Text, tbGetPh_D.Text, int.Parse(tbGet10Mark.Text), int.Parse(tbGetPlus2Mark.Text), tbgetExtraCertificate.Text);
                db.InsertSalary((int)temp[0], salary, salary / 10);
                db.Login_Cred((int)temp[0], tbGetUser.Text, tbGetPasswd.Text, "E");
            }
        }

        private void btnEditEmpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbSearchEmployee.Text);
                //Update basic info
                object[] basicInfo = db.EditBasicInfo(id);
                string[] name = new string[10];
                name = basicInfo[1].ToString().Split(' ');
                tbEditFirstName.Text = name[0];
                tbEditLastnamr.Text = name[1];
                //Update Personal info
                object[] personalinfo = db.EditPersonalInfo(id);
                tbEditEmail.Text = personalinfo[2].ToString();
                tbEditMobile.Text = personalinfo[3].ToString();
                tbEditaddress.Text = personalinfo[4].ToString();
                dtpEditD_O_B.Value = (DateTime)personalinfo[5];
                //Update Eduactional Info
                object[] educationalinfo = db.EditEducationalInfo(id);
                tbEditUG_Degree.Text = educationalinfo[1].ToString();
                tbEditPG_Degree.Text = educationalinfo[2].ToString();
                tbEditPh_D.Text = educationalinfo[3].ToString();
                tbEdit10Mark.Text = educationalinfo[4].ToString();
                tbEditPlusMark.Text = educationalinfo[5].ToString();
                tbEditExtraCertificate.Text = educationalinfo[6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Edit Admin Details\n" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int x = db.UpdateInfo(int.Parse(tbSearchEmployee.Text), tbEditEmail.Text, tbEditMobile.Text, tbEditaddress.Text, (DateTime)dtpEditD_O_B.Value, tbEditUG_Degree.Text, tbEditPG_Degree.Text, tbEditPh_D.Text, int.Parse(tbEdit10Mark.Text),
                int.Parse(tbEditPlusMark.Text), tbEditExtraCertificate.Text);
            if (x > 0)
                MessageBox.Show("Id Updated Successfully!!", "Done");
            else
                MessageBox.Show("Error Occoured During Update \n Please Check next Line", "Look After Something");
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMS_DBDataSet5.Emp_Leave_Info' table. You can move, or remove it, as needed.
            this.emp_Leave_InfoTableAdapter.Fill(this.eMS_DBDataSet5.Emp_Leave_Info);
            dgvEmployeeLeaveRequestTable.DataSource = db.LeaveRequest();
            if (Self_attri == "S")
            {

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm?", "Conformation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if ((attri == "E") && ((Self_attri == "A") || (Self_attri == "S")))
                {
                    int x = db.SetPermission(Leave_id, "Accecpted");
                    if (x > 0)
                        MessageBox.Show("Leave Accepted!!", "Done!!");
                    else
                        MessageBox.Show("Error occoured!");
                    dgvEmployeeLeaveRequestTable.Refresh();
                }
                else if ((attri == "A") && (Self_attri == "S"))
                {
                    int x = db.SetPermission(Leave_id, "Accecpted");
                    if (x > 0)
                        MessageBox.Show("Leave Accepted!!", "Done!!");
                    else
                        MessageBox.Show("Error occoured!");
                    dgvEmployeeLeaveRequestTable.Refresh();
                }
                else
                    MessageBox.Show("A Admin Cannot Accept a Admin's Request");
            }
        }

        private void btnAdminLeaveForm_Click(object sender, EventArgs e)
        {
            string Leave_type;
            if (cbAdminLeaveType.SelectedIndex != -1)
            {
                if ((TbAdminReason.Text != null) || (TbAdminReason.Text != ""))
                {
                    if (cbAdminLeaveType.SelectedIndex == 0)
                        Leave_type = "Sick";
                    else
                        Leave_type = "Permission";
                    db.InsertLeave(id, name, (DateTime)dtpAdminFromDate.Value, (DateTime)dtpAdminToDate.Value, Leave_type, TbAdminReason.Text, "A");
                    MessageBox.Show("Leave Applied", "Done!!");
                    dgvEmployeeLeaveRequestTable.Refresh();
                }
                else
                    MessageBox.Show("Please mention the reason Correctly!!");
            }
            else
                MessageBox.Show("Check The Leave Type Correctly!!");
        }

        private void dgvEmployeeLeaveRequestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEmployeeLeaveRequestTable.CurrentCell.RowIndex;
            DataGridViewRow row = dgvEmployeeLeaveRequestTable.Rows[index];
            Leave_id = (int)row.Cells[0].Value;
            attri = row.Cells[7].Value.ToString();
            dgvEmployeeLeaveRequestTable.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm?", "Conformation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if ((attri == "E") && ((Self_attri == "A") || (Self_attri == "S")))
                {
                    int x = db.SetPermission(Leave_id, "Rejected");
                    if (x > 0)
                        MessageBox.Show("Leave Rejected!!", "Done!!");
                    else
                        MessageBox.Show("Error occoured!");
                    dgvEmployeeLeaveRequestTable.Refresh();
                }
                else if ((attri == "A") && (Self_attri == "S"))
                {
                    int x = db.SetPermission(Leave_id, "Rejected");
                    if (x > 0)
                        MessageBox.Show("Leave Rejected!!", "Done!!");
                    else
                        MessageBox.Show("Error occoured!");
                    dgvEmployeeLeaveRequestTable.Refresh();
                }
                else
                    MessageBox.Show("A Admin Cannot Reject a Admin's Request");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvShowEmployeeDetails.Rows.Clear();
        }
    }
}
