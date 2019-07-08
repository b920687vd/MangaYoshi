using System;
using UnityEngine;
using System.Collections;
public class HpItem : MonoBehaviour
{
    public delegate void OnValue(float hp);
    public event OnValue onHpChanged;
    public Func<bool,bool> hpUp;
    public Func<bool,bool> hpDown;

    public void Start(){
        this.hpUp = hpPlus;
        this.hpDown = hpEq;
    }
    public float _hp = 10f;
    public float hp{
        get{
            return this._hp;
        }
        set{
            if(value == this._hp)
                return;
            onHpChanged(value);
            this._hp = value;
        }
    }
    public float MaxHp = 10f;

    public int group = 0;

    private bool hpPlus(bool p){
        if(!p)
            hp += 1f;
        return true;
    }

    private bool hpEq(bool p){
        if(!p)
            hp -= 1f;
        return true;
    }
}