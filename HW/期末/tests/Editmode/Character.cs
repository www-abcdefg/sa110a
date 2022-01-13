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
        var calculatedHp = _currentHp - damage;//��������ͩR����ثe���ˮ`
        clampHp(calculatedHp);
        //_currentHp = Mathf.Clamp(value: calculatedHp - damage, min: 0, max: 100);
    }
    public void clampHp(int calculatedHp)=>        _currentHp = Mathf.Clamp(value: calculatedHp, min: 0, max: 100);//�ͩR�̤j�Ȭ�100�̤p�Ȭ�0
    public void Heal(int hp)
    {
        var calculatedHp = _currentHp + hp;//�ɦ� ��e�ͩR�a����hp
        //throw new System.NotImplementedException();
        //_currentHp += hp; 
        clampHp(calculatedHp);
    }
    public void SetHp(int hp)=>        _currentHp = hp;
    


}
