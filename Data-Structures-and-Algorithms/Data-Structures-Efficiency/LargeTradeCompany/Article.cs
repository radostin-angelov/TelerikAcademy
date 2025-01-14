﻿namespace LargeTradeCompany
{
    using System;

    class Article: IComparable<Article>
    {
        public Article(string title, string barcode, string vendor, decimal price)
        {
            this.Title = title;
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, {2} - {3:F2}", this.Title, this.Barcode, this.Vendor, this.Price);
        }
    }
}
