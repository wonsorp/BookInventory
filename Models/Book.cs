using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInventory.Models
{
    public class Book 
    {
        private string _Publisher = "";
        private string _Title;
        private string _AuthorLastName;
        private string _AuthorFirstName;
        private decimal _Price;
        private string _titlofcontainer;
        private DateTime _publicationDate;
        private string _location;
        private string _MLA;
        private string _CMS; 
        public string Publisher
        {
            get => _Publisher;
            set => _Publisher = value;
        }
        public string Title {
            get => _Title;
            set => _Title = value;
        }
        public string AuthorLastName {
            get => _AuthorLastName;
            set => _AuthorLastName = value;
        }
        public string AuthorFirstName {
            get => _AuthorFirstName;
            set => _AuthorFirstName = value;
        }
        public decimal Price {
            get => _Price;
            set => _Price = value;
        }
        public string titlofcontainer {
            get => _titlofcontainer;
            set => _titlofcontainer = value;
        }
        public DateTime publicationDate {
            get => _publicationDate;
            set => _publicationDate = value;
        }
        public string location {
            get => _location;
            set => _location = value; 
        }

        public string mla {  get => _MLA;
                             set => _MLA = _AuthorLastName + ", " + _AuthorFirstName + '"' + _Title + '"' + "/n" + _titlofcontainer + ", " + _Publisher + ", " + _publicationDate.Year.ToString() + ", " + _location;
        }
        public string cms
        {
            get => _CMS;
            set => _CMS = _AuthorLastName + ", " + _AuthorFirstName +". " + _publicationDate.Year.ToString() + ". " +'"' + _Title + '"'  + _Publisher + " "  + _location;
        }
    }
      
}