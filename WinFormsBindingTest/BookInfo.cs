using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBindingTest
{
    public class BookInfo
    {
        public BookInfo()
        {
        }

        private string author;
        public event EventHandler<EventArgs> AuthorChanged;
        public string Author
        {
            get { return author; }
            set
            {
                if (author != value)
                {
                    author = value;
                    if (AuthorChanged != null)
                        AuthorChanged(this, EventArgs.Empty);
                }
            }
        }

        private string title;
        public event EventHandler<EventArgs> TitleChanged;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    if (TitleChanged != null)
                        TitleChanged(this, EventArgs.Empty);
                }
            }
        }

        private string isbn;
        public event EventHandler<EventArgs> ISBNChanged;
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (isbn != value)
                {
                    isbn = value;
                    if (ISBNChanged != null)
                        ISBNChanged(this, EventArgs.Empty);
                }
            }
        }

        private int pageCount;
        public event EventHandler<EventArgs> PageCountChanged;
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (pageCount != value)
                {
                    pageCount = value;
                    if (PageCountChanged != null)
                        PageCountChanged(this, EventArgs.Empty);
                }
            }
        }

        private string publisher;
        public event EventHandler<EventArgs> PublisherChanged;
        public string Publisher
        {
            get { return publisher; }
            set
            {
                if (publisher != value)
                {
                    publisher = value;
                    if (PublisherChanged != null)
                        PublisherChanged(this, EventArgs.Empty);
                }
            }
        }
    }
}
