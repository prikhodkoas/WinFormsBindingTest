using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBindingTest
{
    public partial class MainForm : Form
    {
        BookInfo bookInfo;

        public MainForm()
        {
            InitializeComponent();
            bookInfo = CreateBookInfo();
            FillControls();
            AdviseToControlEvents();
        }

        private BookInfo CreateBookInfo()
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Author = "Том Клэнси";
            bookInfo.Title = "Игры патриотов";
            bookInfo.ISBN = "5-699-18175-X";
            bookInfo.PageCount = 706;
            bookInfo.Publisher = "ЭКСМО";
            return bookInfo;
        }

        private void FillControls()
        {
            authorTextBox.Text = bookInfo.Author;
            titleTextBox.Text = bookInfo.Title;
            isbnTextBox.Text = bookInfo.ISBN;
            pageCountTextBox.Text = bookInfo.PageCount.ToString();
            publisherTextBox.Text = bookInfo.Publisher;
        }

        private void AdviseToControlEvents()
        {
            authorTextBox.TextChanged += (o, e) =>
            {
                bookInfo.Author = authorTextBox.Text;
            };

            titleTextBox.TextChanged += (o, e) =>
            {
                bookInfo.Title = titleTextBox.Text;
            };

            isbnTextBox.TextChanged += (o, e) =>
            {
                bookInfo.ISBN = isbnTextBox.Text;
            };

            pageCountTextBox.TextChanged += (o, e) =>
            {
                bookInfo.PageCount = int.Parse(pageCountTextBox.Text);
            };

            publisherTextBox.TextChanged += (o, e) =>
            {
                bookInfo.Publisher = publisherTextBox.Text;
            };
        }
    }
}
