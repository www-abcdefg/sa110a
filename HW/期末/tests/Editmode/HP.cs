using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HP
{
    public Character _character;
    // A Test behaves as an ordinary method
    [SetUp]

    public void SetUp() //角色有100血
    {
        _character = new Character(initHP:100);
    }

    [Test]
    public void Health()
    {
        //_character = new Character();
        HpshouldBe(100);//生命上限為100
        Assert.AreEqual(expected: 100, actual: _character.GetHp());
    }

    [Test]
    public void Health90() 
    {
        //_character.TakeDamage(10);
        TakeDamage(10);//受到攻擊10點
        HpshouldBe(90);//生命值剩90
        Assert.AreEqual(expected: 90, actual: _character.GetHp());
    }

    [Test]
    public void Health0()
    {
        TakeDamage(200);//當遭受超過生命值的扣血
        //_character.TakeDamage(200);
        HpshouldBe(0);//生命值為0
        Assert.AreEqual(expected: 0, actual: _character.GetHp());
    }

    [Test]
    public void Gicen_Hp90_When_Heal10_then_Hp100()
    {
        SetHp(90);//當起始生命為90
        //_character.SetHp(90);
        // _character.Heal(hp:10);
        Heal(hp:10);//生命補10點
        HpshouldBe(100);//生命90點補10點為100點
        Assert.AreEqual(expected: 100, actual: _character.GetHp());
    }

    [Test]
    public void Gicen_Hp90_When_Heal100_then_Hp100()
    {
        SetHp(90);
        Heal(hp: 100);//生命補100點
        HpshouldBe(100);//生命90點補100點 由於超過上限所以還是為為100點
        Assert.AreEqual(expected: 100, actual: _character.GetHp());

    }
    public void TakeDamage(int damage) => _character.TakeDamage(damage);
    public void Heal(int hp) => _character.Heal(hp);
    public void SetHp(int hp)=>  _character.SetHp(hp);
    public void HpshouldBe(int expected)=>  Assert.AreEqual(expected, actual: _character.GetHp());


}
