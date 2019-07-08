using System;
using UnityEngine;
using System.Collections;
public class CtrlMoveItem : MoveItem
{
    protected override void SetMoveAction()
    {
        MoveUp = this.moveUp;
        MoveDown = this.moveDown;
        MoveLeft = this.moveLeft;
        MoveRight = this.moveRight;
        MoveSlow = this.moveSlow;
    }

    void FixedUpdate()
    {
        //。。。
        AutoMove();
        CtrlMove();
    }

    public float speed = 0.1f;

    private bool isUp = false;
    private bool isDown = false;
    private bool isLeft = false;
    private bool isRight = false;

    private bool isSlow = false;



    public Func<bool, bool> MoveUp;
    public Func<bool, bool> MoveDown;
    public Func<bool, bool> MoveLeft;
    public Func<bool, bool> MoveRight;
    public Func<bool, bool> MoveSlow;


    protected void CtrlMove()
    {
        float totalSpeed = speed * (isSlow ? 0.5f : 1f);
        if (isUp)
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x, gameObject.transform.position.y + totalSpeed,
                gameObject.transform.position.z);
        }
        if (isDown)
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x, gameObject.transform.position.y - totalSpeed,
                gameObject.transform.position.z);
        }
        if (isLeft)
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x - totalSpeed, gameObject.transform.position.y,
                gameObject.transform.position.z);
        }
        if (isRight)
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x + totalSpeed, gameObject.transform.position.y,
                gameObject.transform.position.z);
        }
    }

    public bool moveUp(bool isMove)
    {
        isUp = isMove;
        return isUp;
    }
    public bool moveDown(bool isMove)
    {
        isDown = isMove;
        return isDown;
    }
    public bool moveLeft(bool isMove)
    {
        isLeft = isMove;
        return isLeft;
    }
    public bool moveRight(bool isMove)
    {
        isRight = isMove;
        return isRight;
    }
    public bool moveSlow(bool isSlow){
        this.isSlow = isSlow;
        return this.isSlow;
    }
}