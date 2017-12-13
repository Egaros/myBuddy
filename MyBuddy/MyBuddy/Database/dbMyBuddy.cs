using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuddy
{
    public class dbMyBuddy
    {
        readonly SQLiteAsyncConnection database;

        public dbMyBuddy(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        public Task<List<T>> GetItemsAsync<T>() where T : BaseModel, new()
        {
            return database.Table<T>().ToListAsync();
        }

        public Task<List<T>> GetItemsNotDoneAsync<T>() where T : BaseModel, new()
        {
            return database.QueryAsync<T>( "SELECT * FROM [T] WHERE [Done] = 0");
        }

        public Task<T> GetItemAsync<T>(int id) where T : BaseModel, new()
        {
            return database.Table<T>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync<T>(T item) where T : BaseModel, new()
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync<T>(T item) where T : BaseModel, new()
        {
            return database.DeleteAsync(item);
        }
    }
}