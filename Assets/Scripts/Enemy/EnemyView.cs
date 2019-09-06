using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    private TankState currentState;
    [SerializeField]
    public TankPatrollingState tankPatrollingState;
    [SerializeField]
    public TankChasingState tankChasingState;
    [SerializeField]
    public TankAttackingState tankAttackingState;

    [SerializeField]
    public TankState startingState;

    private void Start()
    {
        ChangeState(startingState);
    }

    public void ChangeState(TankState newState)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }
        currentState = newState;
        currentState.OnEnterState();
    }

}
