using NUnit.Framework;
using SQLite;
using TestRepository.Model;
using TestRepository.Service;

namespace TestRepository.Test
{
    public class UserServiceTest
    {
        public SQLiteConnection Connection { get; set; }

        [SetUp]
        public void SetUp()
        {
            Connection = new SQLiteConnection(":memory:");
            Connection.CreateTable<User>();
        }

        [Test]
        public void TestInsert()
        {
            var user = new User { Identifier = "A1B2C3D4E5F6", Name = "Noname", Email = "noname@email.com", Removed = false };
            var service = new UserService(Connection);
            var result = service.Insert(user);

            Assert.IsTrue(result, "Failure!");

            var userSelect = service.Get(user.Identifier);
            Assert.AreEqual("A1B2C3D4E5F6", userSelect.Identifier, "Not selected");
        }
    }
}
