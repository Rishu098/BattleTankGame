using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameUI : MonoBehaviour
{
    
    private int kill;
    void Start()
    {
        EventService.KillCounter += UpdateKillStatus;
        
    }

    private void UpdateKillStatus()
    {
        kill=kill+1;
        Debug.Log("kill" + kill);
    }
    void OnDestroy()
    {
        // OnDeath -= GameUI_OnDeath;
    }
   
}
