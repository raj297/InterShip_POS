using System;
using SQLite.Net;

namespace MyPOS.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
