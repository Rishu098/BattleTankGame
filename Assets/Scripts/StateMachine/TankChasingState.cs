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
    protected override void Awake()
    {
    base.Awake();
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        tankPatrollingState = GetComponent<TankPatrollingState>();
        playerTankPosition = tankPatrollingState.playerTankPosition;
        Debug.Log("Enter into chasing state");
        flick = tankPatrollingState.isPatrolling;
    }
    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exit from Chasing state");
        
    }

    void Update()
    {
        this.transform.LookAt(playerTankPosition);
        this.transform.position = Vector3.MoveTowards(this.transform.position, playerTankPosition, step*Time.deltaTime);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TankView>() != null)
        {
            Debug.Log("Attacking state trigger enter");
            playerTankPosition = other.transform.position;
            enemyView.ChangeState(enemyView.tankAttackingState);
        }
    }
    // private void OnTriggerExit(Collider other)
    // {
    //     enemyView.ChangeState(enemyView.tankPatrollingState);
    // }
}
