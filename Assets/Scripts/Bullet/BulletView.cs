﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;
public class BulletView : MonoBehaviour

{
   

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(10*Time.deltaTime,0,0);
    }

    
}
