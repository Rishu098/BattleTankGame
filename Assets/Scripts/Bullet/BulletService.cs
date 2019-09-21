using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;

public class BulletService : MonoSingletonGeneric<BulletService>
{
    public BulletView bulletPrefab;
    public BulletScriptableObjectList bulletScriptableObjectList;
    private ServicePoolBullet servicePoolBullet;
    private BulletController bulletController;
    void Start()
    {
       servicePoolBullet = GetComponent<ServicePoolBullet>();
       bulletController = GetComponent<BulletController>();
    }

void Update()
{
    if(Input.GetKeyDown(KeyCode.O)){
    bulletController.Disable();
    servicePoolBullet.ReturnItem(bulletController);
    }
    
}
    public BulletController SpawnBullet(Vector3 bulletPosition, Quaternion bulletRotation)
    {

        BulletModel bulletModel = new BulletModel(bulletScriptableObjectList.bulletList[0]);
        //BulletController bulletController = new BulletController(bulletModel, bulletPrefab, bulletPosition, bulletRotation);
        BulletController bulletController = servicePoolBullet.GetBulletPool(bulletModel, bulletPrefab, bulletPosition, bulletRotation);
        Debug.Log("spawningBullet");
        bulletController.Enable();
        return bulletController;
    }

}
