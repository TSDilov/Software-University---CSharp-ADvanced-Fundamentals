
using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Ceco", 100, 100);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ctroThrowsExceptionForNullOrEmptyName(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 100, 100));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void ctroThrowsExceptionWhenDemageISNotPossitive(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Ceco", damage, 100));
        }
        [Test]
        public void ctroThrowsExceptionWhenHPIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Ceco", 100, -5));
        }
        [Test]
        public void AttackThrowsExceptionWhenHpIsLessThanMinumumAttackHP()
        {
            var myWarrior = new Warrior("WarriorOne", 100, 25);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(new Warrior("EnemyWarrior", 100, 50)));
            var mySecondWarrior = new Warrior("WarriorTwo", 100, 50);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(new Warrior("EnemyWarrior", 100, 25)));
            var myThirdWarrior = new Warrior("WarriorThree", 50, 50);
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(new Warrior("EnemyWarrior", 100, 60)));
        }
        [Test]
        public void AttackWhenWorriorHPIsMoreThanMinimumAndMoreThanEnemiWorriorDemage()
        {
            var enemyWarrior = new Warrior("Enemy", 50, 50);
            warrior.Attack(enemyWarrior);
            Assert.AreEqual(50, warrior.HP);
        }
        [Test]
        public void AttackWhenWorriorDemageIsMoreThanEnemyHP()
        {
            var enemyWarrior = new Warrior("Enemy", 50, 50);
            warrior.Attack(enemyWarrior);
            Assert.AreEqual(0, enemyWarrior.HP);
        }
        [Test]
        public void AttackWhenWorriorDemageIsLessThanEnemyHP()
        {
            var enemyWarrior = new Warrior("Enemy", 50, 110);
            warrior.Attack(enemyWarrior);
            Assert.AreEqual(10, enemyWarrior.HP);
        }
    }
}