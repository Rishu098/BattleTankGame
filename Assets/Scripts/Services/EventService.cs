using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventService : MonoSingletonGeneric<EventService>
{
    public static event Action KillCounter; 
    public static void FireOnDeath() => KillCounter.Invoke();
}
