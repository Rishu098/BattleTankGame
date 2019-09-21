using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;
public class BulletView : MonoBehaviour

{
    private ServicePoolBullet servicePoolBullet;
    private BulletController bulletController;
    
    void Update()
    {
        transform.Translate(10 * Time.deltaTime, 0, 0);
    }
    internal void Disable(){
        gameObject.SetActive(false);
    }
    internal void Enable(){
        gameObject.SetActive(true);
    }
   
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.GetComponent<IDamagable>() != null)
        {
             Debug.Log("destroy Tank");
             Destroy(other.gameObject);

        }
        //Destroy(this.gameObject);
       // servicePoolBullet.ReturnItem(bulletController);
        EventService.FireOnDeath();
        Disable();
        

        
    }
    
}
