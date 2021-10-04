using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using BookInventory.Models;

namespace BookInventory.Controllers
{
    public class HomeController : ApiController
    {

        [Route("api/WebApi/GetByPublisher")]
        [HttpGet]
        public List<Book> GetByPublisher()
        {
            List<Book> BookList = InitValues();

            List<Book> booksreturn = BookList.OrderBy(Book => Book.Publisher)
                .ThenBy(Book => Book.AuthorLastName)
                .ThenBy(Book => Book.AuthorFirstName)
                .ThenBy(Book => Book.Title).ToList();
            return booksreturn;
        }

        [Route("api/WebApi/GetByAuthor")]
        [HttpGet]
        public List<Book> GetByAuthor()
        {

            List<Book> BookList = InitValues();

            List<Book> booksreturn = BookList.OrderBy(Book => Book.AuthorLastName)
                .ThenBy(Book => Book.AuthorFirstName)
                .ThenBy(Book => Book.Title).ToList();
            return booksreturn;
        }

        [Route("api/WebApi/GetInventorytotal")]
        [HttpGet]
        public string GetInventorytotal()
        {

            List<Book> BookList = InitValues();

          
            return BookList.Sum(Book => Book.Price).ToString();
        }


        [Route("api/WebApi/GetByPublisherFromDB")]
        [HttpGet]
        public List<Book> GetByPublisherFromDB()
        {
            string storedprocname = "GetByPublisher";
            string connectionstring = "data source=localhost\\MSSQLSERVER01; initial catalog=LocalDev;persist security info=True; Integrated Security = SSPI;";
            DataAccess.DataStore ds = new DataAccess.DataStore(connectionstring, storedprocname);
            return ds.MSSql();
        }

        [Route("api/WebApi/GetByAuthorFromDB")]
        [HttpGet]
        public List<Book> GetByAuthorFromDB()
        {
            string storedprocname = "GetByAuthor";
            string connectionstring = "data source=localhost\\MSSQLSERVER01; initial catalog=LocalDev;persist security info=True; Integrated Security = SSPI;";

            DataAccess.DataStore ds = new DataAccess.DataStore(connectionstring, storedprocname);
            return ds.MSSql();
        }

        public List<Book> InitValues()
        {
            List<Book> Books = new List<Book>();

            Book a = new Book();
            a.Publisher = "Portfolio";
            a.Title = "Start with Why: How Great Leaders Inspire Everyone to Take Action";
            a.AuthorFirstName = "Simon";
            a.AuthorLastName = "Sinek";
            a.Price = new decimal(16.19);
            a.titlofcontainer = "Stop, Look and Listen";
            a.publicationDate = new DateTime(1998, 01, 01);
            a.location = "PP 120-122";
            a.mla = "";
            a.cms = "";
            Books.Add(a);

            Book b = new Book();
            b.Publisher = "Microsoft Press";
            b.Title = "Code Complete: A Practical Handbook of Software Construction";
            b.AuthorFirstName = "Steve";
            b.AuthorLastName = "McConnell";
            b.Price = new decimal(28.43);
            b.titlofcontainer = "Objects are Like Buckets";
            b.publicationDate = new DateTime(1995, 01, 01);
            b.location = "PP 20-42";
            b.mla = "";
            b.cms = "";
            Books.Add(b);

            Book c = new Book();
            c.Publisher = "Addison-Wesley Professional";
            c.Title = "The Pragmatic Programmer";
            c.AuthorFirstName = "Martin";
            c.AuthorLastName = "Fowler";
            c.Price = new decimal(32.00);
            c.titlofcontainer = "What are variables?";
            c.publicationDate = new DateTime(1980, 01, 01);
            c.location = "PP 5-21";
            c.mla = "";
            c.cms = "";
            Books.Add(c);

            Book d = new Book();
            d.Publisher = "Packt Publishing";
            d.Title = "Git for Programmers: Master Git for effective implementation of version control for your programming projects";
            d.AuthorFirstName = "Jesse";
            d.AuthorLastName = "Liberty";
            d.Price = new decimal(49.99);
            d.titlofcontainer = "Git out of here";
            d.publicationDate = new DateTime(2002, 01, 01);
            d.location = "PP 155-157";
            d.mla = "";
            d.cms = "";
            Books.Add(d);

            Book e = new Book();
            e.Publisher = "Morgan Kaufmann";
            e.Title = "The Art of Multiprocessor Programming";
            e.AuthorFirstName = "Maurice";
            e.AuthorLastName = "Herlihy";
            e.Price = new decimal(56.21);
            e.titlofcontainer = "Threads o Plenty";
            e.publicationDate = new DateTime(2009, 01, 01);
            e.location = "PP 85-92";
            e.mla = "";
            e.cms = "";
            Books.Add(e);

            return Books;

        }


    }
}
