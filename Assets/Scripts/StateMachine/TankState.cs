using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;


[RequireComponent(typeof(EnemyView))]
public class TankState : MonoBehaviour
{
    protected EnemyView enemyView;
    protected EnemyModel enemyModel;
    protected virtual void Awake()
    {
        enemyView = GetComponent<EnemyView>();
    }
    public virtual void OnEnterState() { this.enabled = true; }
    public virtual void OnExitState() { this.enabled = false; }


}
