using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L03_stars : MonoBehaviour
{
    int rekord;
    bool levelEnd;

    // Start is called before the first frame update  
    void Start()
    {
        Stars.starsColect = 0;
        rekord = PlayerPrefs.GetInt("starsColectRecord3");
    }

    // Update is called once per frame
    void Update()
    {
        levelEnd = EHole.levelEnd;

        if (Stars.starsColect > rekord)
        {
            rekord = Stars.starsColect;
        }

        if (levelEnd)
        {
            PlayerPrefs.SetInt("starsColectRecord3", rekord);
        }
    }
}
