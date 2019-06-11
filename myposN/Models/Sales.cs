using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace MyPOS.Models
{
    public class Sales
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double TotalCost { get; set; }

        public DateTime Time { get; set; }
    }
}
