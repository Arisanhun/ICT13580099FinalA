using System;
using ICT13580099FinalA.Models;
using SQLite;
namespace ICT13580099FinalA.Helpers
{
    public class DbHelper
    {
		SQLiteConnection db;

		public DbHelper(string dbPath)
		{
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Profile>();
		}

	}
}
