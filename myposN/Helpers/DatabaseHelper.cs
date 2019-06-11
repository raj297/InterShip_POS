using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using MyPOS.Models;
using System;

namespace MyPOS.Helpers
{
    public class DatabaseHelper
    {
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "Pos.db";

        public DatabaseHelper()
        {
            sqliteconnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteconnection.CreateTable<Customer>();
            sqliteconnection.CreateTable<Item>();
            sqliteconnection.CreateTable<Receipt>();
        }

        #region Customers

        // Get All Customers data    
        public List<Customer> GetAllCustomers()
        {
            return (from data in sqliteconnection.Table<Customer>()
                    select data).ToList();
        }

        //Get Specific Customer data
        public Customer GetCustomer(int id)
        {
            return sqliteconnection.Table<Customer>().FirstOrDefault(t => t.Id == id);
        }

        // Delete all Customers Data
        public void DeleteAllCustomers()
        {
            sqliteconnection.DeleteAll<Customer>();
        }

        // Delete Specific Customer
        public void DeleteCustomer(int id)
        {
            sqliteconnection.Delete<Customer>(id);
        }

        // Insert new Customer to DB 
        public void InsertCustomer(Customer customer)
        {
            sqliteconnection.Insert(customer);
        }

        // Update Customer Data
        public void UpdateCustomer(Customer customer)
        {
            sqliteconnection.Update(customer);
        }

        #endregion Customers

        #region Items

        // Get All Items data    
        public List<Item> GetAllItems()
        {
            return (from data in sqliteconnection.Table<Item>()
                    select data).ToList();
        }

        //Get Specific Item data
        public Item GetItem(int id)
        {
            return sqliteconnection.Table<Item>().FirstOrDefault(t => t.Id == id);
        }

        // Delete all Items Data
        public void DeleteAllItems()
        {
            sqliteconnection.DeleteAll<Customer>();
        }

        // Delete Specific Item
        public void DeleteItem(int id)
        {
            sqliteconnection.Delete<Item>(id);
        }

        // Insert new Item to DB 
        public void InsertItem(Item item)
        {
            sqliteconnection.Insert(item);
        }

        // Update Item Data
        public void UpdateItem(Item item)
        {
            sqliteconnection.Update(item);
        }
        #endregion Items

        #region Receipts

        // Get All Receipts data    
        public List<Receipt> GetAllReceipts()
        {
            return (from data in sqliteconnection.Table<Receipt>()
                    select data).ToList();
        }

        //Get Specific Receipt data
        public Receipt GetReceipt(int id)
        {
            return sqliteconnection.Table<Receipt>().FirstOrDefault(t => t.Id == id);
        }

        // Delete all Receipts Data
        public void DeleteAllReceipts()
        {
            sqliteconnection.DeleteAll<Receipt>();
        }

        // Delete Specific Receipt
        public void DeleteReceipt(int id)
        {
            sqliteconnection.Delete<Receipt>(id);
        }

        // Insert new Receipt to DB 
        public void InsertReceipt(Receipt receipt)
        {
            sqliteconnection.Insert(receipt);
        }

        // Update Receipt Data
        public void UpdateReceipt(Receipt receipt)
        {
            sqliteconnection.Update(receipt);
        }
        #endregion Receipts
    }
}