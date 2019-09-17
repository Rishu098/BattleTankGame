using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tanks.Tank
{

    public class TankService : MonoSingletonGeneric<TankService>
    {
        public TankView tankView;
        public TanksScriptableObjectsList tankList;
        private ServicePoolTank servicePoolTank;
        void Start()
        {
            servicePoolTank = GetComponent<ServicePoolTank>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < 3; i++)
                {
                    TankController tankController = CreateTank(i);
                }

            }
        }

        public TankController CreateTank(int index)
        {
            TankModel model = new TankModel(tankList.tanks[index]);
            //TankController tank = new TankController(model, tankView);
            TankController tank = servicePoolTank.GetTank(model, tankView);
            return tank;

        }

    }
}


