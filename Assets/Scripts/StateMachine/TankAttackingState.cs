using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttackingState : TankState
{

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
