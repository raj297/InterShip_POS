using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;


namespace MyPOS.Models
{
    [Table("Authentication")]
    public class Authentication
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        
        public string Password { get; set; }
    }
}
