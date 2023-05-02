using Core.Models;
using Microsoft.Data.Sqlite;
using SQLite;
using System;

namespace Core.Services
{
    public class DatabaseService
    {
        static SQLiteAsyncConnection? Database;
        public DatabaseService()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public static readonly AsyncLazy<DatabaseService> Instance = new AsyncLazy<DatabaseService>(async () =>
        {
            var instance = new DatabaseService();
            CreateTableResult result = await Database.CreateTableAsync<CocktailModel>();
            return instance;
        });

        public void CreateCocktailsTable()
        {
            Database?.CreateTableAsync<CocktailModel>();
        }

        
    }
}