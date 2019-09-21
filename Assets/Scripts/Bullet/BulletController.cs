using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;
public class BulletController
{
    public TankController tankController;
    public BulletController(BulletModel model, BulletView bulletPrefab, Vector3 position, Quaternion rotation)
    {
        BulletModel = model;
        BulletView = GameObject.Instantiate<BulletView>(bulletPrefab, position, rotation);

    }
    public BulletModel BulletModel { get; }
    public BulletView BulletView { get; }

    void OnCollisionEnter(Collision collision)
    {
        IDamagable damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.TakeDamage(BulletModel.Damage);

        }
    }
    public void Disable()
    {
        BulletView.Disable();
    }
    public void Enable()
    {
        BulletView.Enable();
    }
    
}
