using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;
        public string Title
        {
            get { return title; } 
            set { title = value; } 
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Author
        {
            get { return author; }
            set { author= value; }
        }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            
        }
        public override string ToString()
        {
            return $"{this.author} {this.year} {this.title}";
        }
    }
}
