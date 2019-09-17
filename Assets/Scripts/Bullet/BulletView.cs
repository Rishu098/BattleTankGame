using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tanks.Tank;
public class BulletView : MonoBehaviour

{
    void Update()
    {
        transform.Translate(10 * Time.deltaTime, 0, 0);
    }
    internal void Disable(){
        gameObject.SetActive(false);
    }
    internal void Enable(){
        gameObject.SetActive(true);
    }
}
