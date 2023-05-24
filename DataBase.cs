using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml;
using System.Data;

namespace Employee_Leave_Managment
{
    internal class DataBase
    {
        string ConnectionSoucre = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog =EMS_DB ;Integrated Security = true;";
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;
        object[] temp;
        List<object[]> list;
        public DataBase()
        {
            connect = new SqlConnection(ConnectionSoucre);

            connect.Open();
        }

        public List<object[]> LoadDetails()
        {
            command = new SqlCommand("LoadDetails", connect);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            list = new List<object[]>();
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }

        public List<object[]> SortedDetails(string dept, string desig)
        {
            command = new SqlCommand("SortedDetails", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("dept", dept);
            command.Parameters.AddWithValue("desig", desig);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            list = new List<object[]>();
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }

        public List<object[]> SortedDeptDetails(string dept)
        {
            command = new SqlCommand("SortedDeptDetails", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("dept", dept);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            list = new List<object[]>();
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }

        public List<object[]> SortedDesigDetails(string desig)
        {
            command = new SqlCommand("SortedDesigDetails", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("desig", desig);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            list = new List<object[]>();
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }

        public object[] LoginValidate(string name, string passwd)
        {
            int x = 0;
            command = new SqlCommand("LoginDetails", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("user", name);
            command.Parameters.AddWithValue("passwd", passwd);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                x = reader.GetValues(temp);
            }
            reader.Close();
            return temp;
        }

        public void BasicData(string name, string Dept, string Desig)
        {
            command = new SqlCommand("BasicInfo", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Dept", Dept);
            command.Parameters.AddWithValue("Desig", Desig);
            command.ExecuteNonQuery();
        }

        public object[] GetId(string name)
        {
            command = new SqlCommand("GetId", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                var x = reader.GetValues(temp);
            }
            reader.Close();
            return temp;
        }
        public void PersonalInfo(int eid, string gender, string email, string mobile, string address, DateTime dob)
        {
            command = new SqlCommand("Personal_Info", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            command.Parameters.AddWithValue("Gender", gender);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("mobile_no", mobile);
            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("DOB", dob);
            int x = command.ExecuteNonQuery();

        }

        public void EducationalInfo(int eid, string ug_d, string pg_d, string ph_d, int mark10, int mark12, string extra)
        {
            command = new SqlCommand("Educational_Info", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.AddWithValue("@UG_D", SqlDbType.VarChar).Value = ug_d;
            command.Parameters.AddWithValue("@PG_D", SqlDbType.VarChar).Value = pg_d;
            command.Parameters.AddWithValue("@PH_D", SqlDbType.VarChar).Value = ph_d;
            command.Parameters.AddWithValue("@Mark10", SqlDbType.Int).Value = mark10;
            command.Parameters.AddWithValue("@Mark12", SqlDbType.Int).Value = mark12;
            command.Parameters.AddWithValue("@ExtraCert", SqlDbType.VarChar).Value = extra;
            int x = command.ExecuteNonQuery();
        }

        public void Login_Cred(int eid, string user, string passwd, string attribute)
        {
            command = new SqlCommand("Insert_Login_Credencial", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            command.Parameters.AddWithValue("user", user);
            command.Parameters.AddWithValue("passwd", passwd);
            command.Parameters.AddWithValue("attribute", attribute);
            command.ExecuteNonQuery();
        }

        public object[] EditBasicInfo(int eid)
        {
            command = new SqlCommand("GetBacicData", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
            }
            reader.Close();
            return temp;
        }

        public object[] EditPersonalInfo(int eid)
        {
            command = new SqlCommand("GetPersonalData", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
            }
            reader.Close();
            return temp;
        }
        public object[] EditEducationalInfo(int eid)
        {
            command = new SqlCommand("GetEducationalData", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
            }
            reader.Close();
            return temp;
        }

        public int UpdateInfo(int eid, string email, string mobile, string address, DateTime dob, string ug_d,
            string pg_d, string ph_d, int mark10, int mark12, string extra)
        {
            command = new SqlCommand("UpdateInfo", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("mobile_no", mobile);
            command.Parameters.AddWithValue("Address", address);
            command.Parameters.AddWithValue("DOB", dob);
            command.Parameters.AddWithValue("UG_D", ug_d);
            command.Parameters.AddWithValue("PG_D", pg_d);
            command.Parameters.AddWithValue("PH_D", ph_d);
            command.Parameters.AddWithValue("Mark10", mark10);
            command.Parameters.AddWithValue("Mark12", mark12);
            command.Parameters.AddWithValue("ExtraCert", extra);
            int x = command.ExecuteNonQuery();
            return x;
        }

        public string ToatalEmp()
        {
            int x = 0;
            int total = 0;
            command = new SqlCommand("CountEmp", connect);
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                x = reader.GetValues(temp);
                total++;
            }
            reader.Close();
            //MessageBox.Show((string)temp[0]);
            return total.ToString();
        }

        public void UpdateLoginInfo(int eid, string user, string passwd)
        {
            command = new SqlCommand("UpdateLoginData", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            command.Parameters.AddWithValue("user", user);
            command.Parameters.AddWithValue("passwd", passwd);
            command.ExecuteNonQuery();
        }

        public void InsertLeave(int eid, string name, DateTime from, DateTime to, string leave_Type, string reason, string attr)
        {
            command = new SqlCommand("InsertLeave", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", eid);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("from_date", from);
            command.Parameters.AddWithValue("to_date", to);
            command.Parameters.AddWithValue("LeaveType", leave_Type);
            command.Parameters.AddWithValue("Reason", reason);
            command.Parameters.AddWithValue("attr", attr);
            command.Parameters.AddWithValue("status", "Waiting");
            command.ExecuteNonQuery();
        }

        public List<object[]> LoadSpecificLeave(int eid)
        {
            command = new SqlCommand("Specific_Leave_Record", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@eid", eid);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            list = new List<object[]>();
            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);
                list.Add(temp);
            }
            reader.Close();
            return list;
        }

        public DataTable LeaveRequest()
        {
            adapter = new SqlDataAdapter("select Leave_id,eid,name,From_Date date,To_Date date,LeaveType,Reason,attribute,Leave_status from Emp_Leave_Info where Leave_status = 'Waiting'", connect);
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public int SetPermission(int L_id, string status)
        {
            command = new SqlCommand("SetPermission", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Leave_id", L_id);
            command.Parameters.AddWithValue("status", status);
            int x = command.ExecuteNonQuery();
            return x;
        }

        public string CountPermission()
        {
            int total = 0;
            command = new SqlCommand("Countpermission", connect);
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read())
            {
                temp = new object[count];
                reader.GetValues(temp);
                total++;
            }
            reader.Close();
            return total.ToString();
        }

        public void InsertSalary(int id, double base_salary, double monthly_dispatch)
        {
            command = new SqlCommand("InsertSalary", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("eid", id);
            command.Parameters.AddWithValue("b_s", base_salary);
            command.Parameters.AddWithValue("@monthly_dispatch", monthly_dispatch);
            command.ExecuteNonQuery();
        }

        public object[] ShowSalaryResult(int id)
        {
            command = new SqlCommand("SearchSalary", connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@eid", id);
            reader = command.ExecuteReader();
            int count = reader.FieldCount;

            while (reader.Read())
            {
                temp = new object[count];
                int x = reader.GetValues(temp);

            }
            reader.Close();
            return temp;
        }

        public int GetLeaveDays(int eid)
        {
            int days = 0;
            try
            {
                command = new SqlCommand("GetLeaveDate", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("eid", eid);
                reader = command.ExecuteReader();
                int count = reader.FieldCount;
                while (reader.Read())
                {
                    temp = new object[count];
                    int x = reader.GetValues(temp);
                    DateTime from = (DateTime)temp[0];
                    DateTime To = (DateTime)temp[1];
                    TimeSpan Diff = To.Subtract(from);
                    days += Diff.Days;
                }
                //MessageBox.Show(temp[0].ToString() + "" + temp[1].ToString());
                //MessageBox.Show(days.ToString());
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return days;
        }
    }
}
