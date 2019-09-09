﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;

public class TankPatrollingState : TankState
{

    private Vector3 tankNextPosition;
    [HideInInspector]
    public Vector3 playerTankPosition;
    private float step = 3;
    public override void OnEnterState()
    {
        base.OnEnterState();
        tankNextPosition = SetNextPosition();
        Debug.Log("TP" + tankNextPosition);
        Debug.Log("Enter into patrolling state");

    }
    public override void OnExitState()
    {
        base.OnExitState();
        Debug.Log("Exit from patrolling state");
    }

    public void Update()
    {
        if (this.transform.position != tankNextPosition)
        {
            this.transform.LookAt(tankNextPosition);
            this.transform.position = Vector3.MoveTowards(this.transform.position, tankNextPosition, step*Time.deltaTime);
        }
        else
        {
            tankNextPosition = SetNextPosition();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TankView>() == true)
        {
            Debug.Log("Tank Detected");
            playerTankPosition = other.transform.position;
            Debug.Log("PlayerPos = " + playerTankPosition);
            enemyView.ChangeState(enemyView.tankChasingState);
        }
    }
    private Vector3 SetNextPosition()
    {
        return new Vector3(Random.Range(10, -10), 0, Random.Range(10, -10));
    }
}
