using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tanks.Tank
{

    public class TankView : MonoBehaviour,IDamagable
    {
        // Start is called before the first frame update

        public TankType tankType;
        private TankController tankController;

        void Start()
        {
            
        }
        public void TakeDamage(float damage){
        tankController.ApplyDamage(damage);
        }

        public void Init(TankController activeController)
        {
            this.tankController = activeController;
        }
        void Update()
        {
            Move();
            if (Input.GetKey(KeyCode.F))
            {
                tankController.GetBullet();
            }
        }
        public void Move()
        {
            //if (Input.GetKeyDown(KeyCode.W))

            if (Input.GetKey(KeyCode.W))

            {
                transform.Translate(0, 0, 10 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))

            {
                transform.Translate(0, 0, -10 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))

            {
                transform.Translate(10 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))

            {
                transform.Translate(-10 * Time.deltaTime, 0, 0);
            }
        }



    }
}
