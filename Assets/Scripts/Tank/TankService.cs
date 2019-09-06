using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tanks.Tank
{

    public class TankService : MonoSingletonGeneric<TankService>
    {
        // Start is called before the first frame update

        public TankView tankView;
        public TanksScriptableObjectsList tankList;



        void Start()
        {

        }

        // Update is called once per frame 
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < 3; i++)
                {
                    CreateTank(i);
                }

            }
        }

        public void CreateTank(int index)
        {
            TankModel model = new TankModel(tankList.tanks[index]);
            TankController tank = new TankController(model, tankView);

        }

    }
}


