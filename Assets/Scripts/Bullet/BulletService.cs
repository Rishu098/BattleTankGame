using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;

public class BulletService : MonoSingletonGeneric<BulletService>
{
    public BulletView bulletView;
    public BulletScriptableObjectList bulletScriptableObjectList;

    public BulletController SpawnBullet(Vector3 bulletPosition, Quaternion bulletRotation)
    {

        Debug.Log("spawningBullet");

        BulletModel bulletModel = new BulletModel(bulletScriptableObjectList.bulletList[0]);
        BulletController bulletController = new BulletController(bulletModel, bulletView, bulletPosition, bulletRotation);

        return bulletController;
    }

}
