using ContactsTable.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ContactsTable.DataAccess
{
    public static class SQLDataAccess
    {

        public static List<T> GetData<T>(string sql)
        {
            using (MySqlConnection connect = new MySqlConnection("Data Source=localhost; port=3306; Database=testdb; UserId=root; password=123456"))
            {
                connect.Open();
                var test = connect.Query<T>(sql);
                return connect.Query<T>(sql).ToList();
            }
        }

        public static List<Contacts> GetContacts()
        {
            string select = @"Select * from contacts";
            var test = GetData<Contacts>(select);

            return GetData<Contacts>(select);
        }
    }
}