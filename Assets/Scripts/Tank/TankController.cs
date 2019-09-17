using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks.Tank
{
    public class TankController
    {
        private BulletService bulletService;
        private BulletController bulletController;
        private TankView tankView;
        public int XPos;
        public int ZPos;

        public TankController(TankModel tankModel, TankView tankPrefab)
        {
            XPos = Random.Range(40, -40);
            ZPos = Random.Range(40, -40);
            TankModel = tankModel;
            TankView = GameObject.Instantiate<TankView>(tankPrefab, new Vector3(XPos, 0f, ZPos), Quaternion.identity);

            TankView.Init(this);
        }
        public TankModel TankModel { get; }
        public TankView TankView { get; }

        public void GetBullet()
        {
            Debug.Log("GetBullet");
            bulletController = BulletService.Instance.SpawnBullet(this.TankView.transform.position, this.TankView.transform.rotation);
        }

        public void ApplyDamage(float damage)
        {
            if (TankModel.Health - damage <= 0)
            {
                Debug.Log("Death");
            }
            else
            {
                TankModel.Health -= damage;
            }
        }
        public void Disable()
        {
            TankView.Disable();
        }
        public void Enable()
        {
            TankView.Enable();
        }
    }
}
