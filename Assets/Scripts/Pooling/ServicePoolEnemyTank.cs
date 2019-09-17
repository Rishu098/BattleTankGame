using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePoolEnemyTank : ServicePool<EnemyController>
{
  private EnemyView enemyPrefab;
  private EnemyModel enemyModel;
  public EnemyController GetEnemyTank(EnemyModel enemyModel,EnemyView enemyPrefab){
      this.enemyModel = enemyModel;
      this.enemyPrefab = enemyPrefab;
      return GetItem();
  }
  protected override EnemyController CreateItem(){
      EnemyController enemyController = new EnemyController(enemyModel,enemyPrefab);
      return enemyController;
  }
}

