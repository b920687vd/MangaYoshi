using System;
using UnityEngine;
using System.Collections;
public class Controller : MonoBehaviour {
    void Start(){
        //。。。
    }

    void Update(){
        //。。。
        CheckKeyBoardInput();
    }

    private void CheckKeyBoardInput(){
        //..
        CheckKey(KeyCode.W,GetMI().MoveUp);
        CheckKey(KeyCode.S,GetMI().MoveDown);
        CheckKey(KeyCode.A,GetMI().MoveLeft);
        CheckKey(KeyCode.D,GetMI().MoveRight);
        CheckKey(KeyCode.LeftShift,GetMI().MoveSlow);
        CheckKey(KeyCode.UpArrow,GetHP().hpUp);
        CheckKey(KeyCode.DownArrow,GetHP().hpDown);
    }

    private void CheckKey(KeyCode key,Func<bool,bool> func){
        if(Input.GetKeyDown(key)){
            func(true);
        }
        if(Input.GetKeyUp(key)){
            func(false);
        }
    }

    private CtrlMoveItem GetMI(){
        return gameObject.GetComponent<CtrlMoveItem>();
    }

    private HpItem GetHP(){
        return gameObject.GetComponent<HpItem>();
    }
}