using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyView EnemyTank;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemyTank();
    }
    public void SpawnEnemyTank(){
        if(Input.GetKeyDown(KeyCode.Alpha0)){
            EnemyModel enemyModel = new EnemyModel(5,100f);
            EnemyController enemyTank = new EnemyController(enemyModel,EnemyTank);
            
        }
}
}
