using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLock : MonoBehaviour
{
    [SerializeField]
    GameObject B2;

    [SerializeField]
    GameObject L2;

    [SerializeField]
    GameObject B3;

    [SerializeField]
    GameObject L3;

    [SerializeField]
    GameObject B4;

    [SerializeField]
    GameObject L4;

    [SerializeField]
    GameObject B5;

    [SerializeField]
    GameObject L5;

    int maxLevel;

    public void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel");
        B2.gameObject.SetActive(false);
        L2.gameObject.SetActive(true);
        B3.gameObject.SetActive(false);
        L3.gameObject.SetActive(true);
        B4.gameObject.SetActive(false);
        L4.gameObject.SetActive(true);
        B5.gameObject.SetActive(false);
        L5.gameObject.SetActive(true);
        Lock();
    }

    public void Lock()
    {
        if (maxLevel >= 1)
        {
            B2.gameObject.SetActive(true);
            L2.gameObject.SetActive(false);
        }
       
        if (maxLevel >= 2)
        {
            B3.gameObject.SetActive(true);
            L3.gameObject.SetActive(false);
        }

        if (maxLevel >= 3)
        {
            B4.gameObject.SetActive(true);
            L4.gameObject.SetActive(false);
        }
       
        if (maxLevel >= 4)
        {
            B5.gameObject.SetActive(true);
            L5.gameObject.SetActive(false);
        }
    }


}
