using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;

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
            // Đã mở kết nối ở Cnn
            // The connection was not closed. The connection's current state is open
            /*if (cnn.State != ConnectionState.Open)
                Cnn.Open();*/
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

        private void SetCmd (ref string query, CommandType type)
        {
            cmd = new SqlCommand(query, Cnn);
            cmd.CommandType = type;
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
            finally { Cnn.Close(); }
        }


        public DataTable ExecQuery(string query, SqlParameter[] param = null)
        {
            dt = new DataTable();

            try
            {
                SetCmd(ref query, CommandType.Text);

                if (param != null)
                    cmd.Parameters.AddRange(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
            return dt;
        }

        public DataTable ExecQuery(string query, SqlParameter param)
        {
            dt = new DataTable();
            
            try
            {
                SetCmd(ref query, CommandType.Text);
                cmd.Parameters.Add(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
            return dt;
        }

        public object ExecScalar(string query, SqlParameter[] param, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SetCmd(ref query, cmdType);
                if (param != null)
                    cmd.Parameters.AddRange(param);

                return cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
        }

        public object ExecScalar(string query, SqlParameter param, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SetCmd(ref query, cmdType);
                cmd.Parameters.Add(param);

                return cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
        }

        public object ExecScalar(string query, CommandType cmdType = CommandType.Text)
        {
            try
            {
                SetCmd(ref query, cmdType);

                return cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
        }



        public DataTable ExecProc(string query, SqlParameter[] param = null)
        {
            dt = new DataTable();

            try
            {
                SetCmd(ref query, CommandType.StoredProcedure);

                if (param != null)
                    cmd.Parameters.AddRange(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
            return dt;
        }

        public DataTable ExecProc(string query, SqlParameter param)
        {
            dt = new DataTable();

            try
            {
                SetCmd(ref query, CommandType.StoredProcedure);
                cmd.Parameters.Add(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }
            return dt;
        }

        // https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller
        // https://aptech.vn/kien-thuc-tin-hoc/tim-hieu-ve-cau-truc-dataset-trong-ado-net.html
        public DataSet ExecuteProc(string query, SqlParameter[] param = null)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SetCmd(ref query, CommandType.StoredProcedure);
                if (param != null)
                    cmd.Parameters.AddRange(param);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            finally { Cnn.Close(); }

            return dataSet;
        }


        // https://stackoverflow.com/a/11306069
        // https://stackoverflow.com/questions/840261/passing-arguments-to-c-sharp-generic-new-of-templated-type
        // https://toidicodedao.com/2015/03/10/series-c-hay-ho-ienumerable-va-yield-tuong-don-gian-ma-lam-thu-phai-ban/
        public IEnumerable<T> ExecQuery<T>(string query, SqlParameter[] param = null)
        {
            List<T> list = new List<T>();
            try
            {
                dt = ExecQuery(query, param);
                /*foreach (var row in dt.Rows)
                {
                    // https://stackoverflow.com/questions/25577601/constructor-on-type-not-found
                    T item = (T)Activator.CreateInstance(typeof(T), new object[] { row }); // TH chỉ map 1 phần thì 0 đc
                    // ko dùng đc ở đây, nhiều lỗi
                    //yield return item;
                    list.Add(item);
                }*/
                foreach (var row in dt.AsEnumerable())
                {
                    T obj = (T)Activator.CreateInstance(typeof(T));
                    //List<PropertyInfo> properties = obj.GetType().GetProperties().ToList();  0 đc vì bị sửa trong lúc chạy
                    foreach (var prop in obj.GetType().GetProperties())
                        try
                        {
                            //prop.SetValue(prop.Name, Convert.ChangeType(row[col.ColumnName], prop.PropertyType), null);
                            // https://stackoverflow.com/a/25989896
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], prop.PropertyType), null);
                            // properties.Remove(prop);
                        }
                        catch { continue; }
                    list.Add(obj);
                }
            }
            catch (Exception) { throw; }
            finally { Cnn.Close(); }

            return list;
        }

        public IEnumerable<T> ExecQuery<T>(string query, SqlParameter param)
        {
            List<T> list = new List<T>();
            try
            {
                dt = ExecQuery(query, param);
                foreach (var row in dt.AsEnumerable())
                {
                    T obj = (T)Activator.CreateInstance(typeof(T));
                    foreach (var prop in obj.GetType().GetProperties())
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], prop.PropertyType), null);
                        }
                        catch { continue; }
                    list.Add(obj);
                }
            }
            catch (Exception) { throw; }
            finally { Cnn.Close(); }

            return list;
        }

        public IEnumerable<T> ExecProc<T>(string query, SqlParameter[] param = null)
        {
            List<T> list = new List<T>();
            try
            {
                dt = ExecProc(query, param);
                foreach (var row in dt.AsEnumerable())
                {
                    T obj = (T)Activator.CreateInstance(typeof(T));
                    foreach (var prop in obj.GetType().GetProperties())
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], prop.PropertyType), null);
                        }
                        catch { continue; }
                    list.Add(obj);
                }
            }
            catch (Exception) { throw; }
            finally { Cnn.Close(); }

            return list;
        }

        public IEnumerable<T> ExecProc<T>(string query, SqlParameter param)
        {
            List<T> list = new List<T>();
            try
            {
                dt = ExecProc(query, param);
                foreach (var row in dt.Rows)
                {
                    T item = (T)Activator.CreateInstance(typeof(T), row);
                    //yield return item;
                    list.Add(item);
                }
            }
            catch (Exception) { throw; }
            finally { Cnn.Close(); }

            return list;
        }
    }
}
