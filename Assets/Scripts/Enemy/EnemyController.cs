using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{

    public int XPos;
    public int ZPos;
    public EnemyController(EnemyModel enemyModel, EnemyView enemyPrefab)
    {
        XPos = Random.Range(40, -40);
        ZPos = Random.Range(40, -40);
        EnemyModel = enemyModel;
        EnemyView = GameObject.Instantiate<EnemyView>(enemyPrefab, new Vector3(XPos, 0f, ZPos), Quaternion.identity);
    }

    public EnemyModel EnemyModel { get; }
    public EnemyView EnemyView { get; }
    public void ApplyDamage(float damage){}

}
