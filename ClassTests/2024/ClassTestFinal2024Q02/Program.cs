using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestFinal2024Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static Book[] GetBooks(Book[] books, string author)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].GetAuthor() == author)
                {
                    count++;
                }
            }
            Book[] result = new Book[count];
            int index = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].GetAuthor() == author)
                {
                    result[index] = books[i];
                    index++;
                }
            }
            return result;
        }
    }

    public class Book
    {
        private string titile;

        public string GetTitle()
        {
            return this.titile;
        }
        public void SetTitle(string titile)
        {
            this.titile = titile;
        }

        private int price;

        public int GetPrice()
        {
            return this.price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        private string author;

        public string GetAuthor()
        {
            return this.author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public Book(string title,int price, string author)
        {
            this.titile = title;
            this.price = price;
            this.author = author;

        }

    }
}
