using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour, IDamagable
{
    private TankState currentState;
    private EnemyController enemyController;
    [SerializeField]
    public TankPatrollingState tankPatrollingState;
    [SerializeField]
    public TankChasingState tankChasingState;
    [SerializeField]
    public TankAttackingState tankAttackingState;

    [SerializeField]
    public TankState startingState;

    public void TakeDamage(float damage)
    {
        enemyController.ApplyDamage(damage);
    }

    private void Start()
    {
        currentState = startingState;
        ChangeState(currentState);
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
    
    internal void Disable()
    {
        gameObject.SetActive(false);
    }
    internal void Enable()
    {
        gameObject.SetActive(true);
    }

}
