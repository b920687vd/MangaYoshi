using System;
using UnityEngine;
using System.Collections;
public class ShootingItem : MonoBehaviour {
    void Start(){
        //。。。
        //。。。
        SetMoveAction();
    }

    Func<bool,bool> Shoot;

    protected void SetMoveAction(){
        //...
        this.Shoot = shoot;
    }

    private void FixedUpdate() {
        if(isShoot){
            this.ShootButt();
        }
    }

    protected bool isShoot = false;

    private bool shoot(bool isShoot){
        this.isShoot = isShoot;
        return isShoot;
    }

    protected void ShootButt(){
        //....
    }
}