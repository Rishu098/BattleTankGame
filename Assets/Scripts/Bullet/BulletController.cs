using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;  
public class BulletController
{
    // Start is called before the first frame update
    
    public TankController tankController;
    
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
   public BulletController(BulletModel model,BulletView bulletPrefab,Vector3 position,Quaternion rotation){
       BulletModel = model;
       BulletView = GameObject.Instantiate<BulletView>(bulletPrefab,position,rotation);
       
         }
   public BulletModel BulletModel{get;}
   public BulletView BulletView{get;}
  
   void OnCollisionEnter(Collision collision)
   {
       IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
       if(damagable!=null)
       {
           damagable.TakeDamage(BulletModel.Damage);
           
       }
   }
}
