using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    // Start is called before the first frame update
  // public BulletModel (int damage,int bulletSpeed)
   // {
   //  Damage = damage;
   //  BulletSpeed = bulletSpeed;
   // }
   public BulletModel (BulletScriptableObject bulletScriptableObject){
    BulletType = bulletScriptableObject.BulletType;
    BulletName = bulletScriptableObject.BulletName;
    Damage = bulletScriptableObject.Damage;


   }

    // Update is called once per frame
    public BulletType BulletType{get;}
    public string BulletName{get;}
    public float Damage{get; set;}
    

}
