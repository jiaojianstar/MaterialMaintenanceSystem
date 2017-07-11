using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
namespace MaterialMaintenanceSystem
{
    class PostDB
    {
        
        DataSet DS;
        bool ECode;
        string ErrString;
        NpgsqlConnection Conn = new NpgsqlConnection();
        public  PostDB(string ServerName, string ServerPort, string DBName, string UserName, string Pwd)
        {
            ECode = false;
            Conn.ConnectionString = "Server=" + ServerName + ";Port=" + ServerPort + ";User Id=" + UserName + ";Password=" + Pwd + ";Database=" + DBName;
            try
            {
                Conn.Open();
            }
            catch (Exception e)
            {
                ECode = true;
              
            }
        }
        public DataSet GetRecordSet(string sql)
        {
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = sql;
            try
            {
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(sqlCmd);
                DS = new DataSet();
                adp.Fill(DS);
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
                return null;
            }
            return DS;
        }
        public int ExecuteSQLScalar(string Sqls)
        {
            string s;
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = Sqls;
            sqlCmd.CommandType = CommandType.Text;
            try
            {
                s = sqlCmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
                return -1;
            }
            return (int.Parse(s));
        }

        public string ExecuteSQLScalarTOstring(string Sqls)
        {
            string s;
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = Sqls;
            sqlCmd.CommandType = CommandType.Text;
            try
            {
                s = sqlCmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
                return "-1";
            }
            return s;
        }
        public string ExecuteSQLWithTrans(string Sqls)
        {
            string s;
            NpgsqlTransaction myTrans;
            myTrans = Conn.BeginTransaction();
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = Sqls;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Transaction = myTrans;
            sqlCmd.ExecuteNonQuery();
            //Sqls="SELECT @@IDENTITY AS ID";  
            sqlCmd.CommandText = Sqls;
            try
            {
                s = sqlCmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
                myTrans.Commit();
                return "";
            }
            myTrans.Commit();
            return (s);
        }
        public void ExecuteSQL(string Sqls)
        {
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = Sqls;
            sqlCmd.CommandType = CommandType.Text;
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
            }
        }
        public NpgsqlDataReader DBDataReader(string Sqls)
        {
            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = Conn;
            sqlCmd.CommandText = Sqls;
            sqlCmd.CommandType = CommandType.Text;
            try
            {
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
                return null;
            }
        }
        public void DBClose()
        {
            try
            {
                Conn.Close();
            }
            catch (Exception e)
            {
                ErrString = e.Message;
                ECode = true;
            }
        }

        public bool ErrorCode()
        {
            return ECode;
        }
        public string ErrMessage()
        {
            return ErrString;
        }
        ~PostDB()
        {

        }


    }
}
