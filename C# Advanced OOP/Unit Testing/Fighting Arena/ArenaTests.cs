
using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ctorInitializeWarriors()
        {
            var arena = new Arena();
            Assert.IsNotNull(arena.Warriors);
        }
        [Test]
        public void EnrollAddWarrior()
        {
            var arena = new Arena();
            var warrior1 = new Warrior("Warrior1", 100, 100);
            arena.Enroll(warrior1);
            Assert.AreEqual(1, arena.Warriors.Count);
            var IsExistWarrior = arena.Warriors.Any(w => w.Name == warrior1.Name);
            Assert.True(IsExistWarrior);
        }
        [Test]
        public void EnrollThrowExceptionWhenAddWarriorWiththeSameName()
        {
            var arena = new Arena();
            var warrior1 = new Warrior("Warrior1", 100, 100);
            arena.Enroll(warrior1);
            var warrior2 = new Warrior("Warrior1", 100, 100);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior2));
        }
        [Test]
        public void FightThrowExceptionForInvalidWariiors()
        {
            var arena = new Arena();
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Warrior1","Warrior2"));
        }
        [Test]
        public void FightThrowExceptionForInvalidFirstWarrior()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior", 100, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Warrior", "Warrior2"));
        }
        [Test]
        public void FightThrowExceptionForInvalidSecondWarrior()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior", 100, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Warrior1", "Warrior"));
        }
        [Test]
        public void FightWhenWeHaveAProperAttackWithDefenderLessHpThanAttackerDemage()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior1", 100, 100);
            var warrior2 = new Warrior("Warrior2", 80, 80);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            arena.Fight(warrior.Name, warrior2.Name);
            Assert.AreEqual(20, warrior.HP);
            Assert.AreEqual(0, warrior2.HP);
        }
        [Test]
        public void FightWhenWeHaveAProperAttackWithDefenderMoreHpThanAttackerDemage()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior1", 100, 100);
            var warrior2 = new Warrior("Warrior2", 80, 120);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            arena.Fight(warrior.Name, warrior2.Name);
            Assert.AreEqual(20, warrior.HP);
            Assert.AreEqual(20, warrior2.HP);
        }
        [Test]
        public void FightThrowsExceptonWhenAttackerHaveLessHPThanMinHP()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior1", 100, 25);
            var warrior2 = new Warrior("Warrior2", 80, 40);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior.Name, warrior2.Name));
        }
        [Test]
        public void FightThrowsExceptonWhenDeffenderHaveLessHPThanMinHP()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior1", 100, 50);
            var warrior2 = new Warrior("Warrior2", 80, 50);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior.Name, warrior2.Name));
        }
        [Test]
        public void FightThrowsExceptonWhenAttackerHaveLessHPThanDeffenderDemage()
        {
            var arena = new Arena();
            var warrior = new Warrior("Warrior1", 100, 50);
            var warrior2 = new Warrior("Warrior2", 80, 50);
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior.Name, warrior2.Name));
        }
    }
}
