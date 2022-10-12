using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Book
    {
        private string itemId;
        private string title;
        private double price;


        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            this.itemId = itemId;
            this.title = title;
            this.price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0.0)
        {
            ItemId = itemId;
            Title = title;
        }

        public Book(string itemId) : this(itemId, "", 0.0)
        {
            ItemId = itemId;
        }


        public override string ToString()
        {
            return "ItemId: " + itemId + ", " + "Title: " + title + ", " + "Price: " + price;
        }


    }


}
