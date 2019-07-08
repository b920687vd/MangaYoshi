using System;
using UnityEngine;
using System.Collections;
public class CharDress : MonoBehaviour
{
    //...
    public HpItem hpData;
    public Animator actorAnime;
    private void Start() {
        //...
        this.hpData = gameObject.GetComponent<HpItem>();
        if(this.actorAnime == null)
            this.actorAnime = transform.Find("viewChar").gameObject.GetComponent<Animator>();
        
        this.hpData.onHpChanged += this.CheckHpDress;
    }
    private void Update() {
        //...
        //...
    }

    private void CheckHpDress(float hp){
        if(hp > hpData.MaxHp*0.66f){
            this.actorAnime.Play("dress_full",0);
        }else if(hp>hpData.MaxHp*0.33f){
            this.actorAnime.Play("dress_half",0);
        }else{
            this.actorAnime.Play("dress_bare",0);
        }
    }
}