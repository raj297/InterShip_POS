using SQLite.Net.Attributes;
using System;

namespace MyPOS.Models
{
    [Table("Customer")]
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Note { get; set; }
    }
}