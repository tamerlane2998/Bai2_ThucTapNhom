﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KetNoiDB
{
    /// <summary>
    /// Các tham số hệ thống dùng để thống nhất trong toàn bộ dự án
    /// </summary>
    public class AppConfig
	{
        private static string con;
        public static string connectionString()
        {
            con = @"Data Source=DESKTOP-2SCAQKB\MINH;Initial Catalog=QL_ThuVien;Integrated Security=true;";
            return con;
        }
        public static int setConnect(string server, string database, string username, string userpassword)
        {
            con = string.Format("Server={0};Database={1};User Id={2};Password={3};",server,database,username,userpassword);
            return 0;
            
        }       
	}

    public class dbConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        /// <constructor>
        /// Initialise Connection
        /// </constructor>
        public dbConnection()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(AppConfig.connectionString());
        }

        /// <method>
        /// Open Database Connection if Closed or Broken
        /// </method>
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State ==ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

      
    }
}