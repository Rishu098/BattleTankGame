using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;



public class TankState : MonoBehaviour
{
    protected EnemyView enemyView;
    protected EnemyModel enemyModel;
    public virtual void OnEnterState() { this.enabled = true; }
    public virtual void OnExitState() { this.enabled = false; }


}
