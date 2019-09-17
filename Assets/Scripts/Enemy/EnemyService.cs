using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoBehaviour
{
    public EnemyView enemyPrefab;
    private ServicePoolEnemyTank servicePoolEnemyTank;
    void Start()
    {
        servicePoolEnemyTank = GetComponent<ServicePoolEnemyTank>();
    }

    void Update()
    {
        SpawnEnemyTank();
    }
    public EnemyController SpawnEnemyTank()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            EnemyModel enemyModel = new EnemyModel(5, 100f);
            // EnemyController enemyTank = new EnemyController(enemyModel,EnemyTank);
            EnemyController enemy = servicePoolEnemyTank.GetEnemyTank(enemyModel, enemyPrefab);
            return enemy;
        }
        return null;
    }
}
