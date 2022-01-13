using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class Character 
{
    private int _currentHp;
    public Character(int initHP)
    {
        //throw new System.NotImplementedException();
        _currentHp = initHP;
    }
    public int GetHp()
    {
        return _currentHp;
    }
    public void TakeDamage(int damage)
    {
        //throw new System.NotImplementedException();
        //_currentHp -= damage;
        var calculatedHp = _currentHp - damage;//ю阑ネ㏑单ヘ玡Ι端甡
        clampHp(calculatedHp);
        //_currentHp = Mathf.Clamp(value: calculatedHp - damage, min: 0, max: 100);
    }
    public void clampHp(int calculatedHp)=>        _currentHp = Mathf.Clamp(value: calculatedHp, min: 0, max: 100);//ネ㏑程100程0
    public void Heal(int hp)
    {
        var calculatedHp = _currentHp + hp;//干﹀ 讽玡ネ㏑產hp
        //throw new System.NotImplementedException();
        //_currentHp += hp; 
        clampHp(calculatedHp);
    }
    public void SetHp(int hp)=>        _currentHp = hp;
    


}
