using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttackingState : TankState
{
    protected override void Awake()
    {
    base.Awake();
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        Debug.Log("Enter into Attacking state");
    }
    public override void OnExitState()
    {
        base.OnExitState();
    }

}
