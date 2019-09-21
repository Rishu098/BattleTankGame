using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tanks.Tank
{

    public class TankView : MonoBehaviour
    {
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
            if (Input.GetKeyDown(KeyCode.F))
            {
                tankController.GetBullet();
            }
            Move();
            
        }
        public void Move()
        {
    

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, 10 * Time.deltaTime);
            
            }
            if (Input.GetKey(KeyCode.S))

            {
                transform.Translate(0, 0, -10 * Time.deltaTime);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                 transform.Rotate(new Vector3(0,90,0));
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(new Vector3(0,-90,0));
            }
        }
         internal void Disable()
         {
             gameObject.SetActive(false);
         }
         internal void Enable(){
             gameObject.SetActive(true);
         }
    }
}
