using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHole : MonoBehaviour
{
    bool levelUnlock;
    public static bool levelEnd;
    public int levelNumber;
    int maxLevel;
    int maxLevel1;
    float a;
    int sounds;

    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    public void Start()
    {
        levelEnd = false;
        maxLevel1 = PlayerPrefs.GetInt("maxLevel");
        levelUnlock = false;
        audio = GetComponent<AudioSource>();
        sounds = PlayerPrefs.GetInt("soundsON");
    }

    public void Update()
    {            
        if (levelUnlock)
        {
            if (levelNumber >= maxLevel1)
            {
                maxLevel = levelNumber;
                PlayerPrefs.SetInt("maxLevel", maxLevel);
            }
           
            levelEnd = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (sounds == 0)
        {
            audio.Play();
        }
            levelUnlock = true;
            BallMove.SetYouWin();
        
    }
}
