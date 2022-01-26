
using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;
        [SetUp]
        public void Setup()
        {
            database = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void ctorAddPeopleToTheDatabase()
        {
            var persons = new Person[16];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Georgi{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            Assert.AreEqual(16, database.Count);
            foreach (var person in persons)
            {
                var lookingPerson = database.FindById(person.Id);
                Assert.AreEqual(person.Id, lookingPerson.Id);
            }
        }
        [Test]
        public void ctorThrowExceptionWhenDatabaseCountIsOverSixteen()
        {
            var persons = new Person[17];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            Assert.Throws<ArgumentException>(() => database = new ExtendedDatabase.ExtendedDatabase(persons));
        }
        [Test]
        public void AddThrowExceptionWhenPeopleAreSixteen()
        {
            var persons = new Person[16];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(17, "Georgi");
            Assert.Throws<InvalidOperationException>(() => database.Add(newPerson));
        }
        [Test]
        public void AddIncrementCountWheWeAddPerson()
        {
            var persons = new Person[10];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(11, "Georgi");
            database.Add(newPerson);
            Assert.AreEqual(11, database.Count);
        }
        [Test]
        public void AddThrowexceptionWhenThereIsTheSameUsername()
        {
            var persons = new Person[10];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(11, "Name: Ivan1");
            Assert.Throws<InvalidOperationException>(() => database.Add(newPerson));
        }
        [Test]
        public void AddThrowexceptionWhenThereIsTheSameId()
        {
            var persons = new Person[10];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            var newPerson = new Person(10, "Name: Ivan1");
            Assert.Throws<InvalidOperationException>(() => database.Add(newPerson));
        }
        [Test]
        public void RemoveThrowExceptionWhenTheDatabaseIsEmpty()
        {           
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void RemovePersonFromDatabase()
        {
            var persons = new Person[10];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name: Ivan{i}");
            }
            database = new ExtendedDatabase.ExtendedDatabase(persons);
            database.Remove();
            Assert.AreEqual(9, database.Count);
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsernameThrowexceptionIfParameterIsNullOrEmpty(string username)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));
        }
        [Test]
        public void FindByUsernameThrowexceptionIfParameterNotPresent()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Georgi"));
        }
        [Test]
        public void FindByUsernameIfItExist()
        {
            var person = new Person(1, "Georgi");
            database.Add(person);
            var existingPerson = database.FindByUsername(person.UserName);
            Assert.AreEqual(person, existingPerson);
        }
        [Test]
        public void FindByIdThrowExceptionForInvalidId()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(100));
        }
        [Test]
        public void FindByIdThrowExceptionForNegativeNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));
        }
        [Test]
        public void FindByIdWhenItIsCorrect()
        {
            var person = new Person(1, "Georgi");
            database.Add(person);
            var existingPerson = database.FindById(person.Id);
            Assert.AreEqual(person, existingPerson);
        }
    }
}