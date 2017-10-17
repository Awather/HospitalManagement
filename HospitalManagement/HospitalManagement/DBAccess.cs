using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

namespace HospitalManagement
{
    class DBAccess
    {

        public static bool IsUserIdPassWdOK(string UserID, string Password)
        {
            SqlConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = "Integrated Security=true;database=dblHospitalManagement;User ID=DBO;Data Source=.\\SQLEXPRESS";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "spLogin";
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter workparameter1 = new SqlParameter();
            SqlParameter workparameter2 = new SqlParameter();
            SqlParameter workparameter3 = new SqlParameter();

            workparameter1 = myCommand.Parameters.Add("@UserID", SqlDbType.Char);
            workparameter1.Value = UserID;
            workparameter2 = myCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            workparameter2.Value = Password;
            workparameter3 = myCommand.Parameters.Add("@Answer", SqlDbType.Int);
            workparameter3.Direction = ParameterDirection.Output;

            myConnection.Open();



            myCommand.ExecuteNonQuery();

            int svar = Convert.ToInt32(workparameter3.SqlValue.ToString());

            myConnection.Close();

            if (svar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static DataSet GetUserInformation(string UserID)
        {

            DataSet ds = new DataSet();

            SqlConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = "Integrated Security=true;database=dblHospitalManagement;User ID=DBO;Data Source=.\\SQLEXPRESS";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "spUserInformation";
            myCommand.CommandType = CommandType.StoredProcedure;


            SqlParameter workparameter1 = new SqlParameter();

            workparameter1 = myCommand.Parameters.Add("@UserID", SqlDbType.VarChar);
            workparameter1.Value = UserID;


            adapter.SelectCommand = myCommand;

            adapter.Fill(ds);

            return ds;
        }

        public static DataSet GetRolesPermission(string roles)
        {

            DataSet ds = new DataSet();

            SqlConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = "Integrated Security=true;database=dblHospitalManagement;User ID=DBO;Data Source=.\\SQLEXPRESS";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "spRolesPermission";
            myCommand.CommandType = CommandType.StoredProcedure;


            SqlParameter workparameter1 = new SqlParameter();

            workparameter1 = myCommand.Parameters.Add("@RolesDescription", SqlDbType.VarChar);
            workparameter1.Value = roles;


            adapter.SelectCommand = myCommand;

            adapter.Fill(ds);

            return ds;
        }

        //public static bool InsertUpdatePatient(Patient myPatient)

    }
}
