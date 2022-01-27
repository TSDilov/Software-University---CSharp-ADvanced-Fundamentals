using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void TakeAttackLosesHealth()
    {
        var dummy = new Dummy(100, 50);
        dummy.TakeAttack(50);
        Assert.AreEqual(50, dummy.Health);
    }
    [Test]
    public void TakeAttackThrowExceptionIfDead()
    {
        var dummy = new Dummy(0, 50);
        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(100));
    }
    [Test]
    public void GiveExperienceWhenDead()
    {
        var dummy = new Dummy(0, 50);
        var givenExpirience = dummy.GiveExperience();
        Assert.AreEqual(givenExpirience, 50);
    }
    [Test]
    public void GiveExperienceToDoNotGiveWhenItIsAlive()
    {
        var dummy = new Dummy(50, 50);
        Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
