using System;
using UnityEngine;
using System.Collections;
public class MoveItem : MonoBehaviour {
    void Start(){
        //。。。
        //。。。
        SetMoveAction();
    }

    protected virtual void SetMoveAction(){
        //...
    }

    void FixedUpdate(){
        //。。。
        AutoMove();
    }

    protected void AutoMove(){
        //...
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + autoSpeed.x,gameObject.transform.position.y+autoSpeed.y,gameObject.transform.position.z);
    }

    public Vector2 autoSpeed = new Vector2(0,0);
}