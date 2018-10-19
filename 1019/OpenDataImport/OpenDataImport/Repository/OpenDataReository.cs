using OpenDataImport.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OpenDataImport.Repository
{
    class OpenDataReository
    {
        public string ConnectionString
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\[高科大]軟體工程\github\1019\OpenDataImport\OpenDataImport\APP_Data\Database.mdf;Integrated Security=True";
            }
        }
        public void Insert(OpenData item)
        {
            var newItem = item;
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            var command = new SqlCommand("", connection);
            command.CommandText = string.Format(@"
            INSERT INTO OpenData(服務分類, 資料集名稱, 主要欄位說明)
            VALUES              (N'{0}', N'{1}', N'{2}')
            ", newItem.服務分類, newItem.資料集名稱, newItem.主要欄位說明.Replace("'",""));

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
