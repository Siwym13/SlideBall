using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public static int starsColect;
    static int starsColectRecord;
    static bool ifColect;
    int sounds;

    [SerializeField]
    GameObject T1;

    [SerializeField]
    GameObject T2;

    [SerializeField]
    GameObject T3;

    AudioSource audio;
    [SerializeField]
    AudioClip clip;


    void Start()
    {       
        ifColect = false;
        T1.gameObject.SetActive(false);
        T2.gameObject.SetActive(false);
        T3.gameObject.SetActive(false);
        audio = GetComponent<AudioSource>();
        sounds = PlayerPrefs.GetInt("soundsON");
    }

    void Update()
    {
        if (ifColect)
        {
            if (sounds == 0)
            {
                audio.Play();
            }
                starsColect++;
                ifColect = false;
            
        }

         if (starsColect > starsColectRecord)
         {
             starsColectRecord = starsColect;
         }
    }
   
    public void FixedUpdate()
    {
        if (starsColect == 1)
        {
            T1.gameObject.SetActive(true);
        }

        if (starsColect == 2)
        {
            T1.gameObject.SetActive(true);
            T2.gameObject.SetActive(true);
        }

        if (starsColect == 3)
        {
            T1.gameObject.SetActive(true);
            T2.gameObject.SetActive(true);
            T3.gameObject.SetActive(true);
        }

    }
   
    public static void IfColect()
    {
        ifColect = true;
    }

}
