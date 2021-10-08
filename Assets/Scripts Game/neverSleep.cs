using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neverSleep : MonoBehaviour
{
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep; 
    }
}
