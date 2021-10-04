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
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader rdr;

            List<Book> Books = new List<Book>();

            
                con = new SqlConnection(_connectionstring);
                cmd = new SqlCommand(_storedProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Book a = new Book();
                    a.Publisher = rdr["Publisher"].ToString();
                    a.Title = rdr["Title"].ToString();
                    a.AuthorFirstName = rdr["AuthorLastName"].ToString();
                    a.AuthorLastName = rdr["AuthorFirstName"].ToString();
                    a.Price = decimal.Parse(rdr["Price"].ToString());
                    a.titlofcontainer = rdr["titlofcontainer"].ToString();
                    a.publicationDate = DateTime.Parse(rdr["publicationDate"].ToString());
                    a.location = rdr["location"].ToString();
                    a.mla = "";
                    a.cms = "";
                    Books.Add(a);
                }
            }
            catch (Exception e )
            { string test = e.Message; }
            finally { con.Close(); }
           
            return Books;
        }
    }
}