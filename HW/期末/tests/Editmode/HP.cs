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

    public void SetUp() //���⦳100��
    {
        _character = new Character(initHP:100);
    }

    [Test]
    public void Health()
    {
        //_character = new Character();
        HpshouldBe(100);//�ͩR�W����100
        Assert.AreEqual(expected: 100, actual: _character.GetHp());
    }

    [Test]
    public void Health90() 
    {
        //_character.TakeDamage(10);
        TakeDamage(10);//�������10�I
        HpshouldBe(90);//�ͩR�ȳ�90
        Assert.AreEqual(expected: 90, actual: _character.GetHp());
    }

    [Test]
    public void Health0()
    {
        TakeDamage(200);//��D���W�L�ͩR�Ȫ�����
        //_character.TakeDamage(200);
        HpshouldBe(0);//�ͩR�Ȭ�0
        Assert.AreEqual(expected: 0, actual: _character.GetHp());
    }

    [Test]
    public void Gicen_Hp90_When_Heal10_then_Hp100()
    {
        SetHp(90);//��_�l�ͩR��90
        //_character.SetHp(90);
        // _character.Heal(hp:10);
        Heal(hp:10);//�ͩR��10�I
        HpshouldBe(100);//�ͩR90�I��10�I��100�I
        Assert.AreEqual(expected: 100, actual: _character.GetHp());
    }

    [Test]
    public void Gicen_Hp90_When_Heal100_then_Hp100()
    {
        SetHp(90);
        Heal(hp: 100);//�ͩR��100�I
        HpshouldBe(100);//�ͩR90�I��100�I �ѩ�W�L�W���ҥH�٬O����100�I
        Assert.AreEqual(expected: 100, actual: _character.GetHp());

    }
    public void TakeDamage(int damage) => _character.TakeDamage(damage);
    public void Heal(int hp) => _character.Heal(hp);
    public void SetHp(int hp)=>  _character.SetHp(hp);
    public void HpshouldBe(int expected)=>  Assert.AreEqual(expected, actual: _character.GetHp());


}
