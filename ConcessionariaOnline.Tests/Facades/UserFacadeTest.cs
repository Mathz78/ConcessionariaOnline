using System;
using ConcessionariaOnline.Facades;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Tests.DB;
using Shouldly;
using Xunit;

namespace ConcessionariaOnline.Tests
{
    public class UserFacadeTest
    {
        private readonly UserFunctions _user;

        public UserFacadeTest()
        {
            var dbInMemory = new DBInMemory();
            var context = dbInMemory.GetContext();
            _user = new UserFunctions(context);
        }

        [Fact]
        public void GetAllUsers()
        {
            var result = _user.GetAllUsers();

            result[0].Name.ShouldBe("Matheus");
            result.ShouldNotBeEmpty();
        }

        [Fact]  
        public void AddUser()
        {
            var newUser = new User()
                {
                    Id = 2,
                    Email = "testUser@gmail.com",
                    Name = "test",
                    LastName = "tested",
                    Password = "123test123",
                };

            var result = _user.AddUserIntoDb(newUser);
            var allUsers = _user.GetAllUsers();

            result.Status.ShouldBe("Success.");
            allUsers.Count.ShouldBe(2);
        }
    }
}
