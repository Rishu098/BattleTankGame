using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController 
{
    // Start is called before the first frame update
    public int XPos;
    public int ZPos;
    void Start()
    {
        
    }

   
   public EnemyController(EnemyModel enemyModel,EnemyView enemyPrefab)
    {
         XPos = Random.Range(40, -40);
         ZPos = Random.Range(40, -40);
       EnemyModel = enemyModel;
       EnemyView  = GameObject.Instantiate<EnemyView>(enemyPrefab,new Vector3(XPos, 0f, ZPos),Quaternion.identity);
       
      
       //Move();
    }

    public EnemyModel EnemyModel{get;}
    public EnemyView EnemyView{get;}

}
