using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Library:IEnumerable<Book>
    {
         public List<Book> Books;

        public Library()
        {
            Books = new List<Book>()
            { new Book("malkiq princ", "A.A", 1984),
            new Book("pod igoto", "I.V", 1900),
            new Book("Tutun", "D.D", 1951)
            };
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
