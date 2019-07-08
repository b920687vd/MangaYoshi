using System;
using UnityEngine;
using System.Collections.Generic;

public class ButtManager : MonoBehaviour {

    public GameObject buttNode;
    public int InitButtNum = 100;
    public GameObject buttMod;

    private void Start() {
        ButtPoolInit();
    }

    public void ButtPoolInit(){
        buttPool  = new List<GameObject>();
        for(int i = 0;i<InitButtNum;i++){
            buttPool[i] = Instantiate(buttMod);
            buttPool[i].SetActive(false);
        }
    }
    //...
    void Update(){
        //...
    }

    public List<GameObject> buttPool;

    public List<GameObject> GetButtObj(){
        //...
        return new List<GameObject>();//...
    }

    public void CreateButt(List<ButtData> data,int shootGroup){
        //...
    }
}