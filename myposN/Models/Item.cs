using SQLite.Net.Attributes;
using System;

namespace MyPOS.Models
{
    [Table("Item")]
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public string SKU { get; set; }
        public string Barcode { get; set; }
    }
}