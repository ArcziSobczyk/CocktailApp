using Core.Models;
using MvvmCross.Base;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Database
{
    public class CocktailAppDatabase
    {
        static SQLiteAsyncConnection Database;
        public CocktailAppDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public static readonly AsyncLazy<CocktailAppDatabase> Instance = new AsyncLazy<CocktailAppDatabase>(async () =>
        {
            var instance = new CocktailAppDatabase();
            CreateTableResult result = await Database.CreateTableAsync<CocktailModel>();
            return instance;
        });

        public Task<List<CocktailModel>> GetItemsAsync()
        {
            return Database.Table<CocktailModel>().ToListAsync();
        }

        public Task<CocktailModel> GetItemAsync(int id)
        {
            return Database.Table<CocktailModel>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(CocktailModel item)
        {
            if (item.ID != 0)
                return Database.UpdateAsync(item);
            else 
                return Database.InsertAsync(item);
        }

        public Task<int> DeleteItemAsync(CocktailModel item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
