using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TankScriptableObject",menuName="ScriptableObject/Tank/NewTankScriptableObject")]
public class TanksScriptableObjects : ScriptableObject
{
   public TankType TankType;
    public string TankName;
    public float Speed;
    public float Health;
 
}

[CreateAssetMenu(fileName="TankScriptableObject",menuName="ScriptableObject/Tank/NewTankScriptableObjectList")]
public class TanksScriptableObjectsList : ScriptableObject
{
  public TanksScriptableObjects[] tanks;
}
