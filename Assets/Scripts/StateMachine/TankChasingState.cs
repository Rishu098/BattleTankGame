using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;

public class TankChasingState : TankState
{
    private TankPatrollingState tankPatrollingState;
    private Vector3 playerTankPosition;
    private float step = 3f;
    private bool flick;
    public override void OnEnterState()
    {
        base.OnExitState();
        tankPatrollingState = GetComponent<TankPatrollingState>();
        playerTankPosition = tankPatrollingState.playerTankPosition;
        Debug.Log("playertankpos in chase = " + playerTankPosition);
    }
    public override void OnExitState()
    {
        Debug.Log("Exit from Chasing state");
        base.OnExitState();
    }

    void Update()
    {
        this.transform.LookAt(playerTankPosition);
        this.transform.position = Vector3.MoveTowards(this.transform.position, playerTankPosition, step*Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TankView>() == true)
        {
            Debug.Log("Attacking state trigger enter");
            playerTankPosition = other.transform.position;
            Debug.Log("PlayerPos = " + playerTankPosition);
            //enemyView.ChangeState(enemyView.tankAttackingState);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        enemyView.ChangeState(enemyView.tankPatrollingState);
    }
}

