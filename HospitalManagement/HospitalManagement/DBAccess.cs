﻿using System;
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

        public static bool InsertUpdatePatient(Patient myPatient, int registerORupdate)
        {
            

            SqlConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = "Integrated Security=true;database=dblHospitalManagement;User ID=DBO;Data Source=.\\SQLEXPRESS";


            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;

            SqlParameter workparameter10 = new SqlParameter();

            if (registerORupdate =='R')

            {
                myCommand.CommandText = "spInsertPatients";

                myCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter workparameter1 = new SqlParameter();
                SqlParameter workparameter2 = new SqlParameter();
                SqlParameter workparameter3 = new SqlParameter();
                SqlParameter workparameter4 = new SqlParameter();
                SqlParameter workparameter5 = new SqlParameter();
                SqlParameter workparameter6 = new SqlParameter();
                SqlParameter workparameter7 = new SqlParameter();
                SqlParameter workparameter8 = new SqlParameter();
                SqlParameter workparameter9 = new SqlParameter();


                workparameter1 = myCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                workparameter1.Value = myPatient.FirstName;
                workparameter2 = myCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
                workparameter2.Value = myPatient.LastName;
                workparameter3 = myCommand.Parameters.Add("@PersonNumber", SqlDbType.Char);
                workparameter3.Value = myPatient.PersonNumber;
                workparameter4 = myCommand.Parameters.Add("@Gender", SqlDbType.Char);
                workparameter4.Value = myPatient.Gender;
                workparameter5 = myCommand.Parameters.Add("@Address", SqlDbType.VarChar);
                workparameter5.Value = myPatient.Address;
                workparameter6 = myCommand.Parameters.Add("@PostalNr", SqlDbType.Char);
                workparameter6.Value = myPatient.PostalNumber;
                workparameter7 = myCommand.Parameters.Add("@City", SqlDbType.VarChar);
                workparameter7.Value = myPatient.City;
                workparameter8 = myCommand.Parameters.Add("@PhoneNr", SqlDbType.VarChar);
                workparameter8.Value = myPatient.PhoneNumber;
                workparameter9 = myCommand.Parameters.Add("@Email", SqlDbType.VarChar);
                workparameter9.Value = myPatient.EMail;

                workparameter10 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
                workparameter10.Direction = ParameterDirection.Output;

            }

            else

            {

                myCommand.CommandText = "spUpdatePatients";

                myCommand.CommandType = CommandType.StoredProcedure;


                SqlParameter workparameter1 = new SqlParameter();
                SqlParameter workparameter2 = new SqlParameter();
                SqlParameter workparameter3 = new SqlParameter();
                SqlParameter workparameter4 = new SqlParameter();
                SqlParameter workparameter5 = new SqlParameter();
                SqlParameter workparameter6 = new SqlParameter();
                SqlParameter workparameter7 = new SqlParameter();
                SqlParameter workparameter8 = new SqlParameter();
                SqlParameter workparameter9 = new SqlParameter();


                workparameter1 = myCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
                workparameter1.Value = myPatient.FirstName;
                workparameter2 = myCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
                workparameter2.Value = myPatient.LastName;
                workparameter3 = myCommand.Parameters.Add("@PersonNumber", SqlDbType.Char);
                workparameter3.Value = myPatient.PersonNumber;
                workparameter4 = myCommand.Parameters.Add("@Gender", SqlDbType.Char);
                workparameter4.Value = myPatient.Gender;
                workparameter5 = myCommand.Parameters.Add("@Address", SqlDbType.VarChar);
                workparameter5.Value = myPatient.Address;
                workparameter6 = myCommand.Parameters.Add("@PostalNr", SqlDbType.Char);
                workparameter6.Value = myPatient.PostalNumber;
                workparameter7 = myCommand.Parameters.Add("@City", SqlDbType.VarChar);
                workparameter7.Value = myPatient.City;
                workparameter8 = myCommand.Parameters.Add("@PhoneNr", SqlDbType.VarChar);
                workparameter8.Value = myPatient.PhoneNumber;
                workparameter9 = myCommand.Parameters.Add("@Email", SqlDbType.VarChar);
                workparameter9.Value = myPatient.EMail;

                workparameter10 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
                workparameter10.Direction = ParameterDirection.Output;

            }

            myConnection.Open();

            myCommand.ExecuteNonQuery();

            int svar = Convert.ToInt32(workparameter10.SqlValue.ToString());

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

    }
}