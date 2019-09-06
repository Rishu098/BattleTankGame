using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tanks.Tank
{
    public class TankModel
    {
        TanksScriptableObjects tanksScriptableObjects;

        public TankModel(TanksScriptableObjects tanksScriptableObjects){
            TankType = tanksScriptableObjects.TankType;
            TankName = tanksScriptableObjects.TankName;
            Speed = (int)tanksScriptableObjects.Speed;
            Health = tanksScriptableObjects.Health;
        }
       /*  public TankModel(TankType type, int speed, float health)
        {
            TankType = type;
            Speed = speed;
            Health = health;
        }
        */

        
        public TankType TankType { get; }
        public string TankName { get; }
        public int Speed { get; }
        public float Health { get;set; }

    }
}
