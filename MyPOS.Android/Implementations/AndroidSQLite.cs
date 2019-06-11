using System.IO;
using SQLite.Net;
using MyPOS.Droid.Implementaions;
using MyPOS.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]
namespace MyPOS.Droid.Implementaions
{
    public class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            
            // Documents folder
            var path = Path.Combine(documentsPath, DatabaseHelper.DbFileName);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);

            // Return the database connection
            return conn;
        }
    }
}
