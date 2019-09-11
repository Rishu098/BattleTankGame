using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;

public class TankChasingState : TankState
{
    private TankPatrollingState tankPatrollingState;
    private Vector3 playerTankPosition;
    private float step = 3f;
    private EnemyView parentEnemyObject;
    public override void OnEnterState()
    {
        base.OnEnterState();
        parentEnemyObject = GetComponentInParent<EnemyView>();
        tankPatrollingState = parentEnemyObject.GetComponentInChildren<TankPatrollingState>();
        playerTankPosition = tankPatrollingState.playerTankPosition;
        Debug.Log("ptp" + playerTankPosition);
        Debug.Log("Enter into chasing state");
    }
    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exit from Chasing state");
    }

    void Update()
    {
        transform.parent.LookAt(playerTankPosition);
        transform.parent.position = Vector3.MoveTowards(this.transform.position, playerTankPosition, step * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TankView>() != null)
        {
            Debug.Log("Attacking state trigger enter");
            playerTankPosition = other.transform.position;
            parentEnemyObject.ChangeState(parentEnemyObject.tankAttackingState);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<TankView>() != null){
            parentEnemyObject.ChangeState(parentEnemyObject.tankChasingState);
        }
    }
}
