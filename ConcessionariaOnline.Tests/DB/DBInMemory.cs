using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using System;
using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Tests.DB
{
    public class DBInMemory
    {
        private readonly string _dataSource = "DataSource=:memory";
        private ConcessionariaOnlineContext _context;

        public DBInMemory()
        {
            var connection = new SQLiteConnection(_dataSource);
            connection.Open();

            var options = new DbContextOptionsBuilder<ConcessionariaOnlineContext>()
                .UseSqlite(connection)
                .EnableSensitiveDataLogging()
                .Options;

            _context = new ConcessionariaOnlineContext(options);
            InsertFakeData();
        }

        public ConcessionariaOnlineContext GetContext() => _context;

        private void InsertFakeData()
        {
            if (_context.Database.EnsureCreated())
            {
                var myCar = new Car()
                {
                    Id = 1,
                    clientId = 1,
                    Brand = "Honda",
                    Model = "Sedan",
                    Name = "Civic",
                    Price = 1000000,
                    Sold = false,
                    Year = "2021"
                };

                var myUser = new User()
                {
                    Id = 1,
                    Email = "matheusrocha@gmail.com",
                    Name = "Matheus",
                    LastName = "Rocha",
                    Password = "123",
                };

                _context.Users.Add(myUser);
                _context.Cars.Add(myCar);
                _context.SaveChanges();
            }
        }
    }
}
