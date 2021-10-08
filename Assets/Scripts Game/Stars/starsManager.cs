using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsManager : MonoBehaviour
{

    [SerializeField]    
    GameObject T1a1;   
    [SerializeField]
    GameObject T2a1;
    [SerializeField]
    GameObject T3a1;


    [SerializeField]
    GameObject T1a2;
    [SerializeField]
    GameObject T2a2;
    [SerializeField]
    GameObject T3a2;


    [SerializeField]
    GameObject T1a3;
    [SerializeField]
    GameObject T2a3;
    [SerializeField]
    GameObject T3a3;


    [SerializeField]
    GameObject T1a4;
    [SerializeField]
    GameObject T2a4;
    [SerializeField]
    GameObject T3a4;

    [SerializeField]
    GameObject T1a5;
    [SerializeField]
    GameObject T2a5;
    [SerializeField]
    GameObject T3a5;

    int starsColect1;
    int starsColect2;
    int starsColect3;
    int starsColect4;
    int starsColect5;

    // Start is called before the first frame update
    void Start()
    {      
        starsColect1 = PlayerPrefs.GetInt("starsColectRecord1");
        starsColect2 = PlayerPrefs.GetInt("starsColectRecord2");
        starsColect3 = PlayerPrefs.GetInt("starsColectRecord3");
        starsColect4 = PlayerPrefs.GetInt("starsColectRecord4");
        starsColect5 = PlayerPrefs.GetInt("starsColectRecord5");

        T1a1.gameObject.SetActive(false);
        T2a1.gameObject.SetActive(false);
        T3a1.gameObject.SetActive(false);

        T1a2.gameObject.SetActive(false);
        T2a2.gameObject.SetActive(false);
        T3a2.gameObject.SetActive(false);

        T1a3.gameObject.SetActive(false);
        T2a3.gameObject.SetActive(false);
        T3a3.gameObject.SetActive(false);

        T1a4.gameObject.SetActive(false);
        T2a4.gameObject.SetActive(false);
        T3a4.gameObject.SetActive(false);
       
        T1a5.gameObject.SetActive(false);
        T2a5.gameObject.SetActive(false);
        T3a5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //1
        if (starsColect1 == 1)
        {
            T1a1.gameObject.SetActive(true);
        }

        if (starsColect1 == 2)
        {
            T1a1.gameObject.SetActive(true);
            T2a1.gameObject.SetActive(true);
        }

        if (starsColect1 == 3)
        {
            T1a1.gameObject.SetActive(true);
            T2a1.gameObject.SetActive(true);
            T3a1.gameObject.SetActive(true);
        }
       
        //2
        if (starsColect2 == 1)
        {
            T1a2.gameObject.SetActive(true);
        }

        if (starsColect2 == 2)
        {
            T1a2.gameObject.SetActive(true);
            T2a2.gameObject.SetActive(true);
        }

        if (starsColect2 == 3)
        {
            T1a2.gameObject.SetActive(true);
            T2a2.gameObject.SetActive(true);
            T3a2.gameObject.SetActive(true);
        }

        //3
        if (starsColect3 == 1)
        {
            T1a3.gameObject.SetActive(true);
        }

        if (starsColect3 == 2)
        {
            T1a3.gameObject.SetActive(true);
            T2a3.gameObject.SetActive(true);
        }

        if (starsColect3 == 3)
        {
            T1a3.gameObject.SetActive(true);
            T2a3.gameObject.SetActive(true);
            T3a3.gameObject.SetActive(true);
        }

        //4
        if (starsColect4 == 1)
        {
            T1a4.gameObject.SetActive(true);
        }

        if (starsColect4 == 2)
        {
            T1a4.gameObject.SetActive(true);
            T2a4.gameObject.SetActive(true);
        }

        if (starsColect4 == 3)
        {
            T1a4.gameObject.SetActive(true);
            T2a4.gameObject.SetActive(true);
            T3a4.gameObject.SetActive(true);
        }

        //5
        if (starsColect5 == 1)
        {
            T1a5.gameObject.SetActive(true);
        }

        if (starsColect5 == 2)
        {
            T1a5.gameObject.SetActive(true);
            T2a5.gameObject.SetActive(true);
        }

        if (starsColect5 == 3)
        {
            T1a5.gameObject.SetActive(true);
            T2a5.gameObject.SetActive(true);
            T3a5.gameObject.SetActive(true);
        }
    }
}

