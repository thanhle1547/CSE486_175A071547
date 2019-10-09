using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DAO // Data Access Layer
{
    class DataProvider
    {
        private static DataProvider ins;
        private static string cnnStr = ConfigurationManager.ConnectionStrings["cnnStr"].ConnectionString;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable dt;

        private DataProvider()
        {
            // https://medium.com/@kevalpatel2106/how-to-make-the-perfect-singleton-de6b951dfdb0
            if (ins != null)
                throw new Exception("Use 'ins' to get the single instance of this class");
            Cnn = new SqlConnection(cnnStr);
            Cnn.Open();
        }

        public static DataProvider Ins {
            get
            {
                if (ins == null)
                    ins = new DataProvider();
                return ins;
            }
            private set => ins = value;
        }

        private SqlConnection Cnn
        {
            get
            {
                // https://stackoverflow.com/questions/6943933/check-if-sql-connection-is-open-or-closed
                // Broken, Connnecting, Executing, Fetching
                if (cnn.State == ConnectionState.Broken || cnn.State == ConnectionState.Closed)
                    cnn.Open();
                return cnn;
            }
            set => cnn = value;
        }

        /*private void AddParams (ref string query, object[] param)
        {
            // https://blogs.msmvps.com/jcoehoorn/blog/2014/05/12/can-we-stop-using-addwithvalue-already/
            *//* say you have a varchar database column, but send a string parameter using the AddWithValue() function. 
            ADO.Net will send this to the database as an nvarchar value *//*
            string[] listParam = Regex.Split(query, @"(\@)\w+");
            for (int i = 0; i < param.Length; i++)
                cmd.Parameters.AddWithValue(listParam[i], param[i]); // -> dùng store proc trên database để chuyển kiểu dl
        }

        // UPDATE, INSERT, DELETE
        public int ExecNonQuery(string query)
        {
            cmd = new SqlCommand(query, Cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }*/

        public void AddParams(ref SqlParameter[] param, params object[] value)
        {
            int i = 0;
            foreach (SqlParameter p in param)
            {
                p.Value = value[i];
                i++;
            }
        }

        // params: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params
        // https://www.codeproject.com/Articles/36847/Three-Layer-Architecture-in-C-NET-2
        public int ExecNonQuery(string query, SqlParameter[] param = null)
        {
            try
            {
                cmd = new SqlCommand(query, Cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw (e);
            }
        }

        public DataTable ExecQuery(string query, SqlParameter[] param = null)
        {
            dt = new DataTable();

            try
            {
                cmd = new SqlCommand(query, Cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            return dt;
        }
    }
}
