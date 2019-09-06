using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="BulletScriptableObject",menuName="ScriptableObject/Bullet/NewBulletScriptableObject")]
public class BulletScriptableObject:ScriptableObject{
    public BulletType  BulletType;
    public string BulletName;
    public float Damage;

}
[CreateAssetMenu(fileName="BulletScriptableObject",menuName="ScriptableObject/Bullet/NewBulletScriptableObjectList")]
public class BulletScriptableObjectList:ScriptableObject
{
    public BulletScriptableObject[] bulletList;
}