using Disaheim_2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Book : Merchandise
    {
        private string _title;
        private double _price;


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(string itemId, string title, double price) : base(itemId)
        {
            this._title = title;
            this._price = price;
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
            return "ItemId: " + ItemId + ", " + "Title: " + _title + ", " + "Price: " + _price;
        }


    }


}
