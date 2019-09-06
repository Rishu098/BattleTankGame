using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public EnemyModel(int speed, float health){
       Speed = speed;
       Health = health;
}
public int Speed{get; set;}
public float Health{get;}
}
