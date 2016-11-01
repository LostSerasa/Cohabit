using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Cohabit.Core.Interface;
using SQLite.Net;

namespace Cohabit.Droid.Database
{
    public class SQLiteDroid : ISqlite
    {
        public SQLiteDroid() { }

        public SQLiteConnection GetConnection()
        {
            var sqlitefilename = "LocationSQLite.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); //document folder
            var path = Path.Combine(documentsPath, sqlitefilename);
            //create connection
            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), path);
            // return database connection
            return conn;
        }


    }
}