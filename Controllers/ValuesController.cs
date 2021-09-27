using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookInventory.Models;

namespace BookInventory.Controllers
{
    public class ValuesController : ApiController
    {
        Books b = new Books();
        
        [HttpGet]
        public IEnumerable<Book> GetByPublisher()
        {
            IEnumerable<Book> booksreturn = b.OrderBy(Books => Books.Publisher)
                .ThenBy(Books => Books.AuthorLastName)
                .ThenBy(Books => Books.AuthorFirstName)
                .ThenBy(Books => Books.Title).ToList();
            return booksreturn;
        }

        [HttpGet]
        public IEnumerable<Book> GetByAuthor()
        {
            IEnumerable<Book> booksreturn = b.OrderBy(Books => Books.AuthorLastName)
                .ThenBy(Books => Books.AuthorFirstName)
                .ThenBy(Books => Books.Title).ToList();
            return booksreturn;
        }

        [HttpGet]
        public IEnumerable<Book> GetByPublisherFromDB()
        {
            string storedprocname = "GetByPublisher";
            string connectionstring = " ";

            DataAccess.DataStore ds = new DataAccess.DataStore(connectionstring, storedprocname);
            return ds.MSSql();
        }

        [HttpGet]
        public IEnumerable<Book> GetByAuthorFromDB()
        {
            string storedprocname = "GetByAuthor";
            string connectionstring = " ";

            DataAccess.DataStore ds = new DataAccess.DataStore(connectionstring, storedprocname);
            return ds.MSSql();
        }

    }
}
