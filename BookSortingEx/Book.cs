using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Book : IComparable<Book>
    {

        public string ISBN;
        public string Title;
        public string Author;

        public Book(string ISBN, string Title, String Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }
        
        public override string ToString()
        {
            return Title + " by " + Author + " ISBN: " + ISBN;
        }

        int IComparable<Book>.CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

    }


}
