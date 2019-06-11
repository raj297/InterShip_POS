using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;


namespace MyPOS.Models
{
    public class Categories
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        
    }
}
