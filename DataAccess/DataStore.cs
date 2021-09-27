using BookInventory.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;

namespace BookInventory.DataAccess
{
    public class DataStore
    {
        string _connectionstring = "";
        string _storedProcName = "";
        public DataStore (string Connectionstring, string StoredProcName)
        {
            _connectionstring = Connectionstring;
            _storedProcName = StoredProcName;
        }

        public List<Book> MSSql()
        {

            List<Book> Books = new List<Book>();

            using (SqlCommand Cmd = new SqlCommand())
            {
                Cmd.Connection = new SqlConnection(_connectionstring);
                Cmd.CommandText = _storedProcName;
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {

                }
            }

            return Books;
        }
    }
}